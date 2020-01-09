using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TM_Db_Lib;
using TM_Db_Lib.Account;
using TM_Db_Lib.Auth;
using TM_Db_Lib.Media;
using TM_Db_Lib.Search;

namespace View_Account
{
    /// <summary>
    /// Represents the view account form.
    /// </summary>
    public partial class viewAccount_Form : Form
    {
        // Written, 09.12.2019

        #region Properties
       
        /// <summary>
        /// Represents the view account object instance.
        /// </summary>
        private ViewAccount viewAccount 
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the loading dialog form.
        /// </summary>
        private LoadingDialog loadingDialog
        {
            get;
        } =  new LoadingDialog("tmdb View Account") { loadingText = "Loading..", };
        /// <summary>
        /// Represents the selected favorite media.
        /// </summary>
        private MediaSearchResult selectedFavoriteMedia 
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="viewAccount_Form"/>.
        /// </summary>
        public viewAccount_Form()
        {
            // Written, 09.12.2019

            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Login to tmdb account function and logic. Returns bool whether the login was successful or not.
        /// </summary>
        internal async Task<bool> loginTMDbAsync() 
        {
            // Written, 10.12.2019

            string dialogTitle = String.Format("{0} - TMDb Login", this.Text);
            TextDialog textDialog = new TextDialog("Enter Username", dialogTitle);
            Exception exception = null;
            if (textDialog.ShowDialog() == DialogResult.OK)
            {
                string username = textDialog.textInput;
                textDialog = new TextDialog("Enter Password for ACC: " + username, dialogTitle);
                if (textDialog.ShowDialog() == DialogResult.OK)
                {
                    loadingDialog.Show(this);
                    string password = textDialog.textInput;
                    Token token = null;
                    this.loadingDialog.loadingWhatText = "Retrieving Token";
                    try
                    {
                        token = await Token.retrieveTokenAsync();
                    }
                    catch (Exception ex)
                    {
                        exception = ex;
                    }
                    if (token?.success ?? false)
                    {
                        Session session = null;
                        this.loadingDialog.loadingWhatText = "Creating Session";
                        try
                        {
                            session = await Session.createSessionWithLoginAsync(username, password, token.request_token);
                        }
                        catch (Exception ex)
                        {
                            exception = ex;
                        }
                        if (session?.success ?? false)
                        {
                            this.loadingDialog.loadingWhatText = "Retrieving User";
                            try
                            {
                                User user = await User.retrieveUserDetailsAsync(session.session_id);
                                this.viewAccount = new ViewAccount(user);
                            }
                            catch (Exception ex)
                            {
                                exception = ex;
                            }
                        }
                    }
                }
            }
            if (!(exception is null))
            {
                LoadingDialog errorLoadingDialog = new LoadingDialog(this.loadingDialog.programNameText)
                {
                    errorMessage = exception.Message,
                    loadingText = this.loadingDialog.Text,
                    loadingWhatText = this.loadingDialog.loadingWhatText
                };
                this.loadingDialog.Close();
                Application.Run(errorLoadingDialog);
            }
            this.loadingDialog.Close();
            return !(this.viewAccount is null);
        }
        /// <summary>
        /// Updates the search media actions.
        /// </summary>
        private async Task updateSearchMediaActionsAsync() 
        {
            // Written, 17.12.2019

            if (this.searchResults_listView.SelectedItems.Count == 1)
            {
                MediaSearchResult media = this.searchResults_listView.SelectedItems[0].Tag as MediaSearchResult;
                this.searchActions_groupBox.Text = "Actions: " + media.name;
                this.searchMediaPoster_pictureBox.Image = media.poster_image;
                this.searchViewDetails_button.Enabled = true;
                this.searchViewDetails_button.Visible = true;
                this.searchFavoriteMediaItem_button.Enabled = true;
                this.searchFavoriteMediaItem_button.Visible = true;
                this.searchWatchlistMediaItem_button.Enabled = true;
                this.searchWatchlistMediaItem_button.Visible = true;
                List<IdResultObject> favoritedMedia = new List<IdResultObject>();
                favoritedMedia.AddRange(this.viewAccount.favoritedMovies);
                favoritedMedia.AddRange(this.viewAccount.favoritedTvSeries);
                bool favorited = favoritedMedia.Any(_fm => _fm.id == media.id);
                this.searchFavoriteMediaItem_button.Text = !favorited ? "favorite" : "unfavorite";
                List<IdResultObject> watchlistMedia = new List<IdResultObject>();
                watchlistMedia.AddRange(this.viewAccount.watchlistMovies);
                watchlistMedia.AddRange(this.viewAccount.watchlistTvSeries);
                bool watchlisted = watchlistMedia.Any(_wm => _wm.id == media.id);
                this.searchWatchlistMediaItem_button.Text = !watchlisted ? "watch" : "unwatch";
                this.searchViewDetails_button.Text = "View Details: " + media.name;
                if (media.poster_path is null)
                    this.searchImageLoading_label.Text = "No poster present..";
                else
                {
                    if (media.poster_image is null)
                    {
                        this.searchImageLoading_label.Text = "Loading poster..";
                        await media.retrieveMediaImages();
                        this.searchImageLoading_label.Text = string.Empty;
                    }
                }
                if (media == this.searchResults_listView.SelectedItems[0].Tag)
                    this.searchMediaPoster_pictureBox.Image = media.poster_image?.resizeImage(this.searchMediaPoster_pictureBox.Width, this.searchMediaPoster_pictureBox.Height);
            }
            else
            {
                this.searchActions_groupBox.Text = "Actions";
                this.searchViewDetails_button.Enabled = false;
                this.searchViewDetails_button.Visible = false;
                this.searchFavoriteMediaItem_button.Enabled = false;
                this.searchFavoriteMediaItem_button.Visible = false;
                this.searchWatchlistMediaItem_button.Enabled = false;
                this.searchWatchlistMediaItem_button.Visible = false;
                this.searchViewDetails_button.Text = "View Details";
                this.searchMediaPoster_pictureBox.Image = null;
                this.searchImageLoading_label.Text = string.Empty;
            }
        }
        /// <summary>
        /// updates the favorite media actions.
        /// </summary>
        /// <param name="inSender">Listview sender.</param>
        /// <param name="inMediaType">The media type that is to be updated.</param>
        private async Task updateHomeMediaActionsAsync(ListView inSender)
        {
            // Written, 24.12.2019

            if (inSender?.SelectedItems.Count == 1)
            {
                MediaSearchResult media = inSender.SelectedItems[0].Tag as MediaSearchResult;
                if (media != null)
                {
                    this.selectedFavoriteMedia = media;
                    this.favoritesMediaActions_groupBox.Text = "Actions: " + media.name;
                    this.favoriteMediaPoster_pictureBox.Image = media.poster_image;
                    this.favoriteViewDetails_button.Enabled = true;
                    this.favoriteViewDetails_button.Visible = true;
                    this.favoritesRefresh_button.Enabled = true;
                    this.favoritesRefresh_button.Visible = true;
                    this.favoriteViewDetails_button.Text = "View Details: " + media.name;
                    if (media.poster_path is null)
                        this.favoriteImageLoading_label.Text = "No poster present..";
                    else
                    {
                        if (media.poster_image is null)
                        {
                            this.favoriteImageLoading_label.Text = "Loading poster..";
                            await media.retrieveMediaImages();
                            this.favoriteImageLoading_label.Text = string.Empty;
                        }
                    }
                    if (media == inSender.SelectedItems[0].Tag)
                        this.favoriteMediaPoster_pictureBox.Image = media.poster_image?.resizeImage(this.favoriteMediaPoster_pictureBox.Width, this.favoriteMediaPoster_pictureBox.Height);
                }
            }
            else 
            {
                this.favoritesMediaActions_groupBox.Text = "Actions";
                this.favoriteViewDetails_button.Enabled = false;
                this.favoriteViewDetails_button.Visible = false;
                this.favoriteViewDetails_button.Text = "View Details";
                this.favoriteMediaPoster_pictureBox.Image = null;
                this.favoriteImageLoading_label.Text = string.Empty;
            }
        }
        /// <summary>
        /// Updates the favorites lists.
        /// </summary>
        private async Task updateFavoritesAsync(ListView inSender)
        {
            // Written, 24.12.2019

            this.preUpdateLists(inSender);
            await this.refreshFavoritesAsync();
            MediaSearchResult[] mediaResults = inSender == this.favoriteMovies_listView ? this.viewAccount.favoritedMovies : (MediaSearchResult[])this.viewAccount.favoritedTvSeries;
            this.postUpdateLists(inSender, mediaResults);
            
        }
        /// <summary>
        /// Refreshes the favorites. Retreieves favorites.
        /// </summary>
        private async Task refreshFavoritesAsync()
        {
            // Written, 28.12.2019

            this.favoritesRefresh_button.Text = "Refreshing...";
            this.favoritesRefresh_button.Enabled = false;
            await this.viewAccount.retrieveFavoritedMediaAsync();
            this.favoritesRefresh_button.Text = "Refresh Favorites";
            this.favoritesRefresh_button.Enabled = true;
        }
        /// <summary>
        /// Updates the watchlist list.
        /// </summary>
        /// <returns></returns>
        private async Task updateWatchlistAsync(ListView inSender) 
        {
            // Written, 01.01.2020

            this.preUpdateLists(inSender);
            await this.refreshWatchlistAsync();
            MediaSearchResult[] mediaResults = inSender == this.watchlistMovies_listView ? this.viewAccount.watchlistMovies : (MediaSearchResult[])this.viewAccount.watchlistTvSeries;
            this.postUpdateLists(inSender, mediaResults);
        }
        /// <summary>
        /// Refreshes the watchlist list.
        /// </summary>
        private async Task refreshWatchlistAsync() 
        {
            // Written, 01.01.2020

            this.refreshWatchlist_button.Text = "Refreshing...";
            this.refreshWatchlist_button.Enabled = false;
            await this.viewAccount.retrieveWatchlistMediaAsync();
            this.refreshWatchlist_button.Text = "Refresh Watchlist";
            this.refreshWatchlist_button.Enabled = true;
        }
        /// <summary>
        /// Pre-Update list logic.
        /// </summary>
        /// <param name="inSender">the listview to update.</param>
        private void preUpdateLists(ListView inSender)
        {
            // Written, 02.01.2020

            inSender.Clear();
            inSender.Items.Add("Refreshing..");
        }
        /// <summary>
        /// Post-Update list logic.
        /// </summary>
        /// <param name="inSender">the listview to update.</param>
        /// <param name="inMediaResults">the media results to update the list with.</param>
        private void postUpdateLists(ListView inSender, MediaSearchResult[] inMediaResults)
        {
            // Written, 02.01.2020

            inSender.Clear();
            for (int i = 0; i < inMediaResults.Length; i++)
            {
                ListViewItem item = new ListViewItem(inMediaResults[i].name)
                {
                    Tag = inMediaResults[i]
                };
                inSender.Items.Add(item);
            }
            if (inSender.Items.Count == 0)
                inSender.Items.Add("No Results");
        }

        #endregion

        #region Event Handlers

        private async void viewAccount_Form_Load(object sender, EventArgs e)
        {
            // Written, 10.12.2019

            this.Text = this.Text.Insert(0, this.viewAccount.user.username + " - ");
            this.accountName_label.Text = this.viewAccount.user.name;
            await this.updateSearchMediaActionsAsync();
            await this.updateHomeMediaActionsAsync(null);
            await this.updateFavoritesAsync(this.favoriteMovies_listView);
            await this.updateFavoritesAsync(this.favoriteTvSeries_listView);
            await this.updateWatchlistAsync(this.watchlistMovies_listView);
            await this.updateWatchlistAsync(this.watchlistTvSeries_listView);
        }
        private async void search_button_Click(object sender, EventArgs e)
        {
            // Written, 10.12.2019

            this.searchInput_textBox.Enabled = false;
            this.search_button.Enabled = false;
            this.search_button.Text = "Searching..";
            this.searchResults_listView.Clear();
            await this.updateSearchMediaActionsAsync();
            if (!String.IsNullOrEmpty(this.searchInput_textBox.Text)) 
            {
                MultiSearchResult multiSearch = await MultiSearchResult.searchAsync(this.searchInput_textBox.Text, 1);
                for (int i = 0; i < ApplicationInfomation.NUMBER_OF_ITEMS_PER_PAGE; i++)
                {
                    ListViewItem item = null;
                    MediaSearchResult media = multiSearch.movies[i];
                    if (media == null)
                        media = multiSearch.tvSeries[i];
                    if (media != null)
                    {
                        string mediaTypeString = media is MovieSearchResult ? "MOVIE" : media is TvSearchResult ? "TV" : "NULL";
                        item = new ListViewItem(String.Format("\t[{2}] {0} ({1})", media.name, media.release_date, mediaTypeString))
                        {
                            Tag = media
                        };
                    }
                    if (item != null)
                    {
                        this.searchResults_listView.Items.Add(item);
                    }
                }
            }
            this.searchInput_textBox.Enabled = true;
            this.search_button.Enabled = true;
            this.search_button.Text = "Search";
        }
        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            // Written, 10.12.2019

            if (e.TabPage == this.home_tabPage)
            {
                this.Text = this.Text.Replace(String.Format(" - {0}", this.search_tabPage.Text), String.Empty);
            }
            else
            {                
                this.Text = this.Text.Insert(this.viewAccount.user.username.Length, String.Format(" - {0}", e.TabPage.Text));
            }
        }
        private async void searchResults_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Written, 10.12.2019

