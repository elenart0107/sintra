using System;

namespace PifagorsTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;

            Console.WriteLine("Geef een getal in:");
            length = int.Parse(Console.ReadLine());

            for (int rij = 1; rij <= length; rij++)
            {

                for (int colum = 1; colum <= length; colum++)
                {

                    Console.Write($"{colum * rij,4}"); // distance or place holders

                }

                Console.WriteLine(); // to start loop from new line
            }
        }
    }
}
