using System;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TommoJProductions.Net;
using TommoJProductions.TMDB.Media;
using TommoJProductions.YTS.EndPointParameters;
using System.Diagnostics;
using TommoJProductions.YTS.Structure;

namespace TommoJProductions.YTS
{
    /// <summary>
    /// Represents a YTS API Manager.
    /// </summary>
    public class YTSManager
    {
        // Written, 14.09.2020

        #region Fields

        /// <summary>
        /// Represents the yts movie list address.
        /// </summary>
        public const string YTS_MOVIE_LISTS_ADDRESS = "list_movies.json";
        /// <summary>
        /// Represents the yts movie details address.
        /// </summary>
        public const string YTS_MOVIE_DETAILS_ADDRESS = "movie_details.json";
        /// <summary>
        /// Represents yts main domain.
        /// </summary>
        public const string YTS_ADDRESS_V2 = "https://www.yst.am/api/v2";
        /// <summary>
        /// Represents yts recommended trackers (8) in total
        /// </summary>
        public static string[] getRecommendedTrackerUrls
        {
            get
            {
                return new string[8]
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
            }
        }
        /// <summary>
        /// Represents the max amount of trackers to apply to torrent magnet urls.
        /// </summary>
        public static int maxTrackers = 2;

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
        /// Gets a list of movies on YTS based on the end point parameters provided.
        /// </summary>
        public static async Task<Response> retrieveMovieListAsync(MovieListEndPointParameters inEndPointParameters)
        {
            // Written, 17.09.2020

            string parameters = String.Format("limit={0}&page={1}&quality={2}&minimum_rating={3}&query_term={4}&genre={5}&sort_by={6}&order_by={7}", inEndPointParameters.limit, inEndPointParameters.page,
                Enum.GetName(typeof(QualityEndPointParameterEnum), inEndPointParameters.quality).Replace("_", ""), inEndPointParameters.minRating, inEndPointParameters.query, inEndPointParameters.genre,
                Enum.GetName(typeof(SortByEndPointParameterEnum), inEndPointParameters.sortBy), Enum.GetName(typeof(OrderByEndPointParameterEnum), inEndPointParameters.orderBy));
            string address = String.Format("{0}/{1}?{2}", YTS_ADDRESS_V2, YTS_MOVIE_LISTS_ADDRESS, parameters);            
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject.ToObject<Response>();
        }
        /// <summary>
        /// Gets a list of movies on YTS based on the query provided.
        /// </summary>
        public static async Task<Response> searchMovieListAsync(string inQuery)
        {
            // Written, 17.09.2020

            string parameters = String.Format("query_term={0}", inQuery);
            string address = String.Format("{0}/{1}?{2}", YTS_ADDRESS_V2, YTS_MOVIE_LISTS_ADDRESS, parameters);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject.ToObject<Response>();
        }
        /// <summary>
        /// Creates a torrent magnet url.
        /// </summary>
        /// <param name="inTorrent"></param>
        /// <param name="inName">The name of the magnet torrent file</param>
        /// <param name="inTrackerUrls">The array of trackers to use. NOTE, if no trackers are provided, uses <see cref="getRecommendedTrackerUrls"/> array provided by YTS as recommended tracker urls</param>
        public static Uri createTorrentMagenetUrl(TorrentInfo inTorrent, string inName, params string[] inTrackerUrls) 
        {
            // Written, 17.09.2020

            string[] trackers = inTrackerUrls ?? getRecommendedTrackerUrls;
            string magnetUrl = String.Format("magnet:?xt=urn:btih:{0}&dn={1}", inTorrent.hash, inName);
            for (int i = 0; i < trackers.Length; i++)
            {
                if (trackers[i] == null)
                    break;
                if (i > maxTrackers)
                    break;
                magnetUrl += string.Format("&tr={0}", trackers[i]);
            }
            return new Uri(magnetUrl);
        }
        /// <summary>
        /// Opens a torrent magnet url
        /// </summary>
        public static void openURL(Uri inUrl)
        {
            // Written, 14.09.2020                   

            Process.Start(new ProcessStartInfo(inUrl.AbsoluteUri));
        }

        #endregion
    }
}
