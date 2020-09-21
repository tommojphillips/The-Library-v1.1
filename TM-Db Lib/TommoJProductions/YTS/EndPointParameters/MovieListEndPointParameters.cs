namespace TommoJProductions.YTS.EndPointParameters
{
    public class MovieListEndPointParameters
    {
        // Written, 14.09.2020

        #region Properties

        /// <summary>
        /// The limit of results per page. 1 to 50. default = 20
        /// </summary>
        public int limit
        {
            get;
            set;
        } = 20;
        /// <summary>
        /// The page to view. Used to see the next page of results. default = 1. eg. limit=15, page=2 will show you movies 15-30.
        /// </summary>
        public int page
        {
            get;
            set;
        } = 1;
        /// <summary>
        /// Used to filter by a certian quality. default = All.
        /// </summary>
        public QualityEndPointParameterEnum quality
        {
            get;
            set;
        } = QualityEndPointParameterEnum.All;
        /// <summary>
        /// Used to filter by a give min rating. 0 to 9. default = 0
        /// </summary>
        public int minRating
        {
            get;
            set;
        } = 0;
        /// <summary>
        /// Used for movie search, matching on: Movie Title/IMDb Code, Actor Name/IMDb Code, Director Name/IMDb Code. default = 0.
        /// </summary>
        public string query
        {
            get;
            set;
        } = "0";
        /// <summary>
        /// Used to filter by a given genre (See http://www.imdb.com/genre/ for full list). default = "All".
        /// </summary>
        public string genre
        {
            get;
            set;
        } = "All";
        /// <summary>
        /// Sorts the results by choosen value. default = <see cref="SortByEndPointParameterEnum.date_added"/>.
        /// </summary>
        public SortByEndPointParameterEnum sortBy
        {
            get;
            set;
        } = SortByEndPointParameterEnum.date_added;
        /// <summary>
        /// Orders the results by either Ascending or Descending order. default = <see cref="OrderByEndPointParameterEnum.desc"/>.
        /// </summary>
        public OrderByEndPointParameterEnum orderBy
        {
            get;
            set;
        } = OrderByEndPointParameterEnum.desc;

        #endregion
    }
}
