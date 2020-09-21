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
using TommoJProductions.YTS.Structure;
using TommoJProductions.YTS.EndPointParameters;

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
        /// Represents if the form is resizing.
        /// </summary>
        private bool formResizing
        {
            get;
            set;
        } = false;
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
        /// Represents the yts search currently selected media.
        /// </summary>
        private MediaSearchResult yts_selectedMedia
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

        }

        #endregion

        #region Methods

        /// <summary>
        /// Login to tmdb account function and logic. Returns bool whether the login was successful or not.
        /// </summary>
        internal async Task<bool> loginTMDbAsync()
        {
            // Written, 10.12.2019

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
                    this.yts_button.Text = "Search YTS";
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
                await this.updateMediaPosterAsync(this.searchResults_listView, media);
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
        private async Task updateHomeMediaActionsAsync(ListView inSender, MediaSearchResult inMedia = null)
        {
            // Written, 24.12.2019

            if (inSender?.SelectedItems.Count == 1 || inMedia != null)
            {
                MediaSearchResult media = (inSender?.SelectedItems[0].Tag as MediaSearchResult) ?? inMedia;
                if (media != null)
                {
                    this.home_selectedMedia = media;
                    this.actions_groupBox.Text = "Actions: " + media.name;
                    this.mediaPoster_pictureBox.Image = media.poster_image;
                    this.home_viewDetails_button.Enabled = true;
                    this.home_viewDetails_button.Visible = true;
                    this.movieRefresh_button.Enabled = true;
                    this.movieRefresh_button.Visible = true;
                    this.tvRefresh_button.Enabled = true;
                    this.tvRefresh_button.Visible = true;
                    if (media is MovieSearchResult)
                    {
                        this.yts_button.Enabled = true;
                        this.yts_button.Visible = true;
                        this.yts_button.Text = "Search YTS";
                    }
                    else
                    {
                        this.yts_button.Enabled = false;
                        this.yts_button.Visible = false;
                        this.yts_button.Text = "yts_button";
                    }
                    this.home_viewDetails_button.Text = "View Details: " + media.name;
                    await this.updateMediaPosterAsync(inSender, media);
                }
            }
            else
            {
                this.actions_groupBox.Text = "Actions";
                this.home_viewDetails_button.Enabled = false;
                this.home_viewDetails_button.Visible = false;
                this.movieRefresh_button.Enabled = false;
                this.movieRefresh_button.Visible = false;
                this.tvRefresh_button.Enabled = false;
                this.tvRefresh_button.Visible = false;
                this.yts_button.Enabled = false;
                this.yts_button.Visible = false;
                this.home_viewDetails_button.Text = "View Details";
                this.mediaPoster_pictureBox.Image = null;
                this.imageLoading_label.Text = string.Empty;
            }
        }
        /// <summary>
        /// Pre-Update list logic.
        /// </summary>
        /// <param name="inSender">the listview to update.</param>
        private void preUpdateLists(ListView inSender)
        {
            // Written, 02.01.2020

            inSender.Items.Clear();
            inSender.View = View.List;
            inSender.Items.Add("Refreshing..");
        }
        /// <summary>
        /// Post-Update list logic.
        /// </summary>
        /// <param name="inSender">the listview to update.</param>
        /// <param name="inMediaResults">the media results to update the list with.</param>
        private void postUpdateLists(ListView inSender, ListViewItem[] inItems)
        {
            // Written, 02.01.2020

            inSender.Items.Clear();
            inSender.Items.AddRange(inItems);
            if (inSender.Items.Count == 0)
                inSender.Items.Add("No Results");
            else
                inSender.View = View.Details;
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
        /// <param name="inIsResizeLoop">acts like a force update. true if called from inside the resize loop.</param>
        private void updatePosterImageDisplay(bool inIsResizeLoop = false)
        {
            // Written, 31,01.2020

            if (!this.formResizing || inIsResizeLoop)
                this.mediaPoster_pictureBox.Image = this.getMediaToView()?.poster_image?.resizeImage(this.mediaPoster_pictureBox.Width, this.mediaPoster_pictureBox.Height);
        }
        /// <summary>
        /// Gets the currently displayed media on either, <see cref="home_tabPage"/> or <see cref="search_tabPage"/> tabs.
        /// </summary>
        private MediaSearchResult getMediaToView()
        {
            // Written, 31.01.2020

            if (this.tabControl.SelectedTab == this.home_tabPage)
                return this.home_selectedMedia;
            else if (this.tabControl.SelectedTab == this.search_tabPage)
                return this.search_selectedMedia;
            else if (this.tabControl.SelectedTab == this.yts_tabPage)
                return this.yts_selectedMedia;
            return null;
        }
        /// <summary>
        /// updates the actions buttons.
        /// </summary>
        private async Task updateActionButtonsAsync()
        {
            // Written, 18.09.2020

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
                await this.updateHomeMediaActionsAsync(null, this.home_selectedMedia);
            }
            else if (this.tabControl.SelectedTab == this.search_tabPage)
            {
                //view details
                this.home_viewDetails_button.Visible = false;
                this.home_viewDetails_button.Enabled = false;
                //other
                this.tvRefresh_button.Visible = false;
                this.movieRefresh_button.Visible = false;
                //update all actions related to search.
                await this.updateSearchMediaActionsAsync();
            }
            else if (this.tabControl.SelectedTab == this.yts_tabPage) 
            {
                //view details
                this.home_viewDetails_button.Visible = false;
                this.home_viewDetails_button.Enabled = false;
                this.search_viewDetails_button.Visible = false;
                this.search_viewDetails_button.Enabled = false;
                //other
                this.yts_button.Visible = true;
                this.tvRefresh_button.Visible = false;
                this.watchMediaItem_button.Visible = false;
                this.movieRefresh_button.Visible = false;
                this.favoriteMediaItem_button.Visible = false;
                await this.updateYtsMediaActionsAsync();
            }
            else
            {
                this.home_viewDetails_button.Visible = false;
                this.search_viewDetails_button.Visible = false;
                this.home_viewDetails_button.Enabled = false;
                this.search_viewDetails_button.Enabled = false;
                //other
                this.yts_button.Visible = false;
                this.tvRefresh_button.Visible = false;
                this.watchMediaItem_button.Visible = false;
                this.movieRefresh_button.Visible = false;
                this.favoriteMediaItem_button.Visible = false;
            }

        }
        /// <summary>
        /// Updates/retrieves both movie watchlist and favorited lists and displays the new results in the home movie listview.
        /// </summary>
        private async Task updateHomeMoviesAsync()
        {
            // Written, 18.09.2020

            this.preUpdateLists(this.homeMovies_listView);
            await this.refreshHomeMoviesAsync();
            ListViewItem[] Items = new ListViewItem[this.viewAccount.favoritedMovies.Length + this.viewAccount.watchlistMovies.Length];
            string[] subItems;
            MovieSearchResult msr;
            for (int i = 0; i < this.viewAccount.favoritedMovies.Length; i++)
            {
                msr = this.viewAccount.favoritedMovies[i];
                subItems = new string[]
                {
                    msr.name,
                    msr.release_date,
                };
                Items[i] = new ListViewItem(subItems, this.homeMovies_listView.Groups[0]) { Tag = msr };
            }
            for (int i = 0; i < this.viewAccount.watchlistMovies.Length; i++)
            {
                msr = this.viewAccount.watchlistMovies[i];
                subItems = new string[]
                {
                    msr.name,
                    msr.release_date,
                };
                Items[this.viewAccount.favoritedMovies.Length + i] = new ListViewItem(subItems, this.homeMovies_listView.Groups[1]) { Tag = msr };
            }
            this.postUpdateLists(this.homeMovies_listView, Items);
        }
        /// <summary>
        /// Retrieves both movie watchlist and favorited lists from tmdb, thus updating. in addition updates movie refresh button text, and enablity.
        /// </summary>
        private async Task refreshHomeMoviesAsync()
        {
            // Written, 18.09.2020

            this.movieRefresh_button.Text = "Refreshing...";
            this.movieRefresh_button.Enabled = false;
            await this.viewAccount.retrieveFavoriteMoviesAsync();
            await this.viewAccount.retrieveWatchlistMoviesAsync();
            this.movieRefresh_button.Text = "Refresh movies";
            this.movieRefresh_button.Enabled = true;
        }
        /// <summary>
        /// Updates/retrieves both tv watchlist and favorited lists and displays the new results in the home tv listview.
        /// </summary>
        private async Task updateHomeTvSeriesAsync()
        {
            // Written, 18.09.2020

            this.preUpdateLists(this.homeTvSeries_listView);
            await this.refreshHomeTvAsync();
            ListViewItem[] Items = new ListViewItem[this.viewAccount.favoritedTvSeries.Length + this.viewAccount.watchlistTvSeries.Length];
            string[] subItems;
            TvSearchResult tsr;
            for (int i = 0; i < this.viewAccount.favoritedTvSeries.Length; i++)
            {
                tsr = this.viewAccount.favoritedTvSeries[i];
                subItems = new string[]
                {
                    tsr.name,
                    tsr.release_date,
                };
                Items[i] = new ListViewItem(subItems, this.homeTvSeries_listView.Groups[0]) { Tag = tsr };
            }
            for (int i = 0; i < this.viewAccount.watchlistTvSeries.Length; i++)
            {
                tsr = this.viewAccount.watchlistTvSeries[i];
                subItems = new string[]
                {
                    tsr.name,
                    tsr.release_date,
                };
                Items[this.viewAccount.favoritedTvSeries.Length + i] = new ListViewItem(subItems, this.homeTvSeries_listView.Groups[1]) { Tag = tsr };
            }
            this.postUpdateLists(this.homeTvSeries_listView, Items);
        }
        /// <summary>
        /// Retrieves both tv watchlist and favorited lists from tmdb, thus updating. in addition updates tv refresh button text, and enablity.
        /// </summary>
        private async Task refreshHomeTvAsync()
        {
            // Written, 18.09.2020

            this.tvRefresh_button.Text = "Refreshing...";
            this.tvRefresh_button.Enabled = false;
            await this.viewAccount.retrieveFavoriteTvSeriesAsync();
            await this.viewAccount.retrieveWatchlistTvSeriesAsync();
            this.tvRefresh_button.Text = "Refresh tv series";
            this.tvRefresh_button.Enabled = true;
        }
        /// <summary>
        /// Converts control input to object <see cref="MovieListEndPointParameters"/>.
        /// </summary>
        private MovieListEndPointParameters ytsControlsToParameters()
        {
            // Written, 21.09.2020

            return new MovieListEndPointParameters()
            {
                genre = this.ytsGenre_textBox.Text.ToLower(),
                limit = Decimal.ToInt32(this.ytsLimit_numericUpDown.Value),
                minRating = Decimal.ToInt32(this.ytsMinRating_numericUpDown.Value),
                orderBy = (OrderByEndPointParameterEnum)Enum.Parse(typeof(OrderByEndPointParameterEnum), this.ytsOrderBy_comboBox.SelectedItem.ToString()),
                sortBy = (SortByEndPointParameterEnum)Enum.Parse(typeof(SortByEndPointParameterEnum), this.ytsSortBy_comboBox.SelectedItem.ToString()),
                page = Decimal.ToInt32(this.ytsPage_numericUpDown.Value),
                quality = (QualityEndPointParameterEnum)Enum.Parse(typeof(QualityEndPointParameterEnum), this.ytsQuality_comboBox.SelectedItem.ToString()),
                query = this.ytsQuery_textBox.Text

            };
        }
        /// <summary>
        /// Updates/Retrieves a yts response and displays the data.
        /// </summary>
        private async Task updateYtsMoviesAsync()
        {
            // Written, 21.09.2020

            this.ytsSearchParameters_groupBox.Enabled = false;
            this.preUpdateLists(this.ytsMovieResults_listView);
            this.ytsSearchResults_groupBox.Text = "Search results";
            Response<MovieListInfo> response = await YTSManager.retrieveMovieListAsync(this.ytsControlsToParameters());
            ListViewItem[] items = new ListViewItem[response.data.movies?.Length ?? 0];
            if (response.data.movies != null)
            {
                this.ytsSearchResults_groupBox.Text = String.Format("Search results {0}/{1} | ({2} pages)", response.data.movies.Length * response.data.page_number, response.data.movie_count, response.data.movie_count / response.data.limit);
                for (int i = 0; i < response.data.movies.Length; i++)
                {
                    MovieInfo info = response.data.movies[i];
                    string[] subItems = new string[]
                    {
                    info.title,
                    info.description_full,
                    info.year.ToString(),
                    info.runtime + "mins",
                    };
                    items[i] = new ListViewItem(subItems) { Tag = info.toTmdbMovie() };
                }
            }
            this.postUpdateLists(this.ytsMovieResults_listView, items);
            this.ytsSearchParameters_groupBox.Enabled = true;
        }
        /// <summary>
        /// Initializes yts tab.
        /// </summary>
        private void initYts()
        {
            // Written, 21.09.2020

            this.ytsQuality_comboBox.Items.AddRange(Enum.GetNames(typeof(QualityEndPointParameterEnum)));
            this.ytsQuality_comboBox.SelectedIndex = 0;
            this.ytsSortBy_comboBox.Items.AddRange(Enum.GetNames(typeof(SortByEndPointParameterEnum)));
            this.ytsSortBy_comboBox.SelectedIndex = 0;
            this.ytsOrderBy_comboBox.Items.AddRange(Enum.GetNames(typeof(OrderByEndPointParameterEnum)));
            this.ytsOrderBy_comboBox.SelectedIndex = 0;
        }
        private async Task updateYtsMediaActionsAsync()
        {
            // Written, 21.09.2020

            if (this.ytsMovieResults_listView.SelectedItems.Count == 1)
            {
                MovieSearchResult media = this.ytsMovieResults_listView.SelectedItems[0].Tag as MovieSearchResult;
                if (media != null)
                {
                    this.yts_selectedMedia = media;
                    this.actions_groupBox.Text = "Actions: " + media.name;
                    this.mediaPoster_pictureBox.Image = media.poster_image;
                    this.yts_button.Enabled = true;
                    this.yts_button.Text = "Search YTS";
                    await this.updateMediaPosterAsync(this.ytsMovieResults_listView, media, YTSManager.YTS_ADDRESS);                    
                }
            }                
            else
            {
                this.actions_groupBox.Text = "Actions";
                this.yts_button.Enabled = false; 
                this.mediaPoster_pictureBox.Image = null;
            }
        }
        private async Task updateMediaPosterAsync(ListView inSender, MediaSearchResult inMedia, string inOverrideImageAddressPrefix = null) 
        {
            // Written, 21.09.2020

            if (inMedia?.poster_path is null)
                this.imageLoading_label.Text = "No poster present..";
            else
            {
                if (inMedia.poster_image is null)
                {
                    this.imageLoading_label.Text = "Loading poster..";
                    try
                    {
                        await inMedia.retrieveMediaImages(inOverrideImageAddressPrefix);                        
                    }
                    catch
                    {
                        this.imageLoading_label.Text = "Error loading poster";
                        return;
                    }
                }
            }
            //if (inMedia == (inSender?.SelectedItems[0].Tag))
            this.updatePosterImageDisplay();
            this.imageLoading_label.Text = string.Empty;
        }

        #endregion

        #region Event Handlers

        private async void viewAccount_Form_Load(object sender, EventArgs e)
        {
            // Written, 10.12.2019

            this.tabControl_Selected(this.tabControl.SelectedTab.Text, null);
            this.accountName_label.Text = this.viewAccount.user.name;
            await this.updateSearchMediaActionsAsync();
            await this.updateHomeMoviesAsync();
            await this.updateHomeTvSeriesAsync();
            //this.initDiscover();
            this.initYts();
        }
        private async void search_button_Click(object sender, EventArgs e)
        {
            // Written, 10.12.2019

            this.searchInput_textBox.Enabled = false;
            this.search_button.Enabled = false;
            this.search_button.Text = "Searching..";
            if (!String.IsNullOrEmpty(this.searchInput_textBox.Text))
            {
                this.preUpdateLists(this.searchResults_listView);
                await this.updateSearchMediaActionsAsync();
                MultiSearchResult multiSearch = await MultiSearchResult.searchAsync(this.searchInput_textBox.Text, 1);
                List<ListViewItem> items = new List<ListViewItem>();
                for (int i = 0; i < ApplicationInfomation.NUMBER_OF_ITEMS_PER_PAGE; i++)
                {
                    MediaSearchResult media = multiSearch.movie_results[i];
                    if (media == null)
                        media = multiSearch.tv_results[i];
                    if (media != null)
                    {
                        string mediaTypeString = media is MovieSearchResult ? "Movie" : media is TvSearchResult ? "Tv" : "Null";
                        string[] subItems = new string[] 
                        {
                            media.name,
                            media.overview,
                            media.release_date,
                            media.vote_average.ToString(),
                            mediaTypeString
                        };                        
                        items.Add(new ListViewItem(subItems) { Tag = media });
                    }
                }
                this.postUpdateLists(this.searchResults_listView, items.ToArray());
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
            await this.updateActionButtonsAsync();
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
            if (mediaType == MediaTypeEnum.movie)
                await this.updateHomeMoviesAsync();
            else
                await this.updateHomeTvSeriesAsync();
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
                await this.updateHomeTvSeriesAsync();
            }
            else if (mediaToView is MovieSearchResult)
            {
                await this.updateHomeMoviesAsync();
            }
        }
        private async void home_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Written, 24.12.2019
            
            await this.updateHomeMediaActionsAsync(sender as ListView);
        }
        private  async void moviesRefresh_button_Click(object sender, EventArgs e)
        {
            // Written, 18.09.2020

            await this.updateHomeMoviesAsync();
        }
        private async void refreshWatchlist_button_Click(object sender, EventArgs e)
        {
            // Written, 18.09.2020

            await this.updateHomeTvSeriesAsync();
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
            if (mediaType == MediaTypeEnum.movie)
                await this.updateHomeMoviesAsync();
            else
                await this.updateHomeTvSeriesAsync();
            await this.updateSearchMediaActionsAsync();
            this.watchMediaItem_button.Enabled = true;
        }
        private void main_splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            // Written, 21.09.2020

            this.updatePosterImageDisplay();
        }        
        private async void yts_button_Click(object sender, EventArgs e)
        {
            // Written, 17.09.2020

            this.yts_button.Enabled = false;
            this.yts_button.Text = "Searching YTS...";
            Response<MovieListInfo> response = await YTSManager.searchMovieListAsync(this.getMediaToView().name);
            this.yts_button.Text = "Search YTS";
            using (YTSMovieListResponseDialog dialog = new YTSMovieListResponseDialog(response))
                dialog.ShowDialog();
            this.yts_button.Enabled = true;
        }        
        private void viewAccount_Form_ResizeBegin(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            this.formResizing = true;
        }
        private void viewAccount_Form_ResizeEnd(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            this.formResizing = false;
        }
        private void viewAccount_Form_Resize(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            this.updatePosterImageDisplay(true);
        }

        #endregion

        private async void ytsSearch_button_Click(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            await this.updateYtsMoviesAsync();
        }

        private async void ytsNextPage_button_Click(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            this.ytsPage_numericUpDown.Value++;
            await this.updateYtsMoviesAsync();
        }

        private async void ytsPreviousPage_button_Click(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            this.ytsPage_numericUpDown.Value--;
            await this.updateYtsMoviesAsync();
        }

        private async void ytsMovieResults_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            await this.updateYtsMediaActionsAsync();
        }
    }
}
