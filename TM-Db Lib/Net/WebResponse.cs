using System;
using System.Diagnostics;
using System.Net;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace TM_Db_Lib.Net
{
    /// <summary>
    /// Represents Methods to send and return requests in the .json format.
    /// </summary>
    public static class WebResponse
    {
        // Written, 10.03.2018

        #region Fields

        /// <summary>
        /// Occurs when a request is sent out.
        /// </summary>
        internal static event EventHandler<RequestSendingEventArgs> RequestSending;
        /// <summary>
        /// Occurs when a request has failed.
        /// </summary>
        internal static event EventHandler<RequestFailedEventArgs> RequestFailed;
        /// <summary>
        /// Occurs when a request has been sent. Note, sender is null.
        /// </summary>
        internal static event EventHandler<RequestSentEventArgs> RequestSent;
        /// <summary>
        /// Occurs when the Requests Sent Limit has occured. Note, sender is null.
        /// </summary>
        internal static event EventHandler<DelayingEventArgs> Delaying;
        /// <summary>
        /// Represents the amount of requests sent this session.
        /// </summary>
        private static int requestsSentThisSession = 0;
        /// <summary>
        /// Represents the amount of time to delay for.
        /// </summary>
        private static int delay = 0;
        /// <summary>
        /// Represents all tmdb status codes.
        /// </summary>
        internal static Dictionary<string, int> TMDb_Codes = new Dictionary<string, int>() 
        {
            {"Success", 200 },
            {"Invaild service", 501 },
            {"Authentication failed", 401 },
            {"Invaild format", 405 },
            {"Invaild parameters", 422 },
            {"Invaild ID", 404 },
            {"Invaild api key", 401 },
            {"Duplicate entry", 403 },
            {"Service offline", 503 },
            {"Suspended api key", 401 },
            {"Internal error", 500 },
            {"Item updated successfully", 201 },
            {"Item deleted successfully", 200 },
            {"Failed", 500 },
            {"Device denied", 401 },
            {"Session denied", 401 },
            {"Vaildation failed", 400 },
            {"Invaild accept header", 406 },
            {"Invaild date range", 422 },
            {"Entry not found", 200 },
            {"Invaild page", 400 },
            {"Invaild date", 400 },
            {"Server timed out", 504 },
            {"Request limit exceeded", 429 },
            {"Provide username and password", 400 },
            {"Remote calls limit exceeded", 400 },
            {"Invaild timezone", 400 },
            {"Confirm action", 400 },
            {"Invaild login credentials", 401 },
            {"Account disabled", 401 },
            {"Email not verified", 401 },
            {"Resource not found", 401 },
        };
        private static Stopwatch onSendingStopWatch = new Stopwatch();

        #endregion

        #region Methods

        /// <summary>
        /// Sends a request to the provided url, and returns a <see cref="HttpWebResponse"/>.
        /// </summary>
        /// <param name="inUri">The url to request from.</param>
        public static async Task<HttpWebResponse> sendRequestAsync(Uri inUri)
        {
            // Written, 05.06.2018

            onRequestSending(inUri);
            HttpWebRequest request = WebRequest.Create(inUri) as HttpWebRequest;
            HttpWebResponse response;            

            try
            {
                response = await request.GetResponseAsync() as HttpWebResponse;
                onRequestSent(inUri, response);
                return response;
            }
            catch (WebException ex)
            {
                response = ex.Response as HttpWebResponse;
                TMDbStatusResponse statusResponse = (await toJObject(response)).ToObject<TMDbStatusResponse>();
                onRequestFailed(inUri, response, statusResponse);
                HttpStatusCode statusCode = response.StatusCode;
                bool isInt = Int32.TryParse(statusCode.ToString(), out int code);

                if (isInt && code == TMDb_Codes["Request Limit Exceeded"]) // Too many requests error code
                {
                    delay = Int32.Parse(response.Headers.Get("Retry-After"));
                    if (delay > 0)
                        await onDelay();
                    return await sendRequestAsync(inUri);
                }
                throw;
            }
        }
        /// <summary>
        /// Returns a http web request in the json format wrapped within the <see cref="JObject"/> object.
        /// </summary>
        /// <param name="inResponse">The response of the request.</param>
        public static async Task<JObject> toJObject(HttpWebResponse inResponse)
        {
            // Written, 10.03.2018

            using (StreamReader reader = new StreamReader(inResponse.GetResponseStream()))
            {
                return JObject.Parse(await reader.ReadToEndAsync());
            }
        }
        /// <summary>
        /// Connects to a URL and attempts to download the file. Returns an array of bytes.
        /// </summary>
        /// <param name="inUri">The URL to connect to.</param>
        /// <exception cref="NotSupportedException"/>
        /// <exception cref="ArgumentException"/>
        /// <exception cref="ArgumentNullException"/>
        /// <exception cref="System.Security.SecurityException"/>
        /// <exception cref="UriFormatException"/>
        /// <exception cref="ArgumentOutOfRangeException"/>
        /// <exception cref="IOException"/>
        /// <exception cref="ObjectDisposedException"/>
        public static async Task<byte[]> downloadDataAsync(Uri inUri)
        {
            // Written, 22.05.2018

            System.Net.WebResponse response = await sendRequestAsync(inUri);
            Stream stream = response.GetResponseStream();
            byte[] downloadedData;
            byte[] buffer = new byte[1024];
            MemoryStream memStream = new MemoryStream();
            while (true)
            {
                //Try to read the data
                int bytesRead = stream.Read(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                    break;
                else
                    memStream.Write(buffer, 0, bytesRead);
            }
            downloadedData = memStream.ToArray();

            stream.Close();
            memStream.Close();

            return downloadedData;
        }
        /// <summary>
        /// Attempts to download the image data and then attempts to load the data into an <see cref="Image"/> object. returns the image.
        /// </summary>
        /// <param name="inUri">The URL to connect to.</param>
        /// <exception cref="ArgumentException"/>
        /// <exception cref="ArgumentNullException"/>
        public static async Task<Image> downloadImageAsync(Uri inUri)
        {
            // Written, 22.05.2018

            byte[] imageData = await downloadDataAsync(inUri);
            MemoryStream stream = new MemoryStream(imageData);
            Image img = Image.FromStream(stream);
            stream.Close();

            return img;
        }

        #endregion

        #region Events

        /// <summary>
        /// Raises the <see cref="RequestSending"/> event. Note, sender is null.
        /// </summary>
        /// <param name="inUri"></param>
        internal static void onRequestSending(Uri inUri) 
        {
            // Written, 24.11.2019

            onSendingStopWatch.Restart();
            Console.WriteLine("Requesting from the URL, {0}", inUri.AbsoluteUri.Replace(ApplicationInfomation.API_KEY, "<api_key>"));
            RequestSending?.Invoke(null, new RequestSendingEventArgs(inUri));
        }
        /// <summary>
        /// Raises the <see cref="RequestSent"/> event. Note, sender is null.
        /// </summary>
        public static void onRequestSent(Uri inUri, HttpWebResponse inResponse)
        {
            // Written, 02.09.2017

            onSendingStopWatch.Stop();
            requestsSentThisSession++;
            Console.WriteLine("Request Completed: Total RS: {0} ({1}ms)", requestsSentThisSession, onSendingStopWatch.Elapsed.TotalMilliseconds.ToString("F2"));
            RequestSent?.Invoke(null, new RequestSentEventArgs(inUri, inResponse));
        }
        /// <summary>
        /// Raises the <see cref="RequestFailed"/> event. Note, sender is null.
        /// </summary>
        /// <param name="inUri"></param>
        internal static void onRequestFailed(Uri inUri, HttpWebResponse inResponse, TMDbStatusResponse inStatusResponse)
        {
            // Written, 24.11.2019

            Console.WriteLine("Request failed: {0} Code {1}.", inStatusResponse.status_message, inStatusResponse.status_code);
            RequestFailed?.Invoke(null, new RequestFailedEventArgs(inUri, inResponse, inStatusResponse));
        }
        /// <summary>
        /// Raises the <see cref="Delaying"/> event. Note, sender is of type, <see cref="String"/>, sender holds message to console.
        /// </summary>
        /// <returns>Nothing.</returns>
        public static async Task onDelay()
        {
            // Written, 05.06.2018

            Console.WriteLine("Request Limit Exceeded: Delaying for {0}...", delay);
            Delaying?.Invoke(null, new DelayingEventArgs(delay));
            await Task.Delay(delay * 1000/*(1000)*/);
            //delay = 0;
        }

        #endregion
    }
}

