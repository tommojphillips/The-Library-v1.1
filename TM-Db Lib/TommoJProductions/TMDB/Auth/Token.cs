using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;
using TommoJProductions.Net;

namespace TommoJProductions.TMDB.Auth
{
    public class Token
    {
        // Written, 04.12.2019

        #region Properties

        /// <summary>
        /// Represents if the request was a success.
        /// </summary>
        public bool success
        {
            get;
            set;
        }
        /// <summary>
        /// Represents when the <see cref="request_token"/> will expire (60minutes from time requested in UTC).
        /// </summary>
        public string expires_at
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the request token.
        /// </summary>
        public string request_token
        {
            get;
            set;
        }

        #endregion

        #region Methods

        public static async Task<Token> retrieveTokenAsync()
        {
            // Written, 04.12.2019

            string address = String.Format("{0}?api_key={1}", ApplicationInfomation.AUTH_TOKEN_NEW_ADDRESS, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject.ToObject<Token>();
        }

        #endregion
    }
}
