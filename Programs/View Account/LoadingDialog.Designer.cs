namespace View_Account
{
    partial class LoadingDialog
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
            this.loading_label = new System.Windows.Forms.Label();
            this.programName_label = new System.Windows.Forms.Label();
            this.loadingWhat_label = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.errorDismiss_button = new System.Windows.Forms.Button();
            this.tmdbLogo_pictureBox = new System.Windows.Forms.PictureBox();
            this.errorRestartApp_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tmdbLogo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loading_label
            // 
            this.loading_label.AutoSize = true;
            this.loading_label.Font = new System.Drawing.Font("PMingLiU-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_label.Location = new System.Drawing.Point(49, 76);
            this.loading_label.Name = "loading_label";
            this.loading_label.Size = new System.Drawing.Size(222, 40);
            this.loading_label.TabIndex = 0;
            this.loading_label.Text = "loading_label";
            this.loading_label.UseWaitCursor = true;
            // 
            // programName_label
            // 
            this.programName_label.AutoSize = true;
            this.programName_label.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programName_label.Location = new System.Drawing.Point(12, 9);
            this.programName_label.Name = "programName_label";
            this.programName_label.Size = new System.Drawing.Size(220, 27);
            this.programName_label.TabIndex = 1;
            this.programName_label.Text = "programName_label";
            this.programName_label.UseWaitCursor = true;
            // 
            // loadingWhat_label
            // 
            this.loadingWhat_label.AutoSize = true;
            this.loadingWhat_label.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingWhat_label.Location = new System.Drawing.Point(160, 108);
            this.loadingWhat_label.Name = "loadingWhat_label";
            this.loadingWhat_label.Size = new System.Drawing.Size(206, 27);
            this.loadingWhat_label.TabIndex = 2;
            this.loadingWhat_label.Text = "loadingWhat_label";
            this.loadingWhat_label.UseWaitCursor = true;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.Location = new System.Drawing.Point(3, 157);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(88, 20);
            this.error_label.TabIndex = 3;
            this.error_label.Text = "error_label";
            this.error_label.UseWaitCursor = true;
            // 
            // errorDismiss_button
            // 
            this.errorDismiss_button.AutoSize = true;
            this.errorDismiss_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.errorDismiss_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.errorDismiss_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.errorDismiss_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.errorDismiss_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.errorDismiss_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.errorDismiss_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorDismiss_button.Location = new System.Drawing.Point(72, 186);
            this.errorDismiss_button.Name = "errorDismiss_button";
            this.errorDismiss_button.Size = new System.Drawing.Size(147, 29);
            this.errorDismiss_button.TabIndex = 4;
            this.errorDismiss_button.Text = "errorDismiss_button";
            this.errorDismiss_button.UseVisualStyleBackColor = false;
            this.errorDismiss_button.UseWaitCursor = true;
            this.errorDismiss_button.Visible = false;
            this.errorDismiss_button.Click += new System.EventHandler(this.errorDismiss_button_Click);
            // 
            // tmdbLogo_pictureBox
            // 
            this.tmdbLogo_pictureBox.Image = global::View_Account.Properties.Resources.StackedTMDb_Green;
            this.tmdbLogo_pictureBox.Location = new System.Drawing.Point(313, 0);
            this.tmdbLogo_pictureBox.Name = "tmdbLogo_pictureBox";
            this.tmdbLogo_pictureBox.Size = new System.Drawing.Size(100, 100);
            this.tmdbLogo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tmdbLogo_pictureBox.TabIndex = 5;
            this.tmdbLogo_pictureBox.TabStop = false;
            // 
            // errorRestartApp_button
            // 
            this.errorRestartApp_button.AutoSize = true;
            this.errorRestartApp_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.errorRestartApp_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.errorRestartApp_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.errorRestartApp_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.errorRestartApp_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.errorRestartApp_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.errorRestartApp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorRestartApp_button.Location = new System.Drawing.Point(225, 186);
            this.errorRestartApp_button.Name = "errorRestartApp_button";
            this.errorRestartApp_button.Size = new System.Drawing.Size(170, 29);
            this.errorRestartApp_button.TabIndex = 6;
            this.errorRestartApp_button.Text = "errorRestartApp_button";
            this.errorRestartApp_button.UseVisualStyleBackColor = false;
            this.errorRestartApp_button.UseWaitCursor = true;
            this.errorRestartApp_button.Visible = false;
            this.errorRestartApp_button.Click += new System.EventHandler(this.errorRestartApp_button_Click);
            // 
            // LoadingDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(413, 213);
            this.ControlBox = false;
            this.Controls.Add(this.errorRestartApp_button);
            this.Controls.Add(this.tmdbLogo_pictureBox);
            this.Controls.Add(this.errorDismiss_button);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.loadingWhat_label);
            this.Controls.Add(this.programName_label);
            this.Controls.Add(this.loading_label);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingDialog";
            this.Opacity = 0.78D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingDialog";
            ((System.ComponentModel.ISupportInitialize)(this.tmdbLogo_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loading_label;
        private System.Windows.Forms.Label programName_label;
        private System.Windows.Forms.Label loadingWhat_label;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Button errorDismiss_button;
        private System.Windows.Forms.PictureBox tmdbLogo_pictureBox;
        private System.Windows.Forms.Button errorRestartApp_button;
    }
}