using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec = 0;
            int min = 0;
            int uur = 0;

            for (uur = 0; uur < 24; uur++)
            {
                for (min = 0; min < 60; min++)
                {

                    for (sec = 0; sec < 60; sec++)
                    {

                        Console.WriteLine($"tijd is {uur}:{min}:{sec}");
                    }

                }
            }

        }
    }
}
