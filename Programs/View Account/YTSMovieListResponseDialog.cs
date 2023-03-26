using System;
using System.Windows.Forms;
using TommoJProductions.YTS;
using TommoJProductions.YTS.Structure;

namespace View_Account
{
    public partial class YTSMovieListResponseDialog : Form
    {
        // Written, 17.09.2020

        /// <summary>
        /// Represents the movie list response to view.
        /// </summary>
        private Response<MovieListInfo> response = null;

        public YTSMovieListResponseDialog(Response<MovieListInfo> inResponse)
        {
            InitializeComponent();

            // Written, 17.09.2020

            if (inResponse == null)
            {
                MessageBox.Show("The provided YTS Response was null\nClosing Response...", "Error - YTS Movie List Response Dialog");
                DialogResult = DialogResult.Cancel;
            }
            else
                response = inResponse;
        }

        #region Methods

        private void refreshTorrentListView() 
        {
            // Written, 17.09.2020

            if (movies_listView.SelectedItems.Count == 1)
            {
                MovieInfo selectedInfo = movies_listView.SelectedItems[0].Tag as MovieInfo;

                if (selectedInfo != null)
                {
                    for (int i = 0; i < selectedInfo.torrents.Length; i++)
                    {
                        TorrentInfo torrentInfo = selectedInfo.torrents[i];
                        string[] subItems = new string[]
                        {
                        String.Format("{0} ({1})", torrentInfo.type, torrentInfo.quality),
                        torrentInfo.size,
                        torrentInfo.date_uploaded.ToString(),
                        torrentInfo.seeds.ToString(),
                        torrentInfo.peers.ToString(),
                        torrentInfo.hash
                        };
                        torrents_listView.Items.Add(new ListViewItem(subItems) { Tag = torrentInfo });
                    }
                }
            }
            else
            {
                torrents_listView.Items.Clear();
            }
        }

        private void refreshTorrentOptions()
        {
            // Written, 17.09.2020

            if (movies_listView.SelectedItems.Count == 1)
            {
                if (torrents_listView.SelectedItems.Count == 1)
                {
                    MovieInfo selectedInfo = movies_listView.SelectedItems[0].Tag as MovieInfo;
                    TorrentInfo selectedTorrentInfo = torrents_listView.SelectedItems[0].Tag as TorrentInfo;
                    startDownload_button.Text = String.Format("Download: {0} in {1}", selectedInfo.title, selectedTorrentInfo.quality);

                    startDownload_button.Enabled = true;
                }
                else
                {
                    startDownload_button.Text = "Download";
                    startDownload_button.Enabled = false;
                }
            }
            else
            {
                torrents_listView.Items.Clear();
            }
        }

        private void startTorrentDownload(TorrentInfo inTorrentInfo) 
        {
            // Written, 17.09.2020

            YTSManager.openURL(YTSManager.createTorrentMagenetUrl(inTorrentInfo, (movies_listView.SelectedItems[0].Tag as MovieInfo).title));
        }

        #endregion

        #region Event Handlers

        private void YTSMovieListResponseDialog_Load(object sender, EventArgs e)
        {
            // Written, 17.09.2020

            responseStatus_label.Text = String.Format("Status: {0}", response.status);
            responseMessage_label.Text = String.Format("Message: {0}", response.status_message);
            responseMovieListCountLimit_label.Text = String.Format("Movies {0}/{1}", response.data.movie_count, response.data.limit);
            page_label.Text = "Page " + response.data.page_number;

            refreshTorrentOptions();
            if (response.data.movies != null)
            {
                for (int i = 0; i < response.data.movies.Length; i++)
                {
                    MovieInfo info = response.data.movies[i];
                    if (info != null)
                    {
                        string[] subItems = new string[]
                        {
                        info.title,
                        info.description_full,
                        info.year.ToString(),
                        info.runtime + "mins",
                        info.torrents.Length + " available"
                        };
                        movies_listView.Items.Add(new ListViewItem(subItems) { Tag = info });
                    }
                }
            }
            else
            {
                movies_listView.View = View.List;
                movies_listView.Items.Add("No Results found");
            }
        }

        private void movies_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Written, 17.09.2020

            refreshTorrentListView();
            refreshTorrentOptions();
        }

        private void torrents_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Written, 17.09.2020

            refreshTorrentOptions();
        }

        private void startDownload_button_Click(object sender, EventArgs e)
        {
            // Writen, 17.09.2020

            startTorrentDownload(torrents_listView.SelectedItems[0].Tag as TorrentInfo);
        }

        #endregion
    }
}
