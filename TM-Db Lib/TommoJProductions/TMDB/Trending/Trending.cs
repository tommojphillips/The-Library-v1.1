using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TommoJProductions.TMDB.Media;
using TommoJProductions.Net;
using TommoJProductions.TMDB.Search;

namespace TommoJProductions.TMDB.Trending
{
    /// <summary>
    /// Represents Threading media function. Get the daily or weekly trending items. The daily trending list tracks items over 
    /// the period of a day while items have a 24 hour half life. The weekly list tracks items over a 7 day period, with a 7 day half life.
    /// </summary>
    public class Trending
    {
        // Written, 01.12.2019

        #region Properties

        /// <summary>
        /// Represents the trending results retrieved from <see cref="retrieveTrendingAsync(TrendingAllowedMediaTypesEnum, TrendingTimeWindowEnum)"/>. could be type: one of,
        /// <see cref="MovieSearchResult"/>, <see cref="TvSearchResult"/>, or <see cref="PeopleSearchResult"/>.
        /// </summary>
        public IdResultObject[] trendingResults
        {
            get;
            set;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Retrieves trending media items (tv, movie, or people) for the day or week.
        /// </summary>
        /// <param name="inTrendingAllowedMediaTypes">Trending media to retrieve, (all, movie, tv, or people.</param>
        /// <param name="inTrendingTimeWindow">Trending time scale, (day or week)</param>
        public static async Task<Trending> retrieveTrendingAsync(TrendingAllowedMediaTypesEnum inTrendingAllowedMediaTypes, TrendingTimeWindowEnum inTrendingTimeWindow)
        {
            // Written, 01.12.2019

            string address = String.Format("{0}/{1}/{2}?api_key={3}", ApplicationInfomation.TRENDING_ADDRESS, inTrendingAllowedMediaTypes, inTrendingTimeWindow, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObjectAsync(await WebResponse.sendRequestAsync(new Uri(address)));
            JArray results = jObject["results"].ToObject<JArray>();
            List<IdResultObject> _results = new List<IdResultObject>();

            for (int i = 0; i < results.Count; i++)
            {
                JToken jToken = results[i];
                switch (jToken.ToObject<IdResultObjectWithMediaType>().mediaType)
                {
                    case MediaTypeEnum.movie:
                        _results.Add(jToken.ToObject<MovieSearchResult>());
                        break;
                    case MediaTypeEnum.tv:
                        _results.Add(jToken.ToObject<TvSearchResult>());
                        break;
                    case MediaTypeEnum.person:
                        _results.Add(jToken.ToObject<PeopleSearchResult>());
                        break;
                }
            }
            return new Trending
            {
                trendingResults = _results.ToArray()
            };
        }

        #endregion
    }
}