            await this.updateSearchMediaActionsAsync();
        }
        private async void favoriteMediaItem_button_Click(object sender, EventArgs e)
        {
            // Written, 17.12.2019

            this.searchFavoriteMediaItem_button.Enabled = false;
            this.searchFavoriteMediaItem_button.Text = "processing..";
            MediaSearchResult selectedResult = this.searchResults_listView.SelectedItems[0].Tag as MediaSearchResult;
            MediaTypeEnum mediaType = selectedResult is TvSearchResult ? MediaTypeEnum.tv : MediaTypeEnum.movie;            
            List<IdResultObject> favoritedMedia = new List<IdResultObject>();
            favoritedMedia.AddRange(this.viewAccount.favoritedMovies);
            favoritedMedia.AddRange(this.viewAccount.favoritedTvSeries);
            bool favorited = favoritedMedia.Any(_fm => _fm.id == selectedResult.id);
            await this.viewAccount.user.favoriteMediaItem(mediaType, selectedResult.id, !favorited);
            switch (mediaType) 
            {
                case MediaTypeEnum.movie:
                    await this.viewAccount.retrieveFavoriteMoviesAsync();
                    break;
                case MediaTypeEnum.tv:
                    await this.viewAccount.retrieveFavoriteTvSeriesAsync();
                    break;
            }
            this.searchFavoriteMediaItem_button.Text = "updating..";
            await this.updateFavoritesAsync(mediaType == MediaTypeEnum.movie ? this.favoriteMovies_listView : this.favoriteTvSeries_listView);
            await this.updateSearchMediaActionsAsync();
            this.searchFavoriteMediaItem_button.Enabled = true;
        }
        private void viewDetails_button_Click(object sender, EventArgs e)
        {
            // Written, 31.12.2019

            MediaSearchResult mediaToView = null;

            if (sender == this.searchViewDetails_button)
                mediaToView = this.searchResults_listView.SelectedItems[0].Tag as MediaSearchResult;
            else
                if (sender == this.favoriteViewDetails_button)
                    mediaToView = this.selectedFavoriteMedia;
            ViewMediaDialog viewMediaDialog = new ViewMediaDialog(mediaToView);
            viewMediaDialog.ShowDialog();
        }
        private async void favorites_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Written, 24.12.2019
            
