using System;

namespace TommoJProductions.Net
{
    /// <summary>
    /// Represents event data for the <see cref="WebResponse.RequestSending"/> event.
    /// </summary>
    public class RequestSendingEventArgs : EventArgs
    {
        // Written, 24.11.2019

        #region Properties

        /// <summary>
        /// Represents the url of the sent request.
        /// </summary>
        public Uri url
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
        public RequestSendingEventArgs(Uri inUri)
        {
            // Written, 24.11.2019

            this.url = inUri;
        }

        #endregion
    }
}
