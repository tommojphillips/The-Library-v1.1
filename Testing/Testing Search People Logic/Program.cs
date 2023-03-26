using System;
using System.Threading.Tasks;

using TommoJProductions.TMDB.Media;
using TommoJProductions.TMDB.Search;

namespace Testing_Search_People_Logic
{
    class Program
    {
        // Written, 27.11.2019

        static async Task Main(string[] args)
        {
            // Written, 27.11.2019

            Console.WriteLine("The Library v1.1 Search People Test\nEnter Phrase and press Enter to search for people");
            string searchPhrase = Console.ReadLine();
            bool searchOK = true;
            PeopleSearchResult[] peopleSearchResults = null;
            Console.WriteLine("\n\nPeople Search Function\n-------------------------------------------");
            try 
            {
                peopleSearchResults = await PeopleSearchResult.searchAsync(searchPhrase, 1);
                for (int i = 0; i < peopleSearchResults.GetLength(0); i++)
                    Console.WriteLine("{0}.) {1}", i + 1, peopleSearchResults[i].id);
                Console.WriteLine("Total Results: " + peopleSearchResults.GetLength(0));
            }
            catch
            {
                searchOK = false;
            }
            if (searchOK)
            {
                if (peopleSearchResults.GetLength(0) > 0)
                {
                    Console.WriteLine("Enter people number to retrieve details.");
                    if (Int32.TryParse(Console.ReadLine(), out int searchNum))
                    {
                        try
                        {
                            PersonResult result = null;

                            if (searchNum <= peopleSearchResults.GetLength(0))
                            {
                                result = await PersonResult.retrieveDetailsAsync(peopleSearchResults[searchNum - 1].id);
                                result.known_for = peopleSearchResults[searchNum - 1].known_for;
                            }
                            else
                                throw new NullReferenceException("result is null");
                            Console.WriteLine("Selected PersonID: {0}\nName: {1}\nAdult Content: {2}\nProfile Image Path: {3}",
                                result.id, result.name, result.adult ? "Yes" : "No", result.profile_path);
                            if (result.known_for != null)
                            {
                                if (result.known_for.GetLength(0) > 0)
                                {
                                    Console.WriteLine("Known for ({0}):", result.known_for.GetLength(0));
                                    for (int i = 0; i < result.known_for.GetLength(0); i++)
                                    {
                                        MediaSearchResult mediaSearchResult = null;
                                        switch (result.known_for[i].mediaType)
                                        {
                                            case MediaTypeEnum.movie:
                                                mediaSearchResult = await MovieResult.retrieveDetailsAsync(result.known_for[i].id);
                                                break;
                                            case MediaTypeEnum.tv:
                                                mediaSearchResult = await TvSeriesResult.retrieveDetailsAsync(result.known_for[i].id);
                                                break;
                                        }

                                        Console.WriteLine("\t{2}.) [{1}] ID: {0}", result.known_for[i].id, result.known_for[i].mediaTypeString, i + 1);
                                        if (mediaSearchResult != null)
                                        {
                                            Console.WriteLine("\t{0} ({1})", mediaSearchResult.name, mediaSearchResult.release_date);
                                        }
                                    }
                                }
                            }
                        }
                        catch (NullReferenceException ex)
                        {
                            Console.WriteLine("Error: NullReferenceException. Probably number out of range. STACKTRACE: {0}", ex.StackTrace);
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
