using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using TM_Db_Lib;
using TM_Db_Lib.Account;
using TM_Db_Lib.Auth;
using TM_Db_Lib.Media;
using TM_Db_Lib.Search;

namespace View_Account
{
    public partial class viewAccount_Form : Form
    {
        // Written, 09.12.2019

        internal ViewAccount viewAccount;

        public viewAccount_Form()
        {
            // Written, 09.12.2019

            InitializeComponent();

            this.loginTMDb();
            this.updateMediaActions();
        }

        private void loginTMDb() 
        {
            // Written, 10.12.2019

            string dialogTitle = String.Format("{0} - TMDb Login", this.Text);
            TextDialog textDialog = new TextDialog("Enter Username", dialogTitle);
            if (textDialog.ShowDialog() == DialogResult.OK)
            {
                string username = textDialog.textInput;
                textDialog = new TextDialog("Enter Password", dialogTitle);
                if (textDialog.ShowDialog() == DialogResult.OK)
                {
                    string password = textDialog.textInput;
                    AggregateException exception = null;
                    Token token = null;
                    try
                    {
                        token = Token.retrieveTokenAsync().Result;
                    }
                    catch (AggregateException ex)
                    {
                        exception = ex;
                    }
                    if (token?.success ?? false)
                    {
                        Session session = null;
                        try
                        {
                            session = Session.createSessionWithLoginAsync(username, password, token.request_token).Result;
                        }
                        catch (AggregateException ex)
                        {
                            exception = ex;
                        }
                        if (session?.success ?? false)
                        {
                            User user = User.retrieveUserDetailsAsync(session.session_id).Result;
                            this.viewAccount = new ViewAccount(user);
                        }
                    }
                    if (!(exception is null))
                    {
                        string exMessage = exception.Message;
                        for (int i = 0; i < exception.InnerExceptions.Count; i++)
                            exMessage += String.Format("\n{0}.) {1}", i + 1, exception.InnerExceptions[i].Message);
                        MessageBox.Show(exMessage, "An error occured while creating the token and/or session.");
                    }
                }
            }
            if (this.viewAccount is null)
                Environment.Exit(0);
        }
        private void updateMediaActions() 
        {
            // Written, 17.12.2019

            if (this.searchResults_listView.SelectedItems.Count == 1)
            {
                MediaSearchResult result = this.searchResults_listView.SelectedItems[0].Tag as MediaSearchResult;
                this.searchItemActions_groupBox.Text = "Actions: " + result.name;
                this.mediaItemPoster_pictureBox.Image = result.poster_image;
                this.viewDetails_button.Enabled = true;
                this.viewDetails_button.Visible = true;
                this.favoriteMediaItem_button.Enabled = true;
                this.favoriteMediaItem_button.Visible = true;
                List<IdResultObject> favoritedMedia = new List<IdResultObject>();
                favoritedMedia.AddRange(this.viewAccount.favoritedMovies);
                favoritedMedia.AddRange(this.viewAccount.favoritedTvSeries);
                bool favorited = favoritedMedia.Any(_fm => _fm.id == result.id);
                this.favoriteMediaItem_button.Text = !favorited ? "favorite" : "unfavorite";
            }
            else
            {
                this.searchItemActions_groupBox.Text = "Actions";
                this.viewDetails_button.Enabled = false;
                this.viewDetails_button.Visible = false;
                this.favoriteMediaItem_button.Enabled = false;
                this.favoriteMediaItem_button.Visible = false;
            }
        }

        private void viewAccount_Form_Load(object sender, EventArgs e)
        {
            // Written, 10.12.2019

            this.Text = this.Text.Insert(0, this.viewAccount.user.username + " - ");
            this.accountName_label.Text = this.viewAccount.user.name;
        }
        private async void search_button_Click(object sender, EventArgs e)
        {
            // Written, 10.12.2019

            this.searchInput_textBox.Enabled = false;
            this.search_button.Enabled = false;
            this.search_button.Text = "Searching..";
            this.searchResults_listView.Clear();
            if (!String.IsNullOrEmpty(this.searchInput_textBox.Text)) 
            {
                MultiSearchResult multiSearch = await MultiSearchResult.searchAsync(this.searchInput_textBox.Text, 1);
                for (int i = 0; i < ApplicationInfomation.NUMBER_OF_ITEMS_PER_PAGE; i++)
                {
                    ListViewItem item = null;
                    MovieSearchResult movie = multiSearch.movies[i];
                    if (movie != null)
                    {
                        item = new ListViewItem(String.Format("\t[MOVIE] {0} ({1})", movie.name, movie.release_date));
                        item.Tag = movie;
                    }
                    else
                    {
                        TvSearchResult tvSeries = multiSearch.tvSeries[i];
                        if (tvSeries != null)
                        {
                            item = new ListViewItem(String.Format("\t[TV] {0} ({1})", tvSeries.name, tvSeries.release_date));
                            item.Tag = tvSeries;
                        }
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
        private void searchResults_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Written, 10.12.2019

            this.updateMediaActions();
        }
        private async void favoriteMediaItem_button_Click(object sender, EventArgs e)
        {
            // Written, 17.12.2019

            this.favoriteMediaItem_button.Text = "processing";
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
                    await this.viewAccount.retrieveFavoriteMovies();
                    break;
                case MediaTypeEnum.tv:
                    await this.viewAccount.retrieveFavoriteTvSeries();
                    break;
            }
            this.updateMediaActions();
        }
    }
}
