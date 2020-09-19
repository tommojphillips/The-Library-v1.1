using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;
using TommoJProductions.TMDB.Media;
using TommoJProductions.Net;
using TommoJProductions.TMDB.Search;

namespace TommoJProductions.TMDB.Account
{
    /// <summary>
    /// Represents a TMDb User Account.
    /// </summary>
    public class User : IdResultObject
    {
        // Written, 04.12.2019

        #region Properties

        /// <summary>
        /// Represents the users avatar.
        /// </summary>
        public object avatar
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the users username.
        /// </summary>
        public string username
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the users name
        /// </summary>
        public string name
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the users include adult value.
        /// </summary>
        public bool include_adult
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the users ...
        /// </summary>
        public string iso_639_1
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the users ...
        /// </summary>
        public string iso_3166_1
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the auth session.
        /// </summary>
        public Auth.Session session
        {
            get;
            set;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Retrieves user details.
        /// </summary>
        /// <param name="inSessionId">The session id.</param>
        public static async Task<User> retrieveUserDetailsAsync(string inSessionId)
        {
            // Written, 04.12.2019

            string address = String.Format("{0}?session_id={1}&api_key={2}", ApplicationInfomation.ACCOUNT_ADDRESS, inSessionId, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            User user = jObject.ToObject<User>();
            user.session = new Auth.Session()
            {
                session_id = inSessionId,
                success = true,
            };
            return user;
        }
        /// <summary>
        /// Adds or removes a media item from the user's watchlist.
        /// </summary>
        /// <param name="inMediaType">The media item type to add or remove from watchlist. Either, <see cref="MediaTypeEnum.movie"/> or <see cref="MediaTypeEnum.tv"/>.</param>
        /// <param name="inMediaId">The media's ID.</param>
        /// <param name="inWatchlist">Add or remove media item from watchlist.</param>
        public async Task watchlistMediaItem(MediaTypeEnum inMediaType, int inMediaId, bool inWatchlist)
        {
            // Written, 05.12.2019

            if (inMediaType != MediaTypeEnum.movie && inMediaType != MediaTypeEnum.tv)
                throw new ArgumentException("Expected MediaTypeEnum.movie or MediaTypeEnum.tv. invaild argument");

            string address = String.Format("{0}/{1}/watchlist?session_id={2}&api_key={3}", ApplicationInfomation.ACCOUNT_ADDRESS, this.id, this.session.session_id, ApplicationInfomation.API_KEY);
            JObject requestData = new JObject(
                new JProperty("media_type", inMediaType.ToString()),
                new JProperty("media_id", inMediaId),
                new JProperty("watchlist", inWatchlist));
            await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address), System.Text.Encoding.UTF8.GetBytes(requestData.ToString())));
        }
        /// <summary>
        /// Retrieves watchlisted movies. max 20 items per page.
        /// </summary>
        /// <param name="inPage">The page of watched movies to retrieve. max 20 items per page.</param>
        public async Task<MovieSearchResult[]> getWatchlistMovies(int inPage = 1)
        {
            // Written, 01.01.2020

            string address = String.Format("{0}/{1}/watchlist/movies?session_id={2}&api_key={3}&page={4}",
                ApplicationInfomation.ACCOUNT_ADDRESS, this.id, this.session.session_id, ApplicationInfomation.API_KEY, inPage);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject["results"].ToObject<MovieSearchResult[]>();
        }
        /// <summary>
        /// Retrieves watchlisted tv series. max 20 items per page. max 20 items per page.
        /// </summary>
        /// <param name="inPage">The page of watched tv series to retrieve. max 20 items per page.</param>
        public async Task<TvSearchResult[]> getWatchlistTvSeries(int inPage = 1)
        {
            // Written, 01.01.2020

            string address = String.Format("{0}/{1}/watchlist/tv?session_id={2}&api_key={3}&page={4}",
                ApplicationInfomation.ACCOUNT_ADDRESS, this.id, this.session.session_id, ApplicationInfomation.API_KEY, inPage);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject["results"].ToObject<TvSearchResult[]>();
        }
        /// <summary>
        /// Favorites or unfavorites a media item.
        /// </summary>
        /// <param name="inMediaType">The media item type to favorite. Either, <see cref="MediaTypeEnum.movie"/> or <see cref="MediaTypeEnum.tv"/>.</param>
        /// <param name="inMediaId">The media's ID.</param>
        /// <param name="inWatchlsit">Favorite or unfavorite media item.</param>
        public async Task favoriteMediaItem(MediaTypeEnum inMediaType, int inMediaId, bool inFavorite)
        {
            // Written, 05.12.2019

            if (inMediaType != MediaTypeEnum.movie && inMediaType != MediaTypeEnum.tv)
                throw new ArgumentException("Expected MediaTypeEnum.movie or MediaTypeEnum.tv. invaild argument");

            string address = String.Format("{0}/{1}/favorite?session_id={2}&api_key={3}", ApplicationInfomation.ACCOUNT_ADDRESS, this.id, this.session.session_id, ApplicationInfomation.API_KEY);
            JObject requestData = new JObject(
                new JProperty("media_type", inMediaType.ToString()),
                new JProperty("media_id", inMediaId),
                new JProperty("favorite", inFavorite));
            await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address), System.Text.Encoding.UTF8.GetBytes(requestData.ToString())));
        }
        /// <summary>
        /// Retrieves favorited movies. max 20 items per page.
        /// </summary>
        /// <param name="inPage">The page of favorites to retrieve. max 20 items per page.</param>
        public async Task<MovieSearchResult[]> getFavoriteMovies(int inPage = 1)
        {
            // Written, 06.12.2019

            string address = String.Format("{0}/{1}/favorite/movies?session_id={2}&api_key={3}&page={4}",
                ApplicationInfomation.ACCOUNT_ADDRESS, this.id, this.session.session_id, ApplicationInfomation.API_KEY, inPage);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject["results"].ToObject<MovieSearchResult[]>();
        }
        /// <summary>
        /// Retrieves favorited tv series. max 20 items per page.
        /// </summary>
        /// <param name="inPage">The page of favorites to retrieve. max 20 items per page.</param>
        public async Task<TvSearchResult[]> getFavoriteTvSeries(int inPage = 1)
        {
            // Written, 06.12.2019

            string address = String.Format("{0}/{1}/favorite/tv?session_id={2}&api_key={3}&page={4}",
                ApplicationInfomation.ACCOUNT_ADDRESS, this.id, this.session.session_id, ApplicationInfomation.API_KEY, inPage);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject["results"].ToObject<TvSearchResult[]>();
        }

        #endregion
    }
}
