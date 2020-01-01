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

        internal string loadingWhatText 
        {
            set 
            {
                this.loadingWhat_label.Text = value;
            }
        }
        internal string errorMessage 
        {
            set 
            {
                this.errorDismiss_button.Visible = true;
                this.error_label.Text = value;
            }
        }
        public LoadingDialog(string inProgramName, string inLoadingText, string inLoadingWhatText)
        {
            // Written, 31.12.2019

            InitializeComponent();
            this.programName_label.Text = inProgramName;
            this.loading_label.Text = inLoadingText;
            this.loadingWhatText = inLoadingWhatText;
            this.error_label.Text = string.Empty;
            this.Update();
        }

        private void errorDismiss_button_Click(object sender, EventArgs e)
        {
            // Written, 31.12.2019

            this.DialogResult = DialogResult.OK;
        }
    }
}
