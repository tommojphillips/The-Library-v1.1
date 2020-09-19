namespace TommoJProductions.TMDB.Discover
{
    /// <summary>
    /// Represents sort-by ascending and descending options for media. used in <see cref="Discover"/> function.
    /// </summary>
    public enum MediaSortByAscDescEnum
    {
        // Written, 09.01.2020

        /*Allowed Values:
        popularity.asc,
        popularity.desc,
        release_date.asc,
        release_date.desc,
        revenue.asc,
        revenue.desc,
        primary_release_date.asc,
        primary_release_date.desc,
        original_title.asc,
        original_title.desc,
        vote_average.asc,
        vote_average.desc,
        vote_count.asc,
        vote_count.desc
        default: popularity.des*/

        /// <summary>
        /// Represents ascending order.
        /// </summary>
        asc,
        /// <summary>
        /// Represents descending order.
        /// </summary>
        desc,
    }
}
