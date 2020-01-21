using System;
using System.Windows.Forms;
using TM_Db_Lib;
using TM_Db_Lib.Search;

namespace View_Account
{
    public partial class ViewMediaDialog : Form
    {
        // Written, 17.12.2019

        #region Properties

        /// <summary>
        /// Represents the media that is being viewed.
        /// </summary>
        private MediaSearchResult media 
        {

            get;
            set;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of this.
        /// </summary>
        /// <param name="inMedia">The media to view.</param>
        public ViewMediaDialog(MediaSearchResult inMedia)
        {
            // Written, 17.12.2019

            InitializeComponent();

            this.media = inMedia;
            this.Text = String.Format("View Details - {0}", this.media.name);
        }

        #endregion

        #region Event Handlers

        private void ViewMediaDialog_Load(object sender, EventArgs e)
        {
            // Written, 17.12.2019

            this.mediaName_label.Text = "Loading..";
            this.viewReviews_button.Text = "View Reviews";
            this.mediaReleaseDate_label.Text = String.Empty;
            this.mediaVotesAvg_label.Text = String.Empty;
            this.poster_pictureBox.Image = media.poster_image.resizeImage(this.poster_pictureBox.Size.Width, this.poster_pictureBox.Size.Height);
            this.mediaName_label.Text = this.media.name;
            this.mediaReleaseDate_label.Text = this.media.release_date;
            this.mediaDescription_richTextBox.Text = this.media.overview;
            this.mediaVotesAvg_label.Text = String.Format("{0} stars", this.media.vote_average.ToString());
        }
        private async void viewReviews_button_Click(object sender, EventArgs e)
        {
            // Written, 16.01.2020

            if (this.media is TvSearchResult)
                await (media as TvSearchResult).retrieveReviewsAsync();
            else
                await (media as MovieSearchResult).retrieveReviewsAsync();
            if (this.media.reviews.Length > 0)
            {
                ViewReviewsDialog vrd = new ViewReviewsDialog(this.media);
                vrd.ShowDialog();
            }
            else
                MessageBox.Show(String.Format("No reviews for {0}", this.media.name));
        }

        #endregion
    }
}
