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
            this.accountName_label = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.home_tabPage = new System.Windows.Forms.TabPage();
            this.favoritesMediaActions_groupBox = new System.Windows.Forms.GroupBox();
            this.favoriteImageLoading_label = new System.Windows.Forms.Label();
            this.favoriteMediaPoster_pictureBox = new System.Windows.Forms.PictureBox();
            this.favoritesRefresh_button = new System.Windows.Forms.Button();
            this.favoriteViewDetails_button = new System.Windows.Forms.Button();
            this.favoriteTvSeries_groupBox = new System.Windows.Forms.GroupBox();
            this.favoriteTvSeries_listView = new System.Windows.Forms.ListView();
            this.favoriteMovies_groupBox = new System.Windows.Forms.GroupBox();
            this.favoriteMovies_listView = new System.Windows.Forms.ListView();
            this.search_tabPage = new System.Windows.Forms.TabPage();
            this.searchActions_groupBox = new System.Windows.Forms.GroupBox();
            this.searchImageLoading_label = new System.Windows.Forms.Label();
            this.searchMediaPoster_pictureBox = new System.Windows.Forms.PictureBox();
            this.searchFavoriteMediaItem_button = new System.Windows.Forms.Button();
            this.searchViewDetails_button = new System.Windows.Forms.Button();
            this.searchResults_listView = new System.Windows.Forms.ListView();
            this.search_button = new System.Windows.Forms.Button();
            this.searchInput_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.home_tabPage.SuspendLayout();
            this.favoritesMediaActions_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteMediaPoster_pictureBox)).BeginInit();
            this.favoriteTvSeries_groupBox.SuspendLayout();
            this.favoriteMovies_groupBox.SuspendLayout();
            this.search_tabPage.SuspendLayout();
            this.searchActions_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchMediaPoster_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // accountName_label
            // 
            this.accountName_label.AutoSize = true;
            this.accountName_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountName_label.Location = new System.Drawing.Point(0, 0);
            this.accountName_label.Name = "accountName_label";
            this.accountName_label.Size = new System.Drawing.Size(102, 13);
            this.accountName_label.TabIndex = 0;
            this.accountName_label.Text = "accountName_label";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.home_tabPage);
            this.tabControl.Controls.Add(this.search_tabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 437);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // home_tabPage
            // 
            this.home_tabPage.Controls.Add(this.favoritesMediaActions_groupBox);
            this.home_tabPage.Controls.Add(this.favoriteTvSeries_groupBox);
            this.home_tabPage.Controls.Add(this.favoriteMovies_groupBox);
            this.home_tabPage.Location = new System.Drawing.Point(4, 22);
            this.home_tabPage.Name = "home_tabPage";
            this.home_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.home_tabPage.Size = new System.Drawing.Size(792, 411);
            this.home_tabPage.TabIndex = 0;
            this.home_tabPage.Text = "Home";
            this.home_tabPage.UseVisualStyleBackColor = true;
            // 
            // favoritesMediaActions_groupBox
            // 
            this.favoritesMediaActions_groupBox.Controls.Add(this.favoriteImageLoading_label);
            this.favoritesMediaActions_groupBox.Controls.Add(this.favoriteMediaPoster_pictureBox);
            this.favoritesMediaActions_groupBox.Controls.Add(this.favoritesRefresh_button);
            this.favoritesMediaActions_groupBox.Controls.Add(this.favoriteViewDetails_button);
            this.favoritesMediaActions_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favoritesMediaActions_groupBox.Location = new System.Drawing.Point(3, 293);
            this.favoritesMediaActions_groupBox.Name = "favoritesMediaActions_groupBox";
            this.favoritesMediaActions_groupBox.Size = new System.Drawing.Size(786, 115);
            this.favoritesMediaActions_groupBox.TabIndex = 5;
            this.favoritesMediaActions_groupBox.TabStop = false;
            this.favoritesMediaActions_groupBox.Text = "Actions";
            // 
            // favoriteImageLoading_label
            // 
            this.favoriteImageLoading_label.AutoSize = true;
            this.favoriteImageLoading_label.Location = new System.Drawing.Point(664, 59);
            this.favoriteImageLoading_label.Name = "favoriteImageLoading_label";
            this.favoriteImageLoading_label.Size = new System.Drawing.Size(101, 13);
            this.favoriteImageLoading_label.TabIndex = 3;
            this.favoriteImageLoading_label.Text = "imageLoading_label";
            // 
            // favoriteMediaPoster_pictureBox
            // 
            this.favoriteMediaPoster_pictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.favoriteMediaPoster_pictureBox.Location = new System.Drawing.Point(636, 16);
            this.favoriteMediaPoster_pictureBox.Name = "favoriteMediaPoster_pictureBox";
            this.favoriteMediaPoster_pictureBox.Size = new System.Drawing.Size(147, 96);
            this.favoriteMediaPoster_pictureBox.TabIndex = 2;
            this.favoriteMediaPoster_pictureBox.TabStop = false;
            // 
            // favoritesRefresh_button
            // 
            this.favoritesRefresh_button.Location = new System.Drawing.Point(7, 49);
            this.favoritesRefresh_button.Name = "favoritesRefresh_button";
            this.favoritesRefresh_button.Size = new System.Drawing.Size(107, 23);
            this.favoritesRefresh_button.TabIndex = 1;
            this.favoritesRefresh_button.Text = "Refresh Favorites";
            this.favoritesRefresh_button.UseVisualStyleBackColor = true;
            this.favoritesRefresh_button.Click += new System.EventHandler(this.favoritesRefresh_button_Click);
            // 
            // favoriteViewDetails_button
            // 
            this.favoriteViewDetails_button.Location = new System.Drawing.Point(7, 20);
            this.favoriteViewDetails_button.Name = "favoriteViewDetails_button";
            this.favoriteViewDetails_button.Size = new System.Drawing.Size(107, 23);
            this.favoriteViewDetails_button.TabIndex = 0;
            this.favoriteViewDetails_button.Text = "View Details";
            this.favoriteViewDetails_button.UseVisualStyleBackColor = true;
            this.favoriteViewDetails_button.Click += new System.EventHandler(this.viewDetails_button_Click);
            // 
            // favoriteTvSeries_groupBox
            // 
            this.favoriteTvSeries_groupBox.Controls.Add(this.favoriteTvSeries_listView);
            this.favoriteTvSeries_groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.favoriteTvSeries_groupBox.Location = new System.Drawing.Point(3, 148);
            this.favoriteTvSeries_groupBox.Name = "favoriteTvSeries_groupBox";
            this.favoriteTvSeries_groupBox.Size = new System.Drawing.Size(786, 145);
            this.favoriteTvSeries_groupBox.TabIndex = 1;
            this.favoriteTvSeries_groupBox.TabStop = false;
            this.favoriteTvSeries_groupBox.Text = "Favorite Tv Series";
            // 
            // favoriteTvSeries_listView
            // 
            this.favoriteTvSeries_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favoriteTvSeries_listView.HideSelection = false;
            this.favoriteTvSeries_listView.Location = new System.Drawing.Point(3, 16);
            this.favoriteTvSeries_listView.Name = "favoriteTvSeries_listView";
            this.favoriteTvSeries_listView.Size = new System.Drawing.Size(780, 126);
            this.favoriteTvSeries_listView.TabIndex = 0;
            this.favoriteTvSeries_listView.UseCompatibleStateImageBehavior = false;
            this.favoriteTvSeries_listView.View = System.Windows.Forms.View.List;
            this.favoriteTvSeries_listView.SelectedIndexChanged += new System.EventHandler(this.favorites_listView_SelectedIndexChanged);
            this.favoriteTvSeries_listView.Enter += new System.EventHandler(this.favorites_listView_SelectedIndexChanged);
            // 
            // favoriteMovies_groupBox
            // 
            this.favoriteMovies_groupBox.Controls.Add(this.favoriteMovies_listView);
            this.favoriteMovies_groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.favoriteMovies_groupBox.Location = new System.Drawing.Point(3, 3);
            this.favoriteMovies_groupBox.Name = "favoriteMovies_groupBox";
            this.favoriteMovies_groupBox.Size = new System.Drawing.Size(786, 145);
            this.favoriteMovies_groupBox.TabIndex = 0;
            this.favoriteMovies_groupBox.TabStop = false;
            this.favoriteMovies_groupBox.Text = "Favorite Movies";
            // 
            // favoriteMovies_listView
            // 
            this.favoriteMovies_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favoriteMovies_listView.HideSelection = false;
            this.favoriteMovies_listView.Location = new System.Drawing.Point(3, 16);
            this.favoriteMovies_listView.Name = "favoriteMovies_listView";
            this.favoriteMovies_listView.Size = new System.Drawing.Size(780, 126);
            this.favoriteMovies_listView.TabIndex = 0;
            this.favoriteMovies_listView.UseCompatibleStateImageBehavior = false;
            this.favoriteMovies_listView.View = System.Windows.Forms.View.List;
            this.favoriteMovies_listView.SelectedIndexChanged += new System.EventHandler(this.favorites_listView_SelectedIndexChanged);
            this.favoriteMovies_listView.Enter += new System.EventHandler(this.favorites_listView_SelectedIndexChanged);
            // 
            // search_tabPage
            // 
            this.search_tabPage.Controls.Add(this.searchActions_groupBox);
            this.search_tabPage.Controls.Add(this.searchResults_listView);
            this.search_tabPage.Controls.Add(this.search_button);
            this.search_tabPage.Controls.Add(this.searchInput_textBox);
            this.search_tabPage.Controls.Add(this.label1);
            this.search_tabPage.Location = new System.Drawing.Point(4, 22);
            this.search_tabPage.Name = "search_tabPage";
            this.search_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.search_tabPage.Size = new System.Drawing.Size(792, 411);
            this.search_tabPage.TabIndex = 1;
            this.search_tabPage.Text = "Search";
            this.search_tabPage.UseVisualStyleBackColor = true;
            // 
            // searchActions_groupBox
            // 
            this.searchActions_groupBox.Controls.Add(this.searchImageLoading_label);
            this.searchActions_groupBox.Controls.Add(this.searchMediaPoster_pictureBox);
            this.searchActions_groupBox.Controls.Add(this.searchFavoriteMediaItem_button);
            this.searchActions_groupBox.Controls.Add(this.searchViewDetails_button);
            this.searchActions_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchActions_groupBox.Location = new System.Drawing.Point(3, 304);
            this.searchActions_groupBox.Name = "searchActions_groupBox";
            this.searchActions_groupBox.Size = new System.Drawing.Size(786, 104);
            this.searchActions_groupBox.TabIndex = 4;
            this.searchActions_groupBox.TabStop = false;
            this.searchActions_groupBox.Text = "Actions";
            // 
            // searchImageLoading_label
            // 
            this.searchImageLoading_label.AutoSize = true;
            this.searchImageLoading_label.Location = new System.Drawing.Point(666, 49);
            this.searchImageLoading_label.Name = "searchImageLoading_label";
            this.searchImageLoading_label.Size = new System.Drawing.Size(101, 13);
            this.searchImageLoading_label.TabIndex = 3;
            this.searchImageLoading_label.Text = "imageLoading_label";
            // 
            // searchMediaPoster_pictureBox
            // 
            this.searchMediaPoster_pictureBox.Location = new System.Drawing.Point(636, 9);
            this.searchMediaPoster_pictureBox.Name = "searchMediaPoster_pictureBox";
            this.searchMediaPoster_pictureBox.Size = new System.Drawing.Size(147, 92);
            this.searchMediaPoster_pictureBox.TabIndex = 2;
            this.searchMediaPoster_pictureBox.TabStop = false;
            // 
            // searchFavoriteMediaItem_button
            // 
            this.searchFavoriteMediaItem_button.AutoSize = true;
            this.searchFavoriteMediaItem_button.Location = new System.Drawing.Point(7, 49);
            this.searchFavoriteMediaItem_button.Name = "searchFavoriteMediaItem_button";
            this.searchFavoriteMediaItem_button.Size = new System.Drawing.Size(172, 23);
            this.searchFavoriteMediaItem_button.TabIndex = 1;
            this.searchFavoriteMediaItem_button.Text = "searchFavoriteMediaItem_button";
            this.searchFavoriteMediaItem_button.UseVisualStyleBackColor = true;
            this.searchFavoriteMediaItem_button.Click += new System.EventHandler(this.favoriteMediaItem_button_Click);
            // 
            // searchViewDetails_button
            // 
            this.searchViewDetails_button.AutoSize = true;
            this.searchViewDetails_button.Location = new System.Drawing.Point(7, 20);
            this.searchViewDetails_button.Name = "searchViewDetails_button";
            this.searchViewDetails_button.Size = new System.Drawing.Size(140, 23);
            this.searchViewDetails_button.TabIndex = 0;
            this.searchViewDetails_button.Text = "searchViewDetails_button";
            this.searchViewDetails_button.UseVisualStyleBackColor = true;
            this.searchViewDetails_button.Click += new System.EventHandler(this.viewDetails_button_Click);
            // 
            // searchResults_listView
            // 
            this.searchResults_listView.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchResults_listView.HideSelection = false;
            this.searchResults_listView.Location = new System.Drawing.Point(3, 59);
            this.searchResults_listView.MultiSelect = false;
            this.searchResults_listView.Name = "searchResults_listView";
            this.searchResults_listView.Size = new System.Drawing.Size(786, 245);
            this.searchResults_listView.TabIndex = 2;
            this.searchResults_listView.UseCompatibleStateImageBehavior = false;
            this.searchResults_listView.View = System.Windows.Forms.View.List;
            this.searchResults_listView.SelectedIndexChanged += new System.EventHandler(this.searchResults_listView_SelectedIndexChanged);
            // 
            // search_button
            // 
            this.search_button.AutoSize = true;
            this.search_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_button.Location = new System.Drawing.Point(3, 36);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(786, 23);
            this.search_button.TabIndex = 3;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // searchInput_textBox
            // 
            this.searchInput_textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchInput_textBox.Location = new System.Drawing.Point(3, 16);
            this.searchInput_textBox.Name = "searchInput_textBox";
            this.searchInput_textBox.Size = new System.Drawing.Size(786, 20);
            this.searchInput_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input:";
            // 
            // viewAccount_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.accountName_label);
            this.MaximizeBox = false;
            this.Name = "viewAccount_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Account";
            this.Load += new System.EventHandler(this.viewAccount_Form_Load);
            this.tabControl.ResumeLayout(false);
            this.home_tabPage.ResumeLayout(false);
            this.favoritesMediaActions_groupBox.ResumeLayout(false);
            this.favoritesMediaActions_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteMediaPoster_pictureBox)).EndInit();
            this.favoriteTvSeries_groupBox.ResumeLayout(false);
            this.favoriteMovies_groupBox.ResumeLayout(false);
            this.search_tabPage.ResumeLayout(false);
            this.search_tabPage.PerformLayout();
            this.searchActions_groupBox.ResumeLayout(false);
            this.searchActions_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchMediaPoster_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountName_label;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage home_tabPage;
        private System.Windows.Forms.TabPage search_tabPage;
        private System.Windows.Forms.ListView searchResults_listView;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox searchInput_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox searchActions_groupBox;
        private System.Windows.Forms.Button searchFavoriteMediaItem_button;
        private System.Windows.Forms.Button searchViewDetails_button;
        private System.Windows.Forms.PictureBox searchMediaPoster_pictureBox;
        private System.Windows.Forms.Label searchImageLoading_label;
        private System.Windows.Forms.GroupBox favoriteMovies_groupBox;
        private System.Windows.Forms.GroupBox favoriteTvSeries_groupBox;
        private System.Windows.Forms.ListView favoriteMovies_listView;
        private System.Windows.Forms.ListView favoriteTvSeries_listView;
        private System.Windows.Forms.GroupBox favoritesMediaActions_groupBox;
        private System.Windows.Forms.Label favoriteImageLoading_label;
        private System.Windows.Forms.PictureBox favoriteMediaPoster_pictureBox;
        private System.Windows.Forms.Button favoritesRefresh_button;
        private System.Windows.Forms.Button favoriteViewDetails_button;
    }
}

