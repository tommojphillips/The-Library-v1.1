namespace View_Account
{
    partial class LoginDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rememberLogonDetaisl_checkBox = new System.Windows.Forms.CheckBox();
            this.login_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.register_linkLabel = new System.Windows.Forms.LinkLabel();
            this.username_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.username_flowLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.rememberLogonDetaisl_checkBox);
            this.groupBox1.Controls.Add(this.login_button);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.register_linkLabel);
            this.groupBox1.Controls.Add(this.username_flowLayoutPanel);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TMDb Login";
            // 
            // rememberLogonDetaisl_checkBox
            // 
            this.rememberLogonDetaisl_checkBox.AutoSize = true;
            this.rememberLogonDetaisl_checkBox.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rememberLogonDetaisl_checkBox.Enabled = false;
            this.rememberLogonDetaisl_checkBox.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.rememberLogonDetaisl_checkBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.rememberLogonDetaisl_checkBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.rememberLogonDetaisl_checkBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.rememberLogonDetaisl_checkBox.Location = new System.Drawing.Point(115, 117);
            this.rememberLogonDetaisl_checkBox.Name = "rememberLogonDetaisl_checkBox";
            this.rememberLogonDetaisl_checkBox.Size = new System.Drawing.Size(116, 17);
            this.rememberLogonDetaisl_checkBox.TabIndex = 12;
            this.rememberLogonDetaisl_checkBox.Text = "Remember details?";
            this.rememberLogonDetaisl_checkBox.UseVisualStyleBackColor = true;
            // 
            // login_button
            // 
            this.login_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.login_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.ForeColor = System.Drawing.Color.DimGray;
            this.login_button.Location = new System.Drawing.Point(337, 113);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 11;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(518, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "View Account";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // register_linkLabel
            // 
            this.register_linkLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.register_linkLabel.Location = new System.Drawing.Point(3, 190);
            this.register_linkLabel.Name = "register_linkLabel";
            this.register_linkLabel.Size = new System.Drawing.Size(518, 13);
            this.register_linkLabel.TabIndex = 9;
            this.register_linkLabel.TabStop = true;
            this.register_linkLabel.Text = "Register a TMDb account";
            this.register_linkLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // username_flowLayoutPanel
            // 
            this.username_flowLayoutPanel.AutoSize = true;
            this.username_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.username_flowLayoutPanel.Controls.Add(this.label1);
            this.username_flowLayoutPanel.Controls.Add(this.username_textBox);
            this.username_flowLayoutPanel.Location = new System.Drawing.Point(89, 53);
            this.username_flowLayoutPanel.Name = "username_flowLayoutPanel";
            this.username_flowLayoutPanel.Size = new System.Drawing.Size(323, 26);
            this.username_flowLayoutPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(103, 3);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(217, 20);
            this.username_textBox.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.password_textBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(89, 85);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(323, 26);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(103, 3);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(217, 20);
            this.password_textBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View_Account.Properties.Resources.PoweredByTMDb_RectangleGreen;
            this.pictureBox1.Location = new System.Drawing.Point(6, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // LoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 206);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.username_flowLayoutPanel.ResumeLayout(false);
            this.username_flowLayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox rememberLogonDetaisl_checkBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel register_linkLabel;
        private System.Windows.Forms.FlowLayoutPanel username_flowLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}