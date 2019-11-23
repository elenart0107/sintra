using System;

namespace Dobbelstenen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ontwerp een consoletoepassing waarmee je 3 worpen met 2 dobbelstenen nabootst. Het resultaat in de console toont wat de deelnemer wint.
 
            //  De deelnemer kan zelf kiezen hoeveel hij inzet.De minimum inzet is 5 EUR en de maximum inzet is 100 EUR.
 
            //  Het spel kan herhaald worden na de laatste worp.

            //    bij 1 van de 3 worpen is er 2 keer een 6 geworpen: winst = inzet x 50

            //    bij 1 van de 3 worpen is er 2 keer hetzelfde geworpen: winst = inzet x 10

            //    bij de 3 worpen is er 2 keer een zes geworpen: winst = inzet x 2

            


            Random random = new Random();
            decimal worp1, worp2, inzet, terug, keer;
            decimal gewoon1 = 50;
            decimal gewoon2 = 10;
            decimal gewoon3 = 2;
            int aantalZes = 0;
            int tweeKeerZes = 0;
            int hetzelfdeGetal = 0;



            int opniuew = 0;
            keer = 3;


            do
            {

                worp1 = 0;
                worp2 = 0;
                terug = 0;

                Console.WriteLine("Geef je inzet tussen 50 en 100:");
                while (!decimal.TryParse(Console.ReadLine(), out inzet))
                {
                    Console.WriteLine("dat moest enn numer zijn. Geef je inzet tussen 50 en 100:");
                }
                Console.WriteLine();



                for (int i = 1; i <= keer; i++)
                {

                    worp1 = random.Next(1, 7);
                    worp2 = random.Next(1, 7);
                    Console.WriteLine($"Worp {i}: {worp1} en {worp2}");






                    if (worp1 == worp2 && i >= 2)
                    {

                        hetzelfdeGetal++;

                    }

                    else if (worp1 == 6 || worp2 == 6)
                    {

                        if (worp1 == 6 && worp2 == 6)
                        {
                            tweeKeerZes++;
                        }
                        else
                        {
                            aantalZes++;

                        }


                    }



                }
                //output
                if (hetzelfdeGetal >= 1)
                {
                    terug += inzet * gewoon3;
                    Console.WriteLine("bij 1 van de 3 worpen is er 2 keer een hetzelfde geworpen.");
                }
                else if (tweeKeerZes >= 1)
                {
                    terug = inzet * gewoon1;
                    Console.WriteLine("bij 1 van de 3 worpen is er 2 keer een 6 geworpen.");
                }
                else if (aantalZes >= 2)
                {
                    terug = inzet * gewoon2;
                    Console.WriteLine("Bij de 3 worpen is er 2 keer een zes geworpen.");
                }


                Console.WriteLine($"Je kreegt {terug} terug.");


                Console.WriteLine("Wil je opniuew beginen - geef 1 in:");
                opniuew = int.Parse(Console.ReadLine());

                if (opniuew == 1)
                {
                    continue;
                }
            }
            while (opniuew == 1);



        }
    }
}
