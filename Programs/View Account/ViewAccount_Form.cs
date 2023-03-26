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
using TommoJProductions.EzTV;
using TommoJProductions.EzTV.EndPointParameters;
using TommoJProductions.EzTV.Structure;
using TM_Db_Lib.TommoJProductions.TMDB.Media;
using System.Threading;
using System.Drawing;
using TommoJProductions.TMDB.Trending;

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

        private ExternalIdsResultObject selectedMediaExternalIds;
        private Trending trending;
        private MediaSearchResult trending_selectedMedia;

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
        /// Initialzies discover.
        /// </summary>
        private void initDiscover()
        {
            // Written, 09.01.2020

            discoverParameters = new DiscoverParameters();
            discover_sortByMembers_comboBox.Items.AddRange(Enum.GetNames(typeof(MediaSortByMembersEnum)));
            discover_sortByAscDesc_comboBox.Items.AddRange(Enum.GetNames(typeof(MediaSortByAscDescEnum)));

            discover_sortByAscDesc_comboBox.SelectedIndex = 0;
            discover_sortByMembers_comboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// Initialzies trending.
        /// </summary>
        private async Task initTrending()
        {
            // Written, 15.10.2022

            trending_time_comboBox.Items.AddRange(Enum.GetNames(typeof(TrendingTimeWindowEnum)));
            trending_allowedMedia_comboBox.Items.AddRange(Enum.GetNames(typeof(TrendingAllowedMediaTypesEnum)));

            trending_time_comboBox.SelectedIndex = 0;
            trending_allowedMedia_comboBox.SelectedIndex = 0;

            trending_time_comboBox.SelectedIndexChanged += trendingSelectedIndexChanged;
            trending_allowedMedia_comboBox.SelectedIndexChanged += trendingSelectedIndexChanged;

            await refreshTrendingAsync();
        }
        /// <summary>
        /// Initializes yts tab.
        /// </summary>
        private void initYts()
        {
            // Written, 21.09.2020

            ytsQuality_comboBox.Items.AddRange(Enum.GetNames(typeof(QualityEndPointParameterEnum)));
            ytsQuality_comboBox.SelectedIndex = 0;
            ytsSortBy_comboBox.Items.AddRange(Enum.GetNames(typeof(SortByEndPointParameterEnum)));
            ytsSortBy_comboBox.SelectedIndex = 0;
            ytsOrderBy_comboBox.Items.AddRange(Enum.GetNames(typeof(OrderByEndPointParameterEnum)));
            ytsOrderBy_comboBox.SelectedIndex = 0;
        }

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
                loadingDialog.loadingWhatText = "Retrieving Token";
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
                    loadingDialog.loadingWhatText = "Creating Session";
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
                        loadingDialog.loadingWhatText = "Retrieving User";
                        try
                        {
                            User user = await User.retrieveUserDetailsAsync(session.session_id);
                            viewAccount = new ViewAccount(user);
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
                LoadingDialog errorLoadingDialog = new LoadingDialog(loadingDialog.programNameText)
                {
                    errorMessage = exception.Message,
                    loadingText = loadingDialog.Text,
                    loadingWhatText = loadingDialog.loadingWhatText
                };
                loadingDialog.Close();
                Application.Run(errorLoadingDialog);
            }
            loadingDialog.Close();
            return !(viewAccount is null);
        }

        /// <summary>
        /// Updates the search media actions.
        /// </summary>
        private async Task updateSearchMediaActionsAsync()
        {
            // Written, 17.12.2019

            if (searchResults_listView.SelectedItems.Count == 1)
            {
                MediaSearchResult media = searchResults_listView.SelectedItems[0].Tag as MediaSearchResult;
                search_selectedMedia = media;
                actions_groupBox.Text = "Actions: " + media.name;
                mediaPoster_pictureBox.Image = media.poster_image;
                search_viewDetails_button.Enabled = true;
                search_viewDetails_button.Visible = true;
                favoriteMediaItem_button.Enabled = true;
                favoriteMediaItem_button.Visible = true;
                watchMediaItem_button.Enabled = true;
                watchMediaItem_button.Visible = true;
                if (media is MovieSearchResult)
                {
                    yts_button.Enabled = true;
                    yts_button.Visible = true;
                    yts_button.Text = "Search YTS";

                    eztv_button.Enabled = false;
                    eztv_button.Visible = false;
                }
                else
                {
                    selectedMediaExternalIds = await (media as TvSearchResult).retrieveExternalIds();
                    eztv_button.Enabled = true;
                    eztv_button.Visible = true;
                    eztv_button.Text = "Search EzTv";

                    yts_button.Enabled = false;
                    yts_button.Visible = false;
                    yts_button.Text = "yts_button";
                }
                List<IdResultObject> favoritedMedia = new List<IdResultObject>();
                favoritedMedia.AddRange(viewAccount.favoritedMovies);
                favoritedMedia.AddRange(viewAccount.favoritedTvSeries);
                bool favorited = favoritedMedia.Any(_fm => _fm.id == media.id);
                favoriteMediaItem_button.Text = !favorited ? "favorite" : "unfavorite";
                List<IdResultObject> watchlistMedia = new List<IdResultObject>();
                watchlistMedia.AddRange(viewAccount.watchlistMovies);
                watchlistMedia.AddRange(viewAccount.watchlistTvSeries);
                bool watchlisted = watchlistMedia.Any(_wm => _wm.id == media.id);
                watchMediaItem_button.Text = !watchlisted ? "watch" : "unwatch";
                search_viewDetails_button.Text = "View Details: " + media.name;
                updateMediaPoster(searchResults_listView, media);
            }
            else
            {
                actions_groupBox.Text = "Actions";
                search_viewDetails_button.Enabled = false;
                search_viewDetails_button.Visible = false;
                favoriteMediaItem_button.Enabled = false;
                favoriteMediaItem_button.Visible = false;
                watchMediaItem_button.Enabled = false;
                watchMediaItem_button.Visible = false;
                yts_button.Enabled = false;
                yts_button.Visible = false;
                search_viewDetails_button.Text = "View Details";
                mediaPoster_pictureBox.Image = null;
                imageLoading_label.Text = string.Empty;
                eztv_button.Enabled = false;
                eztv_button.Visible = false;
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
                    home_selectedMedia = media;
                    actions_groupBox.Text = "Actions: " + media.name;
                    mediaPoster_pictureBox.Image = media.poster_image;
                    home_viewDetails_button.Enabled = true;
                    home_viewDetails_button.Visible = true;
                    movieRefresh_button.Enabled = true;
                    movieRefresh_button.Visible = true;
                    tvRefresh_button.Enabled = true;
                    tvRefresh_button.Visible = true;
                    if (media is MovieSearchResult)
                    {
                        selectedMediaExternalIds = await (media as MovieSearchResult).retrieveExternalIds();

                        yts_button.Enabled = true;
                        yts_button.Visible = true;
                        yts_button.Text = "Search YTS";

                        eztv_button.Enabled = false;
                        eztv_button.Visible = false;
                    }
                    else
                    {
                        selectedMediaExternalIds = await (media as TvSearchResult).retrieveExternalIds();
                        eztv_button.Enabled = true;
                        eztv_button.Visible = true;
                        eztv_button.Text = "Search EzTv";

                        yts_button.Enabled = false;
                        yts_button.Visible = false;
                        yts_button.Text = "yts_button";
                    }
                    home_viewDetails_button.Text = "View Details: " + media.name;
                    updateMediaPoster(inSender, media);
                }
            }
            else
            {
                actions_groupBox.Text = "Actions";
                home_viewDetails_button.Enabled = false;
                home_viewDetails_button.Visible = false;
                movieRefresh_button.Enabled = false;
                movieRefresh_button.Visible = false;
                tvRefresh_button.Enabled = false;
                tvRefresh_button.Visible = false;
                yts_button.Enabled = false;
                yts_button.Visible = false;
                home_viewDetails_button.Text = "View Details";
                mediaPoster_pictureBox.Image = null;
                imageLoading_label.Text = string.Empty;
                eztv_button.Enabled = false;
                eztv_button.Visible = false;
            }
        }
        private void updateYtsMediaActions()
        {
            // Written, 21.09.2020

            if (ytsMovieResults_listView.SelectedItems.Count == 1)
            {
                MovieSearchResult media = ytsMovieResults_listView.SelectedItems[0].Tag as MovieSearchResult;
                if (media != null)
                {
                    yts_selectedMedia = media;
                    actions_groupBox.Text = "Actions: " + media.name;
                    mediaPoster_pictureBox.Image = media.poster_image;
                    yts_button.Enabled = true;
                    yts_button.Visible = true;
                    yts_button.Text = "Search YTS";
                    //updateMediaPoster(ytsMovieResults_listView, media, YTSManager.YTS_ADDRESS);
                }
            }
            else
            {
                actions_groupBox.Text = "Actions";
                yts_button.Enabled = false;
                yts_button.Visible = true;
                mediaPoster_pictureBox.Image = null;
            }
            eztv_button.Enabled = false;
            eztv_button.Visible = false;
        }

        private async Task updateTrendingMediaActions()
        {
            if (trending_listView.SelectedItems.Count == 1)
            {
                MediaSearchResult media = trending_listView.SelectedItems[0].Tag as MediaSearchResult;
                trending_selectedMedia = media;
                if (media != null)
                {
                    if (media is MovieSearchResult)
                    {
                        yts_button.Enabled = true;
                        yts_button.Visible = true;
                        yts_button.Text = "Search YTS";

                        eztv_button.Enabled = false;
                        eztv_button.Visible = false;
                    }
                    else
                    {
                        selectedMediaExternalIds = await (media as TvSearchResult).retrieveExternalIds();
                        eztv_button.Enabled = true;
                        eztv_button.Visible = true;
                        eztv_button.Text = "Search EzTv";

                        yts_button.Enabled = false;
                        yts_button.Visible = false;
                        yts_button.Text = "yts_button";
                    }

                    actions_groupBox.Text = "Actions: " + media.name;
                    updateMediaPoster(trending_listView, media);
                }
            }
            else
            {
                actions_groupBox.Text = "Actions";
                mediaPoster_pictureBox.Image = null;
                yts_button.Enabled = false;
                yts_button.Visible = false;
                eztv_button.Enabled = false;
                eztv_button.Visible = false;
            }
        }

        private async Task refreshTrendingAsync()
        {
            trending = await Trending.retrieveTrendingAsync((TrendingAllowedMediaTypesEnum)Enum.Parse(typeof(TrendingAllowedMediaTypesEnum), trending_allowedMedia_comboBox.SelectedItem.ToString()), (TrendingTimeWindowEnum)Enum.Parse(typeof(TrendingTimeWindowEnum), trending_time_comboBox.SelectedItem.ToString()));
            trending_listView.Items.Clear();
            IdResultObject result;
            MovieSearchResult movie;
            TvSearchResult tv;
            for (int i = 0; i < trending.trendingResults.Length; i++)
            {
                result = trending.trendingResults[i];
                if (result is MovieSearchResult)
                {
                    movie = (result as MovieSearchResult);
                    string[] subItems = new string[]
                    {
                            movie.name,
                            movie.overview,
                            movie.release_date,
                            movie.vote_average.ToString(),
                            "Movie"
                    };
                    trending_listView.Items.Add(new ListViewItem(subItems) { Tag = movie });
                }
                if (result is TvSearchResult)
                {
                    tv = (result as TvSearchResult);
                    string[] subItems = new string[]
                    {
                            tv.name,
                            tv.overview,
                            tv.release_date,
                            tv.vote_average.ToString(),
                            "Tv"
                    };
                    trending_listView.Items.Add(new ListViewItem(subItems) { Tag = tv });
                }
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
        /// Updates poster based on what tabpage the user is currently on.
        /// </summary>
        /// <param name="inIsResizeLoop">acts like a force update. true if called from inside the resize loop.</param>
        private void updatePosterImageDisplay(bool inIsResizeLoop = false)
        {
            // Written, 31,01.2020

            if (!formResizing || inIsResizeLoop)
            {
                Image displayImage = getMediaToView()?.poster_image;
                if (displayImage != null)
                {
                    mediaPoster_pictureBox.Image = displayImage.resizeImage(mediaPoster_pictureBox.Width, mediaPoster_pictureBox.Height);                    
                }
            }
        }
        /// <summary>
        /// Gets the currently displayed media on either, <see cref="home_tabPage"/> or <see cref="search_tabPage"/> tabs.
        /// </summary>
        private MediaSearchResult getMediaToView()
        {
            // Written, 31.01.2020

            if (tabControl.SelectedTab == home_tabPage)
                return home_selectedMedia;
            else if (tabControl.SelectedTab == search_tabPage)
                return search_selectedMedia;
            else if (tabControl.SelectedTab == trending_tabPage)
                return trending_selectedMedia;
            //else if (tabControl.SelectedTab == yts_tabPage)
            //    return yts_selectedMedia;
            return null;
        }
        /// <summary>
        /// updates the actions buttons.
        /// </summary>
        private async Task updateActionButtonsAsync()
        {
            // Written, 18.09.2020

            if (tabControl.SelectedTab == home_tabPage)
            {
                //view details
                search_viewDetails_button.Visible = false;
                search_viewDetails_button.Enabled = false;
                //other
                yts_button.Visible = true;
                watchMediaItem_button.Visible = false;
                favoriteMediaItem_button.Visible = false;
                //update all actions related to favourite.
                await updateHomeMediaActionsAsync(null, home_selectedMedia);
            }
            else if (tabControl.SelectedTab == search_tabPage)
            {
                //view details
                home_viewDetails_button.Visible = false;
                home_viewDetails_button.Enabled = false;
                //other
                tvRefresh_button.Visible = false;
                movieRefresh_button.Visible = false;
                //update all actions related to search.
                await updateSearchMediaActionsAsync();
            }
            else if (tabControl.SelectedTab == yts_tabPage)
            {
                home_viewDetails_button.Visible = false;
                home_viewDetails_button.Enabled = false;
                search_viewDetails_button.Visible = false;
                search_viewDetails_button.Enabled = false;
                yts_button.Visible = false;
                tvRefresh_button.Visible = false;
                watchMediaItem_button.Visible = false;
                movieRefresh_button.Visible = false;
                favoriteMediaItem_button.Visible = false;
                updateYtsMediaActions();
            }
            else if (tabControl.SelectedTab == trending_tabPage)
            {
                home_viewDetails_button.Visible = false;
                search_viewDetails_button.Visible = false;
                home_viewDetails_button.Enabled = false;
                search_viewDetails_button.Enabled = false;
                yts_button.Visible = false;
                tvRefresh_button.Visible = false;
                watchMediaItem_button.Visible = false;
                movieRefresh_button.Visible = false;
                favoriteMediaItem_button.Visible = false;
                eztv_button.Visible = false;
                eztv_button.Enabled = false;

                await updateTrendingMediaActions();
            }
            else
            {
                home_viewDetails_button.Visible = false;
                search_viewDetails_button.Visible = false;
                home_viewDetails_button.Enabled = false;
                search_viewDetails_button.Enabled = false;
                yts_button.Visible = false;
                tvRefresh_button.Visible = false;
                watchMediaItem_button.Visible = false;
                movieRefresh_button.Visible = false;
                favoriteMediaItem_button.Visible = false;
            }

        }
        /// <summary>
        /// Updates/retrieves both movie watchlist and favorited lists and displays the new results in the home movie listview.
        /// </summary>
        private async Task updateHomeMoviesAsync()
        {
            // Written, 18.09.2020

            preUpdateLists(homeMovies_listView);
            await refreshHomeMoviesAsync();
            ListViewItem[] Items = new ListViewItem[viewAccount.favoritedMovies.Length + viewAccount.watchlistMovies.Length];
            string[] subItems;
            MovieSearchResult msr;
            for (int i = 0; i < viewAccount.favoritedMovies.Length; i++)
            {
                msr = viewAccount.favoritedMovies[i];
                subItems = new string[]
                {
                    msr.name,
                    msr.release_date,
                };
                Items[i] = new ListViewItem(subItems, homeMovies_listView.Groups[0]) { Tag = msr };
            }
            for (int i = 0; i < viewAccount.watchlistMovies.Length; i++)
            {
                msr = viewAccount.watchlistMovies[i];
                subItems = new string[]
                {
                    msr.name,
                    msr.release_date,
                };
                Items[viewAccount.favoritedMovies.Length + i] = new ListViewItem(subItems, homeMovies_listView.Groups[1]) { Tag = msr };
            }
            postUpdateLists(homeMovies_listView, Items);
        }
        /// <summary>
        /// Retrieves both movie watchlist and favorited lists from tmdb, thus updating. in addition updates movie refresh button text, and enablity.
        /// </summary>
        private async Task refreshHomeMoviesAsync()
        {
            // Written, 18.09.2020

            movieRefresh_button.Text = "Refreshing...";
            movieRefresh_button.Enabled = false;
            await viewAccount.retrieveFavoriteMoviesAsync();
            await viewAccount.retrieveWatchlistMoviesAsync();
            movieRefresh_button.Text = "Refresh movies";
            movieRefresh_button.Enabled = true;
        }
        /// <summary>
        /// Updates/retrieves both tv watchlist and favorited lists and displays the new results in the home tv listview.
        /// </summary>
        private async Task updateHomeTvSeriesAsync()
        {
            // Written, 18.09.2020

            preUpdateLists(homeTvSeries_listView);
            await refreshHomeTvAsync();
            ListViewItem[] Items = new ListViewItem[viewAccount.favoritedTvSeries.Length + viewAccount.watchlistTvSeries.Length];
            string[] subItems;
            TvSearchResult tsr;
            for (int i = 0; i < viewAccount.favoritedTvSeries.Length; i++)
            {
                tsr = viewAccount.favoritedTvSeries[i];
                subItems = new string[]
                {
                    tsr.name,
                    tsr.release_date,
                };
                Items[i] = new ListViewItem(subItems, homeTvSeries_listView.Groups[0]) { Tag = tsr };
            }
            for (int i = 0; i < viewAccount.watchlistTvSeries.Length; i++)
            {
                tsr = viewAccount.watchlistTvSeries[i];
                subItems = new string[]
                {
                    tsr.name,
                    tsr.release_date,
                };
                Items[viewAccount.favoritedTvSeries.Length + i] = new ListViewItem(subItems, homeTvSeries_listView.Groups[1]) { Tag = tsr };
            }
            postUpdateLists(homeTvSeries_listView, Items);
        }
        /// <summary>
        /// Retrieves both tv watchlist and favorited lists from tmdb, thus updating. in addition updates tv refresh button text, and enablity.
        /// </summary>
        private async Task refreshHomeTvAsync()
        {
            // Written, 18.09.2020

            tvRefresh_button.Text = "Refreshing...";
            tvRefresh_button.Enabled = false;
            await viewAccount.retrieveFavoriteTvSeriesAsync();
            await viewAccount.retrieveWatchlistTvSeriesAsync();
            tvRefresh_button.Text = "Refresh tv series";
            tvRefresh_button.Enabled = true;
        }
        /// <summary>
        /// Converts control input to object <see cref="MovieListEndPointParameters"/>.
        /// </summary>
        private MovieListEndPointParameters ytsControlsToParameters()
        {
            // Written, 21.09.2020

            return new MovieListEndPointParameters()
            {
                genre = ytsGenre_textBox.Text.ToLower(),
                limit = Decimal.ToInt32(ytsLimit_numericUpDown.Value),
                minRating = Decimal.ToInt32(ytsMinRating_numericUpDown.Value),
                orderBy = (OrderByEndPointParameterEnum)Enum.Parse(typeof(OrderByEndPointParameterEnum), ytsOrderBy_comboBox.SelectedItem.ToString()),
                sortBy = (SortByEndPointParameterEnum)Enum.Parse(typeof(SortByEndPointParameterEnum), ytsSortBy_comboBox.SelectedItem.ToString()),
                page = Decimal.ToInt32(ytsPage_numericUpDown.Value),
                quality = (QualityEndPointParameterEnum)Enum.Parse(typeof(QualityEndPointParameterEnum), ytsQuality_comboBox.SelectedItem.ToString()),
                query = ytsQuery_textBox.Text
            };
        }
        /// <summary>
        /// Updates/Retrieves a yts response and displays the data.
        /// </summary>
        private async Task updateYtsMoviesAsync()
        {
            // Written, 21.09.2020

            ytsSearchParameters_groupBox.Enabled = false;
            preUpdateLists(ytsMovieResults_listView);
            ytsSearchResults_groupBox.Text = "Search results";
            Response<MovieListInfo> response = await YTSManager.retrieveMovieListAsync(ytsControlsToParameters());
            ListViewItem[] items = new ListViewItem[response.data.movies?.Length ?? 0];
            if (response.data.movies != null)
            {
                ytsSearchResults_groupBox.Text = String.Format("Search results {0}/{1} | ({2} pages)", response.data.movies.Length * response.data.page_number, response.data.movie_count, response.data.movie_count / response.data.limit);
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
            postUpdateLists(ytsMovieResults_listView, items);
            ytsSearchParameters_groupBox.Enabled = true;
        }
        private void updateMediaPoster(ListView inSender, MediaSearchResult inMedia, string inOverrideImageAddressPrefix = null)
        {
            // Written, 21.09.2020

            void retrievePoster()
            {
                if (inMedia?.poster_path is null)
                    imageLoading_label.Text = "No poster present..";
                else
                {
                    if (inMedia.poster_image is null)
                    {
                        imageLoading_label.Text = "Loading poster..";
                        try
                        {
                            //await inMedia.retrieveMediaImagesAsync(inOverrideImageAddressPrefix);
                            inMedia.retrieveMediaImages(inOverrideImageAddressPrefix);
                        }
                        catch
                        {
                            imageLoading_label.Text = "Error loading poster";
                            return;
                        }
                    }
                }
                //if (inMedia == (inSender?.SelectedItems[0].Tag))
                updatePosterImageDisplay();
                imageLoading_label.Text = string.Empty;
            }

            Thread thread = new Thread(new ParameterizedThreadStart(delegate { retrievePoster(); }));
            thread.Start();
        }
        #endregion

        #region Event Handlers

        private async void viewAccount_Form_Load(object sender, EventArgs e)
        {
            // Written, 10.12.2019

            tabControl_Selected(tabControl.SelectedTab.Text, null);
            accountName_label.Text = viewAccount.user.name;
            await updateSearchMediaActionsAsync();
            await updateHomeMoviesAsync();
            await updateHomeTvSeriesAsync();
            initDiscover();
            initYts();
            await initTrending();
        }
        private async void search_button_Click(object sender, EventArgs e)
        {
            // Written, 10.12.2019

            searchInput_textBox.Enabled = false;
            search_button.Enabled = false;
            search_button.Text = "Searching..";
            if (!String.IsNullOrEmpty(searchInput_textBox.Text))
            {
                preUpdateLists(searchResults_listView);
                await updateSearchMediaActionsAsync();
                MultiSearchResult multiSearch = await MultiSearchResult.searchAsync(searchInput_textBox.Text, 1);
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
                postUpdateLists(searchResults_listView, items.ToArray());
            }
            searchInput_textBox.Enabled = true;
            search_button.Enabled = true;
            search_button.Text = "Search";
        }
        private async void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            // Written, 10.12.2019

            string textChange = e?.TabPage.Text ?? sender as string;
            Text = String.Format("{1} - View Account | {0}", textChange, viewAccount.user.username);
            main_groupBox.Text = textChange;
            //updatePosterImageDisplay();
            await updateActionButtonsAsync();
        }
        private async void searchResults_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Written, 10.12.2019

            await updateSearchMediaActionsAsync();
        }
        private async void favoriteMediaItem_button_Click(object sender, EventArgs e)
        {
            // Written, 17.12.2019

            favoriteMediaItem_button.Enabled = false;
            favoriteMediaItem_button.Text = "processing..";
            MediaSearchResult selectedResult = searchResults_listView.SelectedItems[0].Tag as MediaSearchResult;
            MediaTypeEnum mediaType = selectedResult is TvSearchResult ? MediaTypeEnum.tv : MediaTypeEnum.movie;            
            List<IdResultObject> favoritedMedia = new List<IdResultObject>();
            favoritedMedia.AddRange(viewAccount.favoritedMovies);
            favoritedMedia.AddRange(viewAccount.favoritedTvSeries);
            bool favorited = favoritedMedia.Any(_fm => _fm.id == selectedResult.id);
            await viewAccount.user.favoriteMediaItem(mediaType, selectedResult.id, !favorited);
            switch (mediaType) 
            {
                case MediaTypeEnum.movie:
                    await viewAccount.retrieveFavoriteMoviesAsync();
                    break;
                case MediaTypeEnum.tv:
                    await viewAccount.retrieveFavoriteTvSeriesAsync();
                    break;
            }
            favoriteMediaItem_button.Text = "updating..";
            if (mediaType == MediaTypeEnum.movie)
                await updateHomeMoviesAsync();
            else
                await updateHomeTvSeriesAsync();
            await updateSearchMediaActionsAsync();
            favoriteMediaItem_button.Enabled = true;
        }
        private async void viewDetails_button_Click(object sender, EventArgs e)
        {
            // Written, 31.12.2019

            MediaSearchResult mediaToView = getMediaToView();
            ViewMediaDialog viewMediaDialog = new ViewMediaDialog(mediaToView, viewAccount);
            viewMediaDialog.ShowDialog();

            if (tabControl.SelectedTab == search_tabPage)
                await updateSearchMediaActionsAsync();
            if (mediaToView is TvSearchResult)
            {
                await updateHomeTvSeriesAsync();
            }
            else if (mediaToView is MovieSearchResult)
            {
                await updateHomeMoviesAsync();
            }
        }
        private async void home_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Written, 24.12.2019
            
            await updateHomeMediaActionsAsync(sender as ListView);
        }
        private  async void moviesRefresh_button_Click(object sender, EventArgs e)
        {
            // Written, 18.09.2020

            await updateHomeMoviesAsync();
        }
        private async void refreshWatchlist_button_Click(object sender, EventArgs e)
        {
            // Written, 18.09.2020

            await updateHomeTvSeriesAsync();
        }
        private async void watchMediaItem_button_Click(object sender, EventArgs e)
        {
            // Written, 01.01.2020

            watchMediaItem_button.Enabled = false;
            watchMediaItem_button.Text = "processing..";
            MediaSearchResult selectedResult = searchResults_listView.SelectedItems[0].Tag as MediaSearchResult;
            MediaTypeEnum mediaType = selectedResult is TvSearchResult ? MediaTypeEnum.tv : MediaTypeEnum.movie;
            List<IdResultObject> watchlistedMedia = new List<IdResultObject>();
            watchlistedMedia.AddRange(viewAccount.watchlistMovies);
            watchlistedMedia.AddRange(viewAccount.watchlistTvSeries);
            bool watchlisted = watchlistedMedia.Any(_fm => _fm.id == selectedResult.id);
            await viewAccount.user.watchlistMediaItem(mediaType, selectedResult.id, !watchlisted);
            switch (mediaType)
            {
                case MediaTypeEnum.movie:
                    await viewAccount.retrieveWatchlistMoviesAsync();
                    break;
                case MediaTypeEnum.tv:
                    await viewAccount.retrieveWatchlistTvSeriesAsync();
                    break;
            }
            watchMediaItem_button.Text = "updating..";
            if (mediaType == MediaTypeEnum.movie)
                await updateHomeMoviesAsync();
            else
                await updateHomeTvSeriesAsync();
            await updateSearchMediaActionsAsync();
            watchMediaItem_button.Enabled = true;
        }
        private void main_splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            // Written, 21.09.2020

            updatePosterImageDisplay();
        }        
        private async void yts_button_Click(object sender, EventArgs e)
        {
            // Written, 17.09.2020

            yts_button.Enabled = false;
            yts_button.Text = "Searching YTS...";
            Response<MovieListInfo> response = await YTSManager.searchMovieListAsync(getMediaToView().name);
            yts_button.Text = "Search YTS";
            using (YTSMovieListResponseDialog dialog = new YTSMovieListResponseDialog(response))
                dialog.ShowDialog();
            yts_button.Enabled = true;
        }        
        private void viewAccount_Form_ResizeBegin(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            formResizing = true;
        }
        private void viewAccount_Form_ResizeEnd(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            formResizing = false;
        }
        private void viewAccount_Form_Resize(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            updatePosterImageDisplay(true);
        }

        #endregion

        private async void ytsSearch_button_Click(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            await updateYtsMoviesAsync();
        }

        private async void ytsNextPage_button_Click(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            ytsPage_numericUpDown.Value++;
            await updateYtsMoviesAsync();
        }

        private async void ytsPreviousPage_button_Click(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            ytsPage_numericUpDown.Value--;
            await updateYtsMoviesAsync();
        }

        private void ytsMovieResults_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            updateYtsMediaActions();
        }

        private async void searchEZTV_button_Click(object sender, EventArgs e)
        {
            // Written, 03.10.2022

            TommoJProductions.EzTV.Structure.Response r = await EztvManager.retrieveTorrentsAsync(new TommoJProductions.EzTV.EndPointParameters.GetTorrrentsEndPointParameters() { imdb_id = "2861424" });
        }

        private async void eztv_button_Click(object sender, EventArgs e)
        {
            eztv_button.Enabled = false;
            eztv_button.Text = "Searching EzTv...";

            if (selectedMediaExternalIds.imdb_id != null)
            {
                GetTorrrentsEndPointParameters param = new GetTorrrentsEndPointParameters()
                {
                    imdb_id = selectedMediaExternalIds.imdb_id.Replace("tt", "")
                };

                Response response = await EztvManager.retrieveTorrentsAsync(param);
                if (response.torrents != null)
                {
                    using (EzTvResponseDialog1 dialog = new EzTvResponseDialog1(response, getMediaToView() as TvSearchResult))
                        dialog.ShowDialog();
                    eztv_button.Text = "Search EzTv";
                    eztv_button.Enabled = true;
                }
                else
                {
                    eztv_button.Text = "Search EzTv: no torrents";
                }
            }
            else
            {
                eztv_button.Text = "Search EzTv: imdb id was null";
            }
        }

        private async void trending_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            await updateTrendingMediaActions();
        }

        private async void trendingSelectedIndexChanged(object sender, EventArgs e)
        {
            await refreshTrendingAsync();
        }
    }
}
