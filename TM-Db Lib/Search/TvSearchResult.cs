using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TM_Db_Lib.Search
{
    /// <summary>
    /// Represents tv data retrieved from the search request.
    /// </summary>
    public class TvSearchResult : MediaSearchResult
    {
        // Written, 06.04.2018

        #region Properties

        /// <summary>
        /// Represents the first air date for the tv series.
        /// </summary>
        public string first_air_date
        {
            get;
            set;
        }
        /// <summary>
        /// Represents an array of involved countries for the tv series.
        /// </summary>
        public string[] origin_country
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the name for the tv series.
        /// </summary>
        public string name
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the original name for the tv series.
        /// </summary>
        public string original_name
        {
            get;
            set;
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Returns a list of <see cref="TvSearchResult"/> objects with the list of searched tv series.
        /// </summary>
        /// <param name="inSearchPhrase">The result to search for.</param>
        /// <param name="inPagesToShow">Represents how many pages to show/report.</param>
        public static async Task<TvSearchResult[]> searchAsync(string inSearchPhrase, int inPagesToShow)
        {
            // Written, 26.11.2019

            List<TvSearchResult> results = new List<TvSearchResult>();
            (await getJTokensAsync(inSearchPhrase, inPagesToShow, ApplicationInfomation.TV_SEARCH_ADDRESS)).ToList()
                .ForEach(jToken => results.Add(jToken.ToObject<TvSearchResult>()));
            return results.ToArray();

            /*// Written, 26.03.2018

            string address = String.Format("{0}?api_key={1}&query={2}", ApplicationInfomation.TV_SEARCH_ADDRESS, ApplicationInfomation.API_KEY, inSearchPhrase.Replace(" ", "+"));
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            int totalPages = jObject["total_pages"].ToObject<JValue>().ToObject<int>();
            List<TvSearchResult> results = new List<TvSearchResult>();

            for (int i = 1; i <= totalPages; i++)
            {
                if (i > inPagesToShow)
                    break;
                if (i < inPagesToShow)
                jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(String.Format("{0}&page={1}", address, i))));
                if (jObject != null)
                {

                    JArray jResults = jObject["results"].ToObject<JArray>();
                    for (int j = 0; j < jResults.Count; j++)
                    {
                        results.Add(jResults[j].ToObject<TvSearchResult>());
                    }
                }
            }
            return results.ToArray();*/
        }

        #endregion
    }
}
