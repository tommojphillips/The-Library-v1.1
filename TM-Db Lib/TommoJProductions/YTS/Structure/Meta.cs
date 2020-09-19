namespace TommoJProductions.YTS.Structure
{
    /// <summary>
    /// Represents meta data for yts (yify) api.
    /// </summary>
    public class Meta
    {
        // Written, 19.09.2020

        /// <summary>
        /// Represents the api version.
        /// </summary>
        public int api_version;
        /// <summary>
        /// Represents the execution time for the response.
        /// </summary>
        public string execution_time;
        /// <summary>
        /// Represents the current server time.
        /// </summary>
        public long server_time;
        /// <summary>
        /// Represents the server's timezone.
        /// </summary>
        public string server_timezone;
    }
}
