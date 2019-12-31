using System;
using System.Threading.Tasks;
using TM_Db_Lib.Account;
using TM_Db_Lib.Search;

namespace View_Account
{
    public class ViewAccount
    {
        // Written, 09.12.2019

        /// <summary>
        /// Represents the current user.
        /// </summary>
        internal User user 
        {
            get;
            private set;
        }
        /// <summary>
        /// Represents favorited movies of the user.
        /// </summary>
        internal MovieSearchResult[] favoritedMovies
        {
            get;
            set;
        }
        /// <summary>
        /// Represents favorited tv series of the user.
        /// </summary>
        internal TvSearchResult[] favoritedTvSeries
        {
            get;
            set;
        }

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="ViewAccount"/>.
        /// </summary>
        /// <param name="inUser">The user to use/view.</param>
        public ViewAccount(User inUser) 
        {
            // Written, 09.12.2019

            if (inUser == null) 
                throw new NullReferenceException("User cannot be null. invaild argument.");
            this.user = inUser;
            Task.Run(this.retrieveFavoritedMediaAsync);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Retrieves favorited movies, puts media in <see cref="favoritedMovies"/>.
        /// </summary>
        internal async Task retrieveFavoriteMoviesAsync()
        {
            // Written, 17.12.2019

            this.favoritedMovies = await this.user.getFavoriteMovies();
        }
        /// <summary>
        /// Retrieves favorited tv series, puts media in <see cref="favoritedTvSeries"/>.
        /// </summary>
        internal async Task retrieveFavoriteTvSeriesAsync()
        {
            // Written, 17.12.2019

            this.favoritedTvSeries = await this.user.getFavoriteTvSeries();
        }
        /// <summary>
        /// Retrieves favorited media, puts media in <see cref="favoritedMovies"/> and <see cref="favoritedTvSeries"/> respectively.
        /// </summary>
        internal async Task retrieveFavoritedMediaAsync()
        {
            // Written, 17.12.2019

            await this.retrieveFavoriteMoviesAsync();
            await this.retrieveFavoriteTvSeriesAsync();
        }

        #endregion
    }
}
