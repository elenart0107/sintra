using System;

namespace EvenOneven
{
    class Program
    {
        static void Main(string[] args)
        {
            int som1 = 0;
            int som2 = 0;
            int even = 0;
            int oneven = 0;
            Console.WriteLine("Geef een getal in:");
            int getal = 0;
            do
            {
                Console.WriteLine("");
                getal = int.Parse(Console.ReadLine());

                if (getal % 2 == 0)
                {
                    even += 1;

                    som1 += getal;
                }
                else
                {
                    oneven += 1;

                    som2 += getal;
                }

            }
            while (getal > 0);


            Console.WriteLine($"Aantal even getalen {even}.\nAantal oneven getalen {oneven}.\nSom van de even getalen is {som1}.\nSom van de oneven getalen is {som2}");
        }
    }
}
