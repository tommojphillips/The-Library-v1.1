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

            media = inMedia;
            selectedReview = media.reviews[0];
            init();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Represents intiailization logic.
        /// </summary>
        private void init() 
        {
            // Written, 16.01.2020

            reviewContent_groupBox.Text = selectedReview.author;
            reviewUrl_linkLabel.Text = selectedReview.url;
            mediaDescription_richTextBox.Text = selectedReview.content;
            numOfReviews_label.Text = String.Format("{0}/{1} Reviews", selectedReviewIndex + 1, media.reviews.Length);
            if (selectedReviewIndex < media.reviews.Length-1)
                nextReview_button.Enabled = true;
            else
                nextReview_button.Enabled = false;
            if (selectedReviewIndex > 0)
                prevReview_button.Enabled = true;
            else
                prevReview_button.Enabled = false;
        }
        /// <summary>
        /// Executes selected review shared logic.
        /// </summary>
        private void selectedReviewChanged()
        {
            // Written, 21.01.2020

            selectedReview = media.reviews[selectedReviewIndex];
            init();
        }

        #endregion

        #region Event Handlers

        private void prevReview_button_Click(object sender, EventArgs e)
        {
            // Written, 16.01.2020

            selectedReviewIndex--;
            selectedReviewChanged();
        }
        private void nextReview_button_Click(object sender, EventArgs e)
        {
            // Written, 16.01.2020

            selectedReviewIndex++;
            selectedReviewChanged();
        }        
        private void reviewUrl_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Written, 21.01.2020

            System.Diagnostics.Process.Start(selectedReview.url);
        }
        
        #endregion
    }
}
