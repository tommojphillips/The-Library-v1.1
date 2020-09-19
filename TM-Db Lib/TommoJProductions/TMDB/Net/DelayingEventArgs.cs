using System;

namespace TommoJProductions.Net
{
    /// <summary>
    /// Represents event data for the <see cref="WebResponse.Delaying"/> event.
    /// </summary>
    public class DelayingEventArgs : EventArgs
    {
        // Written, 05.06.2018

        #region Properties

        /// <summary>
        /// Represents how long the delay will be.
        /// </summary>
        public int delay
        {
            get;
            private set;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="DelayingEventArgs"/>.
        /// </summary>
        /// <param name="inDelay"></param>
        public DelayingEventArgs(int inDelay)
        {
            // Written, 05.06.2018

            this.delay = inDelay;
        }

        #endregion
    }
}
