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

        public static void WriteLine(string line, int speed)
        {
            foreach(var letter in line.ToCharArray())
            {
                Console.Write(letter);
                if (speed > 50)
                    speed = 50;
                else if (speed < 1)
                    speed = 1;
                System.Threading.Thread.Sleep((50-speed) * 10); // new method
            }
            Console.WriteLine("");
        }
    }
}
