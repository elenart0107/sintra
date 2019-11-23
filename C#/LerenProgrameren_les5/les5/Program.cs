using System;

namespace les5
{
    class Program
    {
        static void Main(string[] args)
        {

            // NESTED LOOPS

            //N 1
            //*
            //*
            //*

            //for (int kolom = 0; kolom <= 3; kolom++)
            //{
            //    Console.Write("* ");
            //}

            // N2
            // * * *

            //for (int rij = 0; rij <= 3; rij++)
            //{
            //    Console.WriteLine("* ");
            //}


            // N3  kzadraat
            // * * *
            // * * *
            // * * *


            // rij
            //for (int rij = 1; rij <= 3; rij++)
            //{
            //    //column
            //    for (int kolom = 1; kolom <= 3; kolom++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();

            /// TODO TRY TO SOLVE THE SAUQRE FROM HW4
            /// 

            // opdracht1
            //int i = 1;
            //    for (int rij = 1; rij <= 3; rij++)
            //    {
            //        //column
            //        for (int kolom = 1; kolom <= 3; kolom++)
            //        {
            //            Console.Write($"{i} ");
            //        }
            //    i += 1;
            //        Console.WriteLine();


            //    }

            // 2nd optie

            //for (int rij = 1; rij <= 3; rij++)
            //{
            //    //column
            //    for (int kolom = 1; kolom <= 3; kolom++)
            //    {
            //        Console.Write($"{rij} ");
            //    }

            //    Console.WriteLine();

            //}



            //2de opdracht
            //for (int rij = 1; rij <= 3; rij++)
            //{
            //    column
            //    int kolom;
            //    for (kolom = 1; kolom <= 3; kolom++)
            //    {
            //        Console.Write($"{kolom} ");

            //    }
            //    kolom += 1;
            //    Console.WriteLine();
            //}


            //    2de optie

            //for (int rij = 1; rij <= 3; rij++)
            //{
            //    //column
            //    for (int kolom = 1; kolom <= 3; kolom++)
            //    {
            //        Console.Write($"{kolom} ");
            //    }

            //    Console.WriteLine();

            //}



            int lengte = 15;
            for (int rij = 1; rij <= lengte; rij++)
            {
                //column
                for (int kolom = 1; kolom <= lengte; kolom++)
                {
                    Console.Write($"{rij,2} ");// to give place for number in this case 2 - digits number
                }

                Console.WriteLine();

            }

        }
    }
}
