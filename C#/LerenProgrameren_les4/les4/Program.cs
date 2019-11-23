using System;

namespace les4
{
    class Program
    {
        static void Main(string[] args)
           
        {
            #region while loop
            //int sum = 0;
            //int countCustom = 5;
            //int counter = 1; //every step

                     

            //while (counter <= countCustom)
            //{
            //    Console.WriteLine("Geef een getal in:"); // writing each time new line
            //    int getal1 = int.Parse(Console.ReadLine());
            //    sum += getal1; //adding every time new value
            //    counter++;//change the value of counter on the step we mantioned above DO NOT FORGET IT TO PUT IN!!! ALWAYS
                
            //}
            //Console.WriteLine(sum);
            #endregion

            #region do while



            #endregion

            #region for

            int sum = 0;
            int countCustom = 5;
            //int counter = 1; //every step but 



            for (int counter = 1; counter <= countCustom; counter++) ; // counter++ change the value of counter on the step we mantioned above
            //int counter = 1 only inside to initialize not befor the for loop expresion
            {
                Console.WriteLine("Geef een getal in:"); // writing each time new line
                int getal1 = int.Parse(Console.ReadLine());
                sum += getal1; //adding every time new value
                

            }
            Console.WriteLine(sum);

            #endregion

            #region foreach



            #endregion
        }
    }
}
