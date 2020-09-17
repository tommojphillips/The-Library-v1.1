namespace View_Account
{
    partial class TextDialog
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
            this.textInput_textBox = new System.Windows.Forms.TextBox();
            this.textInput_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textInput_textBox
            // 
            this.textInput_textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.textInput_textBox.Location = new System.Drawing.Point(0, 17);
            this.textInput_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textInput_textBox.Name = "textInput_textBox";
            this.textInput_textBox.Size = new System.Drawing.Size(291, 22);
            this.textInput_textBox.TabIndex = 0;
            // 
            // textInput_label
            // 
            this.textInput_label.AutoSize = true;
            this.textInput_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.textInput_label.Location = new System.Drawing.Point(0, 0);
            this.textInput_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textInput_label.Name = "textInput_label";
            this.textInput_label.Size = new System.Drawing.Size(99, 17);
            this.textInput_label.TabIndex = 1;
            this.textInput_label.Text = "textInput_label";
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.Color.Transparent;
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.ok_button.FlatAppearance.BorderSize = 0;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Location = new System.Drawing.Point(0, 39);
            this.ok_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(291, 28);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = false;
            // 
            // TextDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 73);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.textInput_textBox);
            this.Controls.Add(this.textInput_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TextDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TextDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInput_textBox;
        private System.Windows.Forms.Label textInput_label;
        private System.Windows.Forms.Button ok_button;
    }
}