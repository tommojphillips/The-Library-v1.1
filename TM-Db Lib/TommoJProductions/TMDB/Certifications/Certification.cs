using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TommoJProductions.Net;

namespace TommoJProductions.TMDB.Certifications
{
    /// <summary>
    /// Get an up to date list of the officially supported movie and tv series certifications on TMDb.
    /// </summary>
    public class Certification
    {
        // Written, 09.01.2020

        #region Properties

        /// <summary>
        /// Represents the US certificate data.
        /// </summary>
        public CertObject[] US
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the CA certificate data.
        /// </summary>
        public CertObject[] CA
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the DE certificate data.
        /// </summary>
        public CertObject[] DE
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the GB certificate data.
        /// </summary>
        public CertObject[] GB
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the AU certificate data.
        /// </summary>
        public CertObject[] AU
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the BR certificate data.
        /// </summary>
        public CertObject[] BR
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the FR certificate data.
        /// </summary>
        public CertObject[] FR
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the NZ certificate data.
        /// </summary>
        public CertObject[] NZ
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the IN certificate data.
        /// </summary>
        public CertObject[] IN
        {
            get;
            set;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get an up to date list of the officially supported movie certifications on TMDb.
        /// </summary>
        public async static Task<Certification> retrieveMovieCertificationsAsync() 
        {
            // Written, 09.01.2020

            string address = String.Format("{0}/movie/list?api_key={1}", ApplicationInfomation.CERTIFICATIONS_ADDRESS, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObjectAsync(await WebResponse.sendRequestAsync(new Uri(address)));
            return  jObject["certifications"].ToObject<Certification>();
        }
        /// <summary>
        /// Get an up to date list of the officially supported tv series certifications on TMDb.
        /// </summary>
        public async static Task<Certification> retrieveTvSeriesCertificationsAsync()
        {
            // Written, 09.01.2020

            string address = String.Format("{0}/tv/list?api_key={1}", ApplicationInfomation.CERTIFICATIONS_ADDRESS, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObjectAsync(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject["certifications"].ToObject<Certification>();
        }

        #endregion
    }
}
