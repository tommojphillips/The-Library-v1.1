using System;
using System.Threading.Tasks;
using TM_Db_Lib;
using TM_Db_Lib.Search;
using TM_Db_Lib.Media;

namespace Testing_Reviews
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Written, 01.12.2019

            Console.WriteLine("The Library v1.1 Review Test\nEnter Phrase and press Enter to search for movie & tv series reviews");
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
                            if (result is MovieSearchResult)
                            {
                                Console.WriteLine("[MOVIE] Selected, {0}\nRetrieving movie reviews for ID: {1}..", result.name, result.id);
                                await (result as MovieSearchResult).retrieveReviewsAsync();
                            }
                            else
                            {
                                if (result is TvSearchResult)
                                {
                                    Console.WriteLine("[TV] Selected, {0}\nRetrieving tv series reviews for ID: {1}..", result.name, result.id);
                                    await (result as TvSeriesResult).retrieveReviewsAsync();                                    
                                }
                            }
                            if (result.reviews.GetLength(0) < 1)
                                Console.WriteLine("\nNo reviews recorded");
                            else 
                            {
                                for (int i = 0; i < result.reviews.GetLength(0); i++)
                                {
                                    Review review = result.reviews[i];
                                    Console.WriteLine("\n{0}.) {1} by {2}\n{3}\n...See [{4}]", i + 1, review.reviewID, review.author, review.content, review.url);
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
