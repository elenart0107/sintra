using System;

namespace OefeningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opdracht 5.1 – Stop waarden in array en druk ze af

            //int arrayLength = 10;
            //int[] numbers = new int[arrayLength];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = i + 1;
            //    Console.WriteLine($"Index{i} heeft waarde {numbers[i]}");
            //}

            // backwards
            //int arrayLength = 10;
            //int getal;
            //int[] numbers = new int[arrayLength];
            //for (int i = numbers.Length -1; i >= 0; i--)
            //{
            //    getal = i;
            //    Console.WriteLine($"Index{i} heeft waarde {getal}");
            //}


            //Opdracht 5.2 – Stop eerste 10 even getallen in array

            //int[] numbers = new int[10];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    
            //        numbers[i] = (i + 1) * 2;
            //        Console.WriteLine(numbers[i]);

            //    
            //}

            //Opdracht 5.3 – Druk waarden omgekeerd af

            //int[] numbers = new int[10];
            //int n = 0;
            //    for (int i = numbers.Length; i > 0; i--)
            //    {
            //        numbers[n] = i;
            //        Console.WriteLine(numbers[n]);
            //    }

            //Opdracht 5.4 – Druk negative waarden


            //int arrayLength = 10;
            //int[] numbers = new int[arrayLength];
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    numbers[i] = i + 1;
            //    Console.WriteLine(numbers[i] * -1);
            //}

            //Opdracht 5.5 – Som van entries uit een array

            //int arrayLength = 10, sum = 0;

            //int[] numbers = new int[arrayLength];
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    numbers[i] = i + 1;
            //    sum += numbers[i];

            //}
            //Console.WriteLine($"De som van de entries van de array is {sum}");

            //Opdracht 5.6 – Geef lengte van array 

            //int arrayLength;
            //Console.WriteLine("Hoe groot moet de array zijn?");
            //while (!int.TryParse(Console.ReadLine(), out arrayLength))
            //{
            //    Console.WriteLine("Dat moest een numer zijn! Hoe groot moet de array zijn?");
            //}
            //Console.WriteLine();


            //int[] numbers = new int[arrayLength];
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    numbers[i] = i + 1;
            //    Console.WriteLine(numbers[i]);
            //}

            ////////////////2nd optie with exception. the program stops but will not crash
            ///


            //int arrayLength = 0;
            //try
            //{
            //    Console.WriteLine("Hoe groot moet de array zijn?");
            //    arrayLength = int.Parse(Console.ReadLine());
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Dat moest een numer zijn!");
            //}

            //int[] numbers = new int[arrayLength];
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    numbers[i] = i + 1;
            //    Console.WriteLine(numbers[i]);
            //}

            //Opdracht 5.7 – Geef lengte van array en geef waarde

            //int arrayLength, waarde;
            //Console.WriteLine("Hoe groot moet de array zijn?");
            //while (!int.TryParse(Console.ReadLine(), out arrayLength))
            //{
            //    Console.WriteLine("Dat moest een numer zijn! Hoe groot moet de array zijn?");
            //}
            //Console.WriteLine();


            //int[] numbers = new int[arrayLength];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Geef een getal waarde voor entrie #{i} in");
            //    while (!int.TryParse(Console.ReadLine(), out waarde))
            //    {
            //        Console.WriteLine($"Dat moest een getal zijn! Geef getal #{i} in");
            //    }

            //    numbers[i] = waarde;

            //}
            //Console.WriteLine();

            //for (int l = 0; l < arrayLength; l++)
            //{
            //    Console.WriteLine(numbers[l]);
            //}


            //////////////////////////////Opdracht 5.8 – Geef lengte van array en geef waarde en som

            int arrayLength, waarde, som = 0;
            Console.WriteLine("Hoe groot moet de array zijn?");
            while (!int.TryParse(Console.ReadLine(), out arrayLength))
            {
                Console.WriteLine("Dat moest een numer zijn! Hoe groot moet de array zijn?");
            }
            Console.WriteLine();


            int[] numbers = new int[arrayLength + 1];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Geef een getal waarde voor entrie #{i} in");
                while (!int.TryParse(Console.ReadLine(), out waarde))
                {
                    Console.WriteLine($"Dat moest een getal zijn! Geef getal #{i} in");
                }

                numbers[i] = waarde;
                som += numbers[i];

            }
            numbers[arrayLength] = som;
            Console.WriteLine();

            for (int l = 0; l < arrayLength + 1; l++)
            {
                Console.WriteLine(numbers[l]);
            }

            ///////////////////////////////////Opdracht 5.9 – Grootste getal, kleinste getal, gemiddelde

            //int arrayLength = 10;
            //float waarde, gemiddelde, som = 0;


            //float[] numbers = new float[arrayLength];

            //Console.WriteLine($"Geef een getal waarde voor entrie #{0} in");
            //while (!float.TryParse(Console.ReadLine(), out waarde))
            //{
            //    Console.WriteLine($"Dat moest een getal zijn! Geef getal #{0} in");
            //}
            //numbers[0] = waarde;
            //float min = numbers[0];
            //float max = numbers[0];
            //for (int i = 1; i < arrayLength; i++)
            //{
            //    Console.WriteLine($"Geef een getal waarde voor entrie #{i} in");
            //    while (!float.TryParse(Console.ReadLine(), out waarde)) 
            //    {
            //        Console.WriteLine($"Dat moest een getal zijn! Geef getal #{i} in");
            //    }
            //    numbers[i] = waarde;
            //    som += numbers[i];
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];

            //    }

            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}
            //gemiddelde = (som + numbers[0]) / arrayLength;

            //Console.WriteLine($"De grooteste getal is  {max};\nDe kleinste getal is {min}\nde gemmmidelde is {gemiddelde}");



            // Opdracht 5.10 EvenOneven
            //int arrayLength = 20, somWaarden = 0, somWaardenEven = 0, somWaardenOnven = 0;
            //int waarde = 0;
            //int nullWaarde = -99;
            //bool isEven;
            //int evenIndex = 0;
            //int onevenIndex = 0;

            //int[] numbers = new int[arrayLength];
            //int[] evenNumbers = new int[arrayLength];
            //int[] onevenNumbers = new int[arrayLength];

            //for (int i = 0; i < numbers.Length && waarde != -99; i++)
            //{
            //    Console.WriteLine($"Geef een getal in");
            //    waarde = int.Parse(Console.ReadLine());
            //    numbers[i] = waarde;
            //    somWaarden += 1;
            //}

            //for (int j = 0; j < somWaarden; j++)
            //{
            //    isEven = numbers[j] % 2 == 0;

            //    if (isEven)
            //    {
            //        evenNumbers[evenIndex] = numbers[j];
            //        evenIndex++;
            //        somWaardenEven += 1;
            //    }

            //    if (!isEven)
            //    {
            //        onevenNumbers[onevenIndex] = numbers[j];
            //        onevenIndex++;
            //        somWaardenOnven += 1;
            //    }
            //}


            //for (int n = numbers.Length - 1; n >= somWaarden; n--)
            //{
            //    numbers[n] = nullWaarde;
            //}

            //for (int n = numbers.Length - 1; n >= somWaardenOnven; n--)
            //{
            //    onevenNumbers[n] = nullWaarde;
            //}
            //for (int n = numbers.Length - 1; n >= somWaardenEven; n--)
            //{
            //    evenNumbers[n] = nullWaarde;
            //}


            //Console.Write("your array is: ");

            //for (int a = 0; a < somWaarden; a++)

            //{
            //    if (numbers[a] != -99)
            //    {
            //        Console.Write(numbers[a] + " - ");
            //    }
            //}

            //Console.WriteLine();

            //Console.Write("Array van even getalen : ");

            //for (int b = 0; b < somWaardenEven; b++)
            //{
            //    Console.Write(evenNumbers[b] + " - ");
            //}

            //Console.WriteLine();
            //Console.Write("Array van oneven getalen : ");

            //for (int c = 0; c < somWaardenOnven; c++)


            //{
            //    if (onevenNumbers[c] != -99)
            //    {
            //        Console.Write(onevenNumbers[c] + " - ");
            //    }
            //}

            //Console.WriteLine();



        }
    }
}

















