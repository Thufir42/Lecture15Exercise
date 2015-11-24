using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture15Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMainMenu();
        }

        static void DisplayMainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n1 - StopWatch");
                Console.WriteLine("2 - Stack Overflow Post");
                Console.Write("\nChoose a menu item number, or press any other key to quit: ");
                var input = Console.ReadKey();
                var test = input.KeyChar;
                switch (test)
                {
                    case '1':
                        StopWatchMenu();
                        break;
                    case '2':
                        PostMenu();
                        break;
                    default:
                        return;
                }
            }
        }

        static void StopWatchMenu()
        {
            var stopwatch = new StopWatch();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Stopwatch is currently {0}", stopwatch.GetStatus() ? "Running" : "Stopped");
                Console.WriteLine("\n1 - Start Stopwatch");
                Console.WriteLine("2 - Stop Stopwatch");
                Console.WriteLine("3 - Display the duration");
                Console.Write("\nChoose a menu item number, or press any other key to quit: ");
                var input = Console.ReadKey();
                var test = input.KeyChar;
                Console.Clear();
                switch (test)
                {
                    case '1':
                        stopwatch.Start();
                        break;
                    case '2':
                        stopwatch.Stop();
                        break;
                    case '3':
                        Console.WriteLine("Calculated duration is: " + stopwatch.GetDuration());
                        Console.WriteLine("\nPress any to continue...");
                        Console.ReadKey();
                        break;
                    default:
                        return;
                }

            }
        }
        static void PostMenu()
        {
            var post = new Post();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Post Title: " + post.GetTitle() );
                Console.WriteLine("Post Description: " + post.GetDescription() );
                Console.WriteLine("Posted on date: " + post.GetPostedDate() );
                Console.WriteLine("\nCurrent vote Status:");
                Console.WriteLine("\tUpvotes: {0}\tDownvotes: {1}\tTotal Votes: {2}", post.GetUpvotes(), post.GetDownVotes(), post.GetTotalVotes());
                Console.WriteLine("\n1 - Vote Up");
                Console.WriteLine("2 - Vote Down");
                Console.Write("\nChoose a menu item number, or press any other key to quit: ");
                var input = Console.ReadKey();
                var test = input.KeyChar;
                Console.Clear();
                switch (test)
                {
                    case '1':
                        post.UpVote();
                        break;
                    case '2':
                        post.DownVote();
                        break;
                    default:
                        return;
                }

            }

        }
    }
}
