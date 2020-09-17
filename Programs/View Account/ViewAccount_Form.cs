using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TommoJProductions;
using TommoJProductions.TMDB.Account;
using TommoJProductions.TMDB.Auth;
using TommoJProductions.TMDB.Media;
using TommoJProductions.TMDB.Search;
using TommoJProductions.TMDB.Discover;
using TommoJProductions.YTS;
using YTS.Models;

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
        } = new LoadingDialog("tmdb View Account") { loadingText = "Loading..", };
        /// <summary>
        /// Represents the home (favorite or watchlist) currently selected favorite media.
        /// </summary>
        private MediaSearchResult home_selectedMedia
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the search currently selected media.
        /// </summary>
        private MediaSearchResult search_selectedMedia
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the discover parameters.
        /// </summary>
        private DiscoverParameters discoverParameters
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

            // Written, 14.09.2020
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer2.SplitterDistance = 176;
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
            Exception exception = null;
            LoginDialog loginDialog = new LoginDialog();
            if (loginDialog.ShowDialog() == DialogResult.OK)
            {
                loadingDialog.Show(this);
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
                        session = await Session.createSessionWithLoginAsync(loginDialog.username, loginDialog.password, token.request_token);
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
                this.search_selectedMedia = media;
                this.actions_groupBox.Text = "Actions: " + media.name;
                this.mediaPoster_pictureBox.Image = media.poster_image;
                this.search_viewDetails_button.Enabled = true;
                this.search_viewDetails_button.Visible = true;
                this.favoriteMediaItem_button.Enabled = true;
                this.favoriteMediaItem_button.Visible = true;
                this.watchMediaItem_button.Enabled = true;
                this.watchMediaItem_button.Visible = true;
                if (media is MovieSearchResult)
                {
                    this.yts_button.Enabled = true;
                    this.yts_button.Visible = true;
                    this.yts_button.Text = "Search YTS: " + media.name;
                }
                else
                {
                    this.yts_button.Enabled = false;
                    this.yts_button.Visible = false;
                    this.yts_button.Text = "yts_button";
                }
                List<IdResultObject> favoritedMedia = new List<IdResultObject>();
                favoritedMedia.AddRange(this.viewAccount.favoritedMovies);
                favoritedMedia.AddRange(this.viewAccount.favoritedTvSeries);
                bool favorited = favoritedMedia.Any(_fm => _fm.id == media.id);
                this.favoriteMediaItem_button.Text = !favorited ? "favorite" : "unfavorite";
                List<IdResultObject> watchlistMedia = new List<IdResultObject>();
                watchlistMedia.AddRange(this.viewAccount.watchlistMovies);
                watchlistMedia.AddRange(this.viewAccount.watchlistTvSeries);
                bool watchlisted = watchlistMedia.Any(_wm => _wm.id == media.id);
                this.watchMediaItem_button.Text = !watchlisted ? "watch" : "unwatch";
                this.search_viewDetails_button.Text = "View Details: " + media.name;
                if (media.poster_path is null)
                    this.imageLoading_label.Text = "No poster present..";
                else
                {
                    if (media.poster_image is null)
                    {
                        this.imageLoading_label.Text = "Loading poster..";
                        await media.retrieveMediaImages();
                        this.imageLoading_label.Text = string.Empty;
                    }
                }
                if (media == this.searchResults_listView.SelectedItems[0].Tag)
                    this.mediaPoster_pictureBox.Image = media.poster_image?.resizeImage(this.mediaPoster_pictureBox.Width, this.mediaPoster_pictureBox.Height);
            }
            else
            {
                this.actions_groupBox.Text = "Actions";
                this.search_viewDetails_button.Enabled = false;
                this.search_viewDetails_button.Visible = false;
                this.favoriteMediaItem_button.Enabled = false;
                this.favoriteMediaItem_button.Visible = false;
                this.watchMediaItem_button.Enabled = false;
                this.watchMediaItem_button.Visible = false;
                this.yts_button.Enabled = false;
                this.yts_button.Visible = false;
                this.search_viewDetails_button.Text = "View Details";
                this.mediaPoster_pictureBox.Image = null;
                this.imageLoading_label.Text = string.Empty;
            }
        }
        /// <summary>
        /// updates the favorite media actions.
        /// </summary>
        /// <param name="inSender">Listview sender.</param>
        /// <param name="inMediaType">The media type that is to be updated.</param>
        private async Task updateFavoriteMediaActionsAsync(ListView inSender)
        {
            // Written, 24.12.2019

            if (inSender?.SelectedItems.Count == 1)
            {
                MediaSearchResult media = inSender.SelectedItems[0].Tag as MediaSearchResult;
                if (media != null)
                {
                    this.home_selectedMedia = media;
                    this.actions_groupBox.Text = "Actions: " + media.name;
                    this.mediaPoster_pictureBox.Image = media.poster_image;
                    this.home_viewDetails_button.Enabled = true;
                    this.home_viewDetails_button.Visible = true;
                    this.favoritesRefresh_button.Enabled = true;
                    this.favoritesRefresh_button.Visible = true;
                    this.watchlistRefresh_button.Enabled = true;
                    this.watchlistRefresh_button.Visible = true;
                    if (media is MovieSearchResult)
                    {
                        this.yts_button.Enabled = true;
                        this.yts_button.Visible = true;
                        this.yts_button.Text = "Search YTS: " + media.name;
                    }
                    else
                    {
                        this.yts_button.Enabled = false;
                        this.yts_button.Visible = false;
                        this.yts_button.Text = "yts_button";
                    }
                    this.home_viewDetails_button.Text = "View Details: " + media.name;
                    if (media.poster_path is null)
                        this.imageLoading_label.Text = "No poster present..";
                    else
                    {
                        if (media.poster_image is null)
                        {
                            this.imageLoading_label.Text = "Loading poster..";
                            await media.retrieveMediaImages();
                            this.imageLoading_label.Text = string.Empty;
                        }
                    }
                    if (media == inSender.SelectedItems[0].Tag)
                        this.mediaPoster_pictureBox.Image = media.poster_image?.resizeImage(this.mediaPoster_pictureBox.Width, this.mediaPoster_pictureBox.Height);
                }
            }
            else
            {
                this.actions_groupBox.Text = "Actions";
                this.home_viewDetails_button.Enabled = false;
                this.home_viewDetails_button.Visible = false;
                this.favoritesRefresh_button.Enabled = false;
                this.favoritesRefresh_button.Visible = false;
                this.watchlistRefresh_button.Enabled = false;
                this.watchlistRefresh_button.Visible = false;
                this.yts_button.Enabled = false;
                this.yts_button.Visible = false;
                this.home_viewDetails_button.Text = "View Details";
                this.mediaPoster_pictureBox.Image = null;
                this.imageLoading_label.Text = string.Empty;
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

            this.watchlistRefresh_button.Text = "Refreshing...";
            this.watchlistRefresh_button.Enabled = false;
            await this.viewAccount.retrieveWatchlistMediaAsync();
            this.watchlistRefresh_button.Text = "Refresh Watchlist";
            this.watchlistRefresh_button.Enabled = true;
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
        /// <summary>
        /// Initialzies discover.
        /// </summary>
        private void initDiscover()
        {
            // Written, 09.01.2020

            this.discoverParameters = new DiscoverParameters();
            this.discover_sortByMembers_comboBox.Items.AddRange(Enum.GetNames(typeof(MediaSortByMembersEnum)));
            this.discover_sortByAscDesc_comboBox.Items.AddRange(Enum.GetNames(typeof(MediaSortByAscDescEnum)));
            this.discover_sortByAscDesc_comboBox.SelectedItem = this.discoverParameters.sortByAscDesc.ToString();
            this.discover_sortByMembers_comboBox.SelectedItem = this.discoverParameters.sortByMembers.ToString();
        }
        /// <summary>
        /// Updates poster based on what tabpage the user is currently on.
        /// </summary>
        private void updatePosterImageDisplay()
        {
            // Written, 31,01.2020

            this.mediaPoster_pictureBox.Image = this.getMediaToView()?.poster_image?.resizeImage(this.mediaPoster_pictureBox.Width, this.mediaPoster_pictureBox.Height);            
        }
        /// <summary>
        /// Gets the currently displayed media on either, <see cref="home_tabPage"/> or <see cref="search_tabPage"/> tabs.
        /// </summary>
        private MediaSearchResult getMediaToView() 
        {
            // Written, 31.01.2020

            if (this.tabControl.SelectedTab == home_tabPage)
                return this.home_selectedMedia;
            else if (this.tabControl.SelectedTab == search_tabPage)
                return this.search_selectedMedia;
            return null;
        }
        /// <summary>
        /// updates the actions buttons.
        /// </summary>
        private async Task updateActionButtons()
        {
            if (this.tabControl.SelectedTab == this.home_tabPage)
            {
                //view details
                this.search_viewDetails_button.Visible = false;
                this.search_viewDetails_button.Enabled = false;
                //other
                this.yts_button.Visible = true;
                this.watchMediaItem_button.Visible = false;
                this.favoriteMediaItem_button.Visible = false;
                //update all actions related to favourite.
                await this.updateFavoriteMediaActionsAsync(null);
            }
            else if (this.tabControl.SelectedTab == this.search_tabPage)
            {
                //view details
                this.home_viewDetails_button.Visible = false;
                this.home_viewDetails_button.Enabled = false;
                //other
                this.watchlistRefresh_button.Visible = false;
                this.favoritesRefresh_button.Visible = false;
                //update all actions related to search.
                await this.updateSearchMediaActionsAsync();
            }
            else
            {
                this.home_viewDetails_button.Visible = false;
                this.search_viewDetails_button.Visible = false;
                this.home_viewDetails_button.Enabled = false;
                this.search_viewDetails_button.Enabled = false;
                //other
                this.yts_button.Visible = false;
                this.watchlistRefresh_button.Visible = false;
                this.watchMediaItem_button.Visible = false;
                this.favoritesRefresh_button.Visible = false;
                this.favoriteMediaItem_button.Visible = false;
            }

        }

        #endregion

        #region Event Handlers

        private async void viewAccount_Form_Load(object sender, EventArgs e)
        {
            // Written, 10.12.2019

            this.tabControl_Selected(this.tabControl.SelectedTab.Text, null);
            this.accountName_label.Text = this.viewAccount.user.name;
            await this.updateSearchMediaActionsAsync();
            await this.updateFavoriteMediaActionsAsync(null);
            await this.updateFavoritesAsync(this.favoriteMovies_listView);
            await this.updateFavoritesAsync(this.favoriteTvSeries_listView);
            await this.updateWatchlistAsync(this.watchlistMovies_listView);
            await this.updateWatchlistAsync(this.watchlistTvSeries_listView);
            this.initDiscover();
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
                    MediaSearchResult media = multiSearch.movie_results[i];
                    if (media == null)
                        media = multiSearch.tv_results[i];
                    if (media != null)
                    {
                        string mediaTypeString = media is MovieSearchResult ? "MOVIE" : media is TvSearchResult ? "TV" : "NULL";
                        item = new ListViewItem(String.Format("\t[{2}] {0} ({1})", media.name, media.release_date, mediaTypeString))
                        {
                            Tag = media
                        };
                        this.searchResults_listView.Items.Add(item);
                    }
                }
            }
            this.searchInput_textBox.Enabled = true;
            this.search_button.Enabled = true;
            this.search_button.Text = "Search";
        }
        private async void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            // Written, 10.12.2019

            string textChange = e?.TabPage.Text ?? sender as string;
            this.Text = String.Format("{1} - View Account | {0}", textChange, this.viewAccount.user.username);
            this.main_groupBox.Text = textChange;
            this.updatePosterImageDisplay();
            await this.updateActionButtons();
        }
        private async void searchResults_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Written, 10.12.2019

            await this.updateSearchMediaActionsAsync();
        }
        private async void favoriteMediaItem_button_Click(object sender, EventArgs e)
        {
            // Written, 17.12.2019

            this.favoriteMediaItem_button.Enabled = false;
            this.favoriteMediaItem_button.Text = "processing..";
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
            this.favoriteMediaItem_button.Text = "updating..";
            await this.updateFavoritesAsync(mediaType == MediaTypeEnum.movie ? this.favoriteMovies_listView : this.favoriteTvSeries_listView);
            await this.updateSearchMediaActionsAsync();
            this.favoriteMediaItem_button.Enabled = true;
        }
        private async void viewDetails_button_Click(object sender, EventArgs e)
        {
            // Written, 31.12.2019

            MediaSearchResult mediaToView = this.getMediaToView();
            ViewMediaDialog viewMediaDialog = new ViewMediaDialog(mediaToView, this.viewAccount);
            viewMediaDialog.ShowDialog();

            if (this.tabControl.SelectedTab == this.search_tabPage)
                await this.updateSearchMediaActionsAsync();
            if (mediaToView is TvSearchResult)
            {
                if (viewMediaDialog.watchListChanged)
                    await this.updateWatchlistAsync(this.watchlistTvSeries_listView);
                if (viewMediaDialog.favoriteChanged)
                    await this.updateFavoritesAsync(this.favoriteTvSeries_listView);
            }
            else if (mediaToView is MovieSearchResult)
            {
                if (viewMediaDialog.watchListChanged)
                    await this.updateWatchlistAsync(this.watchlistMovies_listView);
                if (viewMediaDialog.favoriteChanged)
                    await this.updateFavoritesAsync(this.favoriteMovies_listView);
            }
        }
        private async void favorites_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Written, 24.12.2019
            
            await this.updateFavoriteMediaActionsAsync(sender as ListView);
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
        private async void watchMediaItem_button_Click(object sender, EventArgs e)
        {
            // Written, 01.01.2020

            this.watchMediaItem_button.Enabled = false;
            this.watchMediaItem_button.Text = "processing..";
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
            this.watchMediaItem_button.Text = "updating..";
            await this.updateWatchlistAsync(mediaType == MediaTypeEnum.movie ? this.watchlistMovies_listView : this.watchlistTvSeries_listView);
            await this.updateSearchMediaActionsAsync();
            this.watchMediaItem_button.Enabled = true;
        }
        private void main_splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            // Written, 21.01.2020

            this.mediaPoster_pictureBox.Image = this.getMediaToView()?.poster_image.resizeImage(this.mediaPoster_pictureBox.Width, this.mediaPoster_pictureBox.Height);
        }

        #endregion

        private async void yts_button_Click(object sender, EventArgs e)
        {
            // Written, 14.09.2020

            YTSManager manager = new YTSManager();
            MovieInfo info = await manager.getMovieDetailsAsync(this.getMediaToView().id);
            MessageBox.Show(String.Format("Title:{0}\nYear{1}", info.Title, info.Year), "YTS Movie response");
        }
    }
}
