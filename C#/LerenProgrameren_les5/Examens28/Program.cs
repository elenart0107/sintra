using System;

namespace Examens28
{
    class Program
    {
        static void Main(string[] args)
        {
            int wiskunde, informatika, boekhouden, gemiddeldeWI;
            

            Console.WriteLine("Geef je punten voor Wiskunde in");
            while (!int.TryParse(Console.ReadLine(), out wiskunde))
            {
                Console.WriteLine("Geef je punten voor wiskunde in");
            }

            while (wiskunde > 10)
            {
                Console.WriteLine("Geef je punten voor Wiskunde in");
                wiskunde = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Geef je punten voor informatika in");

            while (!int.TryParse(Console.ReadLine(), out informatika))
            {
                Console.WriteLine("Geef je punten voor informatika in");
            }
            while (informatika > 10)
            {
                Console.WriteLine("Geef je punten voor informatika in");
                informatika = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Geef je punten voor boekhouden in");

            while (!int.TryParse(Console.ReadLine(), out boekhouden))
            {
                Console.WriteLine("Geef je punten voor boekhouden in");
            }
            while (boekhouden > 10)
            {
                Console.WriteLine("Geef je punten voor boekhouden in");
                boekhouden = int.Parse(Console.ReadLine());
            }

            gemiddeldeWI = (informatika + wiskunde) / 2;

            if (gemiddeldeWI >= 12 && boekhouden >= 6)
            {
                Console.WriteLine("Je hebt geslagd!");
               
            }

            if (gemiddeldeWI < 12)
            {
                Console.WriteLine("Je hebt niet geslaadg want je gemiddelde van informatika and wiskunde is minder dan 12.");
            }
            else if (boekhouden < 6)
            {
                Console.WriteLine("Je hebt niet geslaadg want je punten van boekhouden zijn minder dan 6.");
            }

        }
    }
}
