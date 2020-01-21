using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TM_Db_Lib.Search;
using TM_Db_Lib.Net;

namespace TM_Db_Lib.Discover
{
    /// <summary>
    /// Discover movies by different types of data like average rating, number of votes, genres and certifications. 
    /// You can get a valid list of certifications from the  method. Discover also supports a nice list of sort options.
    /// See below for all of the available options. Please note, when using certification \ certification.lte you must also specify certification_country.
    /// These two parameters work together in order to filter the results. You can only filter results with the countries we have added to our. If you specify
    /// the region parameter, the regional release date will be used instead of the primary release date.The date returned will be the first date based on your 
    /// query (ie. if a with_release_type is specified). It's important to note the order of the release types that are used. Specifying "2|3" would return the 
    /// limited theatrical release date as opposed to "3|2" which would return the theatrical date. Also note that a number of filters support being comma(,) or
    /// pipe(|) separated.Comma's are treated like an AND and query while pipe's are an OR.
    /// </summary>
    public static class Discover
    {
        // Written, 09.01.2020

        #region Methods

        public static async Task<MovieSearchResult[]> discoverMoviesAsync(DiscoverParameters inDiscoverParameters, int inPage = 1) 
        {
            // Written, 09.01.2020

            string parameters = string.Empty;

            if (inDiscoverParameters.cerficationCountry != null)
                parameters += String.Format("&certification_country={0}", inDiscoverParameters.cerficationCountry);
            if (inDiscoverParameters.certification_gte != null)
                parameters += String.Format("&certification.gte={0}", inDiscoverParameters.certification_gte);
            if (inDiscoverParameters.certification_lte != null)
                parameters += String.Format("&certification.lte={0}", inDiscoverParameters.certification_lte);
            if (inDiscoverParameters.certification != null)
                parameters += String.Format("&certification={0}", inDiscoverParameters.certification);
            if (inDiscoverParameters.includeAdult != null)
                parameters += String.Format("&include_adult={0}", inDiscoverParameters.includeAdult);
            if (inDiscoverParameters.includeVideo != null)
                parameters += String.Format("&include_video={0}", inDiscoverParameters.includeVideo);
            if (inDiscoverParameters.language != null)
                parameters += String.Format("&language={0}", inDiscoverParameters.language);
            if (inDiscoverParameters.primaryReleaseDate_gte != null)
                parameters += String.Format("&primary_release_date.gte={0}", inDiscoverParameters.primaryReleaseDate_gte);
            if (inDiscoverParameters.primaryReleaseDate_lte != null)
                parameters += String.Format("&primary_release_date.lte={0}", inDiscoverParameters.primaryReleaseDate_lte);
            if (inDiscoverParameters.primaryReleaseYear != null)
                parameters += String.Format("&primary_release_year={0}", inDiscoverParameters.primaryReleaseYear);
            if (inDiscoverParameters.year != null)
                parameters += String.Format("&year={0}", inDiscoverParameters.year);
            if (inDiscoverParameters.region != null)
                parameters += String.Format("&region={0}", inDiscoverParameters.region);
            if (inDiscoverParameters.releaseDate_gte != null)
                parameters += String.Format("&release_date.gte={0}", inDiscoverParameters.releaseDate_gte);
            if (inDiscoverParameters.releaseDate_lte != null)
                parameters += String.Format("&release_date.lte={0}", inDiscoverParameters.releaseDate_lte);
            if (inDiscoverParameters.voteAverage_gte != null)
                parameters += String.Format("&vote_avgerage.gte={0}", inDiscoverParameters.voteAverage_gte);
            if (inDiscoverParameters.voteAverage_lte != null)
                parameters += String.Format("&vote_avgerage.lte={0}", inDiscoverParameters.voteAverage_lte);
            if (inDiscoverParameters.voteCount_gte != null)
                parameters += String.Format("&vote_count.gte={0}", inDiscoverParameters.voteCount_gte);
            if (inDiscoverParameters.voteCount_lte != null)
                parameters += String.Format("&vote_count.lte={0}", inDiscoverParameters.voteCount_lte);
            if (inDiscoverParameters.withCast != null)
                parameters += String.Format("&with_cast={0}", inDiscoverParameters.withCast);
            if (inDiscoverParameters.withCompanies != null)
                parameters += String.Format("&with_companies={0}", inDiscoverParameters.withCompanies);
            if (inDiscoverParameters.withCrew != null)
                parameters += String.Format("&with_crew={0}", inDiscoverParameters.withCrew);
            if (inDiscoverParameters.withGenres != null)
                parameters += String.Format("&with_genres={0}", inDiscoverParameters.withGenres);
            if (inDiscoverParameters.withKeywords != null)
                parameters += String.Format("&with_keywords={0}", inDiscoverParameters.withKeywords);
            if (inDiscoverParameters.withOriginalLanguage != null)
                parameters += String.Format("&with_original_language={0}", inDiscoverParameters.withOriginalLanguage);
            if (inDiscoverParameters.withoutGenres != null)
                parameters += String.Format("&without_genres={0}", inDiscoverParameters.withoutGenres);
            if (inDiscoverParameters.withoutKeywords != null)
                parameters += String.Format("&without_keywords={0}", inDiscoverParameters.withoutKeywords);
            if (inDiscoverParameters.withPeople != null)
                parameters += String.Format("&with_people={0}", inDiscoverParameters.withPeople);
            if (inDiscoverParameters.withReleaseType != null)
                parameters += String.Format("&with_release_type={0}", inDiscoverParameters.withReleaseType);
            if (inDiscoverParameters.withRuntime_gte != null)
                parameters += String.Format("&with_runtime.gte={0}", inDiscoverParameters.withRuntime_gte);
            if (inDiscoverParameters.withRuntime_lte != null)
                parameters += String.Format("&with_runtime_lte={0}", inDiscoverParameters.withRuntime_lte);
            parameters += String.Format("&sort_by={0}.{1}", inDiscoverParameters.sortByMembers, inDiscoverParameters.sortByAscDesc);
            string address = String.Format("{0}/movie?api_key={1}&page={2}{3}", ApplicationInfomation.DISCOVER_ADDRESS, ApplicationInfomation.API_KEY, inPage, parameters);
            JObject jObject = await WebResponse.toJObject(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject["results"].ToObject<MovieSearchResult[]>();
        }

        #endregion
    }
}
