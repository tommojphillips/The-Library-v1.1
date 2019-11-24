namespace TM_Db_Lib
{
    /// <summary>
    /// Represents data used by all parts of the application.
    /// </summary>
    public static class ApplicationInfomation
    {
        // Written, 20.04.2018

        /// <summary>
        /// Represents my (Tommo J. Armytage) api key for connecting to The TMDb API.
        /// </summary>
        public const string API_KEY = "70b2d4ba8f50d9f2c4bd12c87cae3b68";
        /// <summary>
        /// Represents the search base address.
        /// </summary>
        public const string SEARCH_BASE_ADDRESS = "https://api.themoviedb.org/3/search";
        /// <summary>
        /// Represents the base url for certifications.
        /// </summary>
        public const string CERTIFICATIONS_BASE_ADDRESS = "https://api.themoviedb.org/3/certification";
        /// <summary>
        /// Represents the base url address for movies.
        /// </summary>
        public const string MOVIE_BASE_ADDRESS = "https://api.themoviedb.org/3/movie";
        /// <summary>
        /// Represents the base url address for tv series.
        /// </summary>
        public const string TV_BASE_ADDRESS = "https://api.themoviedb.org/3/tv";
        /// <summary>
        /// Represents the base url address for images.
        /// </summary>
        public const string IMAGE_BASE_ADDRESS = "https://image.tmdb.org/t/p/original";
        /// <summary>
        /// Represents the base url address for networks.
        /// </summary>
        public const string NETWORK_BASE_ADDRESS = "https://api.themoviedb.org/3/network";
    }
}
