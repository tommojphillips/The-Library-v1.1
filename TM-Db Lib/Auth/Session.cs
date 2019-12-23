using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;
using TM_Db_Lib.Net;

namespace TM_Db_Lib.Auth
{
    /// <summary>
    /// Represents a TMDb Auth Session.
    /// </summary>
    public class Session
    {
        // Written, 04.12.2019

        #region Properties

        /// <summary>
        /// Represents if the request for a session was a success.
        /// </summary>
        public bool success
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the session id.
        /// </summary>
        public string session_id
        {
            get;
            set;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Creates a session from a request token.
        /// </summary>
        public static async Task<Session> createSessionAsync(string inRequestToken)
        {
            // Written, 04.12.2019

            string address = String.Format("{0}?api_key={1}", ApplicationInfomation.AUTH_SESSION_ADDRESS, ApplicationInfomation.API_KEY);
            JObject sessionData = new JObject(new JProperty("request_token", inRequestToken));
            byte[] sessionDataBytes = System.Text.Encoding.UTF8.GetBytes(sessionData.ToString());
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address), sessionDataBytes));
            return jObject.ToObject<Session>();
        }
        /// <summary>
        /// Creates a session from a request token.
        /// </summary>
        public static async Task<Session> createSessionWithLoginAsync(string inUsername, string inPassword, string inRequestToken)
        {
            // Written, 04.12.2019

            string address = String.Format("{0}?api_key={1}", ApplicationInfomation.AUTH_TOKEN_VALIDATE_WITH_LOGIN_ADDRESS, ApplicationInfomation.API_KEY);
            JObject sessionData = new JObject(
                new JProperty("username", inUsername),
                new JProperty("password", inPassword),
                new JProperty("request_token", inRequestToken));
            byte[] sessionDataBytes = System.Text.Encoding.UTF8.GetBytes(sessionData.ToString());
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address), sessionDataBytes));
            Token token = jObject.ToObject<Token>();
            return await createSessionAsync(token.request_token);
        }

        #endregion
    }
}
