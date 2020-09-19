using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TommoJProductions.Net;

namespace TommoJProductions.TMDB.Search
{
    /// <summary>
    /// Represents tv data retrieved from the search request.
    /// </summary>
    public class TvSearchResult : MediaSearchResult
    {
        // Written, 06.04.2018

        #region Properties

        /// <summary>
        /// Represents the release date (first-air date) for the tv series.
        /// </summary>
        [JsonProperty("first_air_date")]
        public override string release_date
        {
            get
            {
                return base.release_date;
            }

            set
            {
                base.release_date = value;
            }
        }
        /// <summary>
        /// Represents an array of involved countries for the tv series.
        /// </summary>
        public string[] origin_country
        {
            get;
            set;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns a list of <see cref="TvSearchResult"/> objects with the list of searched tv series.
        /// </summary>
        /// <param name="inSearchPhrase">The result to search for.</param>
        /// <param name="inPagesToShow">Represents how many pages to show/report.</param>
        public static async Task<TvSearchResult[]> searchAsync(string inSearchPhrase, int inPagesToShow)
        {
            // Written, 26.11.2019

            List<TvSearchResult> results = new List<TvSearchResult>();
            (await retrieveJTokensAsync(inSearchPhrase, inPagesToShow, ApplicationInfomation.TV_SEARCH_ADDRESS)).ToList()
                .ForEach(jToken => results.Add(jToken.ToObject<TvSearchResult>()));
            return results.ToArray();
        }

        /// <summary>
        /// Gets a list of reviews for the tv series.
        /// </summary>
        /// <param name="inTvID">The tv series ID to get reviews for.</param>
        public async Task retrieveReviewsAsync()
        {
            // Written, 01.12.2019

            string address = String.Format("{0}/{1}/reviews?api_key={2}", ApplicationInfomation.TV_ADDRESS, this.id, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            this.reviews = jObject["results"].ToObject<Review[]>();
        }
        #endregion
    }
}
