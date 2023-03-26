using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

using TommoJProductions.Net;
using TommoJProductions.EzTV.EndPointParameters;
using TommoJProductions.EzTV.Structure;

namespace TommoJProductions.EzTV
{
    public class EztvManager
    {
        public const string EZTV_ADDRESS = "http://eztv.re";
        public const string EZTV_ADDRESS_API = "/api";
        public const string EZTV_GET_TORRENTS = "/get-torrents";
        /// <summary>
        /// Gets a list of movies on EZTV based on the end point parameters provided.
        /// </summary>
        public static async Task<Response> retrieveTorrentsAsync(GetTorrrentsEndPointParameters endPointParameters)
        {
            // Written, 17.09.2020

            string parameters = String.Format("limit={0}&page={1}&imdb_id={2}", endPointParameters.limit, endPointParameters.page, endPointParameters.imdb_id);
            string address = String.Format("{0}{1}{2}?{3}", EZTV_ADDRESS, EZTV_ADDRESS_API, EZTV_GET_TORRENTS, parameters);
            JObject jObject = await WebResponse.toJObjectAsync(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject.ToObject<Response>();
        }

        public static DateTime unixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }
    }
}
