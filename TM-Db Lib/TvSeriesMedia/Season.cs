using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using TM_Db_Lib.Net;

namespace TM_Db_Lib.TvSeriesMedia
{
    /// <summary>
    /// Represents a season for a tv series.
    /// </summary>
    public class Season : FileReference
    {
        // Written, 13.04.2018

        #region Properties

        /// <summary>
        /// Represents the episodes for the season.
        /// </summary>
        public List<Episode> episodes
        {
            get;
            set;
        } = new List<Episode>();
        /// <summary>
        /// Represents the name for the season.
        /// </summary>
        public string name
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the overview of the season.
        /// </summary>
        public string overview
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the id for the season.
        /// </summary>
        public int id
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the poster path for the season.
        /// </summary>
        public string poster_path
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the season number.
        /// </summary>
        public int season_number
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the air date for the season.
        /// </summary>
        public string air_date
        {
            get;
            set;
        }
        /// <summary>
        /// represents another id for the season.
        /// </summary>
        public string _id
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
        public Season(string inPath) : base(inPath)
        {
            // Written, 20.04.2018
        }

        #endregion

        #region Methods

       /* /// <summary>
        /// Returns <see langword="true"/> if TMDb has that episode by num.
        /// </summary>
        /// <param name="tvID">Tv ID.</param>
        /// <param name="epNum">Episode Number.</param>
        /// <returns></returns>
        public async Task<bool> hasEpisode(int tvID, int epNum)
        {
            // Written, 02.05.2018

            Episode episode = new Episode(null);
            try
            {
                await episode.retrieveDetailsAsync(tvID, this.season_number, epNum);
                return true;
            }
            catch
            {
                return false;
            }

        }*/
        /// <summary>
        /// Retrieves details about a tv series season.
        /// </summary>
        /// <param name="tvID">The tv id.</param>
        /// <param name="inSeasonNumber">the season to get details on. (works like an array index.. 0 is the first season)</param>
        public async Task retrieveDetailsAsync(int inTvID, int inSeasonNumber)
        {
            // Written, 21.04.2018

            string address = String.Format("{0}/{1}/season/{2}?api_key={3}", ApplicationInfomation.TV_BASE_ADDRESS, inTvID, inSeasonNumber, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            Season seasonResult;
            seasonResult = jObject.ToObject<Season>();
            this.name = seasonResult.name;
            this.overview = seasonResult.overview;
            this.id = seasonResult.id;
            this.poster_path = seasonResult.poster_path;
            this.season_number = seasonResult.season_number;
            this.air_date = seasonResult.air_date;
            this._id = seasonResult._id;
            this.episodes.ForEach(async episode => await episode.retrieveDetailsAsync(inTvID, inSeasonNumber, episode.episode_number));
        }

        #endregion
    }
}
