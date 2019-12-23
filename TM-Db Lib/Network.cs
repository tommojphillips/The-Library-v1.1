using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;
using TM_Db_Lib.Net;

namespace TM_Db_Lib
{
    /// <summary>
    /// Represents a network
    /// </summary>
    public class Network
    {
        // Written, 30.05.2018

        #region Properties

        /// <summary>
        /// Represents the id for the network.
        /// </summary>
        public int id
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the homepage (url address) for the network.
        /// </summary>
        public string homepage
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the headquarters location for the network.
        /// </summary>
        public string headquarters
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the name of the network.
        /// </summary>
        public string name
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the origin of the network (country).
        /// </summary>
        public string origin_country
        {
            get;
            set;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Retrieves details about a network.
        /// </summary>
        /// <param name="network_id">The network id.</param>
        /// <returns></returns>
        public async Task retrieveDetails(int network_id)
        {
            // Written, 30.05.2018

            string address = String.Format(@"{0}/{1}?api_key={2}", ApplicationInfomation.NETWORK_ADDRESS, network_id, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            Network searchedNetwork = jObject.ToObject<Network>();

            this.id = searchedNetwork.id;
            this.homepage = searchedNetwork.homepage;
            this.headquarters = searchedNetwork.headquarters;
            this.name = searchedNetwork.name;
            this.origin_country = searchedNetwork.origin_country;
        }

        #endregion

    }
}
