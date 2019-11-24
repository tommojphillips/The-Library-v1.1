namespace TM_Db_Lib.MovieMedia
{
    /// <summary>
    /// Represents the status' for a movie.
    /// </summary>
    public enum MovieStatusEnum
    {
        // Written, 25.11.2019

        /// <summary>
        /// Represents <see langword="null"/>.
        /// </summary>
        NULL,
        /// <summary>
        /// Represents a rumored movie.
        /// </summary>
        rumored,
        /// <summary>
        /// Represents a planned movie.
        /// </summary>
        planned,
        /// <summary>
        /// Represents a movie that is in production.
        /// </summary>
        in_production,
        /// <summary>
        /// Represents a movie that is post production.
        /// </summary>
        post_production,
        /// <summary>
        /// Represents a released movie.
        /// </summary>
        released,
        /// <summary>
        /// Represents a canceled movie.
        /// </summary>
        canceled
    }
}
