using System;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.Generic;
using TM_Db_Lib.Net;
using Newtonsoft.Json.Linq;


namespace TM_Db_Lib.Search
{
    /// <summary>
    /// Represents information for a derived class.
    /// </summary>
    public abstract class MediaSearchResult
    {
        // Written, 06.04.2018

        #region Properties

        /// <summary>
        /// Represents the ID for the result.
        /// </summary>
        public int id
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the genre ID for the result.
        /// </summary>
        public virtual int[] genre_ids
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the overview for the result.
        /// </summary>
        public string overview
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the original laugauge for the result.
        /// </summary>
        public string original_laugauge
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the poster path for the result.
        /// </summary>
        public string poster_path
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the backdrop path for the result.
        /// </summary>
        public string backdrop_path
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the popularity for the result.
        /// </summary>
        public double popularity
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the vote average for the result.
        /// </summary>
        public double vote_average
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the total votes for the result.
        /// </summary>
        public int vote_count
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the poster image for the result.
        /// </summary>
        public Image poster_image
        {
            get;
            protected set;
        }
        /// <summary>
        /// Represents the backdrop image for the result.
        /// </summary>
        public Image backdrop_image
        {
            get;
            protected set;
        }

        #endregion

        private static async Task<JObject> getJObjectAsync(string inSearchAddressPrefix, string inSearchPhrase, int inPage) 
        {
            // Written, 26.11.2019

            string address = String.Format("{0}?api_key={1}&query={2}&page={3}", inSearchAddressPrefix, ApplicationInfomation.API_KEY, inSearchPhrase.Replace(" ", "+"), inPage);
            return await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
        }
        public static async Task<JToken[]> getJTokensAsync(string inSearchPhrase, int inPagesToShow, string inSearchAddressPrefix) 
        {
            // Written, 26.11.2019

            List<JToken> results = new List<JToken>();
            int totalPages = 1;

            for (int pageNum = 1; pageNum <= totalPages; pageNum++)
            {
                if (pageNum > inPagesToShow)
                    break;
                JObject jObject = await getJObjectAsync(inSearchAddressPrefix, inSearchPhrase, pageNum);
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
    }
}
