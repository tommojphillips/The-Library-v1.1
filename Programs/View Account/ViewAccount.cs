using System;
using System.Threading.Tasks;
using TommoJProductions.TMDB.Account;
using TommoJProductions.TMDB.Search;

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
            private set;
        }
        /// <summary>
        /// Represents favorited tv series of the user.
        /// </summary>
        internal TvSearchResult[] favoritedTvSeries
        {
            get;
            private set;
        }
        /// <summary>
        /// Represents favorited movies of the user.
        /// </summary>
        internal MovieSearchResult[] watchlistMovies
        {
            get;
            private set;
        }
        /// <summary>
        /// Represents favorited tv series of the user.
        /// </summary>
        internal TvSearchResult[] watchlistTvSeries
        {
            get;
            private set;
        }

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="ViewAccount"/>.
        /// </summary>
        /// <param name="inUser">The user to use/view.</param>
        public ViewAccount(User inUser) 
        {
            this.user = inUser ?? throw new NullReferenceException("User cannot be null. invaild argument.");
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
        /// Retrieves watchlisted movies, puts media in <see cref="watchlistMovies"/>.
        /// </summary>
        internal async Task retrieveWatchlistMoviesAsync()
        {
            // Written, 17.12.2019

            this.watchlistMovies = await this.user.getWatchlistMovies();
        }
        /// <summary>
        /// Retrieves watchlisted tv series, puts media in <see cref="watchlistTvSeries"/>.
        /// </summary>
        internal async Task retrieveWatchlistTvSeriesAsync()
        {
            // Written, 17.12.2019

            this.watchlistTvSeries = await this.user.getWatchlistTvSeries();
        }

        #endregion
    }
}
