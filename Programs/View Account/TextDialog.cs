using System.Windows.Forms;

namespace View_Account
{
    /// <summary>
    /// Represents a dialog to retrieve text input from the user.
    /// </summary>
    public partial class TextDialog : Form
    {
        // Written, 09.12.2019

        /// <summary>
        /// Represents the input.
        /// </summary>
        public string textInput 
        {
            get 
            {
                return textInput_textBox.Text;
            }
        }

        public TextDialog(string inProperty, string inTitle)
        {
            // Written, 09.12.2019

            InitializeComponent();

            Text = inTitle;
            textInput_label.Text = inProperty;
        }
    }
}
