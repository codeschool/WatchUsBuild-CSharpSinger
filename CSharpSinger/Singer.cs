using System;

namespace CSharpSinger
{
    public static class Singer
    {
        public static void WriteLine(string line)
        {
            var results = line.Split(':');
            WriteLine(results[0], int.Parse(results[1]));
        }

        public static void WriteLine(string line, int time)
        {
            int speed = time/line.Length;
            foreach(var letter in line.ToCharArray())
            {
                Console.Write(letter);
                System.Threading.Thread.Sleep(speed); // new method
            }
            Console.WriteLine("");
        }
    }
}
