using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TommoJProductions.TMDB.Discover;
using TommoJProductions.TMDB.Search;

namespace Discover_Logic_Testing
{
    class Program
    {
        // Written, 16.01.2020

        static void Main(string[] args)
        {
            // Written, 16.01.2020

            DiscoverParameters discoverParameters;

            Console.WriteLine("The Library v1.1 Discover logic Test\n");

            Console.WriteLine("What is coming out in the next year...?");
            discoverParameters = new DiscoverParameters()
            {
                primaryReleaseDate_lte = DateTime.Now.Add(TimeSpan.FromDays(365)).ToString("yyyy-MM-dd"),
                primaryReleaseDate_gte = DateTime.Now.ToString("yyyy-MM-dd"),
            };
            MovieSearchResult[] movies = Discover.discoverMoviesAsync(discoverParameters).Result;
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine("{0}.) {1} {2}", i + 1, movies[i].name, movies[i].release_date);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("What movies are in theatres?");
            discoverParameters = new DiscoverParameters()
            {
                primaryReleaseDate_lte = DateTime.Now.ToString("yyyy-MM-dd"),
                primaryReleaseDate_gte = DateTime.Now.Subtract(TimeSpan.FromDays(7)).ToString("yyyy-MM-dd"),
            };
            movies = Discover.discoverMoviesAsync(discoverParameters).Result;
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine("{0}.) {1}", i + 1, movies[i].name);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("What are the most popular movies?");
            discoverParameters = new DiscoverParameters();
            movies = Discover.discoverMoviesAsync(discoverParameters).Result;
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine("{0}.) {1}", i + 1, movies[i].name);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("What are the highest rated movies rated R?");
            discoverParameters = new DiscoverParameters() 
            {
                cerficationCountry = "US",
                certification = "R",
                sortByMembers = MediaSortByMembersEnum.vote_average,
            };
            movies = Discover.discoverMoviesAsync(discoverParameters).Result;
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine("{0}.) {1}", i + 1, movies[i].name);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("What are the most popular kids movies?");
            discoverParameters = new DiscoverParameters()
            {
                cerficationCountry = "US",
                certification_gte = "G",
                certification_lte = "PG"
            };
            movies = Discover.discoverMoviesAsync(discoverParameters).Result;
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine("{0}.) {1}", i + 1, movies[i].name);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("What is are the best mature (PG - MA15+) movies from 2013?");
            discoverParameters = new DiscoverParameters()
            {
                cerficationCountry = "US",
                certification_gte = "PG",
                certification_lte = "MA15+",
                year = 2013,
                sortByMembers = MediaSortByMembersEnum.vote_average
            };
            movies = Discover.discoverMoviesAsync(discoverParameters).Result;
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine("{0}.) {1}", i + 1, movies[i].name);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("What are the highest rated science fiction movies that Tom Cruise has been in?");
            discoverParameters = new DiscoverParameters()
            {
                withCast = "500",
                withGenres = "878",
                sortByMembers = MediaSortByMembersEnum.vote_average
            };
            movies = Discover.discoverMoviesAsync(discoverParameters).Result;
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine("{0}.) {1}", i + 1, movies[i].name);
            }
            Console.WriteLine("---------------------");
            Console.ReadKey();
        }
    }
}
