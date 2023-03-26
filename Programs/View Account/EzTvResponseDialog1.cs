using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using TommoJProductions.EzTV;
using TommoJProductions.EzTV.EndPointParameters;
using TommoJProductions.EzTV.Structure;
using TommoJProductions.TMDB.Media;
using TommoJProductions.TMDB.Search;
using TommoJProductions.YTS;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace View_Account
{
    public partial class EzTvResponseDialog1 : Form
    {
        // Written, 17.09.2020

        /// <summary>
        /// Represents the tv episode list response to view.
        /// </summary>
        private Response response = null;
        private GetTorrentsInfo selectedTorrent;
        private TvSearchResult tvSearch;
        private TvSeriesResult tvSeriesResult;

        public EzTvResponseDialog1(Response response, TvSearchResult tvSearch)
        {
            InitializeComponent();

            // Written, 17.09.2020
                        
            if (response == null)
            {
                MessageBox.Show("The provided EzTv Response was null\nClosing Response...", "Error - EzTv Response Dialog");
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                this.response = response;
            }

            this.tvSearch = tvSearch;
        }

        #region Methods

        private void refreshTorrentOptions()
        {
            // Written, 13.10.2022

            startDownload_button.Text = "Download in uTorrent";
            if (episodes_listView.SelectedItems.Count == 1)
            {
                startDownload_button.Text += String.Format(": {0}", selectedTorrent.title);
                startDownload_button.Enabled = true;
            }
            else
            {
                startDownload_button.Enabled = false;
            }
        }

        private void startTorrentDownload(GetTorrentsInfo info) 
        {
            // Written, 17.09.2020

            YTSManager.openURL(new Uri(info.magnet_url));
        }
        Dictionary<string, Dictionary<string, List<GetTorrentsInfo>>> seasonData = new Dictionary<string, Dictionary<string, List<GetTorrentsInfo>>>();
        private void loadData() 
        {
            //label1.Text = String.Format("Message: {0}", response.imdb_id);
            //page_label.Text = "Page " + response.page;
            if (response.torrents != null)
            {
                label1.Text = String.Format("Episodes {0}/{1}", response.torrents.Length * response.page, response.torrents_count);
                for (int i = 0; i < response.torrents.Length; i++)
                {
                    GetTorrentsInfo torrentInfo = response.torrents[i];
                    long.TryParse(torrentInfo.date_released_unix,  out long releaseDateUnix);
                    Episode ep = new Episode("");
                    ep.retrieveDetailsAsync(tvSearch.id, Int32.Parse(torrentInfo.season), Int32.Parse(torrentInfo.episode));
                    string[] subItems = new string[]
                    {
                        torrentInfo.title,
                        ep.overview,
                        torrentInfo.episode,
                        EztvManager.unixTimeStampToDateTime(releaseDateUnix).ToString("dd.MM.yy"),
                        torrentInfo.seeds,
                        torrentInfo.peers,
                        (Math.Round(long.Parse(torrentInfo.size_bytes) / 1e+6f)) + "mb",
                        torrentInfo.hash,
                    };

                    Dictionary<string, List<GetTorrentsInfo>> season;
                    List<GetTorrentsInfo> episodes;
                    ListViewGroup group;

                    if (!seasonData.TryGetValue(torrentInfo.season, out season))
                    {
                        season = new Dictionary<string, List<GetTorrentsInfo>>();
                        seasonData.Add(torrentInfo.season, season);
                        }
                    if (!season.TryGetValue(torrentInfo.episode, out episodes))
                    {
                        season.Add(torrentInfo.episode, new List<GetTorrentsInfo>());
                        episodes_listView.Groups.Add(new ListViewGroup(torrentInfo.season + torrentInfo.episode, $"Season {torrentInfo.season}, Episode {torrentInfo.episode}"));                    
                    }
                    group = episodes_listView.Groups[torrentInfo.season + torrentInfo.episode];
                    season[torrentInfo.episode].Add(torrentInfo);
                    seasonData[torrentInfo.season] = season;

                    episodes_listView.Items.Add(new ListViewItem(subItems) { Tag = torrentInfo, Group = group });
                }
            }
            else
            {
                episodes_listView.View = View.List;
                episodes_listView.Items.Add("No Results found");
            }
        }
        private async Task updateTorrentList()
        {
            episodes_listView.Items.Clear();

            nextPage_button.Enabled = false;
            previousPage_button.Enabled = false;
            search_button.Enabled = false;

            response = await EztvManager.retrieveTorrentsAsync(new GetTorrrentsEndPointParameters() { imdb_id = response.imdb_id, limit = (int)limit_numericUpDown.Value, page = (int)page_numericUpDown.Value });

            nextPage_button.Enabled = true;
            previousPage_button.Enabled = true;
            search_button.Enabled = true;

            loadData();
        }

        #endregion

        #region Event Handlers

        private async void movieListResponseDialog_Load(object sender, EventArgs e)
        {
            // Written, 17.09.2020

            this.tvSeriesResult = await TvSeriesResult.retrieveDetailsAsync(tvSeriesResult.id);

            loadData();
            refreshTorrentOptions();

        }

        private void movies_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Written, 17.09.2020

            if (episodes_listView.SelectedItems.Count == 1)
            {
                selectedTorrent = episodes_listView.SelectedItems[0].Tag as GetTorrentsInfo;
                refreshTorrentOptions();
            }
        }

        private void startDownload_button_Click(object sender, EventArgs e)
        {
            // Writen, 17.09.2020

            startTorrentDownload(episodes_listView.SelectedItems[0].Tag as GetTorrentsInfo);
        }
        private async void query_Click(object sender, EventArgs e)
        {
            await updateTorrentList();
        }
        private async void nextPage_button_Click(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            page_numericUpDown.Value++;
            await updateTorrentList();
        }

        private async void previousPage_button_Click(object sender, EventArgs e)
        {
            // Written, 21.09.2020

            page_numericUpDown.Value--;
            await updateTorrentList();
        }

        #endregion

        private void episodes_listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
        }
    }
}
