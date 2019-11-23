using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 Berekenen van de absolute waarde van een getal 

            //Console.WriteLine("Give any number = positiv or negative: ");
            //int input = int.Parse(Console.ReadLine());
            //int result = Math.Abs(input);
            //Console.WriteLine("the result is {0}", result);

            #endregion

            #region 1 2de optie    Berekenen van de absolute waarde van een getal geen Math.Abs

            //Console.WriteLine("Give any number = positiv or negative: ");
            //string input = Console.ReadLine();

            //int getal = short.Parse(input);

            //if (getal < 0)
            //{
            //    getal = getal * -1;
            //}
            //Console.WriteLine("the result is {0}", getal);
            //#endregion
            #endregion

            #region 1 3de optie    Berekenen van de absolute waarde van een getal met de BOOL

            //Console.WriteLine("Give any number = positiv or negative: ");
            //string input = Console.ReadLine();

            //short getal = short.Parse(input);

            //bool isNegatief = getal < 0;

            //short absoluteGetal = isNegatief ? (short)(getal * -1) : getal;

            //Console.WriteLine("the result is {0}", absoluteGetal);
            #endregion

            #region 2 Bepalen of 2 ingevoerde getallen gelijk zijn
            //Console.WriteLine("Give first number: ");
            //int input1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Give second number: ");
            //int input2 = int.Parse(Console.ReadLine());
            //if (input1 != input2)
            //{
            //    Console.WriteLine("{0} and {1} are different.");
            //}
            //else
            //{
            //    Console.WriteLine("{0} and {1} are same!");
            //}

            #endregion

            #region TODO 2 2de optie Bepalen of 2 ingevoerde getallen gelijk zijn
            //Console.WriteLine("Give first number: ");
            //short input1 = short.Parse(Console.ReadLine());
            //Console.WriteLine("Give second number: ");
            //short input2 = short.Parse(Console.ReadLine());
            //bool zijnGelijk = input1 != input2;

            //short eersteGetal = zijnGelijk ? 


            //    Console.WriteLine("{0} and {1} are different.");
            //    Console.WriteLine("{0} and {1} are same!");


            #endregion

            #region 3 Converteer het aantal graden Celcius naar graden Farenheit 

            //Console.WriteLine("Give the temperature in Celcium: ");
            //float celcius = float.Parse(Console.ReadLine());
            //float fahrenheit = celcius * 9 / 5 + 32;
            //Console.WriteLine("{0} by Celcius is {1} by Fahrenheit", celcius, fahrenheit);

            #endregion

            #region 4 Converteer het aantal graden Farenheit naar graden Celcius 

            //Console.WriteLine("Give the temperature in fahrenheit: ");
            //double fahrenheit = double.Parse(Console.ReadLine());
            //double celcium = (fahrenheit - 32) * 5 / 9;
            //var celciumTwoAfterDecimal = String.Format("{0:0.00}", celcium);
            //int celciumAbs = (int)Math.Round(celcium); ////to cast one data type into the other
            //Console.WriteLine("{0} by Fahrenheit is {1} by Celcium.\nIt's {2} C", fahrenheit, celciumTwoAfterDecimal, celciumAbs);

            #endregion

            #region 4 2de optie Converteer het aantal graden Farenheit naar graden Celcius 

            //Console.WriteLine("Give the temperature in fahrenheit: ");
            //double fahrenheit = double.Parse(Console.ReadLine());
            //double celcium = (fahrenheit - 32) * 5 / 9;
            //int celciumAlsGeheelGetel = (int)celcium;
            //Console.WriteLine("{0} by Fahrenheit is {1} by Celcium.\nIt's {2} C", fahrenheit, celcium, celciumAlsGeheelGetel);

            #endregion

            #region 5 Bereken het aantal uren, minuten en seconden 

            //Console.WriteLine("Geef ein aantal secunden in:");
            //int input = int.Parse(Console.ReadLine());
            //int secunden = input % 60;
            //int minuten = (input % 3600) / 60;
            //int uren = input / 3600;
            //Console.WriteLine("U:{0} M:{1} S:{2}", uren, minuten, secunden);

            #endregion

            #region 5 2de optie Bereken het aantal uren, minuten en seconden CHANGE THE VALUE OF VARIABLE GRADUALLY

            //Console.WriteLine("Geef ein aantal secunden in:");
            //int aantalSec = int.Parse(Console.ReadLine());
            //int aantalSecInUur = 3600;
            //int aantalSecInMin = 60;
            //int aantalUren = aantalSec / aantalSecInUur;
            //aantalSec = aantalSec % aantalSecInUur;
            //int aantalMinuten = aantalSec / aantalSecInMin;
            //aantalSec = aantalSec % aantalSecInMin;
            //Console.WriteLine("U:{0} M:{1} S:{2}", aantalUren, aantalMinuten, aantalSec);

            #endregion

            #region 6 Bepaal duizendtallen, hondertallen tientallen, eenheden van een getal 

            //Console.WriteLine("Give the cyfer >=1000 and <=9999:\n");
            //int input = int.Parse(Console.ReadLine());
            //int a = input / 1000;
            //int b = input % 1000 / 100;
            //int c = input % 100 / 10;
            //int d = input % 10;
            //Console.WriteLine("{0} is thousands\n{1} is hundrens\n{2} is dozens\n{3} is units", a, b, c, d);

            #endregion

            #region 6 2de oplosing Bepaal duizendtallen, hondertallen tientallen, eenheden van een getal USIING THE CHANGING OF THE VCALUES OF THE VARIABLES

            //Console.WriteLine("Give the cyfer >=1000 and <=9999:\n");
            //int getal = int.Parse(Console.ReadLine());
            //int duizentaal, hondertaal, tientaal, eenheid;
            //double tempGetal = getal / 1000; // to show how it change the variables
            //duizentaal = (int)tempGetal;
            //getal = getal % 1000;
            //hondertaal = getal / 100;
            //getal = getal % 100;
            //tientaal = getal / 10;
            //getal = getal % 10;
            //eenheid = getal;

            //Console.WriteLine("{0} is thousands\n{1} is hundrens\n{2} is dozens\n{3} is units", duizentaal, hondertaal, tientaal, eenheid);

            #endregion

            #region 7 Bereken hoeveel dagen tot nieuwjaar 

            //Console.WriteLine("Geef ein datum in(ddmmjjjj):\n");
            //int input = int.Parse(Console.ReadLine());
            //int dagenInMaand = 30;
            //int jaar = dagenInMaand * 12;
            //int nechsteJaar = input % 10000 + 1;
            //int dagenOpManden = ((input % 1000000 - input % 10000) / 10000 - 1) * dagenInMaand;
            //int dagenNog = jaar - dagenOpManden - input/1000000;
            //Console.WriteLine("Het duurt nog {0} dagen voordat het Nieuw {1} Jaar is", dagenNog, nechsteJaar);
            #endregion

            #region 8 Converteer van inch naar  cm
            //const float cmPerInch = 2.54f;
            //Console.WriteLine("Geef lenghte in inch in: ");
            //float inch = float.Parse(Console.ReadLine());
            //float cm = inch * cmPerInch;
            //Console.WriteLine("Het is {0} cm in {1} inch.", cm, inch);
            #endregion

            #region 9 Converteer van cm naar inch 

            //const float cmPerInch = 2.54f;
            //Console.WriteLine("Geef lenghte in cm in: ");
            //float cm = float.Parse(Console.ReadLine());
            //float inch = cm / cmPerInch;
            //Console.WriteLine("{0} cm is {1} inch.", cm, inch);
            #endregion

            #region 10 Omwisselen van 2 getallen 

            //Console.WriteLine("Geef een getal in: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Geef tzeede getal in: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Voor het omwisselen getal1 = {0} - getal2 = {1}", a, b);
            //(a, b) = (b, a);
            //Console.WriteLine("Na het omwisselen getal1 = {0} - getal2 = {1}", a, b);
            #endregion

            #region 11 bereken prijs inclusief BTW 

            //// decimal we use with money!!!

            //Console.WriteLine("Geef prijs exclusif BTW: ");
            //decimal prijs = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Geef BTW percentage: ");
            //decimal percentageBtw = decimal.Parse(Console.ReadLine());
            //decimal prijsInclBtw = prijs * (1 + percentageBtw / 100); // prijs vynesli za dushki
            //Console.WriteLine("Excl BTW : {0}, Incl. BTW : {1}", prijs, prijsInclBtw);

            //////////////////////////////////
            //Console.WriteLine("incl -> excl: ");
            //Console.WriteLine("Geef prijs incl BTW: ");
            //decimal prijs = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Geef BTW percentage: ");
            //decimal percentageBtw = decimal.Parse(Console.ReadLine());
            //decimal prijsExclBtw = prijs / (1 + percentageBtw / 100); // prijs vynesli za dushki
            //Console.WriteLine("Incl BTW : {0}, Excl. BTW : {1}", prijs, prijsExclBtw);

            #endregion

            #region 12 Bereken prijs exlusief, inclusief BTW met korting 
            //Console.WriteLine("Geef prijs exclusif BTW: ");
            //float prijs = float.Parse(Console.ReadLine());
            //Console.WriteLine("Geef een kortingpercentage: ");
            //float kortingpercentage = float.Parse(Console.ReadLine());
            //Console.WriteLine("Geef BTW percentage: ");
            //float percentageBtw = float.Parse(Console.ReadLine());
            //float korting = prijs * kortingpercentage / 100;
            //float prijsMetKorting = prijs - korting;
            //float bedragBtw = prijsMetKorting * percentageBtw / 100;
            //float prijsInclBtw = prijsMetKorting + bedragBtw;
            //Console.WriteLine("Bedrag Exclusif BTW : {0}\nBedrag Korting : {1}\n" +
            //    "Bedrag met Korting : {2}\nBedrag BTW : {3}\nBedrag Inclusif BTW : {4}",
            //    prijs, korting, prijsMetKorting, bedragBtw, prijsInclBtw);
            #endregion

            #region 13 BTW nummer validatie 

            //Console.WriteLine("Geef een BTW nummer: ");
            //int btwNummer = int.Parse(Console.ReadLine());
            //cont int deler = 97;
            //int controleGetal = btwNummer % 100;
            //int restNaDelingDoor97 = ((btwNummer - controleGetal) / 100) % deler;
            //int controlgetalNaTalen = deler - restNaDelingDoor97;
            //if (controleGetal == controlgetalNaTalen)
            //{
            //    Console.WriteLine("Het BTW nummer {0} is geldig.", btwNummer);
            //}
            //else
            //{
            //    Console.WriteLine("Het BTW nummer {0} is ongeldig.", btwNummer);
            //}
            #endregion

            #region BTW nummer validatie  oef 13 2nd option 
            //Convert.ToInt32 method conterting string to an int ; .Substring = list of the symbols in the string
            //Console.WriteLine("Geef een BTW nummer: ");
            //string btwNummer = Console.ReadLine();
            //int controleGetal = Convert.ToInt32(btwNummer.Substring (8, 2));
            //const int deler = 97;
            //int effectiveBtwNummer = Convert.ToInt32(btwNummer.Substring(0, 8));
            //int restNaDelingDoor97 = effectiveBtwNummer % deler;
            //int controleGetalNaTalen = deler - restNaDelingDoor97;
            //if (controleGetal == controleGetalNaTalen)
            //{
            //    Console.WriteLine("Het BTW nummer {0} is geldig.", btwNummer);
            //}
            //else
            //{
            //    Console.WriteLine("Het BTW nummer {0} is ongeldig.", btwNummer);
            //}
            #endregion


            #region 14 Scores

            //decimal a = 8;
            //decimal b = 6;
            //decimal c = 9;
            //decimal d = 4;
            //decimal som = a + b + c + d;
            //const int bestResult = 10;
            //decimal quantatyOfResulst = 4;
            //decimal gem = som / quantatyOfResulst;
            //decimal Percentage = (som / (bestResult * quantatyOfResulst)) * 100;
            //var resultPercentage = string.Format("{0:0.00}", Percentage);
            //Console.WriteLine("Het gemidelde is {0}.\n Hat som is {1}.\nHet is {2}%", gem, som, resultPercentage);


            #endregion

            #region 15 snoepautomat // werkt niet for value 0.88

            Console.WriteLine("kies de snoepkost(E.CC) >= 0.30 and <= 1.20:");
            decimal snoepKost = decimal.Parse(Console.ReadLine());

            bool canBuySnoep;

            decimal minKost = 0.3m;
            decimal maxKost = 1.2m;

            canBuySnoep = snoepKost >= minKost && snoepKost <= maxKost;

            const decimal coin = 2m;
            const decimal cents50 = 0.5m;
            const decimal cents20 = 0.2m;
            const decimal cents10 = 0.1m;
            const decimal cents5 = 0.05m;
            const decimal cents2 = 0.02m;
            decimal change = coin - snoepKost;
            Console.WriteLine("Te betalen : {0}\nTerug te geven : {1}", snoepKost, change);

            decimal giveEur = (int)(change);
            change = change - giveEur;
            int give50c = (int)(change / cents50);
            change = change % cents50;
            int give20c = (int)(change / cents20);
            change = change % cents20;
            int give10c = (int)(change / cents10);
            change = change % cents10;
            int give5c = (int)(change / cents5);
            change = change % cents5;
            int give2c = (int)(change / cents2);
            int give1c = (int)(change % cents2);




            if (canBuySnoep)
            {
                Console.WriteLine("Stuken van 1 Euro : {0}\nStuken van 50 Cents : {1}\n" +
                    "Stuken van 20 Cents : {2}\nStuken van 10 Cents : {3}\nStuken van 5 Cents : {4}\nStuken van 2 Cents : {5}\n" +
                    "Stuken van 1 Cent : {5}", giveEur, give50c, give20c, give10c, give5c, give2c, give1c);
            }
            else
            {
                Console.WriteLine("Sorry, you can not buy the snoep");
            }
            #endregion

            #region 16 Even en oneven 

            //Console.WriteLine("Geef een getal:");
            //int nieuwGetal = int.Parse(Console.ReadLine());
            //int evenGetal = 44;
            //bool isEven = nieuwGetal == evenGetal;
            ////Console.WriteLine($"Is getal even toegelaten: {isEven}");
            //if (isEven)
            //{
            //    Console.WriteLine("{0} getal is even", nieuwGetal);
            //}
            //else
            //{
            //    Console.WriteLine("{0} getal is oneven", nieuwGetal);
            //}


            #endregion

            #region 17 Kwadraat

            //Console.WriteLine("Geef een getal:");
            //double nieuwGetal = double.Parse(Console.ReadLine());
            //double kwadraatGetal = Math.Pow(nieuwGetal, 2);

            //Console.WriteLine("Het kwadraat van {0} is {1}.", nieuwGetal, kwadraatGetal);


            #endregion

            #region 18 Uren, overuren, brutoloon 
            //Console.WriteLine("Geef Uurlon:");
            //float uurlon = float.Parse(Console.ReadLine());
            //Console.WriteLine("Geef aantal uren:");
            //float uren = float.Parse(Console.ReadLine());
            //Console.WriteLine("Geef aantal overuren:");
            //float overuren = float.Parse(Console.ReadLine());
            //const float overurenLoonPercentage = 1.5f;
            //float overurenLoon = (uurlon * overurenLoonPercentage) * overuren;
            //float bruttoloon = uurlon * uren;
            //float effectieveBruttoloonM = overurenLoon + bruttoloon;
            //var effectieveBruttoloon = String.Format("{0:0.00}", effectieveBruttoloonM);

            //Console.WriteLine("Het loonbedraagt {0}.", effectieveBruttoloon);



            #endregion

            #region 19 Bereken het gewicht voor een constructie 
            //Console.WriteLine("Geef beedte in:");
            //double beedte = double.Parse(Console.ReadLine());
            //Console.WriteLine("Geef hoogte in:");
            //double hoogte = double.Parse(Console.ReadLine());
            //Console.WriteLine("Geef leengte in:");
            //double leengte = double.Parse(Console.ReadLine());
            //const int numb = 19;
            //double kzadraatHoogte = Math.Pow(hoogte, 2);
            //double maximaleGewicht = Math.Round (((numb * beedte * kzadraatHoogte) / leengte), 3);


            //Console.WriteLine("Het maximale gewicht voor balken met\n {0} beedte\n    {1} hoogte\n    {2} leengte\nis {3} kg.", beedte, hoogte, leengte, maximaleGewicht);

            #endregion

            #region 20 Remafstand

            //Console.WriteLine("Geef de snelheid in km/uur in:");
            //double snelheid = double.Parse(Console.ReadLine());
            //const double constSnelheid = 10;
            //double droogWeer = Math.Pow(snelheid / constSnelheid, 2) / 2;
            //const double vermenigvuldigt = 1.5d;
            //double natWeer = (Math.Pow(snelheid / constSnelheid, 2) / 2) * vermenigvuldigt;

            //Console.WriteLine("De remafstand bij droog weer is {0}.\n" +
            //    "De remafstand bij nat weer is {1}.", droogWeer, natWeer);

            #endregion


        }
    }
}
