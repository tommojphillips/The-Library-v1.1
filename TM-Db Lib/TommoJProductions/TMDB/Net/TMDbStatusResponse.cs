namespace TommoJProductions.Net
{
    /// <summary>
    /// Represents the TMDb Status Response Object.
    /// </summary>
    public class TMDbStatusResponse
    {
        // Written, 24.11.2019

        #region Properties

        /// <summary>
        /// Represents the status code for the stat response.
        /// </summary>
        public int status_code
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the status message for the stat response.
        /// </summary>
        public string status_message
        {
            get;
            set;
        }

        #endregion
    }
}
