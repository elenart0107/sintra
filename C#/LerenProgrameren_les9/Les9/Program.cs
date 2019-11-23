using System;

namespace Les9
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////// bubble loop
            //int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };
            //int temp;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[j] < arr[i])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}

            ///////////////////// step 1 change 6 into 5 harcoded
            //int[] arr = { 7, 1, 6, 5, 2, 8, 3 };
            //int temp;
            //temp = arr[3-1];
            //arr[3-1] = arr[3];
            //arr[3] = temp;
            //Console.WriteLine($"{arr[2]} || {arr[3]} ");



            ///////////////////// step 2 ask the user to choose the index
            //int[] arr = { 7, 1, 6, 5, 2, 8, 3 };
            //int temp;

            //Console.WriteLine("Geef een getal in:");
            //int index = int.Parse(Console.ReadLine());

            //temp = arr[index - 1];
            //arr[index - 1] = arr[index];
            //arr[index] = temp;
            //Console.WriteLine($"{arr[index - 1]} || {arr[index]} ");




            ///// adding bool to check if we can switch otherwise it gives an error
            /// and new goal to make the changes from given index till [0]

            //int[] arr = { 7, 1, 6, 5, 2, 8, 3 };
            //int index, linkseIndex;

           

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}

            //Console.WriteLine();


            //Console.WriteLine("Geef een getal voor index in:");
            //index = int.Parse(Console.ReadLine());
            //linkseIndex = index - 1;
            //bool kanSwappen = index != 0;

            //Console.WriteLine();


            //for (int i = index; i > 0; i--)
            //{
            //    if (kanSwappen)
            //    {
            //        int temp1 = arr[i];
            //        int temp2 = arr[i -1];
            //        arr[i] = temp2;
            //        arr[i -1] = temp1;
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}
            //////// met while
            /////

            //while (kanSwappen) // condition
            //{
            //    int temp1 = arr[linkseIndex];
            //    int temp2 = arr[index];
            //    arr[linkseIndex] = temp2;
            //    arr[index] = temp1;

            //    linkseIndex--; // countdown
            //    index--; // countdown

            //    kanSwappen = index != 0; //condition for every loop 

            //}

            ///////////////// the indexed number moves in the direction of [0], but stops once it reaches the smaller value
            ///
            //int[] arr = { 7, 1, 6, 5, 2, 8, 3 };
            //int index, linkseIndex;



            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}

            //Console.WriteLine();


            //Console.WriteLine("Geef een getal voor index in:");
            //index = int.Parse(Console.ReadLine());
            //linkseIndex = index - 1;
            //bool kanSwappen = index != 0;
            //bool magSwappen = false;

            //Console.WriteLine();

            //if (kanSwappen)
            //{
            //    magSwappen = arr[linkseIndex] > arr[index];
            //}
            
            //while (kanSwappen && magSwappen) // condition
            //{
            //    int temp1 = arr[linkseIndex];
            //    int temp2 = arr[index];
            //    arr[linkseIndex] = temp2;
            //    arr[index] = temp1;

            //    linkseIndex--; // countdown
            //    index--; // countdown

            //    kanSwappen = index != 0; //condition for every loop 
            //    if (kanSwappen)
            //    {
            //        magSwappen = arr[linkseIndex] > arr[index];
            //    }

            //}

            //Console.WriteLine("NA");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}
            //////////////////the whole array vise versa
            ///
            int[] arr = { 7, 1, 6, 5, 2, 8, 3 };
            int index, linkseIndex;



            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();


            Console.WriteLine("Geef een getal voor index in:");
            index = int.Parse(Console.ReadLine());
            linkseIndex = index - 1;
            bool kanSwappen = index != 0;
            bool magSwappen = false;

            Console.WriteLine();

            if (kanSwappen)
            {
                magSwappen = arr[linkseIndex] > arr[index];
            }

            while (kanSwappen && magSwappen) // condition
            {
                int temp1 = arr[linkseIndex];
                int temp2 = arr[index];
                arr[linkseIndex] = temp2;
                arr[index] = temp1;

                linkseIndex--; // countdown
                index--; // countdown

                kanSwappen = index != 0; //condition for every loop 
                if (kanSwappen)
                {
                    magSwappen = arr[linkseIndex] > arr[index];
                }

            }

            Console.WriteLine("NA");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }



        }
    }
}
