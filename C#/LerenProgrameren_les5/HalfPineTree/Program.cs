using System;

namespace HalfPineTree
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int rij = 1; rij <= 6; rij++)
            {
                //column

                for (int kolom = 1; kolom <= rij; kolom++)
                {
                    Console.Write("* ");

                }


                Console.WriteLine();

            }
        }
    }
}
