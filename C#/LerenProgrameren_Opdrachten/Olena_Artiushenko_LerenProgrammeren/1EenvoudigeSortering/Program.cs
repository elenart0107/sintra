using System;

namespace Olena_Artiushenko_LerenProgrammeren
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int[] arr = new int[3];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Geef getal numer {i} in:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
