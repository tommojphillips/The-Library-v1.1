using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TM_Db_Lib.Net;

namespace TM_Db_Lib.Media
{
    public abstract class IdResultObject
    {
        // Written, 27.11.2019

        #region Properties

        /// <summary>
        /// Represents the id of the result object.
        /// </summary>
        public int id
        {
            get;
            set;
        }

        #endregion

        #region Methods

        private static async Task<JObject> getJObjectAsync(string inSearchPhrase, int inPage, string inSearchAddressPrefix)
        {
            // Written, 26.11.2019

            string address = String.Format("{0}?api_key={1}&query={2}&page={3}", inSearchAddressPrefix, ApplicationInfomation.API_KEY, inSearchPhrase.Replace(" ", "+"), inPage);
            return await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
        }
        /// <summary>
        /// Retrieves jtokens
        /// </summary>
        /// <param name="inSearchPhrase">The search phrase to search for.</param>
        /// <param name="inPagesToShow">The number of pages to enumerate through. (show).</param>
        /// <param name="inSearchAddressPrefix">The search address prefix.</param>
        internal static async Task<JToken[]> retrieveJTokensAsync(string inSearchPhrase, int inPagesToShow, string inSearchAddressPrefix)
        {
            // Written, 26.11.2019

            List<JToken> results = new List<JToken>();
            int totalPages = 1;

            for (int pageNum = 1; pageNum <= totalPages; pageNum++)
            {
                if (pageNum > inPagesToShow)
                    break;
                JObject jObject = await getJObjectAsync(inSearchPhrase, pageNum, inSearchAddressPrefix);
                if (pageNum == 1)
                    totalPages = jObject["total_pages"].ToObject<JValue>().ToObject<int>();
                if (jObject != null)
                {
                    JArray jResults = jObject["results"].ToObject<JArray>();
                    for (int i = 0; i < jResults.Count; i++)
                    {
                        results.Add(jResults[i]);
                    }
                }
            }
            return results.ToArray();
        }

        #endregion
    }
}
