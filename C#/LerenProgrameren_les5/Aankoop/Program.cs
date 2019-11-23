using System;

namespace Aankoop
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal geldig = 0;
            decimal aankoop = 0;
            decimal total = 0;



            Console.WriteLine("Hoe veel geld is geldig?");




            while (!decimal.TryParse(Console.ReadLine(), out geldig))
            {
                Console.WriteLine("Hoeveel geld staat er op uw bankrekening?");
            }// what is the usage of it????

            if (geldig <= 0)
            {
                Console.WriteLine("Jammer, we kunnen niet gan schoppen:(");
            }

            Console.WriteLine("Yupii! je kan nog iets kopen!");



            do
            {
                Console.WriteLine("Geef de bedrag van da aankoop in:");
                string aankopStop = Console.ReadLine();
                string lowerAankopStop = aankopStop.ToLower();
                if (lowerAankopStop == "stop")
                {
                    Console.WriteLine("Einde van de aankoop");
                    break;

                }

                aankoop = decimal.Parse(aankopStop);
                if (geldig - aankoop >= 0)
                {
                    Console.WriteLine($"product gekocht {aankoop}");
                    geldig -= aankoop;
                    total += aankoop;
                }
                else
                {
                    Console.WriteLine("Het product is te duur. Kies andere product aub");
                }


            }
            while (geldig > 0);

            Console.WriteLine($"Total angekoocht: {total}, geldig noch: {geldig}");

        }
    }
}
