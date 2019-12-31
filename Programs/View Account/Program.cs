using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View_Account
{
    static class Program
    {
        static viewAccount_Form viewAccount_Form;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            viewAccount_Form = new viewAccount_Form();
            if (viewAccount_Form.loginTMDbAsync().Result)
            {
                Application.Run(viewAccount_Form);
            }
        }
    }
}
