using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View_Account
{
    public partial class LoadingDialog : Form
    {

        // Written, 31.12.2019

        internal string programNameText
        {
            get
            {
                return this.programName_label.Text;
            }
            set 
            {
                this.programName_label.Text = value;
            }
        }
        internal string loadingText 
        {
            get 
            {
                return this.loading_label.Text;
            }
            set 
            {
                this.loading_label.Text = value;
            }
        }
        internal string loadingWhatText 
        {
            get 
            {
                return this.loadingWhat_label.Text;
            }
            set 
            {
                this.loadingWhat_label.Text = value;
            }
        }
        internal string errorMessage 
        {
            get 
            {
                return this.error_label.Text;
            }
            set 
            {
                this.ShowInTaskbar = true;
                this.errorDismiss_button.Visible = true;
                this.error_label.Text = value;
            }
        }
        public LoadingDialog(string inProgramName)
        {
            // Written, 31.12.2019

            InitializeComponent();
            this.programNameText = inProgramName;
            this.error_label.Text = string.Empty;
            this.errorDismiss_button.Text = "Dismiss error";
            this.Update();
        }

        private void errorDismiss_button_Click(object sender, EventArgs e)
        {
            // Written, 31.12.2019

            Environment.Exit(0);
        }
    }
}
