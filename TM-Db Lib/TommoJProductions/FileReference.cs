using System.IO;

namespace TommoJProductions
{
    /// <summary>
    /// Represents an abstract class that holds infomation about a reference to a file.
    /// </summary>
    public abstract class FileReference
    {
        // Written, 24.11.2019

        #region Properties

        /// <summary>
        /// Represents the file location.
        /// </summary>
        internal virtual string path
        {
            get;
            private set;
        }
        /// <summary>
        /// Represents the file name. Gets the filename from the file location (<see cref="this.path"/>) provided.
        /// </summary>
        internal string fileName
        {
            get
            {
                return Path.GetFileNameWithoutExtension(this.path);
            }
        }

        internal string fileExtention
        {
            get
            {
                return Path.GetExtension(this.path);
            }
        }


        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="FileReference"/> and sets <see cref="this.path"/> to the parameter, <paramref name="path"/>.
        /// </summary>
        /// <param name="path">the path to set.</param>
        internal FileReference(string inPath)
        {
            // Written, 13.04.2018

            this.path = inPath;
        }

        #endregion

        #region Methods 

        /// <summary>
        /// Sets the path for the instance.
        /// </summary>
        /// <param name="inPath">The file location to set the path to.</param>
        internal void setPath(string inPath)
        {
            // Written, 20.04.2018

            this.path = inPath;
        }

        #endregion
    }
}
