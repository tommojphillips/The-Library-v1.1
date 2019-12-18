namespace TM_Db_Lib.Configuration
{
    /// <summary>
    /// Represents image config data.
    /// To build an image URL, you will need 3 pieces of data. The base_url, size and file_path. Simply combine them all and you will have a fully qualified URL.
    /// </summary>
    public class ImageConfigObject
    {
        // Written, 09.12.2019

        #region Properties

        /// <summary>
        /// Represents the base url for retrieving images.
        /// </summary>
        public string base_url 
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the secure base url for retrieving images.
        /// </summary>
        public string secure_base_url 
        {
            get;
            set;
        }
        /// <summary>
        /// Represents all vaild backdrop image sizes.
        /// </summary>
        public string[] backdrop_sizes 
        {
            get;
            set;
        }
        /// <summary>
        /// Represents all vaild logo image sizes.
        /// </summary>
        public string[] logo_sizes
        {
            get;
            set;
        }
        /// <summary>
        /// Represents all vaild poster image sizes.
        /// </summary>
        public string[] poster_sizes
        {
            get;
            set;
        }
        /// <summary>
        /// Represents all vaild profile image sizes.
        /// </summary>
        public string[] profile_sizes
        {
            get;
            set;
        }
        /// <summary>
        /// Represents all vaild still image sizes.
        /// </summary>
        public string[] still_sizes
        {
            get;
            set;
        }

        #endregion
    }
}
