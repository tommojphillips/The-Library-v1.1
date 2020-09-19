namespace TommoJProductions.YTS.Structure
{
    /// <summary>
    /// Represents yts (yify) data of the response.
    /// </summary>
    public class Data
    {
        // Written, 19.09.2020

        /// <summary>
        /// Represents the movie count.
        /// </summary>
        public int movie_count;
        /// <summary>
        /// Represents the current limit.
        /// </summary>
        public int limit;
        /// <summary>
        /// Represents the page number.
        /// </summary>
        public int page_number;
        /// <summary>
        /// Represents all movies in response.
        /// </summary>
        public MovieInfo[] movies;
    }
}
