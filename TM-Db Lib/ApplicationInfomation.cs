using System;

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
        /// Represents the tmdb verson 3 address.
        /// </summary>
        internal const string TMDB_V3_ADDRESS = "https://api.themoviedb.org/3";
        /// <summary>
        /// Represents the search base address.
        /// </summary>
        private static string SEARCH_BASE_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "search");
        /// <summary>
        /// Represents the base url for certifications.
        /// </summary>
        internal static string CERTIFICATIONS_BASE_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "certification");
        /// <summary>
        /// Represents the base url address for movies.
        /// </summary>
        internal static string MOVIE_BASE_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "movie");
        /// <summary>
        /// Represents the base url address for tv series.
        /// </summary>
        internal static string TV_BASE_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "tv");
        /// <summary>
        /// Represents the base url address for images.
        /// </summary>
        internal static string IMAGE_BASE_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "original");
        /// <summary>
        /// Represents the base url address for networks.
        /// </summary>
        internal static string NETWORK_BASE_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "network");
        /// <summary>
        /// Represents the base url address for people.
        /// </summary>
        internal static string PERSON_BASE_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "person");
        /// <summary>
        /// Represents the movie search address
        /// </summary>
        internal static string MOVIE_SEARCH_ADDRESS => String.Join("/", SEARCH_BASE_ADDRESS, "movie");
        /// <summary>
        /// Represents the tv search address
        /// </summary> 
        internal static string TV_SEARCH_ADDRESS => String.Join("/", SEARCH_BASE_ADDRESS, "tv");
        /// <summary>
        /// Represents the people search address.
        /// </summary>
        internal static string PEOPLE_SEARCH_ADDRESS => String.Join("/", SEARCH_BASE_ADDRESS, "person");
        /// <summary>
        /// Represents the multi search address.
        /// </summary>
        internal static string MULTI_SEARCH_ADDRESS => String.Join("/", SEARCH_BASE_ADDRESS, "multi");
    }
}
