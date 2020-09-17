using Newtonsoft.Json;

namespace TommoJProductions.TMDB.Media
{
    public class IdResultObjectWithMediaType : IdResultObject
    {
        // Written, 29.11.2019

        #region Properties

        /// <summary>
        /// Represents the media type as a string.
        /// </summary>
        [JsonProperty("media_type")]
        public string mediaTypeString
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the type of media.
        /// </summary>
        public MediaTypeEnum mediaType
        {
            get
            {
                switch (this.mediaTypeString)
                {
                    case "movie":
                        return MediaTypeEnum.movie;
                    case "tv":
                        return MediaTypeEnum.tv;
                    case "person":
                        return MediaTypeEnum.person;
                    default:
                        return MediaTypeEnum.none;
                }
            }
        }

        #endregion
    }
}
