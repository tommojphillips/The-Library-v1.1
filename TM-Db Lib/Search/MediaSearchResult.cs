using System.Drawing;

namespace TM_Db_Lib.Search
{
    /// <summary>
    /// Represents information for a derived class.
    /// </summary>
    public abstract class MediaSearchResult
    {
        // Written, 06.04.2018

        #region Properties

        /// <summary>
        /// Represents the ID for the result.
        /// </summary>
        public int id
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the genre ID for the result.
        /// </summary>
        public virtual int[] genre_ids
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the overview for the result.
        /// </summary>
        public string overview
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the original laugauge for the result.
        /// </summary>
        public string original_laugauge
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the poster path for the result.
        /// </summary>
        public string poster_path
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the backdrop path for the result.
        /// </summary>
        public string backdrop_path
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the popularity for the result.
        /// </summary>
        public double popularity
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the vote average for the result.
        /// </summary>
        public double vote_average
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the total votes for the result.
        /// </summary>
        public int vote_count
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the poster image for the result.
        /// </summary>
        public Image poster_image
        {
            get;
            protected set;
        }
        /// <summary>
        /// Represents the backdrop image for the result.
        /// </summary>
        public Image backdrop_image
        {
            get;
            protected set;
        }

        #endregion
    }
}
