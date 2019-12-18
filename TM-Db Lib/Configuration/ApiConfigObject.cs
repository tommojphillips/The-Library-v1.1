namespace TM_Db_Lib.Configuration
{
    /// <summary>
    /// Holds the data relevant to building image URLs as well as the change key map.
    /// </summary>
    public class ApiConfigObject
    {
        // Written, 09.12.2019

        #region Properties

        /// <summary>
        /// Holds image config data.
        /// </summary>
        public ImageConfigObject images 
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the change keys data.
        /// </summary>
        public string[] change_keys
        {
            get;
            set;
        }

        #endregion
    }
}
