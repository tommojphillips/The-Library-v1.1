namespace TM_Db_Lib.Certifications
{
    /// <summary>
    /// Represents properties for a certification.
    /// </summary>
    public class CertObject
    {
        // Written, 09.01.2020

        #region Properties 

        /// <summary>
        /// Represents the certification rating.
        /// </summary>
        public string certification 
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the meaning of the rating.
        /// </summary>
        public string meaning 
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the order of the rate.
        /// </summary>
        public int order 
        {
            get;
            set;
        }

        #endregion
    }
}
