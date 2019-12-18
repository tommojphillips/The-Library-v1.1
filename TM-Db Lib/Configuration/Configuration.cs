using System;
using System.Threading.Tasks;
using TM_Db_Lib.Net;
using Newtonsoft.Json.Linq;

namespace TM_Db_Lib.Configuration
{
    /// <summary>
    /// Get the system wide configuration information. Some elements of the API require some knowledge of this configuration data. The purpose of this is to try 
    /// and keep the actual API responses as light as possible. It is recommended you cache this data within your application and check for updates every few days.
    /// </summary>
    public class Configuration
    {
        // Written, 09.12.2019

        #region Properties

        /// <summary>
        /// Holds the data relevant to building image URLs as well as the change key map.
        /// </summary>
        public ApiConfigObject apiConfig 
        {
            get;
            private set;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Retrieves API Configuration data.
        /// </summary>
        public async Task retrieveApiConfig() 
        {
            // Written, 09.12.2019

            string address = String.Format("{0}?api_key={1}", ApplicationInfomation.CONFIGURATION_ADDRESS, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            this.apiConfig = jObject.ToObject<ApiConfigObject>();
        }

        #endregion
    }
}
