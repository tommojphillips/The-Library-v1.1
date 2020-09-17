using System;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using YTS.Models;
using TommoJProductions.Net;
using TommoJProductions.TMDB.Media;

namespace TommoJProductions.YTS
{
    public class YTSManager
    {
        // Written, 14.09.2020

        #region Fields

        public const string YTS_MOVIE_LISTS_ADDRESS = "list_movies.json";
        public const string YTS_MOVIE_DETAILS_ADDRESS = "movie_details.json";
        public const string YTS_ADDRESS_V2 = "https://www.yst.am/api/v2";
        private readonly string[] recommendedTrackerUrls = new string[8] 
        {
            "udp://open.demonii.com:1337/announce",
            "udp://tracker.openbittorrent.com:80",
            "udp://tracker.coppersurfer.tk:6969",
            "udp://glotorrents.pw:6969/announce",
            "udp://tracker.opentrackr.org:1337/announce",
            "udp://torrent.gresille.org:80/announce",
            "udp://p4p.arenabg.com:1337",
            "udp://tracker.leechers-paradise.org:6969",
        };
        private int maxTrackers = 2;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new isntance of <see cref="YTSManager"/>
        /// </summary>
        public YTSManager()
        {
            // Written, 14.09.2020
        }

        #endregion


        #region Methods

        /// <summary>
        /// Gets a list of movies on YTS
        /// </summary>
        public async Task<Response<MovieList>> getMovieList()
        {
            // Written, 15.09.2020

            string address = String.Format("{0}/{1}", YTS_ADDRESS_V2, YTS_MOVIE_LISTS_ADDRESS);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject.ToObject<Response<MovieList>>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inImdbId"></param>
        public async Task<MovieInfo> getMovieDetailsAsync(int inId) 
        {
            // Written, 15.09.2020

            MovieResult tmdbResult = await MovieResult.retrieveDetailsAsync(inId);
            MovieInfo ytsMovieInfo = (await this.getMovieList()).Data.Movies.First(movie_ => movie_.IMDB == tmdbResult.imdb_id);
            return ytsMovieInfo;
        }
        /// <summary>
        /// Creates a torrent magnet url.
        /// </summary>
        /// <param name="inTorrent"></param>
        /// <param name="inName">The name of the magnet torrent file</param>
        /// <param name="inTrackerUrls">The array of trackers to use. NOTE, if no trackers are provided, uses <see cref="recommendedTrackerUrls"/> array provided by YTS as recommended tracker urls</param>
        public Uri createTorrentMagenetUrl(MovieTorrent inTorrent, string inName, params string[] inTrackerUrls) 
        {
            // Written, 17.09.2020

            string[] trackers = inTrackerUrls ?? this.recommendedTrackerUrls;
            string magnetUrl = String.Format("magnet:?xt=urn:btih:{0}&dn={1}", inTorrent.Hash, inName);
            for (int i = 0; i < trackers.Length; i++)
            {
                if (trackers[i] == null)
                    break;
                if (i > this.maxTrackers)
                    break;
                magnetUrl += string.Format("&tr={0}", trackers[i]);
            }
            return new Uri(magnetUrl);
        }
        /// <summary>
        /// Opens a torrent magnet url
        /// </summary>
        public void openTorrentURL()
        {
            // Written, 14.09.2020                   

        }

        #endregion
    }
}
