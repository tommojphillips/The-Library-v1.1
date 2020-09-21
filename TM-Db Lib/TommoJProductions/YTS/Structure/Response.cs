namespace TommoJProductions.YTS.Structure
{
    /// <summary>
    /// Represents a yts response object.
    /// </summary>
    /// <typeparam name="T">Represents the response data.</typeparam>
    public class Response<T>
    {
        // Written, 19.09.2020

        public Meta meta;
        public T data;
        public string status;
        public string status_message;
    }
}
