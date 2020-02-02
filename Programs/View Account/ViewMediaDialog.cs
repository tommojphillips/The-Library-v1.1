using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TM_Db_Lib;
using TM_Db_Lib.Media;
using TM_Db_Lib.Search;

namespace View_Account
{
    public partial class ViewMediaDialog : Form
    {
        // Written, 17.12.2019

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

            this.media = inMedia;
            this.viewAccount = inViewAccount;
            this.Text = String.Format("View Details - {0}", this.media.name);
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

            this.favorite_button.Enabled = false;
            this.favorite_button.Text = "processing..";
            MediaTypeEnum mediaType = this.media is TvSearchResult ? MediaTypeEnum.tv : MediaTypeEnum.movie;
            List<IdResultObject> favoritedMedia = new List<IdResultObject>();
            favoritedMedia.AddRange(this.viewAccount.favoritedMovies);
            favoritedMedia.AddRange(this.viewAccount.favoritedTvSeries);
            bool favorited = favoritedMedia.Any(_fm => _fm.id == this.media.id);
            await this.viewAccount.user.favoriteMediaItem(mediaType, media.id, !favorited);
            switch (mediaType)
            {
                case MediaTypeEnum.movie:
                    await this.viewAccount.retrieveFavoriteMoviesAsync();
                    break;
                case MediaTypeEnum.tv:
                    await this.viewAccount.retrieveFavoriteTvSeriesAsync();
                    break;
            }
            this.updateFavoriteDisplay();
            this.favorite_button.Enabled = true;
            this.favoriteChanged = true;
        }
        /// <summary>
        ///  Updates watchlist boolean.
        /// </summary>
        private async Task updateWatchlist() 
        {
            // Written, 02.02.2020

            this.watch_button.Enabled = false;
            this.watch_button.Text = "processing..";
            MediaTypeEnum mediaType = this.media is TvSearchResult ? MediaTypeEnum.tv : MediaTypeEnum.movie;
            List<IdResultObject> watchedMedia = new List<IdResultObject>();
            watchedMedia.AddRange(this.viewAccount.watchlistMovies);
            watchedMedia.AddRange(this.viewAccount.watchlistTvSeries);
            bool watched = watchedMedia.Any(_fm => _fm.id == this.media.id);
            await this.viewAccount.user.watchlistMediaItem(mediaType, media.id, !watched);
            switch (mediaType)
            {
                case MediaTypeEnum.movie:
                    await this.viewAccount.retrieveWatchlistMoviesAsync();
                    break;
                case MediaTypeEnum.tv:
                    await this.viewAccount.retrieveWatchlistTvSeriesAsync();
                    break;
            }
            this.updateWatchlistDisplay();
            this.watch_button.Enabled = true;
            this.watchListChanged = true;
        }
        /// <summary>
        /// Updates favorite display (button text).
        /// </summary>
        private void updateFavoriteDisplay() 
        {
            // Written, 02.02.2020

            List<IdResultObject> favoritedMedia = new List<IdResultObject>();
            favoritedMedia.AddRange(this.viewAccount.favoritedMovies);
            favoritedMedia.AddRange(this.viewAccount.favoritedTvSeries);
            bool favorited = favoritedMedia.Any(_fm => _fm.id == media.id);
            this.favorite_button.Text = !favorited ? "favorite" : "unfavorite";
        }
        /// <summary>
        /// Updates watchlist display (button text)
        /// </summary>
        private void updateWatchlistDisplay() 
        {
            // Written, 02.02.2020

            List<IdResultObject> watchlistMedia = new List<IdResultObject>();
            watchlistMedia.AddRange(this.viewAccount.watchlistMovies);
            watchlistMedia.AddRange(this.viewAccount.watchlistTvSeries);
            bool watchlisted = watchlistMedia.Any(_wm => _wm.id == media.id);
            this.watch_button.Text = !watchlisted ? "watch" : "unwatch";
        }

        #endregion

        #region Event Handlers

        private void ViewMediaDialog_Load(object sender, EventArgs e)
        {
            // Written, 17.12.2019

            this.mediaName_label.Text = "Loading..";
            this.viewReviews_button.Text = "View Reviews";
            this.mediaReleaseDate_label.Text = String.Empty;
            this.mediaVotesAvg_label.Text = String.Empty;
            this.poster_pictureBox.Image = media.poster_image.resizeImage(this.poster_pictureBox.Size.Width, this.poster_pictureBox.Size.Height);
            this.mediaName_label.Text = this.media.name;
            this.mediaReleaseDate_label.Text = this.media.release_date;
            this.mediaDescription_richTextBox.Text = this.media.overview;
            this.mediaVotesAvg_label.Text = String.Format("{0} stars", this.media.vote_average.ToString());

            this.updateFavoriteDisplay();
            this.updateWatchlistDisplay();
        }
        private async void viewReviews_button_Click(object sender, EventArgs e)
        {
            // Written, 16.01.2020

            if (this.media is TvSearchResult)
                await (media as TvSearchResult).retrieveReviewsAsync();
            else
                await (media as MovieSearchResult).retrieveReviewsAsync();
            if (this.media.reviews.Length > 0)
            {
                ViewReviewsDialog vrd = new ViewReviewsDialog(this.media);
                vrd.ShowDialog();
            }
            else
                MessageBox.Show(String.Format("No reviews for {0}", this.media.name));
        }
        private async void favorite_button_Click(object sender, EventArgs e)
        {
            // Written, 02.02.2020

            await this.updateFavorites();
        }
        private async void watch_button_Click(object sender, EventArgs e)
        {
            // Written, 02.02.2020

            await this.updateWatchlist();
        }

        #endregion
    }
}
