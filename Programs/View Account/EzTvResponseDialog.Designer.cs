namespace View_Account
{
    partial class EzTvResponseDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.imdb_id_label = new System.Windows.Forms.Label();
            this.totalTorrents_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Season = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Episode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seeds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Peers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.previousPage_button = new System.Windows.Forms.Button();
            this.page_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nextPage_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listedTorrentsCount_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.page_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imdb id";
            // 
            // imdb_id_label
            // 
            this.imdb_id_label.AutoSize = true;
            this.imdb_id_label.Location = new System.Drawing.Point(50, 0);
            this.imdb_id_label.Name = "imdb_id_label";
            this.imdb_id_label.Size = new System.Drawing.Size(35, 13);
            this.imdb_id_label.TabIndex = 1;
            this.imdb_id_label.Text = "label2";
            // 
            // totalTorrents_label
            // 
            this.totalTorrents_label.AutoSize = true;
            this.totalTorrents_label.Location = new System.Drawing.Point(74, 0);
            this.totalTorrents_label.Name = "totalTorrents_label";
            this.totalTorrents_label.Size = new System.Drawing.Size(35, 13);
            this.totalTorrents_label.TabIndex = 7;
            this.totalTorrents_label.Text = "label7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "total torrents";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Season,
            this.Episode,
            this.Seeds,
            this.Peers,
            this.Hash});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(910, 386);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 367;
            // 
            // Season
            // 
            this.Season.Text = "Season";
            // 
            // Episode
            // 
            this.Episode.Text = "Episode";
            // 
            // Seeds
            // 
            this.Seeds.Text = "Seeds";
            // 
            // Peers
            // 
            this.Peers.Text = "Peers";
            // 
            // Hash
            // 
            this.Hash.Text = "Hash";
            this.Hash.Width = 159;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.query_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Limit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.previousPage_button.TabIndex = 15;
            this.previousPage_button.Text = "<<";
            this.previousPage_button.UseVisualStyleBackColor = true;
            this.previousPage_button.Click += new System.EventHandler(this.previousPage_button_Click);
            // 
            // page_numericUpDown
            // 
            this.page_numericUpDown.AutoSize = true;
            this.page_numericUpDown.Location = new System.Drawing.Point(69, 2);
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
            this.page_numericUpDown.TabIndex = 13;
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
            this.nextPage_button.Location = new System.Drawing.Point(112, 0);
            this.nextPage_button.Margin = new System.Windows.Forms.Padding(0);
            this.nextPage_button.Name = "nextPage_button";
            this.nextPage_button.Size = new System.Drawing.Size(29, 23);
            this.nextPage_button.TabIndex = 14;
            this.nextPage_button.Text = ">>";
            this.nextPage_button.UseVisualStyleBackColor = true;
            this.nextPage_button.Click += new System.EventHandler(this.nextPage_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(32, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Page";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.Location = new System.Drawing.Point(36, 2);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // listedTorrentsCount_label
            // 
            this.listedTorrentsCount_label.AutoSize = true;
            this.listedTorrentsCount_label.Location = new System.Drawing.Point(78, 0);
            this.listedTorrentsCount_label.Name = "listedTorrentsCount_label";
            this.listedTorrentsCount_label.Size = new System.Drawing.Size(126, 13);
            this.listedTorrentsCount_label.TabIndex = 18;
            this.listedTorrentsCount_label.Text = "listedTorrentsCount_label";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "listed torrents";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(910, 486);
            this.splitContainer1.SplitterDistance = 96;
            this.splitContainer1.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 96);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(904, 77);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.previousPage_button);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.page_numericUpDown);
            this.flowLayoutPanel2.Controls.Add(this.nextPage_button);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(602, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(143, 26);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(515, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(81, 26);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.label5);
            this.flowLayoutPanel4.Controls.Add(this.listedTorrentsCount_label);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(209, 15);
            this.flowLayoutPanel4.TabIndex = 9;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel5.Controls.Add(this.label1);
            this.flowLayoutPanel5.Controls.Add(this.imdb_id_label);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(218, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(90, 15);
            this.flowLayoutPanel5.TabIndex = 9;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel6.Controls.Add(this.label3);
            this.flowLayoutPanel6.Controls.Add(this.totalTorrents_label);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(314, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(114, 15);
            this.flowLayoutPanel6.TabIndex = 9;
            // 
            // EzTvResponseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 486);
            this.Controls.Add(this.splitContainer1);
            this.Name = "EzTvResponseDialog";
            this.Text = "EzTvResponseDialog";
            ((System.ComponentModel.ISupportInitialize)(this.page_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label imdb_id_label;
        private System.Windows.Forms.Label totalTorrents_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Season;
        private System.Windows.Forms.ColumnHeader Episode;
        private System.Windows.Forms.ColumnHeader Seeds;
        private System.Windows.Forms.ColumnHeader Peers;
        private System.Windows.Forms.ColumnHeader Hash;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button previousPage_button;
        private System.Windows.Forms.NumericUpDown page_numericUpDown;
        private System.Windows.Forms.Button nextPage_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label listedTorrentsCount_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}