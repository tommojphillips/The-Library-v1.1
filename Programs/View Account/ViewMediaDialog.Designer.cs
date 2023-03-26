namespace View_Account
{
    partial class ViewMediaDialog
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
            this.poster_pictureBox = new System.Windows.Forms.PictureBox();
            this.mediaName_label = new System.Windows.Forms.Label();
            this.mediaReleaseDate_label = new System.Windows.Forms.Label();
            this.mediaDescription_richTextBox = new System.Windows.Forms.RichTextBox();
            this.mediaVotesAvg_label = new System.Windows.Forms.Label();
            this.viewReviews_button = new System.Windows.Forms.Button();
            this.watch_button = new System.Windows.Forms.Button();
            this.favorite_button = new System.Windows.Forms.Button();
            this.viewMediaActions_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.poster_pictureBox)).BeginInit();
            this.viewMediaActions_flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // poster_pictureBox
            // 
            this.poster_pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.poster_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.poster_pictureBox.Name = "poster_pictureBox";
            this.poster_pictureBox.Size = new System.Drawing.Size(203, 360);
            this.poster_pictureBox.TabIndex = 0;
            this.poster_pictureBox.TabStop = false;
            // 
            // mediaName_label
            // 
            this.mediaName_label.AutoSize = true;
            this.mediaName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaName_label.Location = new System.Drawing.Point(209, 13);
            this.mediaName_label.Name = "mediaName_label";
            this.mediaName_label.Size = new System.Drawing.Size(151, 20);
            this.mediaName_label.TabIndex = 1;
            this.mediaName_label.Text = "mediaName_label";
            // 
            // mediaReleaseDate_label
            // 
            this.mediaReleaseDate_label.AutoSize = true;
            this.mediaReleaseDate_label.Location = new System.Drawing.Point(210, 33);
            this.mediaReleaseDate_label.Name = "mediaReleaseDate_label";
            this.mediaReleaseDate_label.Size = new System.Drawing.Size(92, 13);
            this.mediaReleaseDate_label.TabIndex = 2;
            this.mediaReleaseDate_label.Text = "releaseDate_label";
            // 
            // mediaDescription_richTextBox
            // 
            this.mediaDescription_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mediaDescription_richTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.mediaDescription_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaDescription_richTextBox.Location = new System.Drawing.Point(213, 73);
            this.mediaDescription_richTextBox.Name = "mediaDescription_richTextBox";
            this.mediaDescription_richTextBox.ReadOnly = true;
            this.mediaDescription_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.mediaDescription_richTextBox.Size = new System.Drawing.Size(560, 100);
            this.mediaDescription_richTextBox.TabIndex = 3;
            this.mediaDescription_richTextBox.Text = "";
            // 
            // mediaVotesAvg_label
            // 
            this.mediaVotesAvg_label.AutoSize = true;
            this.mediaVotesAvg_label.Location = new System.Drawing.Point(210, 46);
            this.mediaVotesAvg_label.Name = "mediaVotesAvg_label";
            this.mediaVotesAvg_label.Size = new System.Drawing.Size(80, 13);
            this.mediaVotesAvg_label.TabIndex = 4;
            this.mediaVotesAvg_label.Text = "votesAvg_label";
            // 
            // viewReviews_button
            // 
            this.viewReviews_button.AutoSize = true;
            this.viewReviews_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewReviews_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.viewReviews_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.viewReviews_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.viewReviews_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewReviews_button.Location = new System.Drawing.Point(189, 3);
            this.viewReviews_button.Name = "viewReviews_button";
            this.viewReviews_button.Size = new System.Drawing.Size(118, 25);
            this.viewReviews_button.TabIndex = 5;
            this.viewReviews_button.Text = "viewReviews_button";
            this.viewReviews_button.UseVisualStyleBackColor = true;
            this.viewReviews_button.Click += new System.EventHandler(this.viewReviews_button_Click);
            // 
            // watch_button
            // 
            this.watch_button.AutoSize = true;
            this.watch_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.watch_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.watch_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.watch_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.watch_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watch_button.Location = new System.Drawing.Point(99, 3);
            this.watch_button.Name = "watch_button";
            this.watch_button.Size = new System.Drawing.Size(84, 25);
            this.watch_button.TabIndex = 6;
            this.watch_button.Text = "watch_button";
            this.watch_button.UseVisualStyleBackColor = true;
            this.watch_button.Click += new System.EventHandler(this.watch_button_Click);
            // 
            // favorite_button
            // 
            this.favorite_button.AutoSize = true;
            this.favorite_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.favorite_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.favorite_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.favorite_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.favorite_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favorite_button.Location = new System.Drawing.Point(3, 3);
            this.favorite_button.Name = "favorite_button";
            this.favorite_button.Size = new System.Drawing.Size(90, 25);
            this.favorite_button.TabIndex = 7;
            this.favorite_button.Text = "favorite_button";
            this.favorite_button.UseVisualStyleBackColor = true;
            this.favorite_button.Click += new System.EventHandler(this.favorite_button_Click);
            // 
            // viewMediaActions_flowLayoutPanel
            // 
            this.viewMediaActions_flowLayoutPanel.AutoSize = true;
            this.viewMediaActions_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewMediaActions_flowLayoutPanel.Controls.Add(this.favorite_button);
            this.viewMediaActions_flowLayoutPanel.Controls.Add(this.watch_button);
            this.viewMediaActions_flowLayoutPanel.Controls.Add(this.viewReviews_button);
            this.viewMediaActions_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewMediaActions_flowLayoutPanel.Location = new System.Drawing.Point(203, 329);
            this.viewMediaActions_flowLayoutPanel.Name = "viewMediaActions_flowLayoutPanel";
            this.viewMediaActions_flowLayoutPanel.Size = new System.Drawing.Size(582, 31);
            this.viewMediaActions_flowLayoutPanel.TabIndex = 8;
            // 
            // ViewMediaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 360);
            this.Controls.Add(this.viewMediaActions_flowLayoutPanel);
            this.Controls.Add(this.mediaVotesAvg_label);
            this.Controls.Add(this.mediaDescription_richTextBox);
            this.Controls.Add(this.mediaReleaseDate_label);
            this.Controls.Add(this.mediaName_label);
            this.Controls.Add(this.poster_pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewMediaDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewMediaDialog";
            this.Shown += new System.EventHandler(this.ViewMediaDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poster_pictureBox)).EndInit();
            this.viewMediaActions_flowLayoutPanel.ResumeLayout(false);
            this.viewMediaActions_flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox poster_pictureBox;
        private System.Windows.Forms.Label mediaName_label;
        private System.Windows.Forms.Label mediaReleaseDate_label;
        private System.Windows.Forms.RichTextBox mediaDescription_richTextBox;
        private System.Windows.Forms.Label mediaVotesAvg_label;
        private System.Windows.Forms.Button viewReviews_button;
        private System.Windows.Forms.Button watch_button;
        private System.Windows.Forms.Button favorite_button;
        private System.Windows.Forms.FlowLayoutPanel viewMediaActions_flowLayoutPanel;
    }
}