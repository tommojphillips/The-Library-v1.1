namespace TommoJProductions.TMDB.Discover
{
    /// <summary>
    /// Represents all sort-by member options for media. used in <see cref="Discover"/> function.
    /// </summary>
    public enum MediaSortByMembersEnum
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
        /// Represents ordered by popularity. 
        /// </summary>
        popularity,
        /// <summary>
        /// Represents ordered by release date. 
        /// </summary>
        release_date,
        /// <summary>
        /// Represents ordered by revenue. 
        /// </summary>
        revenue,
        /// <summary>
        /// Represents ordered by primary release date. 
        /// </summary>
        primary_release_date,
        /// <summary>
        /// Represents ordered by original title. 
        /// </summary>
        original_title,
        /// <summary>
        /// Represents ordered by vote average. 
        /// </summary>
        vote_average,
        /// <summary>
        /// Represents ordered by vote count. 
        /// </summary>
        vote_count,
    }
}
