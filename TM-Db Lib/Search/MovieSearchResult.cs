using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TM_Db_Lib.Net;

namespace TM_Db_Lib.Search
{
    /// <summary>
    /// Represents Movie data retrieved from the search request.
    /// </summary>
    public class MovieSearchResult : MediaSearchResult
    {
        // Written, 10.03.2018

        #region Properties
        
        /// <summary>
        /// Represents the current title for the movie.
        /// </summary>
        public string title
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the original title for the movie. This value maybe equal to <see cref="title"/>
        /// as this property only differs if the title has been changed after release (<see cref="release_date"/>).
        /// </summary>
        public string original_title
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the release date for the movie.
        /// </summary>
        public string release_date
        {
            get;
            set;
        }
        /// <summary>
        /// i dont fuckin know - 26.03.2018
        /// </summary>
        public bool video
        {
            get;
            set;
        }
        /// <summary>
        /// Represents if the movie is an adult movie.
        /// </summary>
        public bool adult
        {
            get;
            set;
        }


        #endregion

        #region Static Methods

        /// <summary>
        /// Returns a list of <see cref="MovieSearchResult"/> objects with the list of searched movies.
        /// </summary>
        /// <param name="inSearchPhrase">The movie to search for.</param>
        /// <param name="inPagesToShow">Represents how many pages to show/report.</param>
        public static async Task<MovieSearchResult[]> searchAsync(string inSearchPhrase, int inPagesToShow)
        {
            // Written, 26.03.2018

            string address = String.Format("{0}?api_key={1}&query={2}", ApplicationInfomation.MOVIE_SEARCH_ADDRESS, ApplicationInfomation.API_KEY, inSearchPhrase.Replace(" ", "+"));
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            int totalPages = jObject["total_pages"].ToObject<JValue>().ToObject<int>();
            List<MovieSearchResult> results = new List<MovieSearchResult>();

            for (int i = 1; i <= totalPages; i++)
            {
                if (i > inPagesToShow)
                    break;
                if (i > 1)
                    jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(String.Format("{0}&page={1}", address, i))));
                if (jObject != null)
                {
                    JArray jResults = jObject["results"].ToObject<JArray>();
                    for (int j = 0; j < jResults.Count; j++)
                    {
                        results.Add(jResults[j].ToObject<MovieSearchResult>());
                    }
                }
            }
            return results.ToArray();
        }

        #endregion
    }
}
