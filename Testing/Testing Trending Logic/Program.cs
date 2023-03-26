using System;
using System.Threading.Tasks;

using TommoJProductions.TMDB.Media;
using TommoJProductions.TMDB.Search;
using TommoJProductions.TMDB.Trending;

namespace Testing_Trending_Logic
{
    class Program
    {
        // Written, 02.12.2019

        static async Task Main(string[] args)
        {
            // Written, 02.12.2019

            Console.WriteLine("The Library v1.1 Trending Test\nEnter either, 'all', 'movie', 'tv' or 'person' to get trending items");
            string mediaTypeInput = Console.ReadLine();
            bool vaildTrendingMediaType = true;
            TrendingAllowedMediaTypesEnum trendMediaType = TrendingAllowedMediaTypesEnum.all;            

            switch (mediaTypeInput)
            {
                case "all":
                    trendMediaType = TrendingAllowedMediaTypesEnum.all;
                    break;
                case "movie":
                    trendMediaType = TrendingAllowedMediaTypesEnum.movie;
                    break;
                case "tv":
                    trendMediaType = TrendingAllowedMediaTypesEnum.tv;
                    break;
                case "person":
                    trendMediaType = TrendingAllowedMediaTypesEnum.person;
                    break;
                default:
                    vaildTrendingMediaType = false;
                    break;
            }
            if (vaildTrendingMediaType)
            {
                Console.WriteLine("Enter either, 'day' or 'week' to get daily or weekly trending items.");
                string timeWindowInput = Console.ReadLine();
                bool vaildTimeWindowInput = true;
                TrendingTimeWindowEnum trendingTimeWindow = TrendingTimeWindowEnum.day;

                switch (timeWindowInput)
                {
                    case "day":
                        trendingTimeWindow = TrendingTimeWindowEnum.day;
                        break;
                    case "week":
                        trendingTimeWindow = TrendingTimeWindowEnum.week;
                        break;
                    default:
                        vaildTimeWindowInput = false;
                        break;
                }
                if (vaildTimeWindowInput)
                {
                    Trending trending = await Trending.retrieveTrendingAsync(trendMediaType, trendingTimeWindow);

                    for (int i = 0; i < trending.trendingResults.GetLength(0); i++)
                    {
                        IdResultObject idResult = trending.trendingResults[i];

                        Console.Write("{0}.) [{1}]", i + 1, idResult.GetType().Name);

                        if (idResult is MediaSearchResult)
                        {
                            MediaSearchResult media = idResult as MediaSearchResult;
                            Console.Write(" | {0} ({1})", media.name, media.release_date);
                        }
                        else
                        {
                            if (idResult is PeopleSearchResult)
                            {
                                PersonResult person = await PersonResult.retrieveDetailsAsync(idResult.id);
                                Console.Write(" | {0} ({1})", person.name, person.birthday);
                            }
                        }
                        Console.WriteLine();

                    }
                }
                else
                    Console.WriteLine("Error: Invaild time window input, '{0}'. Expecting either: 'day' or 'week'.", timeWindowInput);
            }
            else
                Console.WriteLine("Error: Invaild trend media type, '{0}'. Expecting one of: 'all', 'movie', 'tv' or 'person'.", mediaTypeInput);
            Console.WriteLine("\n\nPress R to restart or press any key to exit");
            if (Console.ReadKey().Key == ConsoleKey.R)
            {
                Console.Clear();
                await Main(null);
            }
        }
    }
}
