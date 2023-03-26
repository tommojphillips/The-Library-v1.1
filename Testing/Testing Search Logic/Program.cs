using System;
using System.Threading.Tasks;

using TommoJProductions.TMDB.Media;
using TommoJProductions.TMDB.Search;

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
                    Console.WriteLine("{0}.) {1}", i + 1, movieSearchResults[i].name);
                Console.WriteLine("Total Results: " + movieSearchResults.GetLength(0));
            }
            catch 
            {
                searchOK = false;
            }
            TvSearchResult[] tvSearchResults = null;
            Console.WriteLine("\n\nTv Search Function\n----------------------------------------------");
            try
            {
                tvSearchResults = await TvSearchResult.searchAsync(searchPhrase, 1);
                for (int i = 0; i < tvSearchResults.GetLength(0); i++)
                    Console.WriteLine("{0}.) {1}", i + movieSearchResults.GetLength(0) + 1, tvSearchResults[i].name);
                Console.WriteLine("Total Results: " + tvSearchResults.GetLength(0));
            }
            catch
            {
                searchOK = false;
            }
            if (searchOK) 
            {
                if (movieSearchResults.GetLength(0) + tvSearchResults.GetLength(0) > 0)
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
                                else
                                    throw new NullReferenceException("result is null.");
                            }
                            if (result is TvSearchResult)
                            {
                                Console.WriteLine("[TV] Selected, {0}\nRetrieving tv series details for ID: {1}..", (result as TvSearchResult).name, result.id);
                                TvSeriesResult tvResult = await TvSeriesResult.retrieveDetailsAsync(result.id);
                                Console.WriteLine("\nDETAILS RETRIEVED:\nName: {0}\nFirst Aired: {1}\nOverview: {2}\nRating: {3}\nSeasons #: {4}\nEpisodes #: {5}\nAvg ep runtime: {6}minutes\nType: {7}\nStatus: {8}",
                                    tvResult.name, tvResult.release_date, tvResult.overview, tvResult.vote_average, tvResult.number_of_seasons, tvResult.number_of_episodes, tvResult.episode_run_time[0], tvResult.type, tvResult.status);
                            }
                            else
                            {
                                if (result is MovieSearchResult)
                                {
                                    Console.WriteLine("[MOVIE] Selected, {0}\nRetrieving movie details for ID: {1}..", (result as MovieSearchResult).name, result.id);
                                    MovieResult movieResult = await MovieResult.retrieveDetailsAsync(result.id);
                                    Console.WriteLine("\nDETAILS RETRIEVED:\nName: {0}\nRelease Date: {1}\nOverview: {2}\nRating: {3}",
                                        movieResult.name, movieResult.release_date, movieResult.overview, movieResult.vote_average);
                                }
                            }
                        }
                        catch (NullReferenceException)
                        {
                            Console.WriteLine("Error: NullReferenceException. Probably number out of range.");
                        }
                    }
                    else
                        Console.WriteLine("\nError: number expected");
                }
                else
                    Console.WriteLine("\nNo results found");
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
