using System.Diagnostics;
using System.Windows.Forms;

namespace View_Account
{
    public partial class LoginDialog : Form
    {
        // Written, early 2020

        public string username
        {
            get
            {
                return this.username_textBox.Text;
            }
        }
        public string password
        {
            get
            {
                return this.password_textBox.Text;
            }
        }
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void register_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Written, 17.09.2020

            Process.Start(new ProcessStartInfo("https://www.themoviedb.org/signup"));
        }
    }
}
