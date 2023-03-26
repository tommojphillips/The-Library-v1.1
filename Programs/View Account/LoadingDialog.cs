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
                return programName_label.Text;
            }
            set 
            {
                programName_label.Text = value;
            }
        }
        internal string loadingText 
        {
            get 
            {
                return loading_label.Text;
            }
            set 
            {
                loading_label.Text = value;
            }
        }
        internal string loadingWhatText 
        {
            get 
            {
                return loadingWhat_label.Text;
            }
            set 
            {
                loadingWhat_label.Text = value;
            }
        }
        internal string errorMessage 
        {
            get 
            {
                return error_label.Text;
            }
            set 
            {
                ShowInTaskbar = true;
                errorDismiss_button.Visible = true;
                errorRestartApp_button.Visible = true;
                error_label.Text = value;
            }
        }
        public LoadingDialog(string inProgramName)
        {
            // Written, 31.12.2019

            InitializeComponent();
            programNameText = inProgramName;
            error_label.Text = string.Empty;
            errorDismiss_button.Text = "Dismiss error";
            errorRestartApp_button.Text = "Restart";
            Update();
        }

        private void errorDismiss_button_Click(object sender, EventArgs e)
        {
            // Written, 31.12.2019

            Environment.Exit(0);
        }

        private void errorRestartApp_button_Click(object sender, EventArgs e)
        {
            // Written, 14.09.2020

            Application.Restart();
        }
    }
}
