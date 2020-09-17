using Newtonsoft.Json;

namespace TommoJProductions.TMDB
{
    /// <summary>
    /// Represents a review. Get the user reviews for a media item, (movie or tv series).
    /// </summary>
    public class Review
    {
        // Written, 01.12.2019

        #region Properties

        /// <summary>
        /// Represents the review id.
        /// </summary>
        [JsonProperty("id")]
        public string reviewID
        {
            get; set;
        }
        /// <summary>
        /// Represents the author of the review
        /// </summary>
        public string author
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the content of the review.
        /// </summary>
        public string content
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the url for the review.
        /// </summary>
        public string url
        {
            get;
            set;
        }

        #endregion 
    }
}
