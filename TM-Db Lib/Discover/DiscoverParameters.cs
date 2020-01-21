using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_Db_Lib.Discover
{
    /// <summary>
    /// Represents parameters for the discover function.
    /// </summary>
    public class DiscoverParameters
    {
        // Written, 09.01.2020

        #region Properties

        /// <summary>
        /// Specify a language to query translatable fields with.
        /// </summary>
        public string language
        {
            get;
            set;
        } = "en-US";
        /// <summary>
        /// Specify a ISO 3166-1 code to filter release dates. Must be uppercase.
        /// </summary>
        public string region
        {
            get;
            set;
        }
        /// <summary>
        /// Choose from one of the many available sort options.
        /// </summary>
        public MediaSortByMembersEnum sortByMembers
        {
            get;
            set;
        } = MediaSortByMembersEnum.popularity;
        /// <summary>
        /// Sort by ascending or descending.
        /// </summary>
        public MediaSortByAscDescEnum sortByAscDesc
        {
            get;
            set;
        } = MediaSortByAscDescEnum.desc;
        /// <summary>
        /// Used in conjunction with the certification filter, use this to specify a country with a valid certification.
        /// </summary>
        public string cerficationCountry
        {
            get;
            set;
        }
        /// <summary>
        /// Filter results with a valid certification from the 'certification_country' field.
        /// </summary>
        public string certification
        {
            get;
            set;
        }
        /// <summary>
        /// Filter and only include media that have a certification that is less than or equal to the specified value.
        /// </summary>
        public string certification_lte
        {
            get;
            set;
        }
        /// <summary>
        /// Filter and only include media that have a certification that is greater than or equal to the specified value.
        /// </summary>
        public string certification_gte
        {
            get;
            set;
        }
        /// <summary>
        /// A filter and include or exclude adult media.
        /// </summary>
        public bool includeAdult
        {
            get;
            set;
        } = false;
        /// <summary>
        /// A filter to include or exclude media.
        /// </summary>
        public bool includeVideo
        {
            get;
            set;
        } = false;
        /// <summary>
        /// A filter to limit the results to a specific primary release year.
        /// </summary>
        public int? primaryReleaseYear
        {
            get;
            set;
        } = null;
        /// <summary>
        /// Filter and only include media that have a primary release date that is less than or equal to the specified value.
        /// format: date
        /// </summary>
        public string primaryReleaseDate_lte
        {
            get;
            set;
        }
        /// <summary>
        /// Filter and only include media that have a primary release date that is greater or equal to the specified value.
        /// format: date
        /// </summary>
        public string primaryReleaseDate_gte
        {
            get;
            set;
        }
        /// <summary>
        /// Filter and only include media that have a release date (looking at all release dates) that is less than or equal to the specified value.
        /// format: date
        /// </summary>
        public string releaseDate_lte
        {
            get;
            set;
        }
        /// <summary>
        /// Filter and only include media that have a release date (looking at all release dates) that is greater or equal to the specified value.
        /// format: date
        /// </summary>
        public string releaseDate_gte
        {
            get;
            set;
        }
        /// <summary>
        /// Specify a comma (AND) or pipe (OR) separated value to filter release types by. These release types map to the same values found on the movie release date method.
        /// minimum: 1. maximum: 6
        /// </summary>
        public int? withReleaseType
        {
            get;
            set;
        } = null;
        /// <summary>
        /// A filter to limit the results to a specific year (looking at all release dates).
        /// </summary>
        public int? year
        {
            get;
            set;
        } = null;
        /// <summary>
        /// Filter and only include media that have a vote count that is less than or equal to the specified value.
        /// minium: 1
        /// </summary>
        public int? voteCount_lte
        {
            get;
            set;
        } = null;
        /// <summary>
        /// Filter and only include movies that have a vote count that is greater or equal to the specified value.
        /// minimum: 0
        /// </summary>
        public int? voteCount_gte
        {
            get;
            set;
        } = null;
        /// <summary>
        /// Filter and only include movies that have a rating that is less than or equal to the specified value.
        /// minimum: 0
        /// </summary>
        public int? voteAverage_lte
        {
            get;
            set;
        } = null;
        /// <summary>
        /// Filter and only include movies that have a rating that is greater or equal to the specified value.
        /// minimum: 0
        /// </summary>
        public int? voteAverage_gte
        {
            get;
            set;
        } = null;
        /// <summary>
        /// A comma separated list of person ID's. Only include media that have one of the ID's added as an actor.
        /// </summary>
        public string withCast
        {
            get;
            set;
        }
        /// <summary>
        /// A comma separated list of person ID's. Only include media that have one of the ID's added as a crew member.
        /// </summary>
        public string withCrew
        {
            get;
            set;
        }
        /// <summary>
        /// A comma separated list of person ID's. Only include media that have one of the ID's added as a either a actor or a crew member.
        /// </summary>
        public string withPeople 
        {
            get;
            set;
        }
        /// <summary>
        /// A comma separated list of production company ID's. Only include media that have one of the ID's added as a production company.
        /// </summary>
        public string withCompanies 
        {
            get;
            set;
        }
        /// <summary>
        /// Comma separated value of genre ids that you want to include in the results.
        /// </summary>
        public string withGenres 
        {
            get;
            set;
        }
        /// <summary>
        /// Comma separated value of genre ids that you want to exclude from the results.
        /// </summary>
        public string withoutGenres 
        {
            get;
            set;
        }
        /// <summary>
        /// A comma separated list of keyword ID's. Only includes media that have one of the ID's added as a keyword.
        /// </summary>
        public string withKeywords 
        {
            get;
            set;
        }
        /// <summary>
        /// Exclude items with certain keywords. You can comma and pipe seperate these values to create an 'AND' or 'OR' logic.
        /// </summary>
        public string withoutKeywords 
        {
            get;
            set;
        }
        /// <summary>
        /// Filter and only include media that have a runtime that is less or equal to a value.
        /// </summary>
        public int? withRuntime_lte 
        {
            get;
            set;
        } = null;
        /// <summary>
        /// Filter and only include media that have a runtime that is greater than or equal to a value.
        /// </summary>
        public int? withRuntime_gte 
        {
            get;
            set;
        } = null;
        /// <summary>
        /// Specify an ISO 639-1 string to filter results by their original language value.
        /// </summary>
        public string withOriginalLanguage 
        {
            get;
            set;
        }

        #endregion
    }
}
