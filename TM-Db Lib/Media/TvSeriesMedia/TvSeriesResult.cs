﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TM_Db_Lib.Net;

namespace TM_Db_Lib.Media
{
    /// <summary>
    /// Represents the primary tv show details by id; id obtained by <see cref="Search.TvSearchResult"/>, derived from <see cref="Search.TvSearchResult"/>
    /// </summary>
    public class TvSeriesResult : Search.TvSearchResult
    {
        // Written, 29.04.2018

        #region Properties

        /// <summary>
        /// Represents the seasons for the tv series result.
        /// </summary>
        public List<Season> seasons
        {
            get;
            set;
        } = new List<Season>();
        /// <summary>
        /// Represents the last air date for the tv series result.
        /// </summary>
        public string last_air_date
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the number of episodes for the tv series result.
        /// </summary>
        public int number_of_episodes
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the number of seasons for the tv series result.
        /// </summary>
        public int number_of_seasons
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the type of tv series the result is.
        /// </summary>
        public TvSeriesTypeEnum type
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
        /// Represents the status.
        /// </summary>
        public string status
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the status for the tv series result.
        /// </summary>
        public TvSeriesStatusEnum statusEnum
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
        /// <summary>
        /// Represents the average run time for episodes.
        /// </summary>
        public int[] episode_run_time
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the networks for the tv series.
        /// </summary>
        public Network[] networks
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the languages for the tv series.
        /// </summary>
        public string[] languages
        {
            get;
            set;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Phrases an enum from a string.
        /// </summary>
        /// <param name="inStatus"></param>
        /// <returns></returns>
        private TvSeriesStatusEnum phraseTvSeries(string inStatus)
        {
            // Written, 29.04.2018

            TvSeriesStatusEnum tsse;
            switch (inStatus)
            {
                case "Returning Series":
                    tsse = TvSeriesStatusEnum.Returning_Series;
                    break;
                case "Planned":
                    tsse = TvSeriesStatusEnum.planned;
                    break;
                case "In Production":
                    tsse = TvSeriesStatusEnum.in_production;
                    break;
                case "Ended":
                    tsse = TvSeriesStatusEnum.ended;
                    break;
                case "Canceled":
                    tsse = TvSeriesStatusEnum.canceled;
                    break;
                default:
                    tsse = TvSeriesStatusEnum.pilot;
                    break;
            }
            return tsse;
        }
        /// <summary>
        /// Gets the details of the tv series.
        /// </summary>
        /// <param name="inTvID">the tv series id.</param>
        public static async Task<TvSeriesResult> retrieveDetailsAsync(int inTvID) 
        {
            // Written, 27.11.2019

            string address = String.Format("{0}/{1}?api_key={2}", ApplicationInfomation.TV_ADDRESS, inTvID, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject.ToObject<TvSeriesResult>();
        }
        /// <summary>
        /// Gets the details of the tv series. note: Expects <see cref="Search.IdResultObject.id"/> to be filled with the media's ID.
        /// </summary>
        public async Task retrieveDetailsAsync()
        {
            // Written, 13.04.2018

            TvSeriesResult tvResult = await retrieveDetailsAsync(this.id);

            this.backdrop_path = tvResult.backdrop_path;
            this.poster_path = tvResult.poster_path;
            this.backdrop_image = await WebResponse.downloadImageAsync(new Uri(ApplicationInfomation.IMAGE_ADDRESS + this.backdrop_path));
            this.poster_image = await WebResponse.downloadImageAsync(new Uri(ApplicationInfomation.IMAGE_ADDRESS + this.poster_path));
            this.release_date = tvResult.release_date;
            this.genres = tvResult.genres;
            this.homepage = tvResult.homepage;
            this.id = tvResult.id;
            this.last_air_date = tvResult.last_air_date;
            this.name = tvResult.name;
            this.number_of_episodes = tvResult.number_of_episodes;
            this.number_of_seasons = tvResult.number_of_seasons;
            this.original_laugauge = tvResult.original_laugauge;
            this.original_name = tvResult.original_name;
            this.origin_country = tvResult.origin_country;
            this.overview = tvResult.overview;
            this.popularity = tvResult.popularity;
            this.status = tvResult.status;
            this.statusEnum = this.phraseTvSeries(this.status);
            this.type = tvResult.type;
            this.vote_average = tvResult.vote_average;
            this.vote_count = tvResult.vote_count;
            this.episode_run_time = tvResult.episode_run_time;
            this.languages = tvResult.languages;
            this.networks = tvResult.networks;
            this.networks.ToList().ForEach(async nw => await nw.retrieveDetails(nw.id));
        }
        /// <summary>
        /// Gets a list of reviews for the tv series.
        /// </summary>
        /// <param name="inTvID">The tv series ID to get reviews for.</param>
        public static async Task<Review[]> retrieveReviewsAsync(int inTvID)
        {
            // Written, 01.12.2019

            string address = String.Format("{0}/{1}/reviews?api_key={2}", ApplicationInfomation.TV_ADDRESS, inTvID, ApplicationInfomation.API_KEY);
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
