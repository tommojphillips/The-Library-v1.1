using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TommoJProductions;
using TommoJProductions.TMDB.Media;
using TommoJProductions.TMDB.Search;

namespace View_Account
{
    public partial class ViewMediaDialog : Form
    {
        // Written, 17.12.2019

        private TvSearchResult tvMedia;
        private MovieSearchResult movieMedia;

        #region Properties

        /// <summary>
        /// Represents the media that is being viewed.
        /// </summary>
        private MediaSearchResult media 
        {

            get;
            set;
        }
        /// <summary>
        /// Represents the account that is being viewed.
        /// </summary>
        private ViewAccount viewAccount 
        {
            get;
            set;
        }
        /// <summary>
        /// Represents if watch boolean has changed.
        /// </summary>
        public bool watchListChanged 
        {
            get;
            private set;
        }
        /// <summary>
        /// Represents if favorite boolean has changed.
        /// </summary>
        public bool favoriteChanged 
        {
            get;
            private set;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of this.
        /// </summary>
        /// <param name="inMedia">The media to view.</param>
        public ViewMediaDialog(MediaSearchResult inMedia, ViewAccount inViewAccount)
        {
            // Written, 17.12.2019

            InitializeComponent();

            media = inMedia;
            if (media is TvSearchResult)
                tvMedia = media as TvSearchResult;
            if (media is MovieSearchResult)
                movieMedia = media as MovieSearchResult;

            viewAccount = inViewAccount;
            Text = String.Format("View Details - {0}", media.name);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Updates favorite boolean.
        /// </summary>
        /// <returns></returns>
        private async Task updateFavorites() 
        {
            // Written, 02.02.2020

            favorite_button.Enabled = false;
            favorite_button.Text = "processing..";
            MediaTypeEnum mediaType = media is TvSearchResult ? MediaTypeEnum.tv : MediaTypeEnum.movie;
            List<IdResultObject> favoritedMedia = new List<IdResultObject>();
            favoritedMedia.AddRange(viewAccount.favoritedMovies);
            favoritedMedia.AddRange(viewAccount.favoritedTvSeries);
            bool favorited = favoritedMedia.Any(_fm => _fm.id == media.id);
            await viewAccount.user.favoriteMediaItem(mediaType, media.id, !favorited);
            switch (mediaType)
            {
                case MediaTypeEnum.movie:
                    await viewAccount.retrieveFavoriteMoviesAsync();
                    break;
                case MediaTypeEnum.tv:
                    await viewAccount.retrieveFavoriteTvSeriesAsync();
                    break;
            }
            updateFavoriteDisplay();
            favorite_button.Enabled = true;
            favoriteChanged = true;
        }
        /// <summary>
        ///  Updates watchlist boolean.
        /// </summary>
        private async Task updateWatchlist() 
        {
            // Written, 02.02.2020

            watch_button.Enabled = false;
            watch_button.Text = "processing..";
            MediaTypeEnum mediaType = media is TvSearchResult ? MediaTypeEnum.tv : MediaTypeEnum.movie;
            List<IdResultObject> watchedMedia = new List<IdResultObject>();
            watchedMedia.AddRange(viewAccount.watchlistMovies);
            watchedMedia.AddRange(viewAccount.watchlistTvSeries);
            bool watched = watchedMedia.Any(_fm => _fm.id == media.id);
            await viewAccount.user.watchlistMediaItem(mediaType, media.id, !watched);
            switch (mediaType)
            {
                case MediaTypeEnum.movie:
                    await viewAccount.retrieveWatchlistMoviesAsync();
                    break;
                case MediaTypeEnum.tv:
                    await viewAccount.retrieveWatchlistTvSeriesAsync();
                    break;
            }
            updateWatchlistDisplay();
            watch_button.Enabled = true;
            watchListChanged = true;
        }
        /// <summary>
        /// Updates favorite display (button text).
        /// </summary>
        private void updateFavoriteDisplay() 
        {
            // Written, 02.02.2020

            List<IdResultObject> favoritedMedia = new List<IdResultObject>();
            favoritedMedia.AddRange(viewAccount.favoritedMovies);
            favoritedMedia.AddRange(viewAccount.favoritedTvSeries);
            bool favorited = favoritedMedia.Any(_fm => _fm.id == media.id);
            favorite_button.Text = !favorited ? "favorite" : "unfavorite";
        }
        /// <summary>
        /// Updates watchlist display (button text)
        /// </summary>
        private void updateWatchlistDisplay() 
        {
            // Written, 02.02.2020

            List<IdResultObject> watchlistMedia = new List<IdResultObject>();
            watchlistMedia.AddRange(viewAccount.watchlistMovies);
            watchlistMedia.AddRange(viewAccount.watchlistTvSeries);
            bool watchlisted = watchlistMedia.Any(_wm => _wm.id == media.id);
            watch_button.Text = !watchlisted ? "watch" : "unwatch";
        }

        #endregion

        #region Event Handlers

        private void ViewMediaDialog_Load(object sender, EventArgs e)
        {
            // Written, 17.12.2019

            mediaName_label.Text = "Loading..";
            viewReviews_button.Text = "View Reviews";
            mediaReleaseDate_label.Text = String.Empty;
            mediaVotesAvg_label.Text = String.Empty;
            poster_pictureBox.Image = media.poster_image.resizeImage(poster_pictureBox.Size.Width, poster_pictureBox.Size.Height);
            mediaName_label.Text = media.name;
            mediaReleaseDate_label.Text = media.release_date;
            mediaDescription_richTextBox.Text = media.overview;
            mediaVotesAvg_label.Text = String.Format("{0} stars", media.vote_average.ToString());

            updateFavoriteDisplay();
            updateWatchlistDisplay();
        }
        private async void viewReviews_button_Click(object sender, EventArgs e)
        {
            // Written, 16.01.2020

            if (media is TvSearchResult)
                await (media as TvSearchResult).retrieveReviewsAsync();
            else
                await (media as MovieSearchResult).retrieveReviewsAsync();
            if (media.reviews.Length > 0)
            {
                ViewReviewsDialog vrd = new ViewReviewsDialog(media);
                vrd.ShowDialog();
            }
            else
                MessageBox.Show(String.Format("No reviews for {0}", media.name));
        }
        private async void favorite_button_Click(object sender, EventArgs e)
        {
            // Written, 02.02.2020

            await updateFavorites();
        }
        private async void watch_button_Click(object sender, EventArgs e)
        {
            // Written, 02.02.2020

            await updateWatchlist();
        }

        #endregion
    }
}
