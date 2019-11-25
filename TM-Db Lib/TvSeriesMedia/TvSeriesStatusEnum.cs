namespace TM_Db_Lib.TvSeriesMedia
{
    /// <summary>
    /// Represents the status' a for tv series.
    /// </summary>
    public enum TvSeriesStatusEnum
    {
        // Written, 25.11.2019

        /// <summary>
        /// Represents null.
        /// </summary>
        NULL,
        /// <summary>
        /// represents a returning series. off now; back later.
        /// </summary>
        Returning_Series,
        /// <summary>
        /// Represents a planned series.
        /// </summary>
        planned,
        /// <summary>
        /// Represents a series that is in production.
        /// </summary>
        in_production,
        /// <summary>
        /// Represents that a series has ended.
        /// </summary>
        ended,
        /// <summary>
        /// Represents a canceled series.
        /// </summary>
        canceled,
        /// <summary>
        /// Represents a pilot series.
        /// </summary>
        pilot,
    }
}
