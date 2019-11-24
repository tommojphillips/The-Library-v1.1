namespace TM_Db_Lib
{
    /// <summary>
    /// Represents data used by all parts of the application.
    /// </summary>
    internal static class ApplicationInfomation
    {
        // Written, 20.04.2018

        /// <summary>
        /// Represents my (Tommo J. Armytage) api key for connecting to The TMDb API.
        /// </summary>
        internal const string API_KEY = "70b2d4ba8f50d9f2c4bd12c87cae3b68";
        /// <summary>
        /// Represents the search base address.
        /// </summary>
        private const string SEARCH_BASE_ADDRESS = "https://api.themoviedb.org/3/search";
        /// <summary>
        /// Represents the base url for certifications.
        /// </summary>
        internal const string CERTIFICATIONS_BASE_ADDRESS = "https://api.themoviedb.org/3/certification";
        /// <summary>
        /// Represents the base url address for movies.
        /// </summary>
        internal const string MOVIE_BASE_ADDRESS = "https://api.themoviedb.org/3/movie";
        /// <summary>
        /// Represents the base url address for tv series.
        /// </summary>
        internal const string TV_BASE_ADDRESS = "https://api.themoviedb.org/3/tv";
        /// <summary>
        /// Represents the base url address for images.
        /// </summary>
        internal const string IMAGE_BASE_ADDRESS = "https://image.tmdb.org/t/p/original";
        /// <summary>
        /// Represents the base url address for networks.
        /// </summary>
        internal const string NETWORK_BASE_ADDRESS = "https://api.themoviedb.org/3/network";
        /// <summary>
        /// Represents the movie search address
        /// </summary>
        internal static string MOVIE_SEARCH_ADDRESS 
        {
            get
            {
                return string.Join("/", SEARCH_BASE_ADDRESS, "movie");
            }
        }
        /// <summary>
        /// Represents the tv search address
        /// </summary>
        internal static string TV_SEARCH_ADDRESS
        {
            get
            {
                return string.Join("/", SEARCH_BASE_ADDRESS, "tv");
            }
        }
    }
}
