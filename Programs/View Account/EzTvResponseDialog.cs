using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TommoJProductions.EzTV;
using TommoJProductions.EzTV.Structure;
using TommoJProductions.YTS.Structure;

namespace View_Account
{
    public partial class EzTvResponseDialog : Form
    {
        Response response;

        public EzTvResponseDialog(Response response)
        {
            this.response = response;
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            imdb_id_label.Text = response.imdb_id;
            totalTorrents_label.Text = response.torrents_count + "";
            listTorrents();
        }

        void listTorrents() 
        {
            for (int i = 0; i < response.torrents?.Length; i++)
            {
                GetTorrentsInfo torrentInfo = response.torrents[i];
                string[] subItems = new string[]
                {
                        torrentInfo.title,
                        torrentInfo.season,
                        torrentInfo.episode,
                        torrentInfo.seeds,
                        torrentInfo.peers,
                        torrentInfo.hash
                };
                listView1.Items.Add(new ListViewItem(subItems));
            }
            listedTorrentsCount_label.Text = $"{listView1.Items.Count}";
        }

        private async Task updateTorrentList()
        {
            listView1.Items.Clear();

            nextPage_button.Enabled = false;
            previousPage_button.Enabled = false;
            button1.Enabled = false;

            response = await EztvManager.retrieveTorrentsAsync(new TommoJProductions.EzTV.EndPointParameters.GetTorrrentsEndPointParameters() { imdb_id = response.imdb_id, limit = (int)numericUpDown1.Value, page = (int)page_numericUpDown.Value });

            nextPage_button.Enabled = true;
            previousPage_button.Enabled = true;
            button1.Enabled = true;

            loadData();
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
    }
}
