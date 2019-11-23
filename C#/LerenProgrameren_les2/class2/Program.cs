using System;

namespace class2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region unairy

            //int rijNummer = 0;
            //rijNummer++;
            //rijNummer++;
            //rijNummer--;

            //Console.WriteLine(++rijNummer);

            //dif ++i and i++
            #endregion


            #region Booling

            //AND
            // 0 of 1
            //bool resultaat;
            //bool nameIsThijs = false;
            //bool hebHond = true;
            //Console.WriteLine($"Is mijn naam Thijs? { nameIsThijs}");
            //Console.WriteLine($"heb ik een hond? {hebHond}");

            //resultaat = nameIsThijs && hebHond;
            //Console.WriteLine($"Resultaat: {resultaat}");

            //or ||

            //bool nameIsThijs = false;
            //bool hebHond = true;
            //Console.WriteLine($"Is mijn naam Thijs? { nameIsThijs}");
            //Console.WriteLine($"heb ik een hond? {hebHond}");

            //bool resultaat = nameIsThijs || hebHond;
            //Console.WriteLine($"Resultaat: {resultaat}");

            //xor ^
            // 1 1
            //var desert1 = true;
            //var desert2 = true;
            //Console.WriteLine($"ik neem desert1 { desert1}");
            //Console.WriteLine($"ik neem desert2 {desert2}");

            //var resultaat = desert1 ^ desert2;
            //Console.WriteLine($"Resultaat: {resultaat}");
            //#endregion

            //not !

            //bool geenOnderhoudNodig = false;

            //Console.WriteLine($";ijn auto heeft geen onderhoud nodig {geenOnderhoudNodig}");

            //var resultaat = !geenOnderhoudNodig;
            //Console.WriteLine($"heeft mijn auto onderhoud nodig? {resultaat}");
            #endregion

            #region Comparison
            bool isComparable;
            Console.WriteLine("Geef je leeftijd: ");
            string a;
            a = Console.ReadLine();
            int leeftijd = int.Parse(a);
            if (leeftijd >= 18)
            {
                Console.WriteLine("je kan vodka drinken");
            }
            else
            {
                Console.WriteLine("je bent te klein om een sterk drankje krijgen");
            }
            break;
            }
            


            #endregion 
        }
    }
}
