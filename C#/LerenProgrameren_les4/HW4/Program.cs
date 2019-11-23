using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Opdracht 4.1 - Teller #1
            //Maak een teller van 1 tem 10.Maak de oefening 3 keer(mag in hetzelfde opdracht) zowel met een for-loop

            //int keer = 10;
            //for (int teller = 0; teller <= keer; teller++)
            //{
            //    Console.WriteLine("Teller = " + teller);
            //}


            #endregion

            #region Opdracht 4.1 - Teller #2
            //Maak een teller van 1 tem 10.Maak de oefening 3 keer(mag in hetzelfde opdracht) zowel met een while-loop

            //int teller = 0;
            //while (teller <= 10)
            //{
            //    Console.WriteLine("Teller = " + teller);
            //    teller++;
            //}

            #endregion

            #region Opdracht 4.1 - Teller #3
            //Maak een teller van 1 tem 10.Maak de oefening 3 keer(mag in hetzelfde opdracht) zowel met een do -while loop.
            //int teller = 0;
            //do
            //{
            //    Console.WriteLine("Teller = " + teller);
            //    teller++;
            //}
            //while (teller <= 10);

            #endregion

            #region Opdracht 4.2 – Teller + Som
            //Maak een teller van 20 tem 30.Geef hierbij de getallen terug, alsook de som van de getallen.De som van de getallen wordt één keer getoond, nl op het einde.

            //int sum = 0;
            //int keer = 30;
            //for (int teller = 20; teller <= keer; teller++)
            //{
            //    sum += teller;
            //    Console.WriteLine("Teller = " + teller);
            //}
            //Console.WriteLine("sum is = " + sum);

            #endregion

            #region Opdracht 4.3 – Grootste getal
            //De gebruiker geeft het aantal getallen in (aantal > 1) die hij wenst in te geven. Voer daarna een reeks getallen in. Bepaal het grootste getal in de rij. Gebruik geen array!
            //int getal = 0;
            //int conter = 0;
            //int max = 0;

            //while (conter <= 15)
            //    {
            //    Console.WriteLine("Geef een getal in:");
            //    getal = int.Parse(Console.ReadLine());
            //    conter++;

            //    if (conter == 0)
            //    {
            //        max = getal;
            //    }
            //    else
            //    {
            //        if (getal > max)
            //        {
            //            max = getal;
            //        }
            //    };

            //}
            //Console.WriteLine($"de grootste getal is {max}");

            #endregion

            #region Opdracht 4.4 – Aantal positieve, negatieve en 0 - getallen
            //De gebruiker geeft het aantal getallen in (aantal > 1) dat hij zal ingeven. De ingegeven getallen kunnen zowel positief als negatief zijn.

            //De output zal het aantal negatieve getallen, positieve getallen en nulgetallen weergeven.

            //int getal = 0;
            //int conter = 0;
            //int aantalPosit = 0;
            //int aantalNegat = 0;
            //int aantal0 = 0;
            //Console.WriteLine("Hoe veel getalen ga je geven?");
            //int aantalGet = int.Parse(Console.ReadLine());

            //while (conter <= aantalGet)
            //{
            //    Console.WriteLine("Geef een getal in:");
            //    getal = int.Parse(Console.ReadLine());
            //    conter++;

            //    if (getal == 0)
            //    {
            //        aantal0 += 1;
            //    }
            //    else
            //    {
            //        if (getal > 0)
            //        {
            //            aantalPosit += 1;
            //        }
            //        else
            //        {
            //            aantalNegat += 1;
            //        }
            //    };

            //}
            //Console.WriteLine($"je geef {aantal0} de 0 getalen, {aantalPosit} positive getalen en {aantalNegat} negative getalen");


            // 2-ND OPTION:

            //for (conter = 0; conter <= aantalGet; conter++)
            //{
            //    if (getal > 0)
            //    {
            //        aantalPosit++;
            //    }
            //    else if (getal == 0)
            //    {
            //        aantal0++;
            //    }
            //    else
            //    {
            //        aantalNegat++;
            //    }
            //}

            #endregion

            #region Opdracht 4.5 - Kwadraat!!!!!!!!!!!!!!!!!
            //Schrijf een programma dat het kwadraat van de getallen van 1 tot 20 afdruk door middel van while-lus.
            //double i = 1;
            //while (i <=20);
            //{
            //    Console.WriteLine(Math.Pow(i, 2));
            //    i++;
            //}

            #endregion

            #region Opdracht 4.5 - Kwadraat to draw
            //int number = 0;
            //char space = ' ';
            //int counter = 0;
            //int size = 20;
            //while (counter <= size)
            //{
            //    if (counter == 0 || counter == size)
            //    {

            //        int index1 = 1;
            //        while (index1 <= size)
            //        {
            //            Console.Write($"{number}");
            //            number += 1;
            //            index1++;
            //        }
            //    }

            //    else
            //    {
            //        int index2 = 1;
            //        while (index2 < size)

            //        {
            //            if (counter == 0 || counter == size)
            //            {
            //                Console.Write($"{number}");
            //                number += 1;
            //            }
            //            else
            //            {
            //                Console.Write(space);
            //            }
            //            index2++;
            //        }
            //    }

            //}

            #endregion

            #region Opdracht 4.6 – Som van oneindig aantal getallen
            //We moeten een oneindig aantal getallen kunnen ingeven.Van het aantal ingegeven getallen wordt de som berekend 
            //en weergegeven.De getallen die ingegeven worden zijn van het type int.De getallenreeks eindigt met de ingave van het getal “-1”. 
            //Dit getal wordt niet bij de som geteld. Indien we als eerst getal - 1 ingeven, dan is de som = 0.

            //int sum = 0;
            //int counter = 0;
            //int number = 0;
            //while (counter == counter)
            //{
            //    Console.WriteLine("Geef een getal in:");
            //    number = int.Parse(Console.ReadLine());
            //    if (number != -1)
            //    {
            //        sum += number;
            //        Console.WriteLine($"The sum is {sum}");
            //                        }
            //    else
            //    {
            //        sum = 0;
            //        Console.WriteLine($"The sum is {sum}");
            //        break;
            //    }
            //   // counter++;
            //}

            #endregion

            #region Opdracht 4.8 – Faculteit FACTORIAL
            //Bereken de faculteit van een getal.
            //Bv.Faculteit van 5 = 5! = 5 * 4 * 3 * 2 * 1 = 120.

            //Opgelet: de faculteit van 0(0!) is 1, en de faculteit van een negatief getal bestaat niet.

            //De faculteit is een long.
            //long faculteit = 1;
            //long counter = 0;
            //long number = 0;


            //Console.WriteLine("Geef een getal in:");
            //number = long.Parse(Console.ReadLine());
            //counter = number;


            //if (number == 0)
            //    {
            //        Console.WriteLine("\nDe faculteit van 0 is 1\n0! = 1");
            //    }
            //else if (number > 0)
            //    {
            //        while(counter != 1)
            //        {
            //        faculteit = faculteit * counter;
            //        counter -= 1;


            //        }
            //    Console.WriteLine($"De faculteit is {faculteit}\n\n{number}! = {faculteit}");
            //}
            //else
            //    {
            //        Console.WriteLine("\nDe faculteit van een negatief getal bestaat niet");
            //    }


            //2-ND OPTION

            //for (int i = 5; i >= 1; i--) ;
            //{
            //    int factorial *= i;
            //}



            #endregion

            #region Opdracht 4.9 - Gemiddelde
            //We vragen aan de gebruiker een startwaarde en eindwaarde op. (integer getallen).
            //Het programma berekent het gemiddelde van de getallen die tussen deze startwaarde en eindwaarde liggen.

            //De uitvoer is als volgt wanneer de gebruiker 5 als startwaarde en 10 als eindwaarde heeft opgegeven.

            //decimal counter = 0;
            //Console.WriteLine("Geef eerste getal in:");
            //decimal begin = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Geef tweede getal in:");
            //decimal end = decimal.Parse(Console.ReadLine());
            //decimal sum = 0;
            //decimal gemidelde = 0;
            //while (counter <= (end - begin + 1))
            //{
            //    sum = sum + begin;
            //    begin += 1;
            //    counter++;
            //}
            //gemidelde = Math.Round((sum / counter), 2);
            //Console.WriteLine($"Gemidelde is {gemidelde}");


            #endregion

            #region Opdracht 4.10 – Priemgetallen !!!!!!!!!!!!!!!!!!!!!!!
            //Maak een programma die als input een getal vraag groter dan 0, en als output heeft  als het een priemgetal is of niet.

            //Console.WriteLine("Geef een getal in:");
            //long number = long.Parse(Console.ReadLine()); //TODO does not work for value = 55


            //if (number >= 3)
            //{
            //    for (int counter = 2; counter < number; counter++)
            //    {
            //        if (number % counter == 0)
            //        {
            //            Console.WriteLine("De getal is geen priemgetal");
            //            break;

            //        }
            //        else
            //        {
            //            Console.WriteLine("De getal is een priemgetal");
            //            break;
            //        }

            //    }
            //}
            //else if (number == 2)
            //{
            //    Console.WriteLine("De getal is een priemgetal");
            //}
            //else
            //{
            //    Console.WriteLine("De getal is geen priemgetal");
            //}

            // 2 nd option (correct!!!!!):


            //bool isPriemgetal = true;
            //long eindRange = number - 1;

            //for (long beginRange = 2; beginRange <= eindRange; beginRange++)
            //{
            //    if (number % beginRange == 0)
            //    {
            //        isPriemgetal = false;
            //    }
               
            //}
            //Console.WriteLine($"{(isPriemgetal ? "De getal is een priemgetal" : "geenprim")}"); // this is the bool in output bool? "abc" : "cba" and ':' means other
            



            #endregion

            #region Opdracht 4.11 – Rij van Fibonacci
            //Ontwerp een consoletoepassing waarmee je de eerste 10 getallen van de rij van Fibonacci toont.

            //1 1 2 3 5 8 13 21..X1 = 1
            //X2 = 2
            //Xn = Xn - 2 + Un - 1  voor n > 2

            //De “rij van Fibonacci” is een wiskundige rij, waarbij elk element de som van de twee voorgaande is.
            //De eerste twee elementen zijn 0 en 1.Het begin van de rij is dus: 0, 1, 1, 2, 3, 5, 8, 13, 21, …

            //Maak een programma dat 15 elementen van deze rij afdrukt.


            //int int1 = 0;
            //int int2 = 1;
            //Console.Write($"{int1} ");
            //Console.Write($"{int2} ");
            //for (int i = 2; i < 15; i++)
            //{
            //    int n = int1 + int2;
            //    Console.Write($"{n} ");

            //    int1 = int2; // int 1 zill keep the value of the 2nd
            //    int2 = n; // int 2 zill keep the value of the 3rd
            //}



            #endregion

        }

    }
}
