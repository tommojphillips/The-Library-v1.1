using System;
using System.Threading.Tasks;
using TM_Db_Lib.Search;
using TM_Db_Lib.MovieMedia;
using TM_Db_Lib.TvSeriesMedia;

namespace Testing_Search_Logic
{
    class Program
    {
        // Written, 24.11.2019

        static async Task Main(string[] args)
        {
            // Written, 25.11.2019

            Console.WriteLine("The Library v1.1 Search Test\nEnter Phrase and press Enter to search for movies and tv series individually ");
            string searchPhrase = Console.ReadLine();
            bool searchOK = true;
            MovieSearchResult[] movieSearchResults = null;
            Console.WriteLine("\n\nMovie Search Function\n-------------------------------------------");
            try
            {
                movieSearchResults = await MovieSearchResult.searchAsync(searchPhrase, 1);
                for (int i = 0; i < movieSearchResults.GetLength(0); i++)
                    Console.WriteLine("{0}.) {1}", i + 1, movieSearchResults[i].title);
                Console.WriteLine("Total Results: " + movieSearchResults.GetLength(0));
            }
            catch (Exception ex) 
            {
                searchOK = false;
                Console.WriteLine("An Error occured whilist attempting to test movie search function. Error: {0}", ex.Message);
            }
            TvSearchResult[] tvSearchResults = null;
            Console.WriteLine("\n\nTv Search Function\n----------------------------------------------");
            try
            {
                tvSearchResults = await TvSearchResult.searchAsync(searchPhrase, 1);
                for (int i = 0; i < tvSearchResults.GetLength(0); i++)
                    Console.WriteLine("{0}.) {1}", i + movieSearchResults.GetLength(0) + 1, tvSearchResults[i].original_name);
                Console.WriteLine("Total Results: " + tvSearchResults.GetLength(0));
            }
            catch (Exception ex)
            {
                searchOK = false;
                Console.WriteLine("An Error occured whilist attempting to test tv search function. Error: {0}", ex.Message);
            }
            if (searchOK) 
            {
                Console.WriteLine("Enter movie or tv series number to retrieve details.");
                if (Int32.TryParse(Console.ReadLine(), out int searchNum))
                {
                    try 
                    {
                        MediaSearchResult result = null;

                        if (searchNum <= movieSearchResults.GetLength(0))
                        {
                            result = movieSearchResults[searchNum - 1]; 
                        }
                        else
                        {
                            int tvSearchNum = searchNum - movieSearchResults.GetLength(0);
                            if (tvSearchNum <= tvSearchResults.GetLength(0)) 
                            {
                                result = tvSearchResults[tvSearchNum - 1];
                            }
                        }
                        if (result is null)
                            throw new NullReferenceException();

                        if (result is TvSearchResult)
                        {
                            Console.WriteLine("[TV] Selected, {0}", (result as TvSearchResult).name);

                            TvSeriesResult tvResult = new TvSeriesResult();
                            Console.WriteLine("Retrieving tv series details for ID: {0}..", result.id);
                            await tvResult.retrieveDetailsAsync(result.id);
                            Console.WriteLine("\nDETAILS RETRIEVED:\nName: {0}\nFirst Aired: {1}\nOverview: {2}\nRating: {3}\nSeasons #: {4}\nEpisodes #: {5}\nAvg ep runtime: {6}minutes\nType: {7}\nStatus: {8}",
                                tvResult.name, tvResult.first_air_date, tvResult.overview, tvResult.vote_average, tvResult.number_of_seasons, tvResult.number_of_episodes, tvResult.episode_run_time[0], tvResult.type, tvResult.status);
                        }
                        else
                        {
                            if (result is MovieSearchResult) 
                            {
                                Console.WriteLine("[MOVIE] Selected, {0}", (result as MovieSearchResult).title);

                                MovieResult movieResult = new MovieResult();
                                Console.WriteLine("Retrieving movie details for ID: {0}..", result.id);
                                await movieResult.retrieveDetailsAsync(result.id);
                                Console.WriteLine("\nDETAILS RETRIEVED:\nName: {0}\nRelease Date: {1}\nOverview: {2}\nRating: {3}",
                                    movieResult.title, movieResult.release_date, movieResult.overview, movieResult.vote_average);
                            }
                        }
                    }
                    catch (NullReferenceException)
                    {
                        Console.WriteLine("Error: NullReferenceException. Probably Number out of range.");
                    }
                }
                else
                    Console.WriteLine("Error: Number expected");
            }
            Console.WriteLine("\n\nPress R to restart or press any key to exit");
            if (Console.ReadKey().Key == ConsoleKey.R)
            {
                Console.Clear();
                await Main(null);
            }
        }
    }
}
