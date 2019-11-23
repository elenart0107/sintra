using System;

namespace FoutAfhangeling
{
    class Program
    {
        static void Main(string[] args)
        {
            string woord = "CURSUSMATERIALEN";
            

            try
            {
                
                var letterN = woord[woord.Length];

            }
            catch(IndexOutOfRangeException) // it's the name of the error which appears in compiler when the program crashes
            {
                
                var letterN = woord[woord.Length -1]; // gere u can do whatever you whant, e.g. fixing the input or just mabtioning the error 
                string exception = "there's an issue and programe is crashed.\nBut we add '-1' to length and that should work for now";
                
                Console.WriteLine(exception);
                Console.WriteLine(letterN);
            }

            // the string belongs to the reference NOT VALUE type, as well as an object, array is an object, so all the string methods work for objscts(arrays) as well
            
			
			
			//////////////or using the tryParse method
			int arrayLength;
            Console.WriteLine("Hoe groot moet de array zijn?");
            while (!int.TryParse(Console.ReadLine(), out arrayLength))
            {
                Console.WriteLine("Dat moest een numer zijn! Hoe groot moet de array zijn?"); ;
            }
            Console.WriteLine();


            int[] numbers = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                numbers[i] = i + 1;
                Console.WriteLine(numbers[i]);
            }
        }
		
    }
}
