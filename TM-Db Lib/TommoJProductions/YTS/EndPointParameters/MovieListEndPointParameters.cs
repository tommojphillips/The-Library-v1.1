namespace TommoJProductions.YTS.EndPointParameters
{
    public class MovieListEndPointParameters
    {
        // Written, 14.09.2020

        #region Properties

        /// <summary>
        /// The limit of results per page. 1 to 50.
        /// </summary>
        public int limit
        {
            get;
            set;
        } = 20;
        /// <summary>
        /// The page to view. Used to see the next page of results. eg. limit=15, page=2 will show you movies 15-30.
        /// </summary>
        public int page
        {
            get;
            set;
        } = 1;
        /// <summary>
        /// Used to filter by a certian quality.
        /// </summary>
        public QualityEndPointParameterEnum quality
        {
            get;
            set;
        } = QualityEndPointParameterEnum.All;
        /// <summary>
        /// Used to filter by a give min rating. 0 to 9
        /// </summary>
        public int minRating
        {
            get;
            set;
        } = 0;
        /// <summary>
        /// Used for movie search, matching on: Movie Title/IMDb Code, Actor Name/IMDb Code, Director Name/IMDb Code.
        /// </summary>
        public string query
        {
            get;
            set;
        } = "0";
        /// <summary>
        /// Used to filter by a given genre (See http://www.imdb.com/genre/ for full list).
        /// </summary>
        public string genre
        {
            get;
            set;
        } = "All";
        /// <summary>
        /// Sorts the results by choosen value.
        /// </summary>
        public SortByEndPointParameterEnum sortBy
        {
            get;
            set;
        } = SortByEndPointParameterEnum.date_added;
        /// <summary>
        /// Orders the results by either Ascending or Descending order.
        /// </summary>
        public OrderByEndPointParameterEnum orderBy
        {
            get;
            set;
        } = OrderByEndPointParameterEnum.desc;

        #endregion
    }
}
