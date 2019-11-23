using System;

namespace Ratten
{
    class Program
    {
        static void Main(string[] args)
        {
            float ratten = 2000000;
            int jaren = 0;
            float groei = 0.15f;
            while (ratten <= 10000000)
            {
                ratten = ratten * (1 + groei);
                jaren++;
            }
            Console.WriteLine($"Binnen {jaren} jaren zijn er 10 miljoenen retten in New York");
        }
    }
}
