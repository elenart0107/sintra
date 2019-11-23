using System;

namespace _2.CirkelRechthoekVierkant
{
    class Program
    {
        static void Main(string[] args)
        {
            string voorm = "Maak uw keuze voor de vorm:\n1.Cirkel\n2. Rechthoek\n3. Vierkant";
            string bereking = "Maak uw keuze voor de bereking:\n1.Omtrek\n2.Oppervlakte";
            int voormKeuze;

            Console.WriteLine(voorm);

            for (int i = 0; i < voorm.Length; i++)
            {
                Console.Write("_");
            }
            voormKeuze = int.Parse(Console.ReadLine());

            switch (voormKeuze)
            {
                case 1:
                    Console.WriteLine("");
                    break;

                case 2:
                    break;

                case 3:
                    break;
            }

        }
    }
}
