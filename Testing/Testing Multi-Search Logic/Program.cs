using System;
using System.Threading.Tasks;

using TommoJProductions;
using TommoJProductions.TMDB.Search;

namespace Testing_Multi_Search_Logic
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Written, 29.11.2019

            Console.WriteLine("The Library v1.1 Multi-Search Test\nEnter Phrase and press Enter to search for movies, tv series and people as a multi-search request.");
            string searchPhrase = Console.ReadLine();
            MultiSearchResult multiSearch = null;
            Console.WriteLine("\n\nMulti-Search Function\n-------------------------------------------");
            try
            {
                multiSearch = await MultiSearchResult.searchAsync(searchPhrase, 1);
            }
            catch (AggregateException ex)
            {
                string exMessage = ex.Message;
                for (int i = 0; i < ex.InnerExceptions.Count; i++)
                    exMessage += String.Format("\n{0}.) {1}", i + 1, ex.InnerExceptions[i].Message);
                Console.WriteLine("An error occured while performing multi-search function: {0}", exMessage);
            }

            int totalResults = 0;
            for (int i = 0; i < ApplicationInfomation.NUMBER_OF_ITEMS_PER_PAGE; i++)
            {
                MovieSearchResult movie = multiSearch.movie_results[i];
                if (movie != null)
                {
                    Console.WriteLine("\t[MOVIE] {0} ({1})", movie.name, movie.release_date);
                    totalResults++;
                }
                else
                {
                    TvSearchResult tvSeries = multiSearch.tv_results[i];
                    if (tvSeries != null)
                    {
                        Console.WriteLine("\t[TV] {0} ({1})", tvSeries.name, tvSeries.release_date);
                        totalResults++;
                    }
                    else
                    {
                        PeopleSearchResult person = multiSearch.person_results[i];
                        if (person != null)
                        {
                            Console.WriteLine("\t[PERSON] {0} ({1})", person.id, person.profile_path);
                            totalResults++;
                        }
                    }
                }
            }
            Console.WriteLine("Total Results: {0}", totalResults);

            Console.WriteLine("\n\nPress R to restart or press any key to exit");
            if (Console.ReadKey().Key == ConsoleKey.R)
            {
                Console.Clear();
                await Main(null);
            }
        }
    }
}
