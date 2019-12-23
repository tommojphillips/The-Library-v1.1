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
            ((System.ComponentModel.ISupportInitialize)(this.poster_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // poster_pictureBox
            // 
            this.poster_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.poster_pictureBox.Name = "poster_pictureBox";
            this.poster_pictureBox.Size = new System.Drawing.Size(190, 274);
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
            this.mediaDescription_richTextBox.Location = new System.Drawing.Point(213, 87);
            this.mediaDescription_richTextBox.Name = "mediaDescription_richTextBox";
            this.mediaDescription_richTextBox.ReadOnly = true;
            this.mediaDescription_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.mediaDescription_richTextBox.Size = new System.Drawing.Size(503, 113);
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
            // ViewMediaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 298);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox poster_pictureBox;
        private System.Windows.Forms.Label mediaName_label;
        private System.Windows.Forms.Label mediaReleaseDate_label;
        private System.Windows.Forms.RichTextBox mediaDescription_richTextBox;
        private System.Windows.Forms.Label mediaVotesAvg_label;
    }
}