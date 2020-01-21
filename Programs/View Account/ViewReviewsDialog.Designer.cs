namespace View_Account
{
    partial class ViewReviewsDialog
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
            this.nextReview_button = new System.Windows.Forms.Button();
            this.prevReview_button = new System.Windows.Forms.Button();
            this.reviewUrl_linkLabel = new System.Windows.Forms.LinkLabel();
            this.mediaDescription_richTextBox = new System.Windows.Forms.RichTextBox();
            this.numOfReviews_label = new System.Windows.Forms.Label();
            this.reviewContent_groupBox = new System.Windows.Forms.GroupBox();
            this.reviewContent_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextReview_button
            // 
            this.nextReview_button.AutoSize = true;
            this.nextReview_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextReview_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextReview_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.nextReview_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.nextReview_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextReview_button.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.nextReview_button.Location = new System.Drawing.Point(582, 0);
            this.nextReview_button.Name = "nextReview_button";
            this.nextReview_button.Padding = new System.Windows.Forms.Padding(3);
            this.nextReview_button.Size = new System.Drawing.Size(47, 268);
            this.nextReview_button.TabIndex = 0;
            this.nextReview_button.Text = "Next";
            this.nextReview_button.UseVisualStyleBackColor = true;
            this.nextReview_button.Click += new System.EventHandler(this.nextReview_button_Click);
            // 
            // prevReview_button
            // 
            this.prevReview_button.AutoSize = true;
            this.prevReview_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.prevReview_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.prevReview_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.prevReview_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.prevReview_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevReview_button.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.prevReview_button.Location = new System.Drawing.Point(0, 0);
            this.prevReview_button.Name = "prevReview_button";
            this.prevReview_button.Padding = new System.Windows.Forms.Padding(3);
            this.prevReview_button.Size = new System.Drawing.Size(47, 268);
            this.prevReview_button.TabIndex = 1;
            this.prevReview_button.Text = "Prev";
            this.prevReview_button.UseVisualStyleBackColor = true;
            this.prevReview_button.Click += new System.EventHandler(this.prevReview_button_Click);
            // 
            // reviewUrl_linkLabel
            // 
            this.reviewUrl_linkLabel.AutoSize = true;
            this.reviewUrl_linkLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reviewUrl_linkLabel.Location = new System.Drawing.Point(47, 255);
            this.reviewUrl_linkLabel.Name = "reviewUrl_linkLabel";
            this.reviewUrl_linkLabel.Size = new System.Drawing.Size(99, 13);
            this.reviewUrl_linkLabel.TabIndex = 3;
            this.reviewUrl_linkLabel.TabStop = true;
            this.reviewUrl_linkLabel.Text = "reviewUrl_linkLabel";
            this.reviewUrl_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reviewUrl_linkLabel_LinkClicked);
            // 
            // mediaDescription_richTextBox
            // 
            this.mediaDescription_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mediaDescription_richTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.mediaDescription_richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaDescription_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaDescription_richTextBox.Location = new System.Drawing.Point(3, 16);
            this.mediaDescription_richTextBox.Name = "mediaDescription_richTextBox";
            this.mediaDescription_richTextBox.ReadOnly = true;
            this.mediaDescription_richTextBox.Size = new System.Drawing.Size(529, 223);
            this.mediaDescription_richTextBox.TabIndex = 4;
            this.mediaDescription_richTextBox.Text = "";
            // 
            // numOfReviews_label
            // 
            this.numOfReviews_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.numOfReviews_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfReviews_label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.numOfReviews_label.Location = new System.Drawing.Point(47, 0);
            this.numOfReviews_label.Name = "numOfReviews_label";
            this.numOfReviews_label.Size = new System.Drawing.Size(535, 13);
            this.numOfReviews_label.TabIndex = 5;
            this.numOfReviews_label.Text = "numOfReviews_label";
            this.numOfReviews_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // reviewContent_groupBox
            // 
            this.reviewContent_groupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reviewContent_groupBox.Controls.Add(this.mediaDescription_richTextBox);
            this.reviewContent_groupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.reviewContent_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewContent_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewContent_groupBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.reviewContent_groupBox.Location = new System.Drawing.Point(47, 13);
            this.reviewContent_groupBox.Name = "reviewContent_groupBox";
            this.reviewContent_groupBox.Size = new System.Drawing.Size(535, 242);
            this.reviewContent_groupBox.TabIndex = 6;
            this.reviewContent_groupBox.TabStop = false;
            this.reviewContent_groupBox.Text = "reviewContent";
            // 
            // ViewReviewsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 268);
            this.Controls.Add(this.reviewContent_groupBox);
            this.Controls.Add(this.numOfReviews_label);
            this.Controls.Add(this.reviewUrl_linkLabel);
            this.Controls.Add(this.prevReview_button);
            this.Controls.Add(this.nextReview_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewReviewsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewReviewsDialog";
            this.reviewContent_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextReview_button;
        private System.Windows.Forms.Button prevReview_button;
        private System.Windows.Forms.LinkLabel reviewUrl_linkLabel;
        private System.Windows.Forms.RichTextBox mediaDescription_richTextBox;
        private System.Windows.Forms.Label numOfReviews_label;
        private System.Windows.Forms.GroupBox reviewContent_groupBox;
    }
}