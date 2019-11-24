using System;
using System.Net;

namespace TM_Db_Lib.Net
{
    /// <summary>
    /// Represents event data for the <see cref="WebResponse.RequestSending"/> event.
    /// </summary>
    public class RequestSentEventArgs : RequestSendingEventArgs
    {
        // Written, 24.11.2019

        #region Properties

        /// <summary>
        /// Represents the response from the request.
        /// </summary>
        public HttpWebResponse response
        {
            get;
            private set;
        }

        #endregion

        #region Constructors

        public RequestSentEventArgs(Uri inUri, HttpWebResponse inResponse) : base(inUri)
        {
            // Written, 24.11.2019

            this.response = inResponse;
        }

        #endregion
    }
}
