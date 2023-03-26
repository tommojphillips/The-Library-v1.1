using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TommoJProductions.Net;
using TommoJProductions.TMDB.Search;

namespace TommoJProductions.TMDB.Find
{
    /// <summary>
    /// The find method makes it easy to search for objects in our database by an external id. For example, an IMDB ID.
    /// This method will search all objects(movies, TV shows and people) and return the results in a single response.
    /// </summary>
    public class Find
    {
        // Written, 14.09.2020

        /// <summary>
        /// Finds persons, tv, movie results based on an imdb id
        /// </summary>
        /// <param name="imdbID">imdb id to find</param>
        public static async Task<MultiSearchResult> imdbFindByID(string imdbID) 
        {
            // Written, 15.09.2020

            string address = String.Format("{0}/find/{2}?api_key={1}&external_source={3}", ApplicationInfomation.TMDB_V3_ADDRESS, ApplicationInfomation.API_KEY, imdbID, "imdb");
            JObject jObject = await WebResponse.toJObjectAsync(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject.ToObject<MultiSearchResult>();
        }
    }
}
