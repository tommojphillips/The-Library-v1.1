using System;
using System.Diagnostics;
using System.Threading.Tasks;

using TommoJProductions;
using TommoJProductions.TMDB.Account;
using TommoJProductions.TMDB.Auth;

namespace Testing_Sessions
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Written, 04.12.2019

            Console.WriteLine("The Library v1.1 SESSION testing\nCreating request token..");
            Token token = await Token.retrieveTokenAsync();
            Console.WriteLine("Created request token.");
            if (token.success)
            {
                Console.WriteLine("\nVaildate sessions through TMDb? (1) or Login? (2)");
                if (Int32.TryParse(Console.ReadLine(), out int option))
                {
                    Session session = null;

                    if (option == 1)
                    {
                        Process.Start(String.Join("/", ApplicationInfomation.TMDB_AUTHENTICATE_ADDRESS, token.request_token));
                        Console.WriteLine("Redirecting user to URL.. when approved press enter...");
                        Console.ReadLine();
                        Console.WriteLine("Attempting to create session with request token..");
                        try
                        {
                            session = await Session.createSessionAsync(token.request_token);
                        }
                        catch (Exception ex) 
                        {
                            Console.WriteLine("Error occured while creating session via, TMDb: {0}", ex.Message);
                        }
                    }
                    else
                    {
                        if (option == 2)
                        {
                            Console.WriteLine("Enter Username");
                            string username = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            string password = Console.ReadLine();
                            try
                            {
                                session = await Session.createSessionWithLoginAsync(username, password, token.request_token);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error occured while creating session via, login: {0}", ex.Message);
                            }
                        }
                        else
                            Console.WriteLine("Invaild option, expected 1 or 2.");
                    }

                    if (session?.success ?? false)
                    {
                        Console.WriteLine("Successfully created session. via, option {0}\nRetrieving account details ...", option);
                        User user = await User.retrieveUserDetailsAsync(session.session_id);
                        Console.WriteLine("Hello, {0} | {1}, ID={2}", user.name, user.username, user.id);
                    }
                }
                else
                    Console.WriteLine("Number expected..");
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
