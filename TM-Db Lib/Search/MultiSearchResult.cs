using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TM_Db_Lib.Media;

namespace TM_Db_Lib.Search
{
    public class MultiSearchResult
    {
        // Written, 27.11.2019

        #region Properties

        /// <summary>
        /// Represents the results from the multi search.
        /// </summary>
        IdResultObjectWithMediaType[] results 
        {
            get;
            set;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns a list of <see cref="MovieSearchResult"/> objects with the list of searched movies.
        /// </summary>
        /// <param name="inSearchPhrase">The movie to search for.</param>
        /// <param name="inPagesToShow">Represents how many pages to show/report.</param>
        public static async Task<IdResultObjectWithMediaType[]> searchAsync(string inSearchPhrase, int inPagesToShow)
        {
            // Written, 26.11.2019

            List<IdResultObjectWithMediaType> results = new List<IdResultObjectWithMediaType>();
            (await IdResultObject.retrieveJTokensAsync(inSearchPhrase, inPagesToShow, ApplicationInfomation.MULTI_SEARCH_ADDRESS)).ToList()
                .ForEach(jToken => results.Add(jToken.ToObject<IdResultObjectWithMediaType>()));
            return results.ToArray();
        }

        #endregion 
    }
}
