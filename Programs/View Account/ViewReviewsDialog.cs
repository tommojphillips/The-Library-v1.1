using System;
using System.Windows.Forms;
using TommoJProductions.TMDB;
using TommoJProductions.TMDB.Search;

namespace View_Account
{
    public partial class ViewReviewsDialog : Form
    {

        #region Properties

        /// <summary>
        /// Represents the selected review index.
        /// </summary>
        private int selectedReviewIndex 
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the selected review.
        /// </summary>
        private Review selectedReview 
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the media for the review.
        /// </summary>
        private MediaSearchResult media
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new isntance of this. and sets the media.
        /// </summary>
        /// <param name="inMedia">Sets the media to this.</param>
        public ViewReviewsDialog(MediaSearchResult inMedia)
        {
            InitializeComponent();

            // Written, 21.01.2020

            this.media = inMedia;
            this.selectedReview = this.media.reviews[0];
            this.init();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Represents intiailization logic.
        /// </summary>
        private void init() 
        {
            // Written, 16.01.2020

            this.reviewContent_groupBox.Text = this.selectedReview.author;
            this.reviewUrl_linkLabel.Text = this.selectedReview.url;
            this.mediaDescription_richTextBox.Text = this.selectedReview.content;
            this.numOfReviews_label.Text = String.Format("{0}/{1} Reviews", this.selectedReviewIndex + 1, this.media.reviews.Length);
            if (this.selectedReviewIndex < this.media.reviews.Length-1)
                this.nextReview_button.Enabled = true;
            else
                this.nextReview_button.Enabled = false;
            if (this.selectedReviewIndex > 0)
                this.prevReview_button.Enabled = true;
            else
                this.prevReview_button.Enabled = false;
        }
        /// <summary>
        /// Executes selected review shared logic.
        /// </summary>
        private void selectedReviewChanged()
        {
            // Written, 21.01.2020

            this.selectedReview = this.media.reviews[this.selectedReviewIndex];
            this.init();
        }

        #endregion

        #region Event Handlers

        private void prevReview_button_Click(object sender, EventArgs e)
        {
            // Written, 16.01.2020

            this.selectedReviewIndex--;
            this.selectedReviewChanged();
        }
        private void nextReview_button_Click(object sender, EventArgs e)
        {
            // Written, 16.01.2020

            this.selectedReviewIndex++;
            this.selectedReviewChanged();
        }        
        private void reviewUrl_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Written, 21.01.2020

            System.Diagnostics.Process.Start(this.selectedReview.url);
        }
        
        #endregion
    }
}
