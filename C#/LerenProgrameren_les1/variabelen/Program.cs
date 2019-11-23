using System;

namespace variabelen
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "    U're Beautiful   ";
            string newDay = "today's nice day";
            //hello = hello.Replace(hello, newDay);
            //hello = hello.ToLower();
            //hello = hello.Substring(5, 4);
            //hello = hello.Trim();
            //hello = hello.ToLowerInvariant();
            //hello = hello.ToUpperInvariant();
            char[] separator = {'.'};
            int count = 3;
            hello = hello.Split(separator[], count, StringSplitOptions.None);
            Console.WriteLine(hello);


        }
    }
}
