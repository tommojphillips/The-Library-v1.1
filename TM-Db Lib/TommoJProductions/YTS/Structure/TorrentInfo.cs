using System;

namespace TommoJProductions.YTS.Structure
{
    /// <summary>
    /// Represents torrent infomation for yts api.
    /// </summary>
    public class TorrentInfo
    {
        // Written, 19.09.2020

        /// <summary>
        /// Represents the date uploaded. eg. 2020-09-19 06:29:40
        /// </summary>
        public string date_uploaded;
        /// <summary>
        /// Represents the torrents hash. eg. 46FEBA774DF76E625FC...
        /// </summary>
        public string hash;
        /// <summary>
        /// Repersents the number of peers the torrent has. eg. 10
        /// </summary>
        public int peers;
        /// <summary>
        /// Represents the number of seeds the torrent has. eg. 8
        /// </summary>
        public int seeds;
        /// <summary>
        /// Represents the quality of the file. eg. 720p
        /// </summary>
        public string quality;
        /// <summary>
        /// Represents the size of the file. eg. 1.08 GB
        /// </summary>
        public string size;
        /// <summary>
        /// Represents the size in bytes. eg. (1159641170)
        /// </summary>
        public long size_bytes;
        /// <summary>
        /// Represents the type of file. eg. bluray, web
        /// </summary>
        public string type;
    }
}
