using System;
using System.IO;

namespace CSharpSinger
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = { "allthistime", "codemonkey", "futuresoon" };
            Console.WriteLine("Welcome to Singer!");
            
            while (true)
            {
                Console.WriteLine("Please choose the song that you'd like sung!");
                Console.WriteLine("1 for Jonathan Coulton's 'All This Time'");
                Console.WriteLine("2 for 'The End Of The World'");
                Console.WriteLine("3 for 'It's A Small World'");
                Console.WriteLine("Enter the track number of the song you'd like or 'Quit'");
                var response = Console.ReadLine();

                if (response.ToLower() == "quit") // new method
                    break;

                var song = 0;
                if(!int.TryParse(response, out song))
                {
                    Console.WriteLine("Invalid response, try again.");
                    continue;
                }
                else
                    song--; //Arrays count from zero, people don't

                // set the directory to something for yourself
                var fileName = songs[song] + ".txt";

                if (!File.Exists(fileName)) // new condition type
                {
                    Console.WriteLine("File not found, try again");
                    continue; // new keyword
                }

                Console.WriteLine("===============================");
                var lines = File.ReadAllLines(fileName); // new method
                foreach (var line in lines)
                {
                    Singer.WriteLine(line);
                }
                Console.WriteLine("===============================");
            }
        }
    }
}