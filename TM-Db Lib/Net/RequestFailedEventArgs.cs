using System;
using System.Net;

namespace TM_Db_Lib.Net
{
    /// <summary>
    /// Represents event data for the <see cref="WebResponse.RequestFailed"/> event.
    /// </summary>
    public class RequestFailedEventArgs : RequestSentEventArgs
    {
        // Written, 25.11.2019

        #region Properties

        /// <summary>
        /// Representrs the tmdb status response of the request.
        /// </summary>
        public TMDbStatusResponse statusResponse
        {
            get;
            private set;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="inUri">url</param>
        /// <param name="inResponse">response</param>
        /// <param name="inStatusResponse">tmdb response</param>
        public RequestFailedEventArgs(Uri inUri, HttpWebResponse inResponse, TMDbStatusResponse inStatusResponse) : base(inUri, inResponse)
        {
            // Written, 25.11.2019

            this.statusResponse = inStatusResponse;
        }

        #endregion
    }
}
