using System;

namespace PropertiesLes7
{
    class Program
    {
        static void Main(string[] args)
        {
            //properties
            //length

            //return int - the length of the string

            // index []

            string woord = "CURSUSMATERIALEN";
            var letterN = woord[woord.Length-1];
            

            Console.WriteLine(letterN);
            Console.WriteLine();
            Console.WriteLine();

            //for loop

            for (int letterIndex = 0; letterIndex < woord.Length - 1; letterIndex++)
            {
                Console.WriteLine(woord[letterIndex]);
            }




        }
    }
}
