using System;

namespace Investments
{
    class Program
    {
        static void Main(string[] args)
        {
            //int jaar = 1;
            //decimal investment = 1000;
            //decimal bankbedrag = 0;
            //double interest = 0.05;
            //while (jaar <= 10)
            //{
            //    bankbedrag = Math.Round((investment * (decimal)Math.Pow((1 + interest), jaar)), 2); //to cast double into decimal
            //    decimal totalInterest = bankbedrag - investment;


            //    Console.WriteLine($"Jaar {jaar}. Interest: {totalInterest}. Bedrag op bank: {bankbedrag}.");
            //    jaar += 1;
            //}


            #region with for loop
            int duration = 10;
            decimal investment = 1000;
            decimal bankbedrag = 0;
            double interest = 0.05;

            for (int jaar = 1; jaar <= duration; jaar++)
            {
                bankbedrag = Math.Round((investment * (decimal)Math.Pow((1 + interest), jaar)), 2); //to cast double into decimal
                decimal totalInterest = bankbedrag - investment;


                Console.WriteLine($"Jaar {jaar}. Interest: {totalInterest}. Bedrag op bank: {bankbedrag}.");
            }

            #endregion

        }
    }
}
