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
        private Response response = null;

        public YTSMovieListResponseDialog(Response inResponse)
        {
            InitializeComponent();

            // Written, 17.09.2020

            if (inResponse == null)
            {
                MessageBox.Show("The provided YTS Response was null\nClosing Response...", "Error - YTS Movie List Response Dialog");
                this.DialogResult = DialogResult.Cancel;
            }
            else
                this.response = inResponse;
        }

        #region Methods

        private void refreshTorrentListView() 
        {
            // Written, 17.09.2020

            if (this.movies_listView.SelectedItems.Count == 1)
            {
                MovieInfo selectedInfo = this.movies_listView.SelectedItems[0].Tag as MovieInfo;

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
                    this.torrents_listView.Items.Add(new ListViewItem(subItems) { Tag = torrentInfo });
                }
            }
            else
            {
                this.torrents_listView.Items.Clear();
            }
        }

        private void refreshTorrentOptions()
        {
            // Written, 17.09.2020

            if (this.movies_listView.SelectedItems.Count == 1)
            {
                if (this.torrents_listView.SelectedItems.Count == 1)
                {
                    MovieInfo selectedInfo = this.movies_listView.SelectedItems[0].Tag as MovieInfo;
                    TorrentInfo selectedTorrentInfo = this.torrents_listView.SelectedItems[0].Tag as TorrentInfo;
                    this.startDownload_button.Text = String.Format("Download: {0} in {1}", selectedInfo.title, selectedTorrentInfo.quality);

                    this.startDownload_button.Enabled = true;
                }
                else
                {
                    this.startDownload_button.Text = "Download";
                    this.startDownload_button.Enabled = false;
                }
            }
            else
            {
                this.torrents_listView.Items.Clear();
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

            this.responseStatus_label.Text = String.Format("Status: {0}", this.response.status);
            this.responseMessage_label.Text = String.Format("Message: {0}", this.response.status_message);
            this.responseMovieListCountLimit_label.Text = String.Format("Movies {0}/{1}", this.response.data.movie_count, this.response.data.limit);
            this.page_label.Text = "Page " + this.response.data.page_number;

            this.refreshTorrentOptions();
            if (this.response.data.movies != null)
            {
                for (int i = 0; i < this.response.data.movies.Length; i++)
                {
                    MovieInfo info = this.response.data.movies[i];
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
                        this.movies_listView.Items.Add(new ListViewItem(subItems) { Tag = info });
                    }
                }
            }
            else
            {
                this.movies_listView.View = View.List;
                this.movies_listView.Items.Add("No Results found");
            }
        }

        private void movies_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Written, 17.09.2020

            this.refreshTorrentListView();
            this.refreshTorrentOptions();
        }

        private void torrents_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Written, 17.09.2020

            this.refreshTorrentOptions();
        }

        private void startDownload_button_Click(object sender, EventArgs e)
        {
            // Writen, 17.09.2020

            this.startTorrentDownload(this.torrents_listView.SelectedItems[0].Tag as TorrentInfo);
        }

        #endregion
    }
}