            await this.updateHomeMediaActionsAsync(sender as ListView);
        }
        private  async void favoritesRefresh_button_Click(object sender, EventArgs e)
        {
            // Written, 24.12.2019

            await this.updateFavoritesAsync(this.favoriteMovies_listView);
            await this.updateFavoritesAsync(this.favoriteTvSeries_listView);
        }
        private async void refreshWatchlist_button_Click(object sender, EventArgs e)
        {
            // Written, 01.01.2020
            
            await this.updateWatchlistAsync(this.watchlistMovies_listView);
            await this.updateWatchlistAsync(this.watchlistTvSeries_listView);
        }
        private async void searchWatchlistMediaItem_button_Click(object sender, EventArgs e)
        {
            // Written, 01.01.2020

            this.searchWatchlistMediaItem_button.Enabled = false;
            this.searchWatchlistMediaItem_button.Text = "processing..";
            MediaSearchResult selectedResult = this.searchResults_listView.SelectedItems[0].Tag as MediaSearchResult;
            MediaTypeEnum mediaType = selectedResult is TvSearchResult ? MediaTypeEnum.tv : MediaTypeEnum.movie;
            List<IdResultObject> watchlistedMedia = new List<IdResultObject>();
            watchlistedMedia.AddRange(this.viewAccount.watchlistMovies);
            watchlistedMedia.AddRange(this.viewAccount.watchlistTvSeries);
            bool watchlisted = watchlistedMedia.Any(_fm => _fm.id == selectedResult.id);
            await this.viewAccount.user.watchlistMediaItem(mediaType, selectedResult.id, !watchlisted);
            switch (mediaType)
            {
                case MediaTypeEnum.movie:
                    await this.viewAccount.retrieveWatchlistMoviesAsync();
                    break;
                case MediaTypeEnum.tv:
                    await this.viewAccount.retrieveWatchlistTvSeriesAsync();
                    break;
            }
            this.searchWatchlistMediaItem_button.Text = "updating..";
            await this.updateWatchlistAsync(mediaType == MediaTypeEnum.movie ? this.watchlistMovies_listView : this.watchlistTvSeries_listView);
            await this.updateSearchMediaActionsAsync();
            this.searchWatchlistMediaItem_button.Enabled = true;
        }

        #endregion
    }
}
