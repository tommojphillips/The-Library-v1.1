using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TM_Db_Lib.Media;

namespace TM_Db_Lib.Search
{
    /// <summary>
    /// Represents the multi search function.
    /// </summary>
    public class MultiSearchResult
    {
        // Written, 27.11.2019

        #region Properties

        /// <summary>
        /// Represents the people found in the search.
        /// </summary>
        public PeopleSearchResult[] people
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the movies found in the search.
        /// </summary>
        public MovieSearchResult[] movies
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the tv series found in the search.
        /// </summary>
        public TvSearchResult[] tvSeries
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of multi-search.
        /// </summary>
        public MultiSearchResult() 
        {
            // Written, 17.12.2019

            this.people = new PeopleSearchResult[ApplicationInfomation.NUMBER_OF_ITEMS_PER_PAGE];
            this.movies = new MovieSearchResult[ApplicationInfomation.NUMBER_OF_ITEMS_PER_PAGE];
            this.tvSeries = new TvSearchResult[ApplicationInfomation.NUMBER_OF_ITEMS_PER_PAGE];
        }

        #endregion

        #region Methods

        /// <summary>
        /// Multi-search function.
        /// </summary>
        /// <param name="inSearchPhrase">The media item to search for.</param>
        /// <param name="inPage">Represents the page to show/report.</param>
        public static async Task<MultiSearchResult> searchAsync(string inSearchPhrase, int inPage)
        {
            // Written, 26.11.2019

            List<IdResultObjectWithMediaType> results = new List<IdResultObjectWithMediaType>();
            Newtonsoft.Json.Linq.JToken[] tokens = await IdResultObject.retrieveJTokensAsync(inSearchPhrase, inPage, ApplicationInfomation.MULTI_SEARCH_ADDRESS);
            tokens.ToList().ForEach(jToken => results.Add(jToken.ToObject<IdResultObjectWithMediaType>()));
            MultiSearchResult multiSearch = new MultiSearchResult();
            for (int i = 0; i < tokens.Length; i++)
            {
                switch (results[i].mediaType) 
                {
                    case MediaTypeEnum.movie:
                        multiSearch.movies[i] = tokens[i].ToObject<MovieSearchResult>();
                        break;
                    case MediaTypeEnum.tv:
                        multiSearch.tvSeries[i] = tokens[i].ToObject<TvSearchResult>();
                        break;
                    case MediaTypeEnum.person:
                        multiSearch.people[i] = tokens[i].ToObject<PeopleSearchResult>();
                        break;
                }
            }
            return multiSearch;
        }

        #endregion 
    }
}
