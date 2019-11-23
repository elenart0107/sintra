using System;

namespace GradesStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int grotste = 0;
            int grote = 0;
            int onderscheiding = 0;
            int voldoening = 0;
            int nietGeslaagd = 0;
            Console.WriteLine("Geef de resultaten van de cursisten in: (stop als die programa meer dan 100 kreegt)");
            int result = 0;
            while (result <= 100)
            {
                Console.WriteLine("");
                result = int.Parse(Console.ReadLine());
                if (result >= 85)
                {
                    grotste += 1;
                }
                else if (result >= 77)
                {
                    grote += 1;
                }
                else if (result >= 68)
                {
                    onderscheiding += 1;
                }
                else if (result >= 50)
                {
                    voldoening += 1;
                }
                else
                {
                    nietGeslaagd += 1;
                }

            }

            grotste -= 1;

            Console.WriteLine($"Grootste onderscheiding {grotste}\nGrote onderscheiding: {grote}\n " +
                $"Onderscheiding: {onderscheiding}\nVoldoening {voldoening}\nNiet geslaagd {nietGeslaagd}");
        }
    }
}
