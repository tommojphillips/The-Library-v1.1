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
    public partial class LoginDialog : Form
    {
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
    }
}
