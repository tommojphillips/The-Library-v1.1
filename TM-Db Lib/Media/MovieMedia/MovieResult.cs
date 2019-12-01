using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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
        /// <param name="inMovieID">The movie's ID</param>
        public static async Task<MovieResult> retrieveDetailsAsync(int inMovieID)
        {
            // Written, 07.04.2018

            string address = String.Format("{0}/{1}?api_key={2}", ApplicationInfomation.MOVIE_BASE_ADDRESS, inMovieID, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject.ToObject<MovieResult>();
        }
        /// <summary>
        /// Gets the details of the movie. note: Expects <see cref="Search.IdResultObject.id"/> to be filled with the media's ID.
        /// </summary>
        /// <param name="inMovieID">The id of the movie to get details about.</param>
        public async Task retrieveDetailsAsync()
        {
            // Written, 07.04.2018

            MovieResult mf = await retrieveDetailsAsync(this.id);

            this.adult = mf.adult;
            this.backdrop_path = mf.backdrop_path;
            this.poster_path = mf.poster_path;
            this.backdrop_image = await WebResponse.downloadImageAsync(new Uri(ApplicationInfomation.IMAGE_BASE_ADDRESS + this.backdrop_path));
            this.poster_image = await WebResponse.downloadImageAsync(new Uri(ApplicationInfomation.IMAGE_BASE_ADDRESS + this.poster_path));
            this.belongs_to_collection = mf.belongs_to_collection;
            this.budget = mf.budget;
            this.genres = mf.genres;
            this.homepage = mf.homepage;
            this.id = mf.id;
            this.imdb_id = mf.imdb_id;
            this.original_laugauge = mf.original_laugauge;
            this.original_name = mf.original_name;
            this.overview = mf.overview;
            this.popularity = mf.popularity;
            this.release_date = mf.release_date;
            this.status = mf.status;
            this.tagline = mf.tagline;
            this.name = mf.name;
            this.video = mf.video;
            this.vote_average = mf.vote_average;
            this.vote_count = mf.vote_count;
        }
        /// <summary>
        /// Gets a list of similar movies.
        /// </summary>
        /// <param name="inMovieID">The movie ID.</param>
        public static async Task<List<MovieSearchResult>> retrieveSimilarMoviesAsync(int inMovieID)
        {
            // Written, 07.04.2018

            string address = String.Format("{0}/{1}/similar?api_key={2}", ApplicationInfomation.MOVIE_BASE_ADDRESS, inMovieID, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            List<Search.MovieSearchResult> similarMovies = new List<Search.MovieSearchResult>();

            JArray jResults = jObject["results"].ToObject<JArray>();
            for (int j = 0; j < jResults.Count; j++)
            {
                similarMovies.Add(jResults[j].ToObject<Search.MovieSearchResult>());
            }

            return similarMovies;
        }
        /// <summary>
        /// Gets a list of movie ids of similar movies to the movieID
        /// </summary>
        /// <param name="inMovieID">the movie to get similar movies from.</param>
        /// <returns></returns>
        public static async Task<List<int>> retrieveSimilarMoviesMovieIdAsync(int inMovieID)
        {
            // Written, 19.04.2018

            string address = String.Format("{0}/{1}/similar?api_key={2}", ApplicationInfomation.MOVIE_BASE_ADDRESS, inMovieID, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            List<int> movie_ids = new List<int>();

            JArray jResults = jObject["results"].ToObject<JArray>();
            for (int j = 0; j < jResults.Count; j++)
            {
                movie_ids.Add(jResults[j].ToObject<Search.MovieSearchResult>().id);
            }

            return movie_ids;
        }
        /// <summary>
        /// Gets a list of recommended movies.
        /// </summary>
        /// <param name="inMovieID">The movie ID.</param>
        /// <returns></returns>
        public static async Task<List<MovieSearchResult>> retrieveRecommendationsAsync(int inMovieID)
        {
            // Written, 07.04.2018

            string address = String.Format("{0}/{1}/recommendations?api_key={2}", ApplicationInfomation.MOVIE_BASE_ADDRESS, inMovieID, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            List<Search.MovieSearchResult> recommendations = new List<Search.MovieSearchResult>();

            JArray jResults = jObject["results"].ToObject<JArray>();
            for (int j = 0; j < jResults.Count; j++)
            {
                recommendations.Add(jResults[j].ToObject<Search.MovieSearchResult>());
            }

            return recommendations;
        }
        /// <summary>
        /// Gets a list of movie ids of recommended movies.
        /// </summary>
        /// <param name="inMovieID">the movie id to get recommendid movies</param>
        /// <returns></returns>
        public static async Task<int[]> retrieveRecommendationsMovieIdAsync(int inMovieID)
        {
            // Written, 19.04.2018

            string address = String.Format("{0}/{1}/recommendations?api_key={2}", ApplicationInfomation.MOVIE_BASE_ADDRESS, inMovieID, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            List<int> movie_ids = new List<int>();

            JArray jResults = jObject["results"].ToObject<JArray>();
            for (int j = 0; j < jResults.Count; j++)
            {
                movie_ids.Add(jResults[j].ToObject<Search.MovieSearchResult>().id);
            }

            return movie_ids.ToArray();
        }
        /// <summary>
        /// Gets a list of reviews for the movie.
        /// </summary>
        /// <param name="inMovieID">The movie ID to get reviews for.</param>
        public static async Task<Review[]> retrieveReviewsAsync(int inMovieID) 
        {
            // Written, 01.12.2019

            string address = String.Format("{0}/{1}/reviews?api_key={2}", ApplicationInfomation.MOVIE_BASE_ADDRESS, inMovieID, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            List<Review> reviews = new List<Review>();

            JArray jResults = jObject["results"].ToObject<JArray>();
            for (int j = 0; j < jResults.Count; j++)
            {
                reviews.Add(jResults[j].ToObject<Review>());
            }

            return reviews.ToArray();
        }

        #endregion
    }
}
