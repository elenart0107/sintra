using System;

namespace MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputGetal;

            Console.WriteLine("Geef een getal in:");
            inputGetal = int.Parse(Console.ReadLine());


            for (int getal = 0; getal <= 10; getal++)
            {
                Console.WriteLine($"{getal} * {inputGetal} = {getal * inputGetal}");
            }
        }

    }
}
