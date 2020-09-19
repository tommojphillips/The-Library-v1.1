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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Favorited", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Watchlisted", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Favorited", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Watchlisted", System.Windows.Forms.HorizontalAlignment.Left);
            this.accountName_label = new System.Windows.Forms.Label();
            this.main_splitContainer = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.home_tabPage = new System.Windows.Forms.TabPage();
            this.home_lists_splitContainer = new System.Windows.Forms.SplitContainer();
            this.homeMovies_groupBox = new System.Windows.Forms.GroupBox();
            this.homeMovies_listView = new System.Windows.Forms.ListView();
            this.movietitle_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.homeTvSeries_groupBox = new System.Windows.Forms.GroupBox();
            this.homeTvSeries_listView = new System.Windows.Forms.ListView();
            this.tvtitle_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.discover_main_splitContainer = new System.Windows.Forms.SplitContainer();
            this.discoverMovies_groupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.discover_sortByAscDesc_comboBox = new System.Windows.Forms.ComboBox();
            this.discover_sortByMembers_comboBox = new System.Windows.Forms.ComboBox();
            this.discoverTvSeries_groupBox = new System.Windows.Forms.GroupBox();
            this.action_splitContainer = new System.Windows.Forms.SplitContainer();
            this.actions_groupBox = new System.Windows.Forms.GroupBox();
            this.actionsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.home_viewDetails_button = new System.Windows.Forms.Button();
            this.search_viewDetails_button = new System.Windows.Forms.Button();
            this.favoriteMediaItem_button = new System.Windows.Forms.Button();
            this.watchMediaItem_button = new System.Windows.Forms.Button();
            this.watchlistRefresh_button = new System.Windows.Forms.Button();
            this.favoritesRefresh_button = new System.Windows.Forms.Button();
            this.yts_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mediaPoster_pictureBox = new System.Windows.Forms.PictureBox();
            this.imageLoading_label = new System.Windows.Forms.Label();
            this.main_groupBox = new System.Windows.Forms.GroupBox();
            this.movieYear_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvYear_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            ((System.ComponentModel.ISupportInitialize)(this.discover_main_splitContainer)).BeginInit();
            this.discover_main_splitContainer.Panel1.SuspendLayout();
            this.discover_main_splitContainer.Panel2.SuspendLayout();
            this.discover_main_splitContainer.SuspendLayout();
            this.discoverMovies_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.action_splitContainer)).BeginInit();
            this.action_splitContainer.Panel1.SuspendLayout();
            this.action_splitContainer.Panel2.SuspendLayout();
            this.action_splitContainer.SuspendLayout();
            this.actions_groupBox.SuspendLayout();
            this.actionsFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPoster_pictureBox)).BeginInit();
            this.main_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountName_label
            // 
            this.accountName_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountName_label.Location = new System.Drawing.Point(0, 0);
            this.accountName_label.Margin = new System.Windows.Forms.Padding(0);
            this.accountName_label.Name = "accountName_label";
            this.accountName_label.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.accountName_label.Size = new System.Drawing.Size(1243, 40);
            this.accountName_label.TabIndex = 0;
            this.accountName_label.Text = "accountName_label";
            this.accountName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_splitContainer
            // 
            this.main_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_splitContainer.Location = new System.Drawing.Point(3, 19);
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
            this.main_splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.main_splitContainer.Panel2MinSize = 200;
            this.main_splitContainer.Size = new System.Drawing.Size(1237, 599);
            this.main_splitContainer.SplitterDistance = 868;
            this.main_splitContainer.TabIndex = 1;
            this.main_splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.main_splitContainer_SplitterMoved);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.home_tabPage);
            this.tabControl.Controls.Add(this.search_tabPage);
            this.tabControl.Controls.Add(this.discover_tabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(868, 439);
            this.tabControl.TabIndex = 2;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // home_tabPage
            // 
            this.home_tabPage.Controls.Add(this.home_lists_splitContainer);
            this.home_tabPage.Location = new System.Drawing.Point(4, 26);
            this.home_tabPage.Name = "home_tabPage";
            this.home_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.home_tabPage.Size = new System.Drawing.Size(860, 409);
            this.home_tabPage.TabIndex = 0;
            this.home_tabPage.Text = "Home";
            this.home_tabPage.UseVisualStyleBackColor = true;
            // 
            // home_lists_splitContainer
            // 
            this.home_lists_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_lists_splitContainer.Location = new System.Drawing.Point(3, 3);
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
            this.home_lists_splitContainer.Size = new System.Drawing.Size(854, 403);
            this.home_lists_splitContainer.SplitterDistance = 162;
            this.home_lists_splitContainer.TabIndex = 11;
            // 
            // homeMovies_groupBox
            // 
            this.homeMovies_groupBox.Controls.Add(this.homeMovies_listView);
            this.homeMovies_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeMovies_groupBox.Location = new System.Drawing.Point(0, 0);
            this.homeMovies_groupBox.Name = "homeMovies_groupBox";
            this.homeMovies_groupBox.Size = new System.Drawing.Size(854, 162);
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
            listViewGroup1.Header = "Favorited";
            listViewGroup1.Name = "favorited_listViewGroup";
            listViewGroup2.Header = "Watchlisted";
            listViewGroup2.Name = "watchlist_listViewGroup";
            this.homeMovies_listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.homeMovies_listView.HideSelection = false;
            this.homeMovies_listView.Location = new System.Drawing.Point(3, 19);
            this.homeMovies_listView.MultiSelect = false;
            this.homeMovies_listView.Name = "homeMovies_listView";
            this.homeMovies_listView.Size = new System.Drawing.Size(848, 140);
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
            // homeTvSeries_groupBox
            // 
            this.homeTvSeries_groupBox.Controls.Add(this.homeTvSeries_listView);
            this.homeTvSeries_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeTvSeries_groupBox.Location = new System.Drawing.Point(0, 0);
            this.homeTvSeries_groupBox.Name = "homeTvSeries_groupBox";
            this.homeTvSeries_groupBox.Size = new System.Drawing.Size(854, 237);
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
            listViewGroup3.Header = "Favorited";
            listViewGroup3.Name = "favorited_listViewGroup";
            listViewGroup4.Header = "Watchlisted";
            listViewGroup4.Name = "watchlisted_listViewGroup";
            this.homeTvSeries_listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.homeTvSeries_listView.HideSelection = false;
            this.homeTvSeries_listView.Location = new System.Drawing.Point(3, 19);
            this.homeTvSeries_listView.MultiSelect = false;
            this.homeTvSeries_listView.Name = "homeTvSeries_listView";
            this.homeTvSeries_listView.Size = new System.Drawing.Size(848, 215);
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
            // search_tabPage
            // 
            this.search_tabPage.Controls.Add(this.searchResults_listView);
            this.search_tabPage.Controls.Add(this.search_button);
            this.search_tabPage.Controls.Add(this.searchInput_textBox);
            this.search_tabPage.Controls.Add(this.label1);
            this.search_tabPage.Location = new System.Drawing.Point(4, 26);
            this.search_tabPage.Name = "search_tabPage";
            this.search_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.search_tabPage.Size = new System.Drawing.Size(860, 409);
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
            this.searchResults_listView.Location = new System.Drawing.Point(3, 72);
            this.searchResults_listView.MultiSelect = false;
            this.searchResults_listView.Name = "searchResults_listView";
            this.searchResults_listView.Size = new System.Drawing.Size(854, 334);
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
            this.search_button.Location = new System.Drawing.Point(3, 43);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(854, 29);
            this.search_button.TabIndex = 12;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // searchInput_textBox
            // 
            this.searchInput_textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchInput_textBox.Location = new System.Drawing.Point(3, 20);
            this.searchInput_textBox.Name = "searchInput_textBox";
            this.searchInput_textBox.Size = new System.Drawing.Size(854, 23);
            this.searchInput_textBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input:";
            // 
            // discover_tabPage
            // 
            this.discover_tabPage.Controls.Add(this.discover_main_splitContainer);
            this.discover_tabPage.Location = new System.Drawing.Point(4, 25);
            this.discover_tabPage.Name = "discover_tabPage";
            this.discover_tabPage.Size = new System.Drawing.Size(860, 410);
            this.discover_tabPage.TabIndex = 2;
            this.discover_tabPage.Text = "Discover";
            this.discover_tabPage.UseVisualStyleBackColor = true;
            // 
            // discover_main_splitContainer
            // 
            this.discover_main_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discover_main_splitContainer.Location = new System.Drawing.Point(0, 0);
            this.discover_main_splitContainer.Name = "discover_main_splitContainer";
            // 
            // discover_main_splitContainer.Panel1
            // 
            this.discover_main_splitContainer.Panel1.Controls.Add(this.discoverMovies_groupBox);
            // 
            // discover_main_splitContainer.Panel2
            // 
            this.discover_main_splitContainer.Panel2.Controls.Add(this.discoverTvSeries_groupBox);
            this.discover_main_splitContainer.Size = new System.Drawing.Size(860, 410);
            this.discover_main_splitContainer.SplitterDistance = 417;
            this.discover_main_splitContainer.TabIndex = 0;
            // 
            // discoverMovies_groupBox
            // 
            this.discoverMovies_groupBox.Controls.Add(this.label2);
            this.discoverMovies_groupBox.Controls.Add(this.discover_sortByAscDesc_comboBox);
            this.discoverMovies_groupBox.Controls.Add(this.discover_sortByMembers_comboBox);
            this.discoverMovies_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discoverMovies_groupBox.Location = new System.Drawing.Point(0, 0);
            this.discoverMovies_groupBox.Name = "discoverMovies_groupBox";
            this.discoverMovies_groupBox.Size = new System.Drawing.Size(417, 410);
            this.discoverMovies_groupBox.TabIndex = 1;
            this.discoverMovies_groupBox.TabStop = false;
            this.discoverMovies_groupBox.Text = "Discover Movies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sort by";
            // 
            // discover_sortByAscDesc_comboBox
            // 
            this.discover_sortByAscDesc_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discover_sortByAscDesc_comboBox.FormattingEnabled = true;
            this.discover_sortByAscDesc_comboBox.Location = new System.Drawing.Point(183, 19);
            this.discover_sortByAscDesc_comboBox.Name = "discover_sortByAscDesc_comboBox";
            this.discover_sortByAscDesc_comboBox.Size = new System.Drawing.Size(71, 25);
            this.discover_sortByAscDesc_comboBox.TabIndex = 1;
            // 
            // discover_sortByMembers_comboBox
            // 
            this.discover_sortByMembers_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discover_sortByMembers_comboBox.FormattingEnabled = true;
            this.discover_sortByMembers_comboBox.Location = new System.Drawing.Point(56, 19);
            this.discover_sortByMembers_comboBox.Name = "discover_sortByMembers_comboBox";
            this.discover_sortByMembers_comboBox.Size = new System.Drawing.Size(121, 25);
            this.discover_sortByMembers_comboBox.TabIndex = 0;
            // 
            // discoverTvSeries_groupBox
            // 
            this.discoverTvSeries_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discoverTvSeries_groupBox.Location = new System.Drawing.Point(0, 0);
            this.discoverTvSeries_groupBox.Name = "discoverTvSeries_groupBox";
            this.discoverTvSeries_groupBox.Size = new System.Drawing.Size(439, 410);
            this.discoverTvSeries_groupBox.TabIndex = 0;
            this.discoverTvSeries_groupBox.TabStop = false;
            this.discoverTvSeries_groupBox.Text = "Discover Tv Series";
            // 
            // action_splitContainer
            // 
            this.action_splitContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.action_splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.action_splitContainer.Location = new System.Drawing.Point(0, 439);
            this.action_splitContainer.Name = "action_splitContainer";
            // 
            // action_splitContainer.Panel1
            // 
            this.action_splitContainer.Panel1.Controls.Add(this.actions_groupBox);
            // 
            // action_splitContainer.Panel2
            // 
            this.action_splitContainer.Panel2.Controls.Add(this.pictureBox1);
            this.action_splitContainer.Size = new System.Drawing.Size(868, 160);
            this.action_splitContainer.SplitterDistance = 732;
            this.action_splitContainer.TabIndex = 12;
            // 
            // actions_groupBox
            // 
            this.actions_groupBox.Controls.Add(this.actionsFlowLayoutPanel);
            this.actions_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actions_groupBox.Location = new System.Drawing.Point(0, 0);
            this.actions_groupBox.Name = "actions_groupBox";
            this.actions_groupBox.Size = new System.Drawing.Size(732, 160);
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
            this.actionsFlowLayoutPanel.Controls.Add(this.watchlistRefresh_button);
            this.actionsFlowLayoutPanel.Controls.Add(this.favoritesRefresh_button);
            this.actionsFlowLayoutPanel.Controls.Add(this.yts_button);
            this.actionsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.actionsFlowLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.actionsFlowLayoutPanel.Name = "actionsFlowLayoutPanel";
            this.actionsFlowLayoutPanel.Size = new System.Drawing.Size(726, 138);
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
            this.home_viewDetails_button.Location = new System.Drawing.Point(3, 3);
            this.home_viewDetails_button.Name = "home_viewDetails_button";
            this.home_viewDetails_button.Size = new System.Drawing.Size(181, 29);
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
            this.search_viewDetails_button.Location = new System.Drawing.Point(3, 38);
            this.search_viewDetails_button.Name = "search_viewDetails_button";
            this.search_viewDetails_button.Size = new System.Drawing.Size(189, 29);
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
            this.favoriteMediaItem_button.Location = new System.Drawing.Point(3, 73);
            this.favoriteMediaItem_button.Name = "favoriteMediaItem_button";
            this.favoriteMediaItem_button.Size = new System.Drawing.Size(179, 29);
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
            this.watchMediaItem_button.Location = new System.Drawing.Point(198, 3);
            this.watchMediaItem_button.Name = "watchMediaItem_button";
            this.watchMediaItem_button.Size = new System.Drawing.Size(168, 29);
            this.watchMediaItem_button.TabIndex = 4;
            this.watchMediaItem_button.Text = "watchMediaItem_button";
            this.watchMediaItem_button.UseVisualStyleBackColor = true;
            this.watchMediaItem_button.Click += new System.EventHandler(this.watchMediaItem_button_Click);
            // 
            // watchlistRefresh_button
            // 
            this.watchlistRefresh_button.AutoSize = true;
            this.watchlistRefresh_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.watchlistRefresh_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.watchlistRefresh_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.watchlistRefresh_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.watchlistRefresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchlistRefresh_button.Location = new System.Drawing.Point(198, 38);
            this.watchlistRefresh_button.Name = "watchlistRefresh_button";
            this.watchlistRefresh_button.Size = new System.Drawing.Size(171, 29);
            this.watchlistRefresh_button.TabIndex = 0;
            this.watchlistRefresh_button.Text = "watchlistRefresh_button";
            this.watchlistRefresh_button.UseVisualStyleBackColor = true;
            this.watchlistRefresh_button.Click += new System.EventHandler(this.refreshWatchlist_button_Click);
            // 
            // favoritesRefresh_button
            // 
            this.favoritesRefresh_button.AutoSize = true;
            this.favoritesRefresh_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.favoritesRefresh_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.favoritesRefresh_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.favoritesRefresh_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.favoritesRefresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favoritesRefresh_button.Location = new System.Drawing.Point(198, 73);
            this.favoritesRefresh_button.Name = "favoritesRefresh_button";
            this.favoritesRefresh_button.Size = new System.Drawing.Size(172, 29);
            this.favoritesRefresh_button.TabIndex = 6;
            this.favoritesRefresh_button.Text = "favoritesRefresh_button";
            this.favoritesRefresh_button.UseVisualStyleBackColor = true;
            this.favoritesRefresh_button.Click += new System.EventHandler(this.moviesRefresh_button_Click);
            // 
            // yts_button
            // 
            this.yts_button.AutoSize = true;
            this.yts_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yts_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.yts_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.yts_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.yts_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yts_button.Location = new System.Drawing.Point(376, 3);
            this.yts_button.Name = "yts_button";
            this.yts_button.Size = new System.Drawing.Size(86, 29);
            this.yts_button.TabIndex = 5;
            this.yts_button.Text = "yts_button";
            this.yts_button.UseVisualStyleBackColor = true;
            this.yts_button.Click += new System.EventHandler(this.yts_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::View_Account.Properties.Resources.PoweredByTMDb_SquareGreen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mediaPoster_pictureBox
            // 
            this.mediaPoster_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.mediaPoster_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mediaPoster_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaPoster_pictureBox.Location = new System.Drawing.Point(10, 24);
            this.mediaPoster_pictureBox.Name = "mediaPoster_pictureBox";
            this.mediaPoster_pictureBox.Size = new System.Drawing.Size(345, 575);
            this.mediaPoster_pictureBox.TabIndex = 4;
            this.mediaPoster_pictureBox.TabStop = false;
            // 
            // imageLoading_label
            // 
            this.imageLoading_label.BackColor = System.Drawing.Color.Transparent;
            this.imageLoading_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageLoading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLoading_label.Location = new System.Drawing.Point(10, 0);
            this.imageLoading_label.Name = "imageLoading_label";
            this.imageLoading_label.Size = new System.Drawing.Size(345, 24);
            this.imageLoading_label.TabIndex = 5;
            this.imageLoading_label.Text = "imageLoading_label";
            this.imageLoading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_groupBox
            // 
            this.main_groupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.main_groupBox.Controls.Add(this.main_splitContainer);
            this.main_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_groupBox.Location = new System.Drawing.Point(0, 40);
            this.main_groupBox.Name = "main_groupBox";
            this.main_groupBox.Size = new System.Drawing.Size(1243, 621);
            this.main_groupBox.TabIndex = 2;
            this.main_groupBox.TabStop = false;
            this.main_groupBox.Text = "main_groupBox";
            // 
            // movieYear_columnHeader
            // 
            this.movieYear_columnHeader.Text = "Year";
            this.movieYear_columnHeader.Width = 100;
            // 
            // tvYear_columnHeader
            // 
            this.tvYear_columnHeader.Text = "Year";
            this.tvYear_columnHeader.Width = 100;
            // 
            // viewAccount_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 661);
            this.Controls.Add(this.main_groupBox);
            this.Controls.Add(this.accountName_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "viewAccount_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Account";
            this.Load += new System.EventHandler(this.viewAccount_Form_Load);
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
            this.discover_main_splitContainer.Panel1.ResumeLayout(false);
            this.discover_main_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.discover_main_splitContainer)).EndInit();
            this.discover_main_splitContainer.ResumeLayout(false);
            this.discoverMovies_groupBox.ResumeLayout(false);
            this.discoverMovies_groupBox.PerformLayout();
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
        private System.Windows.Forms.SplitContainer discover_main_splitContainer;
        private System.Windows.Forms.GroupBox discoverMovies_groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox discover_sortByAscDesc_comboBox;
        private System.Windows.Forms.ComboBox discover_sortByMembers_comboBox;
        private System.Windows.Forms.GroupBox discoverTvSeries_groupBox;
        private System.Windows.Forms.PictureBox mediaPoster_pictureBox;
        private System.Windows.Forms.Label imageLoading_label;
        private System.Windows.Forms.GroupBox main_groupBox;
        private System.Windows.Forms.Button yts_button;
        private System.Windows.Forms.SplitContainer action_splitContainer;
        private System.Windows.Forms.GroupBox actions_groupBox;
        private System.Windows.Forms.Button watchlistRefresh_button;
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
        private System.Windows.Forms.Button favoritesRefresh_button;
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
    }
}

