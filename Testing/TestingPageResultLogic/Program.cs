using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TM_Db_Lib;
using TM_Db_Lib.Search;

namespace TestingPageResultLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Written, 01.01.2020

            Console.WriteLine("Testing PageResult\nMovie Search Result Test:");
            PageResult<MovieSearchResult> moviePageResult = new PageResult<MovieSearchResult>(null)
            {
                searchPhrase = "the simpsons",
                methodName = "searchAsync",
            };
            Task task = moviePageResult.nextPage();
            task.Wait();
            for (int i = 0; i < moviePageResult.results.Length; i++)
            {
                Console.WriteLine("{0}.) {1}", i + 1, moviePageResult.results[i].name);
            }
            Console.WriteLine("Multi Search Result Test:");
            PageResult<MultiSearchResult> multiPageResult = new PageResult<MultiSearchResult>(new MultiSearchResult())
            {
                searchPhrase = "the simpsons",
                methodName = "searchAsync"
            };
            Task task1 = multiPageResult.nextPage();
            task1.Wait();
            int totalResults = 0;
            for (int i = 0; i < ApplicationInfomation.NUMBER_OF_ITEMS_PER_PAGE; i++)
            {
                MovieSearchResult movie = multiPageResult.accumulator.movies[i];
                if (movie != null)
                {
                    Console.WriteLine("\t[MOVIE] {0} ({1})", movie.name, movie.release_date);
                    totalResults++;
                }
                else
                {
                    TvSearchResult tvSeries = multiPageResult.accumulator.tvSeries[i];
                    if (tvSeries != null)
                    {
                        Console.WriteLine("\t[TV] {0} ({1})", tvSeries.name, tvSeries.release_date);
                        totalResults++;
                    }
                    else
                    {
                        PeopleSearchResult person = multiPageResult.accumulator.people[i];
                        if (person != null)
                        {
                            Console.WriteLine("\t[PERSON] {0} ({1})", person.id, person.profile_path);
                            totalResults++;
                        }
                    }
                }
            }
            Console.WriteLine("Total Results: {0}", totalResults);
            Console.ReadKey();
        }
    }
}
