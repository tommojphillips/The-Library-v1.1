namespace View_Account
{
    partial class EzTvResponseDialog1
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
            this.episodes_listView = new System.Windows.Forms.ListView();
            this.title_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.season_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.episode_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.releasedate_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.seeds_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Peers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.response_groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ytsMain_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ytsLimit_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ytsLimit_label = new System.Windows.Forms.Label();
            this.limit_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ytsPage_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.previousPage_button = new System.Windows.Forms.Button();
            this.ytsPage_label = new System.Windows.Forms.Label();
            this.page_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nextPage_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.torrentOptions_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.startDownload_button = new System.Windows.Forms.Button();
            this.response_groupBox.SuspendLayout();
            this.ytsMain_flowLayoutPanel.SuspendLayout();
            this.ytsLimit_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limit_numericUpDown)).BeginInit();
            this.ytsPage_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.torrentOptions_flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // episodes_listView
            // 
            this.episodes_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title_columnHeader,
            this.season_columnHeader,
            this.episode_columnHeader,
            this.releasedate_columnHeader,
            this.seeds_columnHeader,
            this.Peers,
            this.columnHeader2,
            this.columnHeader1});
            this.episodes_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.episodes_listView.HideSelection = false;
            this.episodes_listView.LabelWrap = false;
            this.episodes_listView.Location = new System.Drawing.Point(0, 0);
            this.episodes_listView.Margin = new System.Windows.Forms.Padding(2);
            this.episodes_listView.MultiSelect = false;
            this.episodes_listView.Name = "episodes_listView";
            this.episodes_listView.Size = new System.Drawing.Size(784, 338);
            this.episodes_listView.TabIndex = 3;
            this.episodes_listView.UseCompatibleStateImageBehavior = false;
            this.episodes_listView.View = System.Windows.Forms.View.Details;
            this.episodes_listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.episodes_listView_ColumnClick);
            this.episodes_listView.SelectedIndexChanged += new System.EventHandler(this.movies_listView_SelectedIndexChanged);
            // 
            // title_columnHeader
            // 
            this.title_columnHeader.Text = "Title";
            this.title_columnHeader.Width = 246;
            // 
            // season_columnHeader
            // 
            this.season_columnHeader.DisplayIndex = 2;
            this.season_columnHeader.Text = "Season";
            this.season_columnHeader.Width = 48;
            // 
            // episode_columnHeader
            // 
            this.episode_columnHeader.DisplayIndex = 3;
            this.episode_columnHeader.Text = "Episode";
            this.episode_columnHeader.Width = 52;
            // 
            // releasedate_columnHeader
            // 
            this.releasedate_columnHeader.DisplayIndex = 1;
            this.releasedate_columnHeader.Text = "Release date";
            this.releasedate_columnHeader.Width = 85;
            // 
            // seeds_columnHeader
            // 
            this.seeds_columnHeader.Text = "Seeds";
            this.seeds_columnHeader.Width = 43;
            // 
            // Peers
            // 
            this.Peers.Text = "Peers";
            this.Peers.Width = 40;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hash";
            this.columnHeader1.Width = 198;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 48;
            // 
            // response_groupBox
            // 
            this.response_groupBox.Controls.Add(this.label1);
            this.response_groupBox.Controls.Add(this.ytsMain_flowLayoutPanel);
            this.response_groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.response_groupBox.Location = new System.Drawing.Point(0, 0);
            this.response_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.response_groupBox.Name = "response_groupBox";
            this.response_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.response_groupBox.Size = new System.Drawing.Size(784, 57);
            this.response_groupBox.TabIndex = 4;
            this.response_groupBox.TabStop = false;
            this.response_groupBox.Text = "Response Infomation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // ytsMain_flowLayoutPanel
            // 
            this.ytsMain_flowLayoutPanel.AutoSize = true;
            this.ytsMain_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsMain_flowLayoutPanel.Controls.Add(this.ytsLimit_flowLayoutPanel);
            this.ytsMain_flowLayoutPanel.Controls.Add(this.ytsPage_flowLayoutPanel);
            this.ytsMain_flowLayoutPanel.Controls.Add(this.search_button);
            this.ytsMain_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ytsMain_flowLayoutPanel.Location = new System.Drawing.Point(2, 15);
            this.ytsMain_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ytsMain_flowLayoutPanel.Name = "ytsMain_flowLayoutPanel";
            this.ytsMain_flowLayoutPanel.Size = new System.Drawing.Size(780, 30);
            this.ytsMain_flowLayoutPanel.TabIndex = 9;
            // 
            // ytsLimit_flowLayoutPanel
            // 
            this.ytsLimit_flowLayoutPanel.AutoSize = true;
            this.ytsLimit_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ytsLimit_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ytsLimit_flowLayoutPanel.Controls.Add(this.ytsLimit_label);
            this.ytsLimit_flowLayoutPanel.Controls.Add(this.limit_numericUpDown);
            this.ytsLimit_flowLayoutPanel.Location = new System.Drawing.Point(2, 2);
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
            // limit_numericUpDown
            // 
            this.limit_numericUpDown.AutoSize = true;
            this.limit_numericUpDown.Location = new System.Drawing.Point(34, 2);
            this.limit_numericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.limit_numericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.limit_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.limit_numericUpDown.Name = "limit_numericUpDown";
            this.limit_numericUpDown.Size = new System.Drawing.Size(35, 20);
            this.limit_numericUpDown.TabIndex = 6;
            this.limit_numericUpDown.Value = new decimal(new int[] {
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
            this.ytsPage_flowLayoutPanel.Controls.Add(this.previousPage_button);
            this.ytsPage_flowLayoutPanel.Controls.Add(this.ytsPage_label);
            this.ytsPage_flowLayoutPanel.Controls.Add(this.page_numericUpDown);
            this.ytsPage_flowLayoutPanel.Controls.Add(this.nextPage_button);
            this.ytsPage_flowLayoutPanel.Location = new System.Drawing.Point(79, 2);
            this.ytsPage_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ytsPage_flowLayoutPanel.Name = "ytsPage_flowLayoutPanel";
            this.ytsPage_flowLayoutPanel.Size = new System.Drawing.Size(141, 26);
            this.ytsPage_flowLayoutPanel.TabIndex = 10;
            // 
            // previousPage_button
            // 
            this.previousPage_button.AutoSize = true;
            this.previousPage_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previousPage_button.FlatAppearance.BorderSize = 0;
            this.previousPage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousPage_button.Location = new System.Drawing.Point(0, 0);
            this.previousPage_button.Margin = new System.Windows.Forms.Padding(0);
            this.previousPage_button.Name = "previousPage_button";
            this.previousPage_button.Size = new System.Drawing.Size(29, 23);
            this.previousPage_button.TabIndex = 9;
            this.previousPage_button.Text = "<<";
            this.previousPage_button.UseVisualStyleBackColor = true;
            this.previousPage_button.Click += new System.EventHandler(this.previousPage_button_Click);
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
            // page_numericUpDown
            // 
            this.page_numericUpDown.AutoSize = true;
            this.page_numericUpDown.Location = new System.Drawing.Point(67, 2);
            this.page_numericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.page_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.page_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.page_numericUpDown.Name = "page_numericUpDown";
            this.page_numericUpDown.Size = new System.Drawing.Size(41, 20);
            this.page_numericUpDown.TabIndex = 7;
            this.page_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nextPage_button
            // 
            this.nextPage_button.AutoSize = true;
            this.nextPage_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextPage_button.FlatAppearance.BorderSize = 0;
            this.nextPage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPage_button.Location = new System.Drawing.Point(110, 0);
            this.nextPage_button.Margin = new System.Windows.Forms.Padding(0);
            this.nextPage_button.Name = "nextPage_button";
            this.nextPage_button.Size = new System.Drawing.Size(29, 23);
            this.nextPage_button.TabIndex = 8;
            this.nextPage_button.Text = ">>";
            this.nextPage_button.UseVisualStyleBackColor = true;
            this.nextPage_button.Click += new System.EventHandler(this.nextPage_button_Click);
            // 
            // search_button
            // 
            this.search_button.AutoSize = true;
            this.search_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Location = new System.Drawing.Point(222, 2);
            this.search_button.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.search_button.Name = "search_button";
            this.search_button.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.search_button.Size = new System.Drawing.Size(51, 26);
            this.search_button.TabIndex = 13;
            this.search_button.Text = "Submit";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.query_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 57);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.episodes_listView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.torrentOptions_flowLayoutPanel);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(784, 391);
            this.splitContainer1.SplitterDistance = 338;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            // 
            // torrentOptions_flowLayoutPanel
            // 
            this.torrentOptions_flowLayoutPanel.Controls.Add(this.startDownload_button);
            this.torrentOptions_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.torrentOptions_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.torrentOptions_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.torrentOptions_flowLayoutPanel.Name = "torrentOptions_flowLayoutPanel";
            this.torrentOptions_flowLayoutPanel.Size = new System.Drawing.Size(784, 50);
            this.torrentOptions_flowLayoutPanel.TabIndex = 0;
            // 
            // startDownload_button
            // 
            this.startDownload_button.AutoSize = true;
            this.startDownload_button.Enabled = false;
            this.startDownload_button.Location = new System.Drawing.Point(2, 2);
            this.startDownload_button.Margin = new System.Windows.Forms.Padding(2);
            this.startDownload_button.Name = "startDownload_button";
            this.startDownload_button.Size = new System.Drawing.Size(65, 23);
            this.startDownload_button.TabIndex = 0;
            this.startDownload_button.Text = "Download";
            this.startDownload_button.UseVisualStyleBackColor = true;
            this.startDownload_button.Click += new System.EventHandler(this.startDownload_button_Click);
            // 
            // EzTvResponseDialog1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 448);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.response_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EzTvResponseDialog1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EzTvResponseDialog";
            this.Load += new System.EventHandler(this.movieListResponseDialog_Load);
            this.response_groupBox.ResumeLayout(false);
            this.response_groupBox.PerformLayout();
            this.ytsMain_flowLayoutPanel.ResumeLayout(false);
            this.ytsMain_flowLayoutPanel.PerformLayout();
            this.ytsLimit_flowLayoutPanel.ResumeLayout(false);
            this.ytsLimit_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limit_numericUpDown)).EndInit();
            this.ytsPage_flowLayoutPanel.ResumeLayout(false);
            this.ytsPage_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page_numericUpDown)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.torrentOptions_flowLayoutPanel.ResumeLayout(false);
            this.torrentOptions_flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView episodes_listView;
        private System.Windows.Forms.ColumnHeader title_columnHeader;
        private System.Windows.Forms.ColumnHeader season_columnHeader;
        private System.Windows.Forms.ColumnHeader releasedate_columnHeader;
        private System.Windows.Forms.ColumnHeader episode_columnHeader;
        private System.Windows.Forms.ColumnHeader seeds_columnHeader;
        private System.Windows.Forms.GroupBox response_groupBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel torrentOptions_flowLayoutPanel;
        private System.Windows.Forms.Button startDownload_button;
        private System.Windows.Forms.ColumnHeader Peers;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.FlowLayoutPanel ytsMain_flowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ytsLimit_flowLayoutPanel;
        private System.Windows.Forms.Label ytsLimit_label;
        private System.Windows.Forms.NumericUpDown limit_numericUpDown;
        private System.Windows.Forms.FlowLayoutPanel ytsPage_flowLayoutPanel;
        private System.Windows.Forms.Button previousPage_button;
        private System.Windows.Forms.Label ytsPage_label;
        private System.Windows.Forms.NumericUpDown page_numericUpDown;
        private System.Windows.Forms.Button nextPage_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}