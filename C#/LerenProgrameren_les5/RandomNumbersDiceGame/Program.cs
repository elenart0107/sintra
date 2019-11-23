using System;

namespace RandomNumbersDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //int randomNumber1, randomNumber2;
            //int punkten1 = 0;
            //int punkten2 = 0;

            //Console.WriteLine("Geef je naam in:");
            //string gebruiker1 = Console.ReadLine();
            //Console.WriteLine("Geef je naam in:");
            //string gebruiker2 = Console.ReadLine();

            //do
            //{

            //    randomNumber1 = 0;
            //    randomNumber2 = 0;

            //    while (randomNumber1 != 6 && randomNumber2 != 6)

            //    {
            //        Console.WriteLine("Volgende runde");
            //        randomNumber1 = random.Next(1, 7);
            //        Console.WriteLine($"{gebruiker1} gooit {randomNumber1}");
            //        randomNumber2 = random.Next(1, 7);
            //        Console.WriteLine(value: gebruiker2 + " gooit " + randomNumber2);
            //    }

            //    Console.WriteLine("Er heeft iemand 6 gesmeten");

            //    if (randomNumber1 == 6)
            //    {
            //        punkten1++;

            //    }
            //    if (randomNumber2 == 6)
            //    {
            //        punkten2++;

            //    }
            //    Console.WriteLine($"{gebruiker1}:\t{punkten1}\t{gebruiker2}:\t{punkten2}");


            //}
            //while (punkten1 < 3 && punkten2 < 3);
            //Console.WriteLine($"{(punkten1 >= 3 ? gebruiker1 : gebruiker2)} is a winner!");



            #region 2nd option
            Random random = new Random();
            int randomNumber1, randomNumber2;
            int punkten1 = 0;
            int punkten2 = 0;
            bool spelGedaan = true;

            Console.WriteLine("Geef je naam in:");
            string gebruiker1 = Console.ReadLine();
            Console.WriteLine("Geef je naam in:");
            string gebruiker2 = Console.ReadLine();

            do
            {

                randomNumber1 = 0;
                randomNumber2 = 0;
                Console.WriteLine("Volgende runde");
                randomNumber1 = random.Next(1, 7);
                Console.WriteLine($"{gebruiker1} gooit {randomNumber1}");
                randomNumber2 = random.Next(1, 7);
                Console.WriteLine(value: gebruiker2 + " gooit " + randomNumber2);

                punkten1 += randomNumber1 == 6 ? 1 : 0;
                punkten2 += randomNumber2 == 6 ? 1 : 0; // punkten2 += (якщо randomNumber2 == дорівнює 6 ? добав 1 : інакше добав нуль 0);

                spelGedaan = punkten1 == 3 || punkten2 == 3;

            }
            while (!spelGedaan);
            Console.WriteLine($"{(punkten1 >= 3 ? gebruiker1 : gebruiker2)} is a winner!");

            #endregion
        }


    }
}
