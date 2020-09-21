using Newtonsoft.Json;

namespace TommoJProductions.YTS.Structure
{
    /// <summary>
    /// Represents the movie response object from a request to yts.
    /// </summary>
    public class MovieInfo
    {
        // Written, 19.09.2020

        /// <summary>
        /// Represents the background image url.
        /// </summary>
        [JsonProperty("large_cover_image")]
        public string poster_path;
        /// <summary>
        /// Represents the movies upload date.
        /// </summary>
        public string date_uploaded;
        /// <summary>
        /// Represents the full description.
        /// </summary>
        public string description_full;
        /// <summary>
        /// Represents the id of the movie. (unknown id) possibly yify code..?
        /// </summary>
        public int id;
        /// <summary>
        /// Represents the imdb_code.
        /// </summary>
        public string imdb_code;
        /// <summary>
        /// Represents the movie rating, pressumably imdb rating. eg 4.8
        /// </summary>
        public float rating;
        /// <summary>
        /// Represents the runtime in minutes. eg. 101, 84
        /// </summary>
        public int runtime;
        /// <summary>
        /// Represents the movies' title.
        /// </summary>
        public string title;
        /// <summary>
        /// Represents the release year of the movie.
        /// </summary>
        public int year;
        /// <summary>
        /// Represents the torrents avaliable for movie.
        /// </summary>
        public TorrentInfo[] torrents;
    }
}
