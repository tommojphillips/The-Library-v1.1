using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
        /// Represents the name (title) of the movie.
        /// </summary>
        [JsonProperty("title")]
        public override string name
        {
            get
            {
                return base.name;
            }

            set
            {
                base.name = value;
            }
        }
        /// <summary>
        /// Represents the original name (title) of the movie.
        /// </summary>
        [JsonProperty("original_title")]
        public override string original_name
        {
            get
            {
                return base.original_name;
            }

            set
            {
                base.original_name = value;
            }
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
            // Written, 26.11.2019

            List<MovieSearchResult> results = new List<MovieSearchResult>();
            (await retrieveJTokensAsync(inSearchPhrase, inPagesToShow, ApplicationInfomation.MOVIE_SEARCH_ADDRESS)).ToList()
                .ForEach(jToken => results.Add(jToken.ToObject<MovieSearchResult>()));
            return results.ToArray();
        }

        #endregion
    }
}
