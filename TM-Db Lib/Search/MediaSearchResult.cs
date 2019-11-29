using System.Drawing;
using TM_Db_Lib.Media;

namespace TM_Db_Lib.Search
{
    /// <summary>
    /// Represents information for a derived class.
    /// </summary>
    public class MediaSearchResult : IdResultObject
    {
        // Written, 06.04.2018

        #region Properties

        /// <summary>
        /// Represents the name of the media item.
        /// </summary>
        public virtual string name 
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the original name for the media item.
        /// </summary>        
        public virtual string original_name
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the release date for the media item.
        /// </summary>
        public virtual string release_date
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
