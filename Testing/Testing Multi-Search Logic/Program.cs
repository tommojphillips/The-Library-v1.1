using System;
using System.Threading.Tasks;
using TM_Db_Lib.Search;
using TM_Db_Lib.Media;

namespace Testing_Multi_Search_Logic
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Written, 29.11.2019

            Console.WriteLine("The Library v1.1 Multi-Search Test\nEnter Phrase and press Enter to search for movies, tv series and people as a multi-search request.");
            string searchPhrase = Console.ReadLine();
            bool searchOK = true;
            IdResultObjectWithMediaType[] mediaResults = null;
            Console.WriteLine("\n\nMulti-Search Function\n-------------------------------------------");
            try
            {
                mediaResults = await MultiSearchResult.searchAsync(searchPhrase, 1);
                for (int i = 0; i < mediaResults.GetLength(0); i++)
                    Console.WriteLine("{0}.) [{1}] {2}", i + 1, mediaResults[i].mediaTypeString, mediaResults[i].id);
                Console.WriteLine("Total Results: " + mediaResults.GetLength(0));
            }
            catch
            {
                searchOK = false;
            }

            if (searchOK)
            {
                Console.WriteLine("SEARCH OK");
                if (mediaResults.GetLength(0) > 0)
                {
                    Console.WriteLine("Enter media number to retrieve details.");
                    if (Int32.TryParse(Console.ReadLine(), out int searchNum))
                    {
                        try
                        {
                            IdResultObjectWithMediaType result = null;

                            if (searchNum <= mediaResults.GetLength(0))
                            {
                                result = mediaResults[searchNum - 1];
                            }
                            else
                                throw new NullReferenceException("result is null.");                            
                            MediaSearchResult mediaSearchResult = null;
                            PersonResult personResult = null;
                            switch (result.mediaType)
                            {
                                case MediaTypeEnum.movie:
                                    mediaSearchResult = await MovieResult.retrieveDetailsAsync(result.id);
                                    break;
                                case MediaTypeEnum.tv:
                                    mediaSearchResult = await TvSeriesResult.retrieveDetailsAsync(result.id);
                                    break;
                                case MediaTypeEnum.person:
                                    personResult = await PersonResult.retrieveDetailsAsync(result.id);
                                    break;
                            }
                            Console.WriteLine("Selected *{1}* ID: {0}", result.id, result.mediaTypeString);
                            if (mediaSearchResult != null)
                            {
                                Console.WriteLine("\t{0} ({1})", mediaSearchResult.name, mediaSearchResult.release_date);
                            }
                            else
                            {
                                if (personResult != null)
                                {
                                    Console.WriteLine("\t{0} ({1})", personResult.name, personResult.birthday);
                                }
                                else
                                    Console.WriteLine("Result Array was null");
                            }

                        }
                        catch (NullReferenceException ex)
                        {
                            Console.WriteLine("Error: NullReferenceException. Probably number out of range. INNER ERROR: {0}", ex.StackTrace);
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
