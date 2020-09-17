using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;
using TommoJProductions.Net;

namespace TommoJProductions.TMDB.Media
{
    /// <summary>
    /// Represents an episode for a season.
    /// </summary>
    public class Episode : FileReference
    {
        // Written, 13.04.2018

        #region Properties

        /// <summary>
        /// Represents the air date for the episode.
        /// </summary>
        public string air_date
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the episode number.
        /// </summary>
        public int episode_number
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the name of the episode.
        /// </summary>
        public string name
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the overview of the episode.
        /// </summary>
        public string overview
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the id for the episode.
        /// </summary>
        public int id
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the production code for the episode.
        /// </summary>
        public string production_code
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the season number for the episode.
        /// </summary>
        public int season_number
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the still path for the episode.
        /// </summary>
        public string still_path
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the vote average for the episode.
        /// </summary>
        public int vote_average
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the the vote count for the episode.
        /// </summary>
        public int vote_count
        {
            get;
            set;
        }
        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="inPath"></param>
        public Episode(string inPath) : base(inPath)
        {
            // Written, 09.05.2018
        }

        #endregion

        #region Methods

        /// <summary>
        /// Retrieves details about a tv series episode.
        /// </summary>
        /// <param name="inTvID">The tv id.</param>
        /// <param name="inSeasonNumber">the season to get details on. (works like an index.. 0 is the first season)</param>
        /// <param name="inEpisodeNumber">the episode to get details on</param>
        public async Task retrieveDetailsAsync(int inTvID, int inSeasonNumber, int inEpisodeNumber)
        {
            // Written, 21.04.2018

            string address = String.Format("{0}/{1}/season/{2}/episode/{3}?api_key={4}", ApplicationInfomation.TV_ADDRESS, inTvID, inSeasonNumber, inEpisodeNumber, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            Episode episodeResult = jObject.ToObject<Episode>();

            this.air_date = episodeResult.air_date;
            this.episode_number = episodeResult.episode_number;
            this.id = episodeResult.id;
            this.name = episodeResult.name;
            this.overview = episodeResult.overview;
            this.production_code = episodeResult.production_code;
            this.season_number = episodeResult.season_number;
            this.still_path = episodeResult.still_path;
            this.vote_average = episodeResult.vote_average;
            this.vote_count = episodeResult.vote_count;
        }

        #endregion
    }
}
