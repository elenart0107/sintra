using System;

namespace ErsteProject
{
    class Program
    {
        static void Main(string[] args)
        {
            String bovenEnOnder;
            bovenEnOnder = "*******";
            String midden = "*     *";
            Console.WriteLine(bovenEnOnder);
            Console.WriteLine(midden);
            Console.WriteLine(midden);
            Console.WriteLine(midden);
            Console.WriteLine(bovenEnOnder);
            Console.WriteLine("done the first execise n/");


            Console.WriteLine("Geef je voornaam: ");
            String voornaam;
            voornaam = Console.ReadLine();
            Console.WriteLine("Geef je naam: ");
            String naam;
            naam = Console.ReadLine();
            Console.WriteLine("Geef je adres: ");
            String adres;
            adres = Console.ReadLine();
            Console.WriteLine("{0} {1} woont in {2}", voornaam, naam, adres);
            Console.WriteLine("done the second execise n/");
            


            Console.WriteLine("Geef eerste getal: ");
            float a;
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Geef tweede getal: ");
            float b;
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Geef een bewerking ('+', '-', '*' of '/'): ");
            char bewerking;
            bewerking = char.Parse(Console.ReadLine());
            float resultaat;
            //switch (bewerking)
            //{
            //    case '*': resultaat = a * b;
            //       break;
            //    case '/': resultaat = a / b;
            //        break;
            //    case '+': resultaat = a + b;
            //        break;
            //   case '-': resultaat = a - b;
            //        break;
            //}
            string space = " ";
            //resultaat = (a + space + bewerking + space + b);
            Console.WriteLine(a + space + bewerking + space + b);

        }
    }
}
