namespace View_Account
{
    partial class YTSMovieListResponseDialog
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
            this.responseStatus_label = new System.Windows.Forms.Label();
            this.responseMessage_label = new System.Windows.Forms.Label();
            this.responseMovieListCountLimit_label = new System.Windows.Forms.Label();
            this.movies_listView = new System.Windows.Forms.ListView();
            this.title_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.duration_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.torrents_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.response_groupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.page_label = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.torrents_listView = new System.Windows.Forms.ListView();
            this.torrentQuality_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.torrentSize_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.torrentDateAdded_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.torrentSeeds_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.torrentPeers_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.torrentHash_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.torrentOptions_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.startDownload_button = new System.Windows.Forms.Button();
            this.response_groupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.torrentOptions_flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // responseStatus_label
            // 
            this.responseStatus_label.AutoSize = true;
            this.responseStatus_label.Location = new System.Drawing.Point(3, 0);
            this.responseStatus_label.Name = "responseStatus_label";
            this.responseStatus_label.Size = new System.Drawing.Size(145, 17);
            this.responseStatus_label.TabIndex = 0;
            this.responseStatus_label.Text = "responseStatus_label";
            // 
            // responseMessage_label
            // 
            this.responseMessage_label.AutoSize = true;
            this.responseMessage_label.Location = new System.Drawing.Point(3, 17);
            this.responseMessage_label.Name = "responseMessage_label";
            this.responseMessage_label.Size = new System.Drawing.Size(162, 17);
            this.responseMessage_label.TabIndex = 1;
            this.responseMessage_label.Text = "responseMessage_label";
            // 
            // responseMovieListCountLimit_label
            // 
            this.responseMovieListCountLimit_label.AutoSize = true;
            this.responseMovieListCountLimit_label.Location = new System.Drawing.Point(171, 0);
            this.responseMovieListCountLimit_label.Name = "responseMovieListCountLimit_label";
            this.responseMovieListCountLimit_label.Size = new System.Drawing.Size(230, 17);
            this.responseMovieListCountLimit_label.TabIndex = 2;
            this.responseMovieListCountLimit_label.Text = "responseMovieListCountLimit_label";
            // 
            // movies_listView
            // 
            this.movies_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title_columnHeader,
            this.description_columnHeader,
            this.year_columnHeader,
            this.duration_columnHeader,
            this.torrents_columnHeader});
            this.movies_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movies_listView.HideSelection = false;
            this.movies_listView.LabelWrap = false;
            this.movies_listView.Location = new System.Drawing.Point(0, 0);
            this.movies_listView.MultiSelect = false;
            this.movies_listView.Name = "movies_listView";
            this.movies_listView.Size = new System.Drawing.Size(1045, 309);
            this.movies_listView.TabIndex = 3;
            this.movies_listView.UseCompatibleStateImageBehavior = false;
            this.movies_listView.View = System.Windows.Forms.View.Details;
            this.movies_listView.SelectedIndexChanged += new System.EventHandler(this.movies_listView_SelectedIndexChanged);
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
            // torrents_columnHeader
            // 
            this.torrents_columnHeader.Text = "Torrents";
            this.torrents_columnHeader.Width = 75;
            // 
            // response_groupBox
            // 
            this.response_groupBox.Controls.Add(this.flowLayoutPanel1);
            this.response_groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.response_groupBox.Location = new System.Drawing.Point(0, 0);
            this.response_groupBox.Name = "response_groupBox";
            this.response_groupBox.Size = new System.Drawing.Size(1045, 70);
            this.response_groupBox.TabIndex = 4;
            this.response_groupBox.TabStop = false;
            this.response_groupBox.Text = "Response Infomation";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.responseStatus_label);
            this.flowLayoutPanel1.Controls.Add(this.responseMessage_label);
            this.flowLayoutPanel1.Controls.Add(this.responseMovieListCountLimit_label);
            this.flowLayoutPanel1.Controls.Add(this.page_label);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1039, 49);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // page_label
            // 
            this.page_label.AutoSize = true;
            this.page_label.Location = new System.Drawing.Point(171, 17);
            this.page_label.Name = "page_label";
            this.page_label.Size = new System.Drawing.Size(78, 17);
            this.page_label.TabIndex = 3;
            this.page_label.Text = "page_label";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 70);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.movies_listView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 165;
            this.splitContainer1.Size = new System.Drawing.Size(1045, 481);
            this.splitContainer1.SplitterDistance = 309;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.torrents_listView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.torrentOptions_flowLayoutPanel);
            this.splitContainer2.Panel2MinSize = 40;
            this.splitContainer2.Size = new System.Drawing.Size(1045, 168);
            this.splitContainer2.SplitterDistance = 103;
            this.splitContainer2.TabIndex = 0;
            // 
            // torrents_listView
            // 
            this.torrents_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.torrentQuality_columnHeader,
            this.torrentSize_columnHeader,
            this.torrentDateAdded_columnHeader,
            this.torrentSeeds_columnHeader,
            this.torrentPeers_columnHeader,
            this.torrentHash_columnHeader});
            this.torrents_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.torrents_listView.HideSelection = false;
            this.torrents_listView.Location = new System.Drawing.Point(0, 0);
            this.torrents_listView.Name = "torrents_listView";
            this.torrents_listView.Size = new System.Drawing.Size(1045, 103);
            this.torrents_listView.TabIndex = 0;
            this.torrents_listView.UseCompatibleStateImageBehavior = false;
            this.torrents_listView.View = System.Windows.Forms.View.Details;
            this.torrents_listView.SelectedIndexChanged += new System.EventHandler(this.torrents_listView_SelectedIndexChanged);
            // 
            // torrentQuality_columnHeader
            // 
            this.torrentQuality_columnHeader.Text = "Quality";
            this.torrentQuality_columnHeader.Width = 100;
            // 
            // torrentSize_columnHeader
            // 
            this.torrentSize_columnHeader.Text = "Size";
            this.torrentSize_columnHeader.Width = 100;
            // 
            // torrentDateAdded_columnHeader
            // 
            this.torrentDateAdded_columnHeader.Text = "Date added";
            this.torrentDateAdded_columnHeader.Width = 130;
            // 
            // torrentSeeds_columnHeader
            // 
            this.torrentSeeds_columnHeader.Text = "Seeds";
            this.torrentSeeds_columnHeader.Width = 80;
            // 
            // torrentPeers_columnHeader
            // 
            this.torrentPeers_columnHeader.Text = "Peers";
            this.torrentPeers_columnHeader.Width = 80;
            // 
            // torrentHash_columnHeader
            // 
            this.torrentHash_columnHeader.Text = "Hash";
            this.torrentHash_columnHeader.Width = 250;
            // 
            // torrentOptions_flowLayoutPanel
            // 
            this.torrentOptions_flowLayoutPanel.Controls.Add(this.startDownload_button);
            this.torrentOptions_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.torrentOptions_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.torrentOptions_flowLayoutPanel.Name = "torrentOptions_flowLayoutPanel";
            this.torrentOptions_flowLayoutPanel.Size = new System.Drawing.Size(1045, 61);
            this.torrentOptions_flowLayoutPanel.TabIndex = 0;
            // 
            // startDownload_button
            // 
            this.startDownload_button.AutoSize = true;
            this.startDownload_button.Enabled = false;
            this.startDownload_button.Location = new System.Drawing.Point(3, 3);
            this.startDownload_button.Name = "startDownload_button";
            this.startDownload_button.Size = new System.Drawing.Size(80, 27);
            this.startDownload_button.TabIndex = 0;
            this.startDownload_button.Text = "Download";
            this.startDownload_button.UseVisualStyleBackColor = true;
            this.startDownload_button.Click += new System.EventHandler(this.startDownload_button_Click);
            // 
            // YTSMovieListResponseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 551);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.response_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YTSMovieListResponseDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YTSMovieListResponseDialog";
            this.Load += new System.EventHandler(this.YTSMovieListResponseDialog_Load);
            this.response_groupBox.ResumeLayout(false);
            this.response_groupBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.torrentOptions_flowLayoutPanel.ResumeLayout(false);
            this.torrentOptions_flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label responseStatus_label;
        private System.Windows.Forms.Label responseMessage_label;
        private System.Windows.Forms.Label responseMovieListCountLimit_label;
        private System.Windows.Forms.ListView movies_listView;
        private System.Windows.Forms.ColumnHeader title_columnHeader;
        private System.Windows.Forms.ColumnHeader description_columnHeader;
        private System.Windows.Forms.ColumnHeader year_columnHeader;
        private System.Windows.Forms.ColumnHeader duration_columnHeader;
        private System.Windows.Forms.ColumnHeader torrents_columnHeader;
        private System.Windows.Forms.GroupBox response_groupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label page_label;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView torrents_listView;
        private System.Windows.Forms.ColumnHeader torrentHash_columnHeader;
        private System.Windows.Forms.ColumnHeader torrentSeeds_columnHeader;
        private System.Windows.Forms.ColumnHeader torrentPeers_columnHeader;
        private System.Windows.Forms.ColumnHeader torrentDateAdded_columnHeader;
        private System.Windows.Forms.ColumnHeader torrentQuality_columnHeader;
        private System.Windows.Forms.ColumnHeader torrentSize_columnHeader;
        private System.Windows.Forms.FlowLayoutPanel torrentOptions_flowLayoutPanel;
        private System.Windows.Forms.Button startDownload_button;
    }
}