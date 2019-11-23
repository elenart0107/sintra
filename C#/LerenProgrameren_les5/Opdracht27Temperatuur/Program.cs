using System;

namespace Opdracht27Temperatuur
{
    class Program
    {
        static void Main(string[] args)
        {
            float temperatuur, gemideldePositief, gemideldeNegatief, aantalPositief, aantalNegatief, somPositief, somNegatief, aantalNull;

            gemideldePositief = 0;
            gemideldeNegatief = 0;
            aantalPositief = 0;
            aantalNegatief = 0;
            somPositief = 0;
            somNegatief = 0;
            aantalNull = 0;






            do
            {
                Console.WriteLine("Geef temperatuur in (99 voor stoppen)");
                temperatuur = float.Parse(Console.ReadLine());

                bool isPositief = temperatuur >= 0;
                if (temperatuur != 99)// to prevent encounting 99 as positive number in result
                {


                    if (isPositief)
                    {
                        aantalPositief++;
                        somPositief += temperatuur;


                    }
                    else if (temperatuur == 0)
                    {
                        aantalNull++;
                    }
                    else
                    {
                        aantalNegatief++;
                        somNegatief += temperatuur;


                    }
                }

            }
            while (temperatuur != 99);

            if (aantalPositief == 0)    // Vermijd om te delen door 0
            {
                gemideldePositief = 0;
            }
            else
            {
                gemideldePositief = somPositief / aantalPositief;
            }

            if (aantalNegatief == 0)    // Vermijd om te delen door 0
            {
                gemideldeNegatief = 0;
            }
            else
            {
                gemideldeNegatief = somNegatief / aantalNegatief;
            }
            Console.WriteLine($"Aantal Positief : {aantalPositief - 1}\nAantal Negatief : {aantalNegatief}\nAantal Null: {aantalNull}\nGemidelde Positief : " +
                $"{Math.Round(gemideldePositief, 2)}\nGemidelde Negatief : {Math.Round(gemideldeNegatief, 2)}");
        }

        
    }
}
