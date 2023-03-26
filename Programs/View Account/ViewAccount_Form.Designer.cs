namespace View_Account
{
    partial class viewAccount_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup25 = new System.Windows.Forms.ListViewGroup("Favorited", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup26 = new System.Windows.Forms.ListViewGroup("Watchlisted", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup27 = new System.Windows.Forms.ListViewGroup("Favorited", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup28 = new System.Windows.Forms.ListViewGroup("Watchlisted", System.Windows.Forms.HorizontalAlignment.Left);
            this.accountName_label = new System.Windows.Forms.Label();
            this.main_splitContainer = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.home_tabPage = new System.Windows.Forms.TabPage();
            this.home_lists_splitContainer = new System.Windows.Forms.SplitContainer();
            this.homeMovies_groupBox = new System.Windows.Forms.GroupBox();
            this.homeMovies_listView = new System.Windows.Forms.ListView();
            this.movietitle_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movieYear_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.homeTvSeries_groupBox = new System.Windows.Forms.GroupBox();
            this.homeTvSeries_listView = new System.Windows.Forms.ListView();
            this.tvtitle_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvYear_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.search_tabPage = new System.Windows.Forms.TabPage();
            this.searchResults_listView = new System.Windows.Forms.ListView();
            this.searchTitle_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchDescription_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchYear_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchRating_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchMediaType_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.search_button = new System.Windows.Forms.Button();
            this.searchInput_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discover_tabPage = new System.Windows.Forms.TabPage();
            this.discoverMovies_groupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.discover_sortByAscDesc_comboBox = new System.Windows.Forms.ComboBox();
            this.discover_sortByMembers_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trending_tabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trending_time_comboBox = new System.Windows.Forms.ComboBox();
            this.trending_allowedMedia_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yts_tabPage = new System.Windows.Forms.TabPage();
            this.ytsSearchResults_groupBox = new System.Windows.Forms.GroupBox();
            this.ytsMovieResults_listView = new System.Windows.Forms.ListView();
            this.title_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.duration_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ytsSearchParameters_groupBox = new System.Windows.Forms.GroupBox();
            this.ytsMain_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ytsQuery_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ytsQuery_label = new System.Windows.Forms.Label();
            this.ytsQuery_textBox = new System.Windows.Forms.TextBox();
            this.ytsLimit_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ytsLimit_label = new System.Windows.Forms.Label();
            this.ytsLimit_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ytsPage_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ytsPreviousPage_button = new System.Windows.Forms.Button();
            this.ytsPage_label = new System.Windows.Forms.Label();
            this.ytsPage_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ytsNextPage_button = new System.Windows.Forms.Button();
            this.ytsQuality_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ytsQuality_label = new System.Windows.Forms.Label();
            this.ytsQuality_comboBox = new System.Windows.Forms.ComboBox();
            this.ytsMinRating_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ytsMinRating_label = new System.Windows.Forms.Label();
            this.ytsMinRating_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ytsGenre_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ytsGenre_label = new System.Windows.Forms.Label();
            this.ytsGenre_textBox = new System.Windows.Forms.TextBox();
            this.ytsSortBy_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ytsSortBy_label = new System.Windows.Forms.Label();
            this.ytsSortBy_comboBox = new System.Windows.Forms.ComboBox();
            this.ytsOrderBy_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ytsOrderBy_label = new System.Windows.Forms.Label();
            this.ytsOrderBy_comboBox = new System.Windows.Forms.ComboBox();
            this.ytsSearch_button = new System.Windows.Forms.Button();
            this.eztv_tabPage = new System.Windows.Forms.TabPage();
            this.searchEZTV_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.action_splitContainer = new System.Windows.Forms.SplitContainer();
            this.actions_groupBox = new System.Windows.Forms.GroupBox();
            this.actionsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.home_viewDetails_button = new System.Windows.Forms.Button();
            this.search_viewDetails_button = new System.Windows.Forms.Button();
            this.favoriteMediaItem_button = new System.Windows.Forms.Button();
            this.watchMediaItem_button = new System.Windows.Forms.Button();
            this.tvRefresh_button = new System.Windows.Forms.Button();
            this.movieRefresh_button = new System.Windows.Forms.Button();
            this.yts_button = new System.Windows.Forms.Button();
            this.eztv_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mediaPoster_pictureBox = new System.Windows.Forms.PictureBox();
            this.imageLoading_label = new System.Windows.Forms.Label();
            this.main_groupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trending_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.main_splitContainer)).BeginInit();
            this.main_splitContainer.Panel1.SuspendLayout();
            this.main_splitContainer.Panel2.SuspendLayout();
            this.main_splitContainer.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.home_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_lists_splitContainer)).BeginInit();
            this.home_lists_splitContainer.Panel1.SuspendLayout();
            this.home_lists_splitContainer.Panel2.SuspendLayout();
            this.home_lists_splitContainer.SuspendLayout();
            this.homeMovies_groupBox.SuspendLayout();
            this.homeTvSeries_groupBox.SuspendLayout();
            this.search_tabPage.SuspendLayout();
            this.discover_tabPage.SuspendLayout();
            this.discoverMovies_groupBox.SuspendLayout();
            this.trending_tabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.yts_tabPage.SuspendLayout();
            this.ytsSearchResults_groupBox.SuspendLayout();
            this.ytsSearchParameters_groupBox.SuspendLayout();
            this.ytsMain_flowLayoutPanel.SuspendLayout();
            this.ytsQuery_flowLayoutPanel.SuspendLayout();
            this.ytsLimit_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ytsLimit_numericUpDown)).BeginInit();
            this.ytsPage_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ytsPage_numericUpDown)).BeginInit();
            this.ytsQuality_flowLayoutPanel.SuspendLayout();
            this.ytsMinRating_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ytsMinRating_numericUpDown)).BeginInit();
            this.ytsGenre_flowLayoutPanel.SuspendLayout();
            this.ytsSortBy_flowLayoutPanel.SuspendLayout();
            this.ytsOrderBy_flowLayoutPanel.SuspendLayout();
            this.eztv_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.action_splitContainer)).BeginInit();
            this.action_splitContainer.Panel1.SuspendLayout();
            this.action_splitContainer.Panel2.SuspendLayout();
            this.action_splitContainer.SuspendLayout();
            this.actions_groupBox.SuspendLayout();
            this.actionsFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPoster_pictureBox)).BeginInit();
            this.main_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountName_label
            // 
            this.accountName_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountName_label.Location = new System.Drawing.Point(0, 0);
            this.accountName_label.Margin = new System.Windows.Forms.Padding(0);
            this.accountName_label.Name = "accountName_label";
            this.accountName_label.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.accountName_label.Size = new System.Drawing.Size(932, 31);
            this.accountName_label.TabIndex = 0;
            this.accountName_label.Text = "accountName_label";
            this.accountName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_splitContainer
            // 
            this.main_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_splitContainer.Location = new System.Drawing.Point(2, 15);
            this.main_splitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.main_splitContainer.Name = "main_splitContainer";
            // 
            // main_splitContainer.Panel1
            // 
            this.main_splitContainer.Panel1.Controls.Add(this.tabControl);
            this.main_splitContainer.Panel1.Controls.Add(this.action_splitContainer);
            // 
            // main_splitContainer.Panel2
            // 
            this.main_splitContainer.Panel2.Controls.Add(this.mediaPoster_pictureBox);
            this.main_splitContainer.Panel2.Controls.Add(this.imageLoading_label);
            this.main_splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.main_splitContainer.Panel2MinSize = 200;
            this.main_splitContainer.Size = new System.Drawing.Size(928, 457);
            this.main_splitContainer.SplitterDistance = 651;
            this.main_splitContainer.SplitterWidth = 3;
            this.main_splitContainer.TabIndex = 1;
            this.main_splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.main_splitContainer_SplitterMoved);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.home_tabPage);
            this.tabControl.Controls.Add(this.search_tabPage);
            this.tabControl.Controls.Add(this.discover_tabPage);
            this.tabControl.Controls.Add(this.trending_tabPage);
            this.tabControl.Controls.Add(this.yts_tabPage);
            this.tabControl.Controls.Add(this.eztv_tabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(651, 335);
            this.tabControl.TabIndex = 2;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // home_tabPage
            // 
            this.home_tabPage.Controls.Add(this.home_lists_splitContainer);
            this.home_tabPage.Location = new System.Drawing.Point(4, 22);
            this.home_tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.home_tabPage.Name = "home_tabPage";
            this.home_tabPage.Padding = new System.Windows.Forms.Padding(2);
            this.home_tabPage.Size = new System.Drawing.Size(643, 309);
            this.home_tabPage.TabIndex = 0;
            this.home_tabPage.Text = "Home";
            this.home_tabPage.UseVisualStyleBackColor = true;
            // 
            // home_lists_splitContainer
            // 
            this.home_lists_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_lists_splitContainer.Location = new System.Drawing.Point(2, 2);
            this.home_lists_splitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.home_lists_splitContainer.Name = "home_lists_splitContainer";
            this.home_lists_splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // home_lists_splitContainer.Panel1
            // 
            this.home_lists_splitContainer.Panel1.Controls.Add(this.homeMovies_groupBox);
            // 
            // home_lists_splitContainer.Panel2
            // 
            this.home_lists_splitContainer.Panel2.Controls.Add(this.homeTvSeries_groupBox);
            this.home_lists_splitContainer.Size = new System.Drawing.Size(639, 305);
            this.home_lists_splitContainer.SplitterDistance = 122;
            this.home_lists_splitContainer.SplitterWidth = 3;
            this.home_lists_splitContainer.TabIndex = 11;
            // 
            // homeMovies_groupBox
            // 
            this.homeMovies_groupBox.Controls.Add(this.homeMovies_listView);
            this.homeMovies_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeMovies_groupBox.Location = new System.Drawing.Point(0, 0);
            this.homeMovies_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.homeMovies_groupBox.Name = "homeMovies_groupBox";
            this.homeMovies_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.homeMovies_groupBox.Size = new System.Drawing.Size(639, 122);
            this.homeMovies_groupBox.TabIndex = 4;
            this.homeMovies_groupBox.TabStop = false;
            this.homeMovies_groupBox.Text = "Favorited/Watchlisted Movies";
            // 
            // homeMovies_listView
            // 
            this.homeMovies_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.movietitle_columnHeader,
            this.movieYear_columnHeader});
            this.homeMovies_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeMovies_listView.FullRowSelect = true;
            listViewGroup25.Header = "Favorited";
            listViewGroup25.Name = "favorited_listViewGroup";
            listViewGroup26.Header = "Watchlisted";
            listViewGroup26.Name = "watchlist_listViewGroup";
            this.homeMovies_listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup25,
            listViewGroup26});
            this.homeMovies_listView.HideSelection = false;
            this.homeMovies_listView.Location = new System.Drawing.Point(2, 15);
            this.homeMovies_listView.Margin = new System.Windows.Forms.Padding(2);
            this.homeMovies_listView.MultiSelect = false;
            this.homeMovies_listView.Name = "homeMovies_listView";
            this.homeMovies_listView.Size = new System.Drawing.Size(635, 105);
            this.homeMovies_listView.TabIndex = 0;
            this.homeMovies_listView.UseCompatibleStateImageBehavior = false;
            this.homeMovies_listView.View = System.Windows.Forms.View.Details;
            this.homeMovies_listView.SelectedIndexChanged += new System.EventHandler(this.home_listView_SelectedIndexChanged);
            // 
            // movietitle_columnHeader
            // 
            this.movietitle_columnHeader.Text = "Title";
            this.movietitle_columnHeader.Width = 280;
            // 
            // movieYear_columnHeader
            // 
            this.movieYear_columnHeader.Text = "Year";
            this.movieYear_columnHeader.Width = 100;
            // 
            // homeTvSeries_groupBox
            // 
            this.homeTvSeries_groupBox.Controls.Add(this.homeTvSeries_listView);
            this.homeTvSeries_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeTvSeries_groupBox.Location = new System.Drawing.Point(0, 0);
            this.homeTvSeries_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.homeTvSeries_groupBox.Name = "homeTvSeries_groupBox";
            this.homeTvSeries_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.homeTvSeries_groupBox.Size = new System.Drawing.Size(639, 180);
            this.homeTvSeries_groupBox.TabIndex = 5;
            this.homeTvSeries_groupBox.TabStop = false;
            this.homeTvSeries_groupBox.Text = "Favorited/Watchlisted Tv Series";
            // 
            // homeTvSeries_listView
            // 
            this.homeTvSeries_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tvtitle_columnHeader,
            this.tvYear_columnHeader});
            this.homeTvSeries_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeTvSeries_listView.FullRowSelect = true;
            listViewGroup27.Header = "Favorited";
            listViewGroup27.Name = "favorited_listViewGroup";
            listViewGroup28.Header = "Watchlisted";
            listViewGroup28.Name = "watchlisted_listViewGroup";
            this.homeTvSeries_listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup27,
            listViewGroup28});
            this.homeTvSeries_listView.HideSelection = false;
            this.homeTvSeries_listView.Location = new System.Drawing.Point(2, 15);
            this.homeTvSeries_listView.Margin = new System.Windows.Forms.Padding(2);
            this.homeTvSeries_listView.MultiSelect = false;
            this.homeTvSeries_listView.Name = "homeTvSeries_listView";
            this.homeTvSeries_listView.Size = new System.Drawing.Size(635, 163);
            this.homeTvSeries_listView.TabIndex = 0;
            this.homeTvSeries_listView.UseCompatibleStateImageBehavior = false;
            this.homeTvSeries_listView.View = System.Windows.Forms.View.Details;
            this.homeTvSeries_listView.SelectedIndexChanged += new System.EventHandler(this.home_listView_SelectedIndexChanged);
            // 
            // tvtitle_columnHeader
            // 
            this.tvtitle_columnHeader.Text = "Title";
            this.tvtitle_columnHeader.Width = 280;
            // 
            // tvYear_columnHeader
            // 
            this.tvYear_columnHeader.Text = "Year";
            this.tvYear_columnHeader.Width = 100;
            // 
            // search_tabPage
            // 
            this.search_tabPage.Controls.Add(this.searchResults_listView);
            this.search_tabPage.Controls.Add(this.search_button);
            this.search_tabPage.Controls.Add(this.searchInput_textBox);
            this.search_tabPage.Controls.Add(this.label1);
            this.search_tabPage.Location = new System.Drawing.Point(4, 22);
            this.search_tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.search_tabPage.Name = "search_tabPage";
            this.search_tabPage.Padding = new System.Windows.Forms.Padding(2);
            this.search_tabPage.Size = new System.Drawing.Size(643, 309);
            this.search_tabPage.TabIndex = 1;
            this.search_tabPage.Text = "Search";
            this.search_tabPage.UseVisualStyleBackColor = true;
            // 
            // searchResults_listView
            // 
            this.searchResults_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.searchTitle_columnHeader,
            this.searchDescription_columnHeader,
            this.searchYear_columnHeader,
            this.searchRating_columnHeader,
            this.searchMediaType_columnHeader});
            this.searchResults_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResults_listView.FullRowSelect = true;
            this.searchResults_listView.HideSelection = false;
            this.searchResults_listView.Location = new System.Drawing.Point(2, 60);
            this.searchResults_listView.Margin = new System.Windows.Forms.Padding(2);
            this.searchResults_listView.MultiSelect = false;
            this.searchResults_listView.Name = "searchResults_listView";
            this.searchResults_listView.Size = new System.Drawing.Size(639, 247);
            this.searchResults_listView.TabIndex = 11;
            this.searchResults_listView.UseCompatibleStateImageBehavior = false;
            this.searchResults_listView.View = System.Windows.Forms.View.Details;
            this.searchResults_listView.SelectedIndexChanged += new System.EventHandler(this.searchResults_listView_SelectedIndexChanged);
            // 
            // searchTitle_columnHeader
            // 
            this.searchTitle_columnHeader.Text = "Title";
            this.searchTitle_columnHeader.Width = 100;
            // 
            // searchDescription_columnHeader
            // 
            this.searchDescription_columnHeader.Text = "Description";
            this.searchDescription_columnHeader.Width = 345;
            // 
            // searchYear_columnHeader
            // 
            this.searchYear_columnHeader.Text = "Year";
            // 
            // searchRating_columnHeader
            // 
            this.searchRating_columnHeader.Text = "Rating";
            // 
            // searchMediaType_columnHeader
            // 
            this.searchMediaType_columnHeader.Text = "Media Type";
            // 
            // search_button
            // 
            this.search_button.AutoSize = true;
            this.search_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.search_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.search_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Location = new System.Drawing.Point(2, 35);
            this.search_button.Margin = new System.Windows.Forms.Padding(2);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(639, 25);
            this.search_button.TabIndex = 12;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // searchInput_textBox
            // 
            this.searchInput_textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchInput_textBox.Location = new System.Drawing.Point(2, 15);
            this.searchInput_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchInput_textBox.Name = "searchInput_textBox";
            this.searchInput_textBox.Size = new System.Drawing.Size(639, 20);
            this.searchInput_textBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input:";
            // 
            // discover_tabPage
            // 
            this.discover_tabPage.Controls.Add(this.discoverMovies_groupBox);
            this.discover_tabPage.Location = new System.Drawing.Point(4, 22);
            this.discover_tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.discover_tabPage.Name = "discover_tabPage";
            this.discover_tabPage.Size = new System.Drawing.Size(643, 309);
            this.discover_tabPage.TabIndex = 2;
            this.discover_tabPage.Text = "Discover";
            this.discover_tabPage.UseVisualStyleBackColor = true;
            // 
            // discoverMovies_groupBox
            // 
            this.discoverMovies_groupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.discoverMovies_groupBox.Controls.Add(this.textBox1);
            this.discoverMovies_groupBox.Controls.Add(this.label3);
            this.discoverMovies_groupBox.Controls.Add(this.discover_sortByAscDesc_comboBox);
            this.discoverMovies_groupBox.Controls.Add(this.discover_sortByMembers_comboBox);
            this.discoverMovies_groupBox.Controls.Add(this.label2);
            this.discoverMovies_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discoverMovies_groupBox.Location = new System.Drawing.Point(0, 0);
            this.discoverMovies_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.discoverMovies_groupBox.Name = "discoverMovies_groupBox";
            this.discoverMovies_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.discoverMovies_groupBox.Size = new System.Drawing.Size(643, 309);
            this.discoverMovies_groupBox.TabIndex = 1;
            this.discoverMovies_groupBox.TabStop = false;
            this.discoverMovies_groupBox.Text = "Discover Movies";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sort by";
            // 
            // discover_sortByAscDesc_comboBox
            // 
            this.discover_sortByAscDesc_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discover_sortByAscDesc_comboBox.FormattingEnabled = true;
            this.discover_sortByAscDesc_comboBox.Location = new System.Drawing.Point(144, 18);
            this.discover_sortByAscDesc_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.discover_sortByAscDesc_comboBox.Name = "discover_sortByAscDesc_comboBox";
            this.discover_sortByAscDesc_comboBox.Size = new System.Drawing.Size(54, 21);
            this.discover_sortByAscDesc_comboBox.TabIndex = 1;
            // 
            // discover_sortByMembers_comboBox
            // 
            this.discover_sortByMembers_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discover_sortByMembers_comboBox.FormattingEnabled = true;
            this.discover_sortByMembers_comboBox.Location = new System.Drawing.Point(49, 18);
            this.discover_sortByMembers_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.discover_sortByMembers_comboBox.Name = "discover_sortByMembers_comboBox";
            this.discover_sortByMembers_comboBox.Size = new System.Drawing.Size(92, 21);
            this.discover_sortByMembers_comboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sort by";
            // 
            // trending_tabPage
            // 
            this.trending_tabPage.Controls.Add(this.groupBox1);
            this.trending_tabPage.Location = new System.Drawing.Point(4, 22);
            this.trending_tabPage.Name = "trending_tabPage";
            this.trending_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.trending_tabPage.Size = new System.Drawing.Size(643, 309);
            this.trending_tabPage.TabIndex = 5;
            this.trending_tabPage.Text = "Trending";
            this.trending_tabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(637, 303);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trending Media";
            // 
            // trending_time_comboBox
            // 
            this.trending_time_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trending_time_comboBox.FormattingEnabled = true;
            this.trending_time_comboBox.Location = new System.Drawing.Point(91, 31);
            this.trending_time_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.trending_time_comboBox.Name = "trending_time_comboBox";
            this.trending_time_comboBox.Size = new System.Drawing.Size(54, 21);
            this.trending_time_comboBox.TabIndex = 1;
            // 
            // trending_allowedMedia_comboBox
            // 
            this.trending_allowedMedia_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trending_allowedMedia_comboBox.FormattingEnabled = true;
            this.trending_allowedMedia_comboBox.Location = new System.Drawing.Point(91, 6);
            this.trending_allowedMedia_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.trending_allowedMedia_comboBox.Name = "trending_allowedMedia_comboBox";
            this.trending_allowedMedia_comboBox.Size = new System.Drawing.Size(92, 21);
            this.trending_allowedMedia_comboBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Media Type";
            // 
            // yts_tabPage
            // 
            this.yts_tabPage.Controls.Add(this.ytsSearchResults_groupBox);
            this.yts_tabPage.Controls.Add(this.ytsSearchParameters_groupBox);
            this.yts_tabPage.Location = new System.Drawing.Point(4, 22);
            this.yts_tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.yts_tabPage.Name = "yts_tabPage";
            this.yts_tabPage.Size = new System.Drawing.Size(643, 309);
            this.yts_tabPage.TabIndex = 3;
            this.yts_tabPage.Text = "Yify";
            this.yts_tabPage.UseVisualStyleBackColor = true;
            // 
            // ytsSearchResults_groupBox
            // 
            this.ytsSearchResults_groupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsSearchResults_groupBox.Controls.Add(this.ytsMovieResults_listView);
            this.ytsSearchResults_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ytsSearchResults_groupBox.Location = new System.Drawing.Point(0, 78);
            this.ytsSearchResults_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ytsSearchResults_groupBox.Name = "ytsSearchResults_groupBox";
            this.ytsSearchResults_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ytsSearchResults_groupBox.Size = new System.Drawing.Size(643, 231);
            this.ytsSearchResults_groupBox.TabIndex = 11;
            this.ytsSearchResults_groupBox.TabStop = false;
            this.ytsSearchResults_groupBox.Text = "Search results";
            // 
            // ytsMovieResults_listView
            // 
            this.ytsMovieResults_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title_columnHeader,
            this.description_columnHeader,
            this.year_columnHeader,
            this.duration_columnHeader});
            this.ytsMovieResults_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ytsMovieResults_listView.HideSelection = false;
            this.ytsMovieResults_listView.LabelWrap = false;
            this.ytsMovieResults_listView.Location = new System.Drawing.Point(2, 15);
            this.ytsMovieResults_listView.Margin = new System.Windows.Forms.Padding(2);
            this.ytsMovieResults_listView.MultiSelect = false;
            this.ytsMovieResults_listView.Name = "ytsMovieResults_listView";
            this.ytsMovieResults_listView.Size = new System.Drawing.Size(639, 214);
            this.ytsMovieResults_listView.TabIndex = 4;
            this.ytsMovieResults_listView.UseCompatibleStateImageBehavior = false;
            this.ytsMovieResults_listView.View = System.Windows.Forms.View.Details;
            this.ytsMovieResults_listView.SelectedIndexChanged += new System.EventHandler(this.ytsMovieResults_listView_SelectedIndexChanged);
            // 
            // title_columnHeader
            // 
            this.title_columnHeader.Text = "Title";
            this.title_columnHeader.Width = 170;
            // 
            // description_columnHeader
            // 
            this.description_columnHeader.Text = "Description";
            this.description_columnHeader.Width = 410;
            // 
            // year_columnHeader
            // 
            this.year_columnHeader.Text = "Year";
            // 
            // duration_columnHeader
            // 
            this.duration_columnHeader.Text = "Duration";
            this.duration_columnHeader.Width = 75;
            // 
            // ytsSearchParameters_groupBox
            // 
            this.ytsSearchParameters_groupBox.AutoSize = true;
            this.ytsSearchParameters_groupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsSearchParameters_groupBox.Controls.Add(this.ytsMain_flowLayoutPanel);
            this.ytsSearchParameters_groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ytsSearchParameters_groupBox.Location = new System.Drawing.Point(0, 0);
            this.ytsSearchParameters_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ytsSearchParameters_groupBox.Name = "ytsSearchParameters_groupBox";
            this.ytsSearchParameters_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ytsSearchParameters_groupBox.Size = new System.Drawing.Size(643, 78);
            this.ytsSearchParameters_groupBox.TabIndex = 10;
            this.ytsSearchParameters_groupBox.TabStop = false;
            this.ytsSearchParameters_groupBox.Text = "Search parameters";
            // 
            // ytsMain_flowLayoutPanel
            // 
            this.ytsMain_flowLayoutPanel.AutoSize = true;
            this.ytsMain_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsMain_flowLayoutPanel.Controls.Add(this.ytsQuery_flowLayoutPanel);
            this.ytsMain_flowLayoutPanel.Controls.Add(this.ytsLimit_flowLayoutPanel);
            this.ytsMain_flowLayoutPanel.Controls.Add(this.ytsPage_flowLayoutPanel);
            this.ytsMain_flowLayoutPanel.Controls.Add(this.ytsQuality_flowLayoutPanel);
            this.ytsMain_flowLayoutPanel.Controls.Add(this.ytsMinRating_flowLayoutPanel);
            this.ytsMain_flowLayoutPanel.Controls.Add(this.ytsGenre_flowLayoutPanel);
            this.ytsMain_flowLayoutPanel.Controls.Add(this.ytsSortBy_flowLayoutPanel);
            this.ytsMain_flowLayoutPanel.Controls.Add(this.ytsOrderBy_flowLayoutPanel);
            this.ytsMain_flowLayoutPanel.Controls.Add(this.ytsSearch_button);
            this.ytsMain_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ytsMain_flowLayoutPanel.Location = new System.Drawing.Point(2, 15);
            this.ytsMain_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ytsMain_flowLayoutPanel.MinimumSize = new System.Drawing.Size(0, 61);
            this.ytsMain_flowLayoutPanel.Name = "ytsMain_flowLayoutPanel";
            this.ytsMain_flowLayoutPanel.Size = new System.Drawing.Size(639, 61);
            this.ytsMain_flowLayoutPanel.TabIndex = 9;
            // 
            // ytsQuery_flowLayoutPanel
            // 
            this.ytsQuery_flowLayoutPanel.AutoSize = true;
            this.ytsQuery_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsQuery_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ytsQuery_flowLayoutPanel.Controls.Add(this.ytsQuery_label);
            this.ytsQuery_flowLayoutPanel.Controls.Add(this.ytsQuery_textBox);
            this.ytsQuery_flowLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.ytsQuery_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ytsQuery_flowLayoutPanel.Name = "ytsQuery_flowLayoutPanel";
            this.ytsQuery_flowLayoutPanel.Size = new System.Drawing.Size(187, 26);
            this.ytsQuery_flowLayoutPanel.TabIndex = 11;
            // 
            // ytsQuery_label
            // 
            this.ytsQuery_label.AutoSize = true;
            this.ytsQuery_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.ytsQuery_label.Location = new System.Drawing.Point(2, 0);
            this.ytsQuery_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ytsQuery_label.Name = "ytsQuery_label";
            this.ytsQuery_label.Size = new System.Drawing.Size(35, 24);
            this.ytsQuery_label.TabIndex = 5;
            this.ytsQuery_label.Text = "Query";
            this.ytsQuery_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ytsQuery_textBox
            // 
            this.ytsQuery_textBox.Location = new System.Drawing.Point(41, 2);
            this.ytsQuery_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.ytsQuery_textBox.Name = "ytsQuery_textBox";
            this.ytsQuery_textBox.Size = new System.Drawing.Size(142, 20);
            this.ytsQuery_textBox.TabIndex = 7;
            // 
            // ytsLimit_flowLayoutPanel
            // 
            this.ytsLimit_flowLayoutPanel.AutoSize = true;
            this.ytsLimit_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsLimit_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ytsLimit_flowLayoutPanel.Controls.Add(this.ytsLimit_label);
            this.ytsLimit_flowLayoutPanel.Controls.Add(this.ytsLimit_numericUpDown);
            this.ytsLimit_flowLayoutPanel.Location = new System.Drawing.Point(193, 2);
            this.ytsLimit_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ytsLimit_flowLayoutPanel.Name = "ytsLimit_flowLayoutPanel";
            this.ytsLimit_flowLayoutPanel.Size = new System.Drawing.Size(73, 26);
            this.ytsLimit_flowLayoutPanel.TabIndex = 8;
            // 
            // ytsLimit_label
            // 
            this.ytsLimit_label.AutoSize = true;
            this.ytsLimit_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.ytsLimit_label.Location = new System.Drawing.Point(2, 0);
            this.ytsLimit_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ytsLimit_label.Name = "ytsLimit_label";
            this.ytsLimit_label.Size = new System.Drawing.Size(28, 24);
            this.ytsLimit_label.TabIndex = 5;
            this.ytsLimit_label.Text = "Limit";
            this.ytsLimit_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ytsLimit_numericUpDown
            // 
            this.ytsLimit_numericUpDown.AutoSize = true;
            this.ytsLimit_numericUpDown.Location = new System.Drawing.Point(34, 2);
            this.ytsLimit_numericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.ytsLimit_numericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ytsLimit_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ytsLimit_numericUpDown.Name = "ytsLimit_numericUpDown";
            this.ytsLimit_numericUpDown.Size = new System.Drawing.Size(35, 20);
            this.ytsLimit_numericUpDown.TabIndex = 6;
            this.ytsLimit_numericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // ytsPage_flowLayoutPanel
            // 
            this.ytsPage_flowLayoutPanel.AutoSize = true;
            this.ytsPage_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsPage_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ytsPage_flowLayoutPanel.Controls.Add(this.ytsPreviousPage_button);
            this.ytsPage_flowLayoutPanel.Controls.Add(this.ytsPage_label);
            this.ytsPage_flowLayoutPanel.Controls.Add(this.ytsPage_numericUpDown);
            this.ytsPage_flowLayoutPanel.Controls.Add(this.ytsNextPage_button);
            this.ytsPage_flowLayoutPanel.Location = new System.Drawing.Point(270, 2);
            this.ytsPage_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ytsPage_flowLayoutPanel.Name = "ytsPage_flowLayoutPanel";
            this.ytsPage_flowLayoutPanel.Size = new System.Drawing.Size(141, 26);
            this.ytsPage_flowLayoutPanel.TabIndex = 10;
            // 
            // ytsPreviousPage_button
            // 
            this.ytsPreviousPage_button.AutoSize = true;
            this.ytsPreviousPage_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsPreviousPage_button.FlatAppearance.BorderSize = 0;
            this.ytsPreviousPage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ytsPreviousPage_button.Location = new System.Drawing.Point(0, 0);
            this.ytsPreviousPage_button.Margin = new System.Windows.Forms.Padding(0);
            this.ytsPreviousPage_button.Name = "ytsPreviousPage_button";
            this.ytsPreviousPage_button.Size = new System.Drawing.Size(29, 23);
            this.ytsPreviousPage_button.TabIndex = 9;
            this.ytsPreviousPage_button.Text = "<<";
            this.ytsPreviousPage_button.UseVisualStyleBackColor = true;
            this.ytsPreviousPage_button.Click += new System.EventHandler(this.ytsPreviousPage_button_Click);
            // 
            // ytsPage_label
            // 
            this.ytsPage_label.AutoSize = true;
            this.ytsPage_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.ytsPage_label.Location = new System.Drawing.Point(31, 0);
            this.ytsPage_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ytsPage_label.Name = "ytsPage_label";
            this.ytsPage_label.Size = new System.Drawing.Size(32, 24);
            this.ytsPage_label.TabIndex = 6;
            this.ytsPage_label.Text = "Page";
            this.ytsPage_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ytsPage_numericUpDown
            // 
            this.ytsPage_numericUpDown.AutoSize = true;
            this.ytsPage_numericUpDown.Location = new System.Drawing.Point(67, 2);
            this.ytsPage_numericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.ytsPage_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ytsPage_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ytsPage_numericUpDown.Name = "ytsPage_numericUpDown";
            this.ytsPage_numericUpDown.Size = new System.Drawing.Size(41, 20);
            this.ytsPage_numericUpDown.TabIndex = 7;
            this.ytsPage_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ytsNextPage_button
            // 
            this.ytsNextPage_button.AutoSize = true;
            this.ytsNextPage_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsNextPage_button.FlatAppearance.BorderSize = 0;
            this.ytsNextPage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ytsNextPage_button.Location = new System.Drawing.Point(110, 0);
            this.ytsNextPage_button.Margin = new System.Windows.Forms.Padding(0);
            this.ytsNextPage_button.Name = "ytsNextPage_button";
            this.ytsNextPage_button.Size = new System.Drawing.Size(29, 23);
            this.ytsNextPage_button.TabIndex = 8;
            this.ytsNextPage_button.Text = ">>";
            this.ytsNextPage_button.UseVisualStyleBackColor = true;
            this.ytsNextPage_button.Click += new System.EventHandler(this.ytsNextPage_button_Click);
            // 
            // ytsQuality_flowLayoutPanel
            // 
            this.ytsQuality_flowLayoutPanel.AutoSize = true;
            this.ytsQuality_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsQuality_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ytsQuality_flowLayoutPanel.Controls.Add(this.ytsQuality_label);
            this.ytsQuality_flowLayoutPanel.Controls.Add(this.ytsQuality_comboBox);
            this.ytsQuality_flowLayoutPanel.Location = new System.Drawing.Point(415, 2);
            this.ytsQuality_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ytsQuality_flowLayoutPanel.Name = "ytsQuality_flowLayoutPanel";
            this.ytsQuality_flowLayoutPanel.Size = new System.Drawing.Size(117, 27);
            this.ytsQuality_flowLayoutPanel.TabIndex = 10;
            // 
            // ytsQuality_label
            // 
            this.ytsQuality_label.AutoSize = true;
            this.ytsQuality_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.ytsQuality_label.Location = new System.Drawing.Point(2, 0);
            this.ytsQuality_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ytsQuality_label.Name = "ytsQuality_label";
            this.ytsQuality_label.Size = new System.Drawing.Size(39, 25);
            this.ytsQuality_label.TabIndex = 5;
            this.ytsQuality_label.Text = "Quality";
            this.ytsQuality_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ytsQuality_comboBox
            // 
            this.ytsQuality_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ytsQuality_comboBox.FormattingEnabled = true;
            this.ytsQuality_comboBox.Location = new System.Drawing.Point(45, 2);
            this.ytsQuality_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ytsQuality_comboBox.Name = "ytsQuality_comboBox";
            this.ytsQuality_comboBox.Size = new System.Drawing.Size(68, 21);
            this.ytsQuality_comboBox.TabIndex = 11;
            // 
            // ytsMinRating_flowLayoutPanel
            // 
            this.ytsMinRating_flowLayoutPanel.AutoSize = true;
            this.ytsMinRating_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsMinRating_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ytsMinRating_flowLayoutPanel.Controls.Add(this.ytsMinRating_label);
            this.ytsMinRating_flowLayoutPanel.Controls.Add(this.ytsMinRating_numericUpDown);
            this.ytsMinRating_flowLayoutPanel.Location = new System.Drawing.Point(536, 2);
            this.ytsMinRating_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ytsMinRating_flowLayoutPanel.Name = "ytsMinRating_flowLayoutPanel";
            this.ytsMinRating_flowLayoutPanel.Size = new System.Drawing.Size(95, 26);
            this.ytsMinRating_flowLayoutPanel.TabIndex = 10;
            // 
            // ytsMinRating_label
            // 
            this.ytsMinRating_label.AutoSize = true;
            this.ytsMinRating_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.ytsMinRating_label.Location = new System.Drawing.Point(2, 0);
            this.ytsMinRating_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ytsMinRating_label.Name = "ytsMinRating_label";
            this.ytsMinRating_label.Size = new System.Drawing.Size(53, 24);
            this.ytsMinRating_label.TabIndex = 5;
            this.ytsMinRating_label.Text = "Min rating";
            this.ytsMinRating_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ytsMinRating_numericUpDown
            // 
            this.ytsMinRating_numericUpDown.Location = new System.Drawing.Point(59, 2);
            this.ytsMinRating_numericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.ytsMinRating_numericUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.ytsMinRating_numericUpDown.Name = "ytsMinRating_numericUpDown";
            this.ytsMinRating_numericUpDown.Size = new System.Drawing.Size(32, 20);
            this.ytsMinRating_numericUpDown.TabIndex = 6;
            // 
            // ytsGenre_flowLayoutPanel
            // 
            this.ytsGenre_flowLayoutPanel.AutoSize = true;
            this.ytsGenre_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsGenre_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ytsGenre_flowLayoutPanel.Controls.Add(this.ytsGenre_label);
            this.ytsGenre_flowLayoutPanel.Controls.Add(this.ytsGenre_textBox);
            this.ytsGenre_flowLayoutPanel.Location = new System.Drawing.Point(2, 33);
            this.ytsGenre_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ytsGenre_flowLayoutPanel.Name = "ytsGenre_flowLayoutPanel";
            this.ytsGenre_flowLayoutPanel.Size = new System.Drawing.Size(112, 26);
            this.ytsGenre_flowLayoutPanel.TabIndex = 12;
            // 
            // ytsGenre_label
            // 
            this.ytsGenre_label.AutoSize = true;
            this.ytsGenre_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.ytsGenre_label.Location = new System.Drawing.Point(2, 0);
            this.ytsGenre_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ytsGenre_label.Name = "ytsGenre_label";
            this.ytsGenre_label.Size = new System.Drawing.Size(36, 24);
            this.ytsGenre_label.TabIndex = 5;
            this.ytsGenre_label.Text = "Genre";
            this.ytsGenre_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ytsGenre_textBox
            // 
            this.ytsGenre_textBox.Location = new System.Drawing.Point(42, 2);
            this.ytsGenre_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.ytsGenre_textBox.Name = "ytsGenre_textBox";
            this.ytsGenre_textBox.Size = new System.Drawing.Size(66, 20);
            this.ytsGenre_textBox.TabIndex = 13;
            this.ytsGenre_textBox.Text = "All";
            // 
            // ytsSortBy_flowLayoutPanel
            // 
            this.ytsSortBy_flowLayoutPanel.AutoSize = true;
            this.ytsSortBy_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsSortBy_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ytsSortBy_flowLayoutPanel.Controls.Add(this.ytsSortBy_label);
            this.ytsSortBy_flowLayoutPanel.Controls.Add(this.ytsSortBy_comboBox);
            this.ytsSortBy_flowLayoutPanel.Location = new System.Drawing.Point(118, 33);
            this.ytsSortBy_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ytsSortBy_flowLayoutPanel.Name = "ytsSortBy_flowLayoutPanel";
            this.ytsSortBy_flowLayoutPanel.Size = new System.Drawing.Size(135, 27);
            this.ytsSortBy_flowLayoutPanel.TabIndex = 11;
            // 
            // ytsSortBy_label
            // 
            this.ytsSortBy_label.AutoSize = true;
            this.ytsSortBy_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.ytsSortBy_label.Location = new System.Drawing.Point(2, 0);
            this.ytsSortBy_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ytsSortBy_label.Name = "ytsSortBy_label";
            this.ytsSortBy_label.Size = new System.Drawing.Size(40, 25);
            this.ytsSortBy_label.TabIndex = 5;
            this.ytsSortBy_label.Text = "Sort by";
            this.ytsSortBy_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ytsSortBy_comboBox
            // 
            this.ytsSortBy_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ytsSortBy_comboBox.FormattingEnabled = true;
            this.ytsSortBy_comboBox.Location = new System.Drawing.Point(46, 2);
            this.ytsSortBy_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ytsSortBy_comboBox.Name = "ytsSortBy_comboBox";
            this.ytsSortBy_comboBox.Size = new System.Drawing.Size(85, 21);
            this.ytsSortBy_comboBox.TabIndex = 11;
            // 
            // ytsOrderBy_flowLayoutPanel
            // 
            this.ytsOrderBy_flowLayoutPanel.AutoSize = true;
            this.ytsOrderBy_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsOrderBy_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ytsOrderBy_flowLayoutPanel.Controls.Add(this.ytsOrderBy_label);
            this.ytsOrderBy_flowLayoutPanel.Controls.Add(this.ytsOrderBy_comboBox);
            this.ytsOrderBy_flowLayoutPanel.Location = new System.Drawing.Point(257, 33);
            this.ytsOrderBy_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ytsOrderBy_flowLayoutPanel.Name = "ytsOrderBy_flowLayoutPanel";
            this.ytsOrderBy_flowLayoutPanel.Size = new System.Drawing.Size(135, 27);
            this.ytsOrderBy_flowLayoutPanel.TabIndex = 12;
            // 
            // ytsOrderBy_label
            // 
            this.ytsOrderBy_label.AutoSize = true;
            this.ytsOrderBy_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.ytsOrderBy_label.Location = new System.Drawing.Point(2, 0);
            this.ytsOrderBy_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ytsOrderBy_label.Name = "ytsOrderBy_label";
            this.ytsOrderBy_label.Size = new System.Drawing.Size(47, 25);
            this.ytsOrderBy_label.TabIndex = 5;
            this.ytsOrderBy_label.Text = "Order by";
            this.ytsOrderBy_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ytsOrderBy_comboBox
            // 
            this.ytsOrderBy_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ytsOrderBy_comboBox.FormattingEnabled = true;
            this.ytsOrderBy_comboBox.Location = new System.Drawing.Point(53, 2);
            this.ytsOrderBy_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ytsOrderBy_comboBox.Name = "ytsOrderBy_comboBox";
            this.ytsOrderBy_comboBox.Size = new System.Drawing.Size(78, 21);
            this.ytsOrderBy_comboBox.TabIndex = 11;
            // 
            // ytsSearch_button
            // 
            this.ytsSearch_button.AutoSize = true;
            this.ytsSearch_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsSearch_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ytsSearch_button.Location = new System.Drawing.Point(394, 33);
            this.ytsSearch_button.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.ytsSearch_button.Name = "ytsSearch_button";
            this.ytsSearch_button.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.ytsSearch_button.Size = new System.Drawing.Size(79, 26);
            this.ytsSearch_button.TabIndex = 13;
            this.ytsSearch_button.Text = "Search YIFY";
            this.ytsSearch_button.UseVisualStyleBackColor = true;
            this.ytsSearch_button.Click += new System.EventHandler(this.ytsSearch_button_Click);
            // 
            // eztv_tabPage
            // 
            this.eztv_tabPage.Controls.Add(this.searchEZTV_button);
            this.eztv_tabPage.Controls.Add(this.textBox2);
            this.eztv_tabPage.Controls.Add(this.label4);
            this.eztv_tabPage.Location = new System.Drawing.Point(4, 22);
            this.eztv_tabPage.Name = "eztv_tabPage";
            this.eztv_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.eztv_tabPage.Size = new System.Drawing.Size(643, 309);
            this.eztv_tabPage.TabIndex = 4;
            this.eztv_tabPage.Text = "EZTV";
            this.eztv_tabPage.UseVisualStyleBackColor = true;
            // 
            // searchEZTV_button
            // 
            this.searchEZTV_button.AutoSize = true;
            this.searchEZTV_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchEZTV_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchEZTV_button.Location = new System.Drawing.Point(185, 5);
            this.searchEZTV_button.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.searchEZTV_button.Name = "searchEZTV_button";
            this.searchEZTV_button.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.searchEZTV_button.Size = new System.Drawing.Size(84, 26);
            this.searchEZTV_button.TabIndex = 14;
            this.searchEZTV_button.Text = "Search EZTV";
            this.searchEZTV_button.UseVisualStyleBackColor = true;
            this.searchEZTV_button.Click += new System.EventHandler(this.searchEZTV_button_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 9);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Query";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // action_splitContainer
            // 
            this.action_splitContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.action_splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.action_splitContainer.Location = new System.Drawing.Point(0, 335);
            this.action_splitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.action_splitContainer.Name = "action_splitContainer";
            // 
            // action_splitContainer.Panel1
            // 
            this.action_splitContainer.Panel1.Controls.Add(this.actions_groupBox);
            // 
            // action_splitContainer.Panel2
            // 
            this.action_splitContainer.Panel2.Controls.Add(this.pictureBox1);
            this.action_splitContainer.Size = new System.Drawing.Size(651, 122);
            this.action_splitContainer.SplitterDistance = 521;
            this.action_splitContainer.SplitterWidth = 3;
            this.action_splitContainer.TabIndex = 12;
            // 
            // actions_groupBox
            // 
            this.actions_groupBox.Controls.Add(this.actionsFlowLayoutPanel);
            this.actions_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actions_groupBox.Location = new System.Drawing.Point(0, 0);
            this.actions_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.actions_groupBox.Name = "actions_groupBox";
            this.actions_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.actions_groupBox.Size = new System.Drawing.Size(521, 122);
            this.actions_groupBox.TabIndex = 5;
            this.actions_groupBox.TabStop = false;
            this.actions_groupBox.Text = "Actions";
            // 
            // actionsFlowLayoutPanel
            // 
            this.actionsFlowLayoutPanel.AutoSize = true;
            this.actionsFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.actionsFlowLayoutPanel.Controls.Add(this.home_viewDetails_button);
            this.actionsFlowLayoutPanel.Controls.Add(this.search_viewDetails_button);
            this.actionsFlowLayoutPanel.Controls.Add(this.favoriteMediaItem_button);
            this.actionsFlowLayoutPanel.Controls.Add(this.watchMediaItem_button);
            this.actionsFlowLayoutPanel.Controls.Add(this.tvRefresh_button);
            this.actionsFlowLayoutPanel.Controls.Add(this.movieRefresh_button);
            this.actionsFlowLayoutPanel.Controls.Add(this.yts_button);
            this.actionsFlowLayoutPanel.Controls.Add(this.eztv_button);
            this.actionsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.actionsFlowLayoutPanel.Location = new System.Drawing.Point(2, 15);
            this.actionsFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.actionsFlowLayoutPanel.Name = "actionsFlowLayoutPanel";
            this.actionsFlowLayoutPanel.Size = new System.Drawing.Size(517, 105);
            this.actionsFlowLayoutPanel.TabIndex = 1;
            // 
            // home_viewDetails_button
            // 
            this.home_viewDetails_button.AutoSize = true;
            this.home_viewDetails_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.home_viewDetails_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.home_viewDetails_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.home_viewDetails_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.home_viewDetails_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_viewDetails_button.Location = new System.Drawing.Point(2, 2);
            this.home_viewDetails_button.Margin = new System.Windows.Forms.Padding(2);
            this.home_viewDetails_button.Name = "home_viewDetails_button";
            this.home_viewDetails_button.Size = new System.Drawing.Size(141, 25);
            this.home_viewDetails_button.TabIndex = 0;
            this.home_viewDetails_button.Text = "home_viewDetails_button";
            this.home_viewDetails_button.UseVisualStyleBackColor = true;
            this.home_viewDetails_button.Click += new System.EventHandler(this.viewDetails_button_Click);
            // 
            // search_viewDetails_button
            // 
            this.search_viewDetails_button.AutoSize = true;
            this.search_viewDetails_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search_viewDetails_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.search_viewDetails_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.search_viewDetails_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.search_viewDetails_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_viewDetails_button.Location = new System.Drawing.Point(2, 31);
            this.search_viewDetails_button.Margin = new System.Windows.Forms.Padding(2);
            this.search_viewDetails_button.Name = "search_viewDetails_button";
            this.search_viewDetails_button.Size = new System.Drawing.Size(147, 25);
            this.search_viewDetails_button.TabIndex = 7;
            this.search_viewDetails_button.Text = "search_viewDetails_button";
            this.search_viewDetails_button.UseVisualStyleBackColor = true;
            this.search_viewDetails_button.Click += new System.EventHandler(this.viewDetails_button_Click);
            // 
            // favoriteMediaItem_button
            // 
            this.favoriteMediaItem_button.AutoSize = true;
            this.favoriteMediaItem_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.favoriteMediaItem_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.favoriteMediaItem_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.favoriteMediaItem_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.favoriteMediaItem_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favoriteMediaItem_button.Location = new System.Drawing.Point(2, 60);
            this.favoriteMediaItem_button.Margin = new System.Windows.Forms.Padding(2);
            this.favoriteMediaItem_button.Name = "favoriteMediaItem_button";
            this.favoriteMediaItem_button.Size = new System.Drawing.Size(139, 25);
            this.favoriteMediaItem_button.TabIndex = 1;
            this.favoriteMediaItem_button.Text = "favoriteMediaItem_button";
            this.favoriteMediaItem_button.UseVisualStyleBackColor = true;
            this.favoriteMediaItem_button.Click += new System.EventHandler(this.favoriteMediaItem_button_Click);
            // 
            // watchMediaItem_button
            // 
            this.watchMediaItem_button.AutoSize = true;
            this.watchMediaItem_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.watchMediaItem_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.watchMediaItem_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.watchMediaItem_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.watchMediaItem_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchMediaItem_button.Location = new System.Drawing.Point(153, 2);
            this.watchMediaItem_button.Margin = new System.Windows.Forms.Padding(2);
            this.watchMediaItem_button.Name = "watchMediaItem_button";
            this.watchMediaItem_button.Size = new System.Drawing.Size(133, 25);
            this.watchMediaItem_button.TabIndex = 4;
            this.watchMediaItem_button.Text = "watchMediaItem_button";
            this.watchMediaItem_button.UseVisualStyleBackColor = true;
            this.watchMediaItem_button.Click += new System.EventHandler(this.watchMediaItem_button_Click);
            // 
            // tvRefresh_button
            // 
            this.tvRefresh_button.AutoSize = true;
            this.tvRefresh_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tvRefresh_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tvRefresh_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.tvRefresh_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.tvRefresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tvRefresh_button.Location = new System.Drawing.Point(153, 31);
            this.tvRefresh_button.Margin = new System.Windows.Forms.Padding(2);
            this.tvRefresh_button.Name = "tvRefresh_button";
            this.tvRefresh_button.Size = new System.Drawing.Size(133, 25);
            this.tvRefresh_button.TabIndex = 0;
            this.tvRefresh_button.Text = "watchlistRefresh_button";
            this.tvRefresh_button.UseVisualStyleBackColor = true;
            this.tvRefresh_button.Click += new System.EventHandler(this.refreshWatchlist_button_Click);
            // 
            // movieRefresh_button
            // 
            this.movieRefresh_button.AutoSize = true;
            this.movieRefresh_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.movieRefresh_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.movieRefresh_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.movieRefresh_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.movieRefresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movieRefresh_button.Location = new System.Drawing.Point(153, 60);
            this.movieRefresh_button.Margin = new System.Windows.Forms.Padding(2);
            this.movieRefresh_button.Name = "movieRefresh_button";
            this.movieRefresh_button.Size = new System.Drawing.Size(132, 25);
            this.movieRefresh_button.TabIndex = 6;
            this.movieRefresh_button.Text = "favoritesRefresh_button";
            this.movieRefresh_button.UseVisualStyleBackColor = true;
            this.movieRefresh_button.Click += new System.EventHandler(this.moviesRefresh_button_Click);
            // 
            // yts_button
            // 
            this.yts_button.AutoSize = true;
            this.yts_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yts_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.yts_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.yts_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.yts_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yts_button.Location = new System.Drawing.Point(290, 2);
            this.yts_button.Margin = new System.Windows.Forms.Padding(2);
            this.yts_button.Name = "yts_button";
            this.yts_button.Size = new System.Drawing.Size(68, 25);
            this.yts_button.TabIndex = 5;
            this.yts_button.Text = "yts_button";
            this.yts_button.UseVisualStyleBackColor = true;
            this.yts_button.Click += new System.EventHandler(this.yts_button_Click);
            // 
            // eztv_button
            // 
            this.eztv_button.AutoSize = true;
            this.eztv_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eztv_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.eztv_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.eztv_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.eztv_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eztv_button.Location = new System.Drawing.Point(290, 31);
            this.eztv_button.Margin = new System.Windows.Forms.Padding(2);
            this.eztv_button.Name = "eztv_button";
            this.eztv_button.Size = new System.Drawing.Size(75, 25);
            this.eztv_button.TabIndex = 8;
            this.eztv_button.Text = "eztv_button";
            this.eztv_button.UseVisualStyleBackColor = true;
            this.eztv_button.Click += new System.EventHandler(this.eztv_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::View_Account.Properties.Resources.PoweredByTMDb_SquareGreen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mediaPoster_pictureBox
            // 
            this.mediaPoster_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.mediaPoster_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mediaPoster_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mediaPoster_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaPoster_pictureBox.Location = new System.Drawing.Point(8, 16);
            this.mediaPoster_pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.mediaPoster_pictureBox.Name = "mediaPoster_pictureBox";
            this.mediaPoster_pictureBox.Size = new System.Drawing.Size(258, 441);
            this.mediaPoster_pictureBox.TabIndex = 4;
            this.mediaPoster_pictureBox.TabStop = false;
            // 
            // imageLoading_label
            // 
            this.imageLoading_label.BackColor = System.Drawing.Color.Transparent;
            this.imageLoading_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageLoading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLoading_label.Location = new System.Drawing.Point(8, 0);
            this.imageLoading_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imageLoading_label.Name = "imageLoading_label";
            this.imageLoading_label.Size = new System.Drawing.Size(258, 16);
            this.imageLoading_label.TabIndex = 5;
            this.imageLoading_label.Text = "imageLoading_label";
            this.imageLoading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_groupBox
            // 
            this.main_groupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.main_groupBox.Controls.Add(this.main_splitContainer);
            this.main_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_groupBox.Location = new System.Drawing.Point(0, 31);
            this.main_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.main_groupBox.Name = "main_groupBox";
            this.main_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.main_groupBox.Size = new System.Drawing.Size(932, 474);
            this.main_groupBox.TabIndex = 2;
            this.main_groupBox.TabStop = false;
            this.main_groupBox.Text = "main_groupBox";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Time Window";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 15);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.trending_allowedMedia_comboBox);
            this.splitContainer1.Panel1.Controls.Add(this.trending_time_comboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.trending_listView);
            this.splitContainer1.Size = new System.Drawing.Size(633, 286);
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.TabIndex = 4;
            // 
            // trending_listView
            // 
            this.trending_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.trending_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trending_listView.FullRowSelect = true;
            this.trending_listView.HideSelection = false;
            this.trending_listView.Location = new System.Drawing.Point(0, 0);
            this.trending_listView.Margin = new System.Windows.Forms.Padding(2);
            this.trending_listView.MultiSelect = false;
            this.trending_listView.Name = "trending_listView";
            this.trending_listView.Size = new System.Drawing.Size(633, 222);
            this.trending_listView.TabIndex = 12;
            this.trending_listView.UseCompatibleStateImageBehavior = false;
            this.trending_listView.View = System.Windows.Forms.View.Details;
            this.trending_listView.SelectedIndexChanged += new System.EventHandler(this.trending_listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 345;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Year";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rating";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Media Type";
            // 
            // viewAccount_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 505);
            this.Controls.Add(this.main_groupBox);
            this.Controls.Add(this.accountName_label);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "viewAccount_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Account";
            this.Load += new System.EventHandler(this.viewAccount_Form_Load);
            this.ResizeBegin += new System.EventHandler(this.viewAccount_Form_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.viewAccount_Form_ResizeEnd);
            this.Resize += new System.EventHandler(this.viewAccount_Form_Resize);
            this.main_splitContainer.Panel1.ResumeLayout(false);
            this.main_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_splitContainer)).EndInit();
            this.main_splitContainer.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.home_tabPage.ResumeLayout(false);
            this.home_lists_splitContainer.Panel1.ResumeLayout(false);
            this.home_lists_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.home_lists_splitContainer)).EndInit();
            this.home_lists_splitContainer.ResumeLayout(false);
            this.homeMovies_groupBox.ResumeLayout(false);
            this.homeTvSeries_groupBox.ResumeLayout(false);
            this.search_tabPage.ResumeLayout(false);
            this.search_tabPage.PerformLayout();
            this.discover_tabPage.ResumeLayout(false);
            this.discoverMovies_groupBox.ResumeLayout(false);
            this.discoverMovies_groupBox.PerformLayout();
            this.trending_tabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.yts_tabPage.ResumeLayout(false);
            this.yts_tabPage.PerformLayout();
            this.ytsSearchResults_groupBox.ResumeLayout(false);
            this.ytsSearchParameters_groupBox.ResumeLayout(false);
            this.ytsSearchParameters_groupBox.PerformLayout();
            this.ytsMain_flowLayoutPanel.ResumeLayout(false);
            this.ytsMain_flowLayoutPanel.PerformLayout();
            this.ytsQuery_flowLayoutPanel.ResumeLayout(false);
            this.ytsQuery_flowLayoutPanel.PerformLayout();
            this.ytsLimit_flowLayoutPanel.ResumeLayout(false);
            this.ytsLimit_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ytsLimit_numericUpDown)).EndInit();
            this.ytsPage_flowLayoutPanel.ResumeLayout(false);
            this.ytsPage_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ytsPage_numericUpDown)).EndInit();
            this.ytsQuality_flowLayoutPanel.ResumeLayout(false);
            this.ytsQuality_flowLayoutPanel.PerformLayout();
            this.ytsMinRating_flowLayoutPanel.ResumeLayout(false);
            this.ytsMinRating_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ytsMinRating_numericUpDown)).EndInit();
            this.ytsGenre_flowLayoutPanel.ResumeLayout(false);
            this.ytsGenre_flowLayoutPanel.PerformLayout();
            this.ytsSortBy_flowLayoutPanel.ResumeLayout(false);
            this.ytsSortBy_flowLayoutPanel.PerformLayout();
            this.ytsOrderBy_flowLayoutPanel.ResumeLayout(false);
            this.ytsOrderBy_flowLayoutPanel.PerformLayout();
            this.eztv_tabPage.ResumeLayout(false);
            this.eztv_tabPage.PerformLayout();
            this.action_splitContainer.Panel1.ResumeLayout(false);
            this.action_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.action_splitContainer)).EndInit();
            this.action_splitContainer.ResumeLayout(false);
            this.actions_groupBox.ResumeLayout(false);
            this.actions_groupBox.PerformLayout();
            this.actionsFlowLayoutPanel.ResumeLayout(false);
            this.actionsFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPoster_pictureBox)).EndInit();
            this.main_groupBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label accountName_label;
        private System.Windows.Forms.SplitContainer main_splitContainer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage home_tabPage;
        private System.Windows.Forms.TabPage search_tabPage;
        private System.Windows.Forms.Button watchMediaItem_button;
        private System.Windows.Forms.Button favoriteMediaItem_button;
        private System.Windows.Forms.Button home_viewDetails_button;
        private System.Windows.Forms.TabPage discover_tabPage;
        private System.Windows.Forms.GroupBox discoverMovies_groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox discover_sortByAscDesc_comboBox;
        private System.Windows.Forms.ComboBox discover_sortByMembers_comboBox;
        private System.Windows.Forms.PictureBox mediaPoster_pictureBox;
        private System.Windows.Forms.Label imageLoading_label;
        private System.Windows.Forms.GroupBox main_groupBox;
        private System.Windows.Forms.Button yts_button;
        private System.Windows.Forms.SplitContainer action_splitContainer;
        private System.Windows.Forms.GroupBox actions_groupBox;
        private System.Windows.Forms.Button tvRefresh_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel actionsFlowLayoutPanel;
        private System.Windows.Forms.ListView searchResults_listView;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox searchInput_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer home_lists_splitContainer;
        private System.Windows.Forms.GroupBox homeMovies_groupBox;
        private System.Windows.Forms.ListView homeMovies_listView;
        private System.Windows.Forms.GroupBox homeTvSeries_groupBox;
        private System.Windows.Forms.ListView homeTvSeries_listView;
        private System.Windows.Forms.Button movieRefresh_button;
        private System.Windows.Forms.Button search_viewDetails_button;
        private System.Windows.Forms.ColumnHeader searchTitle_columnHeader;
        private System.Windows.Forms.ColumnHeader searchDescription_columnHeader;
        private System.Windows.Forms.ColumnHeader searchYear_columnHeader;
        private System.Windows.Forms.ColumnHeader searchRating_columnHeader;
        private System.Windows.Forms.ColumnHeader searchMediaType_columnHeader;
        private System.Windows.Forms.ColumnHeader movietitle_columnHeader;
        private System.Windows.Forms.ColumnHeader tvtitle_columnHeader;
        private System.Windows.Forms.ColumnHeader movieYear_columnHeader;
        private System.Windows.Forms.ColumnHeader tvYear_columnHeader;
        private System.Windows.Forms.TabPage yts_tabPage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel ytsGenre_flowLayoutPanel;
        private System.Windows.Forms.Label ytsGenre_label;
        private System.Windows.Forms.FlowLayoutPanel ytsMain_flowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ytsLimit_flowLayoutPanel;
        private System.Windows.Forms.Label ytsLimit_label;
        private System.Windows.Forms.NumericUpDown ytsLimit_numericUpDown;
        private System.Windows.Forms.FlowLayoutPanel ytsPage_flowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ytsQuery_flowLayoutPanel;
        private System.Windows.Forms.Label ytsQuery_label;
        private System.Windows.Forms.TextBox ytsQuery_textBox;
        private System.Windows.Forms.FlowLayoutPanel ytsQuality_flowLayoutPanel;
        private System.Windows.Forms.Label ytsQuality_label;
        private System.Windows.Forms.ComboBox ytsQuality_comboBox;
        private System.Windows.Forms.FlowLayoutPanel ytsMinRating_flowLayoutPanel;
        private System.Windows.Forms.Label ytsMinRating_label;
        private System.Windows.Forms.NumericUpDown ytsMinRating_numericUpDown;
        private System.Windows.Forms.TextBox ytsGenre_textBox;
        private System.Windows.Forms.GroupBox ytsSearchResults_groupBox;
        private System.Windows.Forms.GroupBox ytsSearchParameters_groupBox;
        private System.Windows.Forms.FlowLayoutPanel ytsSortBy_flowLayoutPanel;
        private System.Windows.Forms.Label ytsSortBy_label;
        private System.Windows.Forms.ComboBox ytsSortBy_comboBox;
        private System.Windows.Forms.FlowLayoutPanel ytsOrderBy_flowLayoutPanel;
        private System.Windows.Forms.Label ytsOrderBy_label;
        private System.Windows.Forms.ComboBox ytsOrderBy_comboBox;
        private System.Windows.Forms.Button ytsSearch_button;
        private System.Windows.Forms.ListView ytsMovieResults_listView;
        private System.Windows.Forms.ColumnHeader title_columnHeader;
        private System.Windows.Forms.ColumnHeader description_columnHeader;
        private System.Windows.Forms.ColumnHeader year_columnHeader;
        private System.Windows.Forms.ColumnHeader duration_columnHeader;
        private System.Windows.Forms.TabPage eztv_tabPage;
        private System.Windows.Forms.Button searchEZTV_button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button eztv_button;
        private System.Windows.Forms.Button ytsPreviousPage_button;
        private System.Windows.Forms.Label ytsPage_label;
        private System.Windows.Forms.NumericUpDown ytsPage_numericUpDown;
        private System.Windows.Forms.Button ytsNextPage_button;
        private System.Windows.Forms.TabPage trending_tabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox trending_time_comboBox;
        private System.Windows.Forms.ComboBox trending_allowedMedia_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView trending_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

