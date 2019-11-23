using System;

namespace hwString
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Twee woorden(*)
            //Vraag de gebruiker om 2 woorden in te geven. Wij gaan na of het karakter op de 2e plaats, hetzelfde karakter is.

            //Als output wordt het 2e karakter van ieder woord weergegeven alsook of ze dezelfde zijn of niet. 

            //Bedenk ook het scenario als je een woord van 1 letter meegeeft.

            //string woord1, woord2;



            //Console.WriteLine("Geef een woord in");
            //woord1 = Console.ReadLine();

            //Console.WriteLine("Geef een woord in");
            //woord2 = Console.ReadLine();


            //bool isDezelfde = woord1.Equals(woord2);

            //Console.WriteLine($"{(isDezelfde ? "De 2 karakters zijn dezelfde" : "De 2 karakters zijn niet dezelfde")}");



            // 2.	Aantal hetzelfde woord, aantal verschillend woord (*)

            //string woord1 = String.Empty, woord2 = String.Empty;
            //int verschil = 0, gelijk = 0;



            //while (woord1 != "?" && woord2 != "?")
            //{
            //    Console.WriteLine("Geef eerste woord in");
            //    woord1 = Console.ReadLine();

            //    Console.WriteLine("Geef tweede woord in");
            //    woord2 = Console.ReadLine();

            //    bool isDezelfde = woord1.Equals(woord2);


            //    Console.WriteLine("_ _ _ _ _ _ _ _ _ _");
            //    if (!isDezelfde)
            //    {
            //        verschil += 1;
            //    }
            //    if (isDezelfde)
            //    {
            //        gelijk += 1;
            //    }
            //}

            //Console.WriteLine($"Aantal gelijke worden {gelijk - 1};\nAantal verschilende worden {verschil}.");



            // 3. 	Aantal keer dat een teken voorkomt in een zin (*)

            //string zin;
            //char character;
            //int aantal = 0;


            //Console.WriteLine("Geef een zin in");
            //zin = Console.ReadLine();
            //Console.WriteLine("Welke karakter zoek je?");
            //character = char.Parse(Console.ReadLine());
            //bool containsChar = zin.Contains(character);

            //if (containsChar)
            //{
            //    foreach (char c in zin) // solution for string as an array
            //    {
            //        if (c == character)
            //        {
            //            aantal += 1;
            //        }

            //    }
            //}
            ///////////////////// 2de optie ///////////////////////
            //for (int i = 0; i < zin.Length; i++)
            //{
            //    if (character == zin[i])
            //    {
            //        aantal += 1;
            //    }
            //}

            //Console.WriteLine($"Aantal keer karakter: {aantal}");



            // 4.Keuzes op een zin(*)


            //string zin;
            //char keuze;



            //Console.WriteLine("Geef een zin in");
            //zin = Console.ReadLine();


            //Console.WriteLine("maak je keuze:\n1.Bepaal de lengte van de zin\n " +
            //    "2.Verander iedere e door een o \n" +
            //    "3.Plaats alle letters in hoofdletters \n " +
            //    "4.Plaats alle letters in kleine letters \n" +
            //    "5.Vervang alleen de eerst keer dat de letter o voorkomt door Jantje\nX  Stop");
            //keuze = char.Parse(Console.ReadLine());
            //switch (keuze)
            //{
            //    case '1':
            //        Console.WriteLine(zin.Length);
            //        break;

            //    case '2':
            //        Console.WriteLine(zin.Replace('e', 'o'));
            //        break;
            //    case '3':
            //        Console.WriteLine(zin.ToUpper());
            //        break;
            //    case '4':
            //        Console.WriteLine(zin.ToLower());
            //        break;
            //    case '5':
            //for (int i = 0; i < zin.Length; i++)
            //{
            //    if ('o' == zin[i])
            //    {
            //        Console.WriteLine(zin.Replace("o", "Jantje"));
            //        break;
            //    }
            //}
            //////////////// 2de oplosing ///////////////
            //        bool firstTimeO = false;
            //        char karacter = 'o';
            //        for (int i = 0; i < zin.Length; i++)
            //        {
            //            if(!firstTimeO && karacter == zin[i])
            //            {
            //                firstTimeO = true;
            //                zin = zin.Remove(i, 1);
            //                zin = zin.Insert(i, "Jantje");
            //            }
            //        }
            //////////////////////////////////////////////////

            /////////////////// 3de optie ///////////////////
            //int firstTimeO = zin.IndexOf('o');
            //zin = zin.Remove(firstTimeO, 1);
            //zin = zin.Insert(firstTimeO, "Jantje");
            /////////////////////////////////////////////////
            //            break;
            //    case 'X':
            //        break;
            //}

            // 5.Verwijder 1ste en laatste karakter(*)


            //string zin, trimZin;


            //Console.WriteLine("Geef een zin in");
            //zin = Console.ReadLine();

            //trimZin = zin.Substring(1, zin.Length - 2);
            //Console.WriteLine(trimZin);


            //  6.	Aantal zinnen met een punt (*)

            //string zin;
            //bool isPunkt = false;
            //int linesMetPunkt = 0;
            //char punkt = '.';
            //do
            //{
            //    Console.WriteLine("Geef een zin in. Sluit met ?");
            //    zin = Console.ReadLine();
            //    for (int i = 0; i < zin.Length; i++)
            //    {
            //        if (!isPunkt && punkt == zin[i])
            //        {
            //            linesMetPunkt += 1;
            //        }
            //    }


            //}
            //while (zin != "?");

            //Console.WriteLine($"Er zijn {linesMetPunkt} lijnen met de punt.");


            // 7.Aantal lijnen met een punt of blankolijn(*)

            //string zin;
            //bool isPunkt = false;
            //int linenMetPunkt = 0, blankolijnen = 0;
            //char punkt = '.';
            //Console.WriteLine("Geef een zin in. Sluit met ?");

            //do
            //{
            //    Console.WriteLine();
            //    zin = Console.ReadLine();
            //    if (zin != string.Empty)
            //    {


            //        for (int i = 0; i < zin.Length; i++)
            //        {
            //            if (!isPunkt && punkt == zin[i])
            //            {
            //                linenMetPunkt += 1;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        blankolijnen += 1;
            //        continue;
            //    }

            //}
            //while (zin != "?");

            //Console.WriteLine($"Er zijn {linenMetPunkt} lijnen met de punt.\nEn er zijn {blankolijnen} blankolijnen.");


            //8.	Geboortedatum (*)

            //string geboortedatum;
            //int dag = 0, maand = 0, jaar = 0; 
            //Console.WriteLine("Geef een geboortedatum in DD/MM/YYYY");
            //geboortedatum = Console.ReadLine();

            //if (geboortedatum.Length == 10) ;
            //Console.WriteLine("fout format");
            //return; // or thraw;


            //try
            //{
            //    dag = int.Parse(geboortedatum.Substring(0, 2)); //parse works with string into int 
            //    maand = int.Parse(geboortedatum.Substring(3, 2));
            //    jaar = int.Parse(geboortedatum.Substring(6, 4));
            //}
            //catch
            //{
            //    Console.WriteLine("fout bij parsen");
            //}
            //Console.WriteLine($"Dag {dag}\nMaand {maand}\nJaar {jaar}");

            // 9.BijPlakken(*)

            //string woord, woord1;
            //string lastKarakter;

            //Console.WriteLine("Geef een woord in");
            //woord = Console.ReadLine();

            //lastKarakter = woord[woord.Length - 1].ToString();

            //woord1 = woord.Insert(woord.Length - 1, lastKarakter);

            //Console.WriteLine( $"input is {woord}\nOutput is {lastKarakter + woord1}");


            //   10.	StringOmgekeerd (*)

            //string zin;

            //Console.WriteLine("Geef een zin in");
            //zin = Console.ReadLine();
            //int i = zin.Length;
            //for ( i = zin.Length-1; i >= 0; i--)
            //{
            //    Console.Write(zin[i]);
            //}

            // 11.	Palindroom (**)

            //string text, textPolindrom = String.Empty;
            //int n = 0;
            //bool isPolindrom = true;
            //do
            //{
            //    Console.WriteLine("Geef een text in");
            //    text = Console.ReadLine();
            //    int i = text.Length;
            //    for (i = text.Length - 1; i >= 0; i--)
            //    {
            //        textPolindrom = textPolindrom.Insert(n++, text[i].ToString());
            //    }
            //    isPolindrom = text == textPolindrom;

            //    Console.WriteLine($"{(isPolindrom ? "deze taxt is palindrom" : "deze text is geen palindrom")}");
            //    Console.WriteLine("______________________________________________________________________");
            //}
            //while (text != "X");

            // 12.	Woord raden (***) TODO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //string woord, newWord = String.Empty;

            //do
            //{
            //    Console.WriteLine("Geef een woord in");
            //    woord = Console.ReadLine();
            //    do
            //    {
            //        Console.WriteLine("Geef een teken of raad een word:");
            //        for (int i = 0; i < woord.Length; i++)
            //        {
            //            Console.Write("_ ");
            //        }
            //    }
            //    while (!newWord.Contains("_ "));

            //}
            //while (woord != "X");
        }
    }
}
