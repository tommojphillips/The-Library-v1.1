using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TM_Db_Lib;
using TM_Db_Lib.Media;
using TM_Db_Lib.Search;

namespace View_Account
{
    public partial class ViewMediaDialog : Form
    {
        // Written, 17.12.2019

        #region Properties

        private MediaSearchResult media 
        {

            get;
            set;
        }

        #endregion

        #region Constructors

        public ViewMediaDialog(MediaSearchResult inMedia)
        {
            // Written, 17.12.2019

            InitializeComponent();

            this.media = inMedia;
            this.Text = String.Format("View Details - {0}", this.media.name);
        }

        #endregion

        private void ViewMediaDialog_Load(object sender, EventArgs e)
        {
            this.mediaName_label.Text = "Loading..";
            this.mediaReleaseDate_label.Text = String.Empty;
            this.mediaVotesAvg_label.Text = String.Empty;
            this.poster_pictureBox.Image = media.poster_image.resizeImage(this.poster_pictureBox.Size.Width, this.poster_pictureBox.Size.Height);
            this.mediaName_label.Text = this.media.name;
            this.mediaReleaseDate_label.Text = this.media.release_date;
            this.mediaDescription_richTextBox.Text = this.media.overview;
            this.mediaVotesAvg_label.Text = String.Format("{0} stars", this.media.vote_average.ToString());
        }
    }
}
