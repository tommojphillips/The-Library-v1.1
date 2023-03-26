using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Threading.Tasks;
using TommoJProductions.Net;
using TommoJProductions.TMDB.Search;

namespace TommoJProductions.TMDB.Media
{
    public class PersonResult : PeopleSearchResult
    {
        // Written, 29.11.2019

        #region Properties

        /// <summary>
        /// Represents the profile image of the person.
        /// </summary>
        public Image profileImage
        {
            get;
            private set;
        }
        /// <summary>
        /// Represents the person's birthday
        /// </summary>
        public string birthday
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the person's known for department
        /// </summary>
        public string known_for_department
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the person's death-day (if applicable otherwise <see langword="null"/>).
        /// </summary>
        public string deathday
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the person's name.
        /// </summary>
        public string name
        {
            get;
            set;
        }
        /// <summary>
        /// Represents other known names of the person.
        /// </summary>
        public string[] also_known_as
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the person's gender.
        /// </summary>
        public int gender
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the person's about bio.
        /// </summary>
        public string biography
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the person's popularity
        /// </summary>
        public int popularity
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the birth place of the person.
        /// </summary>
        public string place_of_birth
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the imdb id of the person
        /// </summary>
        public string imdb_id
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the person's website.
        /// </summary>
        public string homepage
        {
            get;
            set;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the details of the person.
        /// </summary>
        /// <param name="inPersonID">The person's ID</param>
        public static async Task<PersonResult> retrieveDetailsAsync(int inPersonID)
        {
            // Written, 29.11.2019

            string address = String.Format("{0}/{1}?api_key={2}", ApplicationInfomation.PERSON_ADDRESS, inPersonID, ApplicationInfomation.API_KEY);
            JObject jObject = await WebResponse.toJObjectAsync(await WebResponse.sendRequestAsync(new Uri(address)));
            return jObject.ToObject<PersonResult>();
        }
        /// <summary>
        /// Gets the details of the person. note: Expects <see cref="IdResultObject.id"/> to be filled with the media's ID.
        /// </summary>
        public async Task retrieveDetailsAsync()
        {
            // Written, 29.11.2019

            PersonResult person = await retrieveDetailsAsync(this.id);

            this.adult = person.adult;
            this.id = person.id;
            this.also_known_as = person.also_known_as;
            this.biography = person.biography;
            this.birthday = person.birthday;
            this.deathday = person.deathday;
            this.gender = person.gender;
            this.homepage = person.homepage;
            this.imdb_id = person.imdb_id;
            this.known_for_department = person.known_for_department;
            this.name = person.name;
            this.place_of_birth = person.place_of_birth;
            this.popularity = person.popularity;
            this.profile_path = person.profile_path;
            //this.profileImage = await WebResponse.downloadImageAsync(new Uri(ApplicationInfomation.IMAGE_ORIGINAL_ADDRESS + this.profile_path));
        }

        #endregion
    }
}
