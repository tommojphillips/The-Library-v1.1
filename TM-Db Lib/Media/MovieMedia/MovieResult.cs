using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Threading.Tasks;
using TM_Db_Lib.Net;
using TM_Db_Lib.Search;

namespace TM_Db_Lib.Media
{
    /// <summary>
    /// Represensts a movie result. Gets the primary infomation about a movie by id; id obtained by <see cref="MovieSearchResult"/>,
    /// derived from <see cref="MovieSearchResult"/>.
    /// </summary>
    public class MovieResult : MovieSearchResult
    {
        // Written, 25.11.2019

        #region Properties

        /// <summary>
        /// Represents the collections the movie belongs to.
        /// </summary>
        public object belongs_to_collection
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the budget of the movie.
        /// </summary>
        public int budget
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the IMDb id for the movie.
        /// </summary>
        public string imdb_id
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the tagline for the movie.
        /// </summary>
        public string tagline
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the genres for the movie.
        /// </summary>
        public Genre[] genres
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the status of the movie.
        /// </summary>
        public MovieStatusEnum status
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the home page for the tv series result.
        /// </summary>
        public string homepage
        {
            get;

            set;
        }
        /// <summary>
        /// Represents the an array of genre IDs for the result.
        /// </summary>
        public override int[] genre_ids
        {
            get
            {
                return genres.Select(genre => genre.id).ToArray();
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the details of the movie.
        /// </summary>
        /// <param name="inMovieID">The movie ID</param>
        public static async Task<MovieResult> retrieveDetailsAsync(int inMovieID)
        {
            // Written, 07.04.2018

            string address = String.Format("{0}/{1}?api_key={2}", ApplicationInfomation.MOVIE_ADDRESS, inMovieID, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            MovieResult result = jObject.ToObject<MovieResult>();
            await result.retrieveMediaImages();
            return result;
        }
        /// <summary>
        /// Retrieves similar movies.
        /// </summary>
        /// <param name="inMovieID">The movie ID.</param>
        public async Task<MovieSearchResult[]> retrieveSimilarMoviesAsync()
        {
            // Written, 07.04.2018

            string address = String.Format("{0}/{1}/similar?api_key={2}", ApplicationInfomation.MOVIE_ADDRESS, this.id, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject["results"].ToObject<MovieSearchResult[]>();
        }
        /// <summary>
        /// Retrieves recommended movies.
        /// </summary>
        /// <param name="inMovieID">The movie ID.</param>
        /// <returns></returns>
        public async Task<MovieSearchResult[]> retrieveRecommendationsAsync()
        {
            // Written, 07.04.2018

            string address = String.Format("{0}/{1}/recommendations?api_key={2}", ApplicationInfomation.MOVIE_ADDRESS, this.id, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject["results"].ToObject<MovieSearchResult[]>();
        }
        /// <summary>
        /// Gets a list of reviews for the movie.
        /// </summary>
        /// <param name="inMovieID">The movie ID to get reviews for.</param>
        public static async Task<Review[]> retrieveReviewsAsync(int inMovieID)
        {
            // Written, 01.12.2019

            string address = String.Format("{0}/{1}/reviews?api_key={2}", ApplicationInfomation.MOVIE_ADDRESS, inMovieID, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject["results"].ToObject<Review[]>();
        }

        #endregion
    }
}
