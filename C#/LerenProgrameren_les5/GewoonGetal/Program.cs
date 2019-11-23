using System;

namespace GewoonGetal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int getal;
            int beginRange;
            bool isPriemgetal;

            Console.WriteLine("Geef een getal in:");
            while (!int.TryParse(Console.ReadLine(), out getal))
            {
                Console.WriteLine("Geef een getal in:");
            }

            
            for (beginRange = 2; beginRange <= getal; beginRange++)
            {
                isPriemgetal = true;
                for (int i = 2; i < beginRange; i++)
                {
                    if (beginRange % i == 0)
                    {
                        isPriemgetal = false;
                        break;

                    }
                }
                if (!isPriemgetal)
                {
                    continue;// in the loop to continue the loop after break
                }

                Console.WriteLine(beginRange);

            }
        }
    }
}
