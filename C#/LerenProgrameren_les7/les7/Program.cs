using System;

namespace les7
{
    class Program
    {
        static void Main(string[] args)
        {
            // methods
            //ToString()


            //int leeftijd = 235;
            //string leeftijdAlsString = leeftijd.ToString();

            //Console.WriteLine(leeftijdAlsString);

            // IndexOf
            // the question is does it work for arrays???

            //string woord = "Radiator";
            //var indexVanD = woord.IndexOf('d');

            //Console.WriteLine(indexVanD);

            //var indexVanZ = woord.IndexOf("z");

            //Console.WriteLine(indexVanZ); // no z in the woord, so get -1

            //var indexVanA = woord.IndexOf("a");

            //Console.WriteLine(indexVanA);// u can use the string or char data type here


            //Trim()

            //string woord = "   Radiator   .";
            //var indexTrim = woord.Trim();

            //Console.WriteLine(indexTrim);

            //woord = "   Radiator   .";
            //var indexTrimEnd = woord.Trim();

            //Console.WriteLine(indexTrimEnd);

            //Replace

            //string zin = "I love u baby.";
            //var zinReplace = zin.Replace('a', 'A');

            //Console.WriteLine(zinReplace);

            //zin = "I love u baby.";
            //var zinReplaceString = zin.Replace('b', 'B');

            //Console.WriteLine(zinReplaceString);


            //ToUpper
            //ToLower

            //string zin = "i love u baby.";
            //var zinUpper = zin.ToUpper();
            //Console.WriteLine(zinUpper);

            //string zin = "i love u baby.";
            //var zinSomeUpper = zin.ToUpper();
            //Console.WriteLine(zinSomeUpper); //how tyo make

            //zin = "i love u baby.";
            //var zinLower = zin.ToLower();
            //Console.WriteLine(zinLower);

            //Equals to compare and return bool

            //string a, d, c;
            //a = "appel";
            //d = "Appel";
            //c = "appel";

            //bool compare = a.Equals(d);
            //Console.WriteLine(compare);

            //bool compare2 = a == c;
            //Console.WriteLine(compare2);

            //bool compare3 = a.ToLower() == d.ToLower();
            //Console.WriteLine(compare3);

            //bool compare4 = c.Equals(d, StringComparison.OrdinalIgnoreCase);//during the string comparisone with the property to ignore the case
            //Console.WriteLine(compare4);

            //contains() - search for something what is inside the string

            //string woord = "appelflap";
            //bool containsA = woord.Contains("a");
            //Console.WriteLine(containsA);

            //bool containsCharA = woord.Contains('a');
            //Console.WriteLine(containsCharA);

            //bool containsUpperA = woord.Contains("A");
            //Console.WriteLine(containsUpperA);

            //Substring()
            string woord = "CURSUSMATERIALEN";
            var materialen = woord.Substring(6);// from index , length

            Console.WriteLine(materialen);

            var cursus = woord.Substring(0, 6);// from index , length

            Console.WriteLine(cursus);

            var susma = woord.Substring(3, 5);// from index , length

            Console.WriteLine(susma);

            var cursusMateriale = woord.Substring(0, woord.Length);// the property - without the () - return the length of string in general

            Console.WriteLine(cursusMateriale);

            var cursusMaterial = woord.Substring(0, woord.Length - 1);// the property - without the () - return the length of string in general

            Console.WriteLine(cursusMaterial);




        }
    }
}
