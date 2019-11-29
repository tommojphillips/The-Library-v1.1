using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TM_Db_Lib.Media;

namespace TM_Db_Lib.Search
{
    public class PeopleSearchResult : IdResultObject
    {
        // Written, 27.11.2019

        #region Properties

        /// <summary>
        /// Represents the path to the person's profile.
        /// </summary>
        public string profile_path 
        {
            get;
            set;
        }
        /// <summary>
        /// Represents if the person is adult-content related.
        /// </summary>
        public bool adult 
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the person's known-for media
        /// </summary>
        public IdResultObjectWithMediaType[] known_for
        {
            get;
            set;
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Returns a list of <see cref="PeopleSearchResult"/> objects with the list of searched movies.
        /// </summary>
        /// <param name="inSearchPhrase">The movie to search for.</param>
        /// <param name="inPagesToShow">Represents how many pages to show/report.</param>
        public static async Task<PeopleSearchResult[]> searchAsync(string inSearchPhrase, int inPagesToShow)
        {
            // Written, 27.11.2019

            List<PeopleSearchResult> results = new List<PeopleSearchResult>();
            (await retrieveJTokensAsync(inSearchPhrase, inPagesToShow, ApplicationInfomation.PEOPLE_SEARCH_ADDRESS)).ToList()
                .ForEach(jToken => results.Add(jToken.ToObject<PeopleSearchResult>()));
            return results.ToArray();
        }

        #endregion
    }
}
