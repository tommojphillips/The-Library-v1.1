using System;

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
        internal const string API_KEY = "70b2d4ba8f50d9f2c4bd12c87cae3b68";
        /// <summary>
        /// Represents the auth url.
        /// </summary>
        public const string TMDB_AUTHENTICATE_ADDRESS = "https://www.themoviedb.org/authenticate";
        /// <summary>
        /// Represents the tmdb verson 3 address.
        /// </summary>
        internal const string TMDB_V3_ADDRESS = "https://api.themoviedb.org/3";
        /// <summary>
        /// Represents the base url for certifications.
        /// </summary>
        internal static string CONFIGURATION_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "configuration");
        /// <summary>
        /// Represents the search base address.
        /// </summary>
        private static string SEARCH_BASE_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "search");
        /// <summary>
        /// Represents the base url for certifications.
        /// </summary>
        internal static string CERTIFICATIONS_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "certification");
        /// Represents the base url address for priginal images.
        /// </summary>
        internal static string IMAGE_ORIGINAL_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "original");
        /// <summary>
        /// Represents the base url address for movies.
        /// </summary>
        internal static string MOVIE_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "movie");
        /// <summary>
        /// Represents the base url address for tv series.
        /// </summary>
        internal static string TV_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "tv");
        /// <summary>
        /// Represents the networks url address.
        /// </summary>
        internal static string NETWORK_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "network");
        /// <summary>
        /// Represents the person url address.
        /// </summary>
        internal static string PERSON_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "person");
        /// <summary>
        /// Repersents the review url address.
        /// </summary>
        internal static string REVIEW_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "review");
        /// <summary>
        /// Repersents the account url address.
        /// </summary>
        internal static string ACCOUNT_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "account");
        /// <summary>
        /// Represents the authentication url address.
        /// </summary>
        internal static string AUTH_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "authentication");
        /// <summary>
        /// Represents the authentication token new url address.
        /// </summary>
        internal static string AUTH_TOKEN_ADDRESS => String.Join("/", AUTH_ADDRESS, "token");
        /// <summary>
        /// Represents the authentication token new url address.
        /// </summary>
        internal static string AUTH_TOKEN_NEW_ADDRESS => String.Join("/", AUTH_TOKEN_ADDRESS, "new");
        /// <summary>
        /// Represents the authentication token vaildate with login url address.
        /// </summary>
        internal static string AUTH_TOKEN_VALIDATE_WITH_LOGIN_ADDRESS => String.Join("/", AUTH_TOKEN_ADDRESS, "validate_with_login");
        /// <summary>
        /// Represents the auth session url address.
        /// </summary>
        internal static string AUTH_SESSION_ADDRESS => String.Join("/", AUTH_ADDRESS, "session", "new");
        /// <summary>
        /// Repersents the trending url address.
        /// </summary>
        internal static string TRENDING_ADDRESS => String.Join("/", TMDB_V3_ADDRESS, "trending");
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
        /// <summary>
        /// Represents the number of items per page.
        /// </summary>
        public const int NUMBER_OF_ITEMS_PER_PAGE = 20;
    }
}
