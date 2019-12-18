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
            this.search_tabPage = new System.Windows.Forms.TabPage();
            this.searchItemActions_groupBox = new System.Windows.Forms.GroupBox();
            this.mediaItemPoster_pictureBox = new System.Windows.Forms.PictureBox();
            this.favoriteMediaItem_button = new System.Windows.Forms.Button();
            this.viewDetails_button = new System.Windows.Forms.Button();
            this.searchResults_listView = new System.Windows.Forms.ListView();
            this.search_button = new System.Windows.Forms.Button();
            this.searchInput_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.search_tabPage.SuspendLayout();
            this.searchItemActions_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaItemPoster_pictureBox)).BeginInit();
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
            this.home_tabPage.Location = new System.Drawing.Point(4, 22);
            this.home_tabPage.Name = "home_tabPage";
            this.home_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.home_tabPage.Size = new System.Drawing.Size(792, 411);
            this.home_tabPage.TabIndex = 0;
            this.home_tabPage.Text = "Home";
            this.home_tabPage.UseVisualStyleBackColor = true;
            // 
            // search_tabPage
            // 
            this.search_tabPage.Controls.Add(this.searchItemActions_groupBox);
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
            // searchItemActions_groupBox
            // 
            this.searchItemActions_groupBox.Controls.Add(this.mediaItemPoster_pictureBox);
            this.searchItemActions_groupBox.Controls.Add(this.favoriteMediaItem_button);
            this.searchItemActions_groupBox.Controls.Add(this.viewDetails_button);
            this.searchItemActions_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchItemActions_groupBox.Location = new System.Drawing.Point(3, 304);
            this.searchItemActions_groupBox.Name = "searchItemActions_groupBox";
            this.searchItemActions_groupBox.Size = new System.Drawing.Size(786, 104);
            this.searchItemActions_groupBox.TabIndex = 4;
            this.searchItemActions_groupBox.TabStop = false;
            this.searchItemActions_groupBox.Text = "Actions";
            // 
            // mediaItemPoster_pictureBox
            // 
            this.mediaItemPoster_pictureBox.Location = new System.Drawing.Point(636, 6);
            this.mediaItemPoster_pictureBox.Name = "mediaItemPoster_pictureBox";
            this.mediaItemPoster_pictureBox.Size = new System.Drawing.Size(147, 92);
            this.mediaItemPoster_pictureBox.TabIndex = 2;
            this.mediaItemPoster_pictureBox.TabStop = false;
            // 
            // favoriteMediaItem_button
            // 
            this.favoriteMediaItem_button.Location = new System.Drawing.Point(7, 49);
            this.favoriteMediaItem_button.Name = "favoriteMediaItem_button";
            this.favoriteMediaItem_button.Size = new System.Drawing.Size(107, 23);
            this.favoriteMediaItem_button.TabIndex = 1;
            this.favoriteMediaItem_button.Text = "favoriteMediaItem_button";
            this.favoriteMediaItem_button.UseVisualStyleBackColor = true;
            this.favoriteMediaItem_button.Click += new System.EventHandler(this.favoriteMediaItem_button_Click);
            // 
            // viewDetails_button
            // 
            this.viewDetails_button.Location = new System.Drawing.Point(7, 20);
            this.viewDetails_button.Name = "viewDetails_button";
            this.viewDetails_button.Size = new System.Drawing.Size(107, 23);
            this.viewDetails_button.TabIndex = 0;
            this.viewDetails_button.Text = "viewDetails_button";
            this.viewDetails_button.UseVisualStyleBackColor = true;
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
            this.search_tabPage.ResumeLayout(false);
            this.search_tabPage.PerformLayout();
            this.searchItemActions_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaItemPoster_pictureBox)).EndInit();
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
        private System.Windows.Forms.GroupBox searchItemActions_groupBox;
        private System.Windows.Forms.Button favoriteMediaItem_button;
        private System.Windows.Forms.Button viewDetails_button;
        private System.Windows.Forms.PictureBox mediaItemPoster_pictureBox;
    }
}

