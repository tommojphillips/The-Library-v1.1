using System;
using System.Threading.Tasks;
using TM_Db_Lib.Media;
using TM_Db_Lib.Net;
using Newtonsoft.Json.Linq;

namespace TM_Db_Lib.Account
{
    /// <summary>
    /// Represents a TMDb User Account.
    /// </summary>
    public class User : IdResultObject
    {
        // Written, 04.12.2019

        #region Properties

        /// <summary>
        /// Represents the users avatar.
        /// </summary>
        public object avatar
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the users username.
        /// </summary>
        public string username 
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the users name
        /// </summary>
        public string name 
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the users include adult value.
        /// </summary>
        public bool include_adult
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the users ...
        /// </summary>
        public string iso_639_1
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the users ...
        /// </summary>
        public string iso_3166_1
        {
            get;
            set;
        }

        #endregion

        #region Methods

        public static async Task<User> retrieveUserDetailsAsync(string inSessionId) 
        {
            // Written, 04.12.2019

            string address = String.Format("{0}?session_id={1}&api_key={2}", ApplicationInfomation.ACCOUNT_ADDRESS, inSessionId, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject.ToObject<User>();
        }

        #endregion
    }
}
