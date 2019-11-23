using System;

namespace HZ_les_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Opdracht 3.1 – Absolute waarde *2

            //Console.WriteLine("Geef een getal (positief of negatief) in");
            //int getal = int.Parse(Console.ReadLine());
            //if (getal < 0)
            //{
            //    int absGetal = getal * -1;
            //    Console.WriteLine("De absolute waarde van {0} is {1}", getal, absGetal);
            //}
            //else
            //{
            //    Console.WriteLine("De absolute waarde van {0} is {1}", getal, getal);
            //}


            #endregion

            #region Opdracht 3.2 – hetzelfde getal *2

            //Console.WriteLine("Geef eerste getal in");
            //int getal1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Geef tweede getal in");
            //int getal2 = int.Parse(Console.ReadLine());
            //if (getal1 == getal2)
            //{
            //    Console.WriteLine("Getallen {0} en {1} zijn hetzelfde", getal1, getal2);
            //}
            //else
            //{
            //    Console.WriteLine("Getallen {0} en {1} zijn verschilende", getal1, getal2);
            //}



            #endregion


            #region Opdracht 3.3 zoek het grootste getal *2
            //Console.WriteLine("Geef eerste getal in");
            //int getal1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Geef tweede getal in");
            //int getal2 = int.Parse(Console.ReadLine());
            //if (getal1 > getal2)
            //{
            //    Console.WriteLine("Getal {0} is groter dan {1}", getal1, getal2);
            //}
            //else if (getal2 > getal1)
            //{
            //    Console.WriteLine("Getal {1} is groter dan {0}", getal1, getal2);
            //}
            //else
            //{
            //    Console.WriteLine("Getalen {0} en {1} zeijn hetzelfde", getal1, getal2);
            //}


            #endregion


            #region Opdracht 3.4 even of oneven * 3 (chetnyy/nechetnyy)

            //Console.WriteLine("Geef eerste getal in");
            //int getal1 = int.Parse(Console.ReadLine());
            //bool isEven;
            //isEven = (getal1 % 2) == 0;


            //if (isEven)
            //{
            //    Console.WriteLine("Getal {0} is even", getal1);
            //}
            //else
            //{
            //    Console.WriteLine("Getal {0} is oneven", getal1);
            //}



            #endregion


            #region Opdracht 3.5 Cinema * *3
            //Console.WriteLine("Schrijf je leeftijd in");
            //int leeftijd = int.Parse(Console.ReadLine());
            //decimal toegangsticket = 3;
            //decimal korting = 0;




            //if (leeftijd < 11)
            //{
            //    toegangsticket = 1;
            //    Console.WriteLine("je leeftijd is {1}, Congrats, je krijgt je toegangsticket voor {0} Euro", toegangsticket, leeftijd);


            //}
            //else
            //{
            //    if (11 <= leeftijd && leeftijd < 15)
            //    {
            //        korting = 15;


            //    }
            //    else if (15 <= leeftijd && leeftijd < 18)
            //    {
            //        korting = 10;


            //    }
            //    else if (18 <= leeftijd && leeftijd < 21)
            //    {
            //        korting = 5;


            //    }
            //    else
            //    {
            //        Console.WriteLine("je leeftijd is {1}\n" +
            //            "Je toegangsticket kost {0} Euro, " +
            //            "sorry je krijgt geen korting", toegangsticket, leeftijd);
            //    }
            //    toegangsticket = Math.Round((toegangsticket * (1 - korting / 100)), 2);

            //    Console.WriteLine("je leeftijd is {2}, Congrats, je krijgt korting {1} %!!!\n" +
            //        "Je toegangsticket kost {0} Euro", toegangsticket, korting, leeftijd);
            //}

            #endregion


            #region   Opdracht 3.6 Vrachtwagen * *4

            //Console.WriteLine("Geef lengte van de pakje getal in");
            //float pakjeLengte = float.Parse(Console.ReadLine());
            //Console.WriteLine("Geef breedte van de pakje getal in");
            //float pakjeBreedte = float.Parse(Console.ReadLine());
            //Console.WriteLine("Geef hoogte van de pakje getal in");
            //float pakjeHoogte = float.Parse(Console.ReadLine());
            //float lengte = 3f;
            //float breedte = 1.5f;
            //float hoogte = 2f;
            //float alGeladenM3 = 4.5f;
            //double vrachtwagenVolume = Math.Round((lengte * breedte * hoogte), 2);
            //double vrijPlaats = vrachtwagenVolume - alGeladenM3;
            //double pakjeVolume = Math.Round((pakjeLengte * pakjeBreedte * pakjeHoogte), 2);
            //bool isGelukt = pakjeVolume <= vrijPlaats;
            //Console.WriteLine("de vrachtwagen heeft een totale inhoud van {0} m3.\n" +
            //    "Er zitten al pakjes in van {2} m3, er kan nog {3} bij.\n" +
            //    "Je wil een pakje van {1} m3 bijladen.\n", vrachtwagenVolume, pakjeVolume, 
            //            alGeladenM3, vrijPlaats);
            //if (isGelukt)
            //{
            //    Console.WriteLine("Dat zal nog lukken.");
            //}
            //else
            //{
            //    Console.WriteLine( "Dat zal niet lukken.");
            //}
            #endregion


            #region Opdracht 3.7 – Portkosten * *5

            //Console.WriteLine("versturen binnen Belgie? (y/n)");
            //string versturenBrifje = Console.ReadLine();
            //Console.WriteLine("is je brief genormalisierd? (y/n)");
            //string pakjeGenormalizierd = Console.ReadLine();
            //Console.WriteLine("hoeveel weegt je pakje? (gr)");
            //float pakjeGewicht = float.Parse(Console.ReadLine());
            //float genormalizierdKost = 0.7f;
            //float genormalizierdKostBuiten = 1.07f;
            //float kostenBinnenBelgie1 = 1.40f;
            //float kostenBinnenBelgie2 = 2.10f;
            //float kostenBinnenBelgie3 = 3.50f;
            //float kostenBinnenBelgie4 = 4.90f;
            //float kostenEuropa1 = 3.21f;
            //float kostenEuropa2 = 6.42f;
            //float kostenEuropa3 = 10.70f;
            //float kostenEuropa4 = 21.40f;


            //switch (versturenBrifje)
            //{
            //    case "y":
            //        switch (pakjeGenormalizierd)
            //        {
            //            case "y":
            //                if (pakjeGewicht < 50)
            //                {
            //                    Console.WriteLine("te betalen {0}", genormalizierdKost);
            //                    break;
            //                }


            //                else
            //                {
            //                    Console.WriteLine("je brief is niet genormalizierd.\n" +
            //                        "Probier opnieuw");
            //                    break;
            //                }

            //            case "n":
            //                if (pakjeGewicht < 100)
            //                {
            //                    Console.WriteLine("te betalen {0}", kostenBinnenBelgie1);
            //                    break;
            //                }
            //                else if (pakjeGewicht >= 100 && pakjeGewicht < 350)
            //                {
            //                    Console.WriteLine("te betalen {0}", kostenBinnenBelgie2);
            //                    break;
            //                }
            //                else if (pakjeGewicht >= 350 && pakjeGewicht < 1000)
            //                {
            //                    Console.WriteLine("te betalen {0}", kostenBinnenBelgie3);
            //                    break;
            //                }
            //                else if (pakjeGewicht >= 1000 && pakjeGewicht < 2000)
            //                {
            //                    Console.WriteLine("te betalen {0}", kostenBinnenBelgie4);
            //                    break;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("sorry, onze bedrijf verstuurt geen pakjes " +
            //                        "met gewicht {0} niet", pakjeGewicht);
            //                    break;
            //                }

            //                break;

            //        }
            //        break;
            //    case "n":
            //        switch (pakjeGenormalizierd)
            //        {
            //            case "y":
            //                if (pakjeGewicht < 50)
            //                {
            //                    Console.WriteLine("te betalen {0}", genormalizierdKostBuiten);
            //                    break;
            //                }


            //                else
            //                {
            //                    Console.WriteLine("je brief is niet genormalizierd.\n" +
            //                        "Probier opnieuw");
            //                    break;
            //                }

            //            case "n":
            //                if(pakjeGewicht < 100)
            //                {
            //                    Console.WriteLine("te betalen {0}", kostenEuropa1);
            //                    break;
            //                }
            //                else if (pakjeGewicht >= 100 && pakjeGewicht < 350)
            //                {
            //                    Console.WriteLine("te betalen {0}", kostenEuropa2);
            //                    break;
            //                }
            //                else if (pakjeGewicht >= 350 && pakjeGewicht < 1000)
            //                {
            //                    Console.WriteLine("te betalen {0}", kostenEuropa3);
            //                    break;
            //                }
            //                else if (pakjeGewicht >= 1000 && pakjeGewicht < 2000)
            //                {
            //                    Console.WriteLine("te betalen {0}", kostenEuropa4);
            //                    break;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("sorry, onze bedrijf verstuurt geen pakjes " +
            //                        "met gewicht {0} buiten Belgie niet", pakjeGewicht);
            //                    break;
            //                }
            //        }

            //        break;


            //}


            #endregion

            #region Opdracht 3.7 – Portkosten * *5 the same but improved the variabels

            //Console.WriteLine("versturen binnen Belgie? (y/n)");
            //string versturenBrifje = Console.ReadLine();
            //Console.WriteLine("is je brief genormalisierd? (y/n)");
            //string pakjeGenormalizierd = Console.ReadLine();
            //Console.WriteLine("hoeveel weegt je pakje? (gr)");
            //float pakjeGewicht = float.Parse(Console.ReadLine());
            //float genormalizierdKost = 0.7f;
            //float genormalizierdKostBuiten = 1.07f;
            //float kostenBinnenBelgie1 = 1.40f;
            //float kostenBinnenBelgie2 = 2.10f;
            //float kostenBinnenBelgie3 = 3.50f;
            //float kostenBinnenBelgie4 = 4.90f;
            //float kostenEuropa1 = 3.21f;
            //float kostenEuropa2 = 6.42f;
            //float kostenEuropa3 = 10.70f;
            //float kostenEuropa4 = 21.40f;
            //float prijs = 0.00f;


            //switch (versturenBrifje)
            //{
            //    case "y":
            //        if(pakjeGenormalizierd == "y") // bool is it yes? - is the bool true if the inout is 'y'?
            //        {
            //            if (pakjeGewicht < 50)
            //            {
            //                prijs = genormalizierdKost;
            //            }
            //        }
            //        else
            //        {
            //            if (pakjeGewicht < 100)
            //            {
            //                prijs = kostenBinnenBelgie1;
            //                break;
            //            }
            //            else if (pakjeGewicht >= 100 && pakjeGewicht < 350)
            //            {
            //                prijs = kostenBinnenBelgie2;
            //                break;
            //            }
            //            else if (pakjeGewicht >= 350 && pakjeGewicht < 1000)
            //            {
            //                prijs = kostenBinnenBelgie3;
            //                break;
            //            }
            //            else if (pakjeGewicht >= 1000 && pakjeGewicht < 2000)
            //            {
            //                prijs = kostenBinnenBelgie4;
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("sorry, onze bedrijf verstuurt geen pakjes " +
            //                    "met gewicht {0} niet", pakjeGewicht);
            //                break;
            //            }
            //        }
            //        break;
            //    case "n":
            //        switch (pakjeGenormalizierd)
            //        {
            //            case "y":
            //                if (pakjeGewicht < 50)
            //                {
            //                    prijs = genormalizierdKostBuiten;
            //                    break;
            //                }


            //                else
            //                {
            //                    Console.WriteLine("je brief is niet genormalizierd.\n" +
            //                        "Probier opnieuw");
            //                    break;
            //                }

            //            case "n":
            //                if (pakjeGewicht < 100)
            //                {
            //                    prijs = kostenEuropa1;
            //                    break;
            //                }
            //                else if (pakjeGewicht >= 100 && pakjeGewicht < 350)
            //                {
            //                    prijs = kostenEuropa2;
            //                    break;
            //                }
            //                else if (pakjeGewicht >= 350 && pakjeGewicht < 1000)
            //                {
            //                    prijs = kostenEuropa3;
            //                    break;
            //                }
            //                else if (pakjeGewicht >= 1000 && pakjeGewicht < 2000)
            //                {
            //                    prijs = kostenEuropa4;
            //                    break;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("sorry, onze bedrijf verstuurt geen pakjes " +
            //                        "met gewicht {0} buiten Belgie niet", pakjeGewicht);
            //                    break;
            //                }
            //        }

            //        break;


            //}
            //Console.WriteLine($"te betalen {prijs} Euros");//do not shoz the 0 in float


            #endregion

            #region   Opdracht 3.8 Multiple choice *6

            //Console.WriteLine("wat de correcte manier is om een variabele op te slaan in een integer variabele\n");
            //Console.WriteLine("a. int 1x = 10\nb.int w = 10\nc.float x = 10.0f\nd.string x = “10”\n");
            //Console.WriteLine("Geef je keuze in:");
            //string anttwoord = Console.ReadLine();
            //string negatiefAntw = "Foutive";
            //string positiefAntw = "Juist";
            // string resultat;
            //switch (anttwoord)
            //{
            //    case "a":
            //        //Console.WriteLine("Foutive!");
            //          resultat = negatiefAntw;
            //        Console.WriteLine(resultat);
            //        break;

            //    case "b":
            //        //Console.WriteLine("Juist!");
            //           resultat = positiefAntw;
            //        Console.WriteLine(resultat);
            //        break;
            //    case "c":
            //        //Console.WriteLine("Foutive!");
            //          resultat = negatiefAntw;
            //        Console.WriteLine(resultat);
            //        break;
            //    case "d":
            //        //Console.WriteLine("Foutive!");
            //         resultat = negatiefAntw;
            //        Console.WriteLine(resultat);
            //        break;



            //}

            //Console.WriteLine("Bedankt om mee te doen");



            #endregion

            #region Opdracht 3.9 Dag van de week *7


            //Console.WriteLine("Schrijf een getal (1 tem 7) die een dag van de week voorstelt:");
            //int nummer = int.Parse(Console.ReadLine());
            //string daag = string.Empty;

            //switch (nummer)
            //{
            //    case 1:
            //        daag = "Maandag";
            //        break;


            //    case 2:
            //        daag = "Dinsdag";
            //        break;

            //    case 3:
            //        daag = "Woensdag";
            //        break;

            //    case 4:
            //        daag = "Donderdag";
            //        break;
            //    case 5:
            //        daag = "Vrijdag";
            //        break;
            //    case 6:
            //        daag = "Zaterdag";
            //        break;
            //    case 7:
            //        daag = "Zondag";
            //        break;

            //}
            //Console.WriteLine("Vandaag is {0}!", daag);
            //Console.WriteLine("Een goede dag voor u :)");





            #endregion

            #region Opdracht 3.10 Aantal dagen per maand *(*)   7


            //Console.WriteLine("Schrijf een getal (1 tem 12) die een maand van het jaar voorstelt:");
            //int nummer = int.Parse(Console.ReadLine());
            //Console.WriteLine("Geef jaar in:");
            //int jaar = int.Parse(Console.ReadLine());
            //int schrikkeljaar = jaar % 400;
            //bool isSchrikkeljaar = schrikkeljaar == 0;
            //bool isSchrikkeljaar1 = jaar % 4 == 0;
            //switch (nummer)
            //int aantalDagen = 0;
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 6:
            //    case 8:
            //    case 10:
            //    case 12:
            //        aantalDagen = 31;
            //        break;
            //    case 4:
            //    case 7:
            //    case 9:
            //    case 11:
            //        aantalDagen = 30;
            //        break;
            //    case 2:
            //        if (isSchrikkeljaar)
            //        {
            //           aantalDagen = 29;
            //        }
            //        else
            //        {
            //            if (isSchrikkeljaar1)
            //            {
            //                aantalDagen = 29;
            //            }
            //            else
            //            {
            //                aantalDagen = 28;
            //            }
            //        }
            //        break;
            //}
            //Console.WriteLine(aantalDagen);
            #endregion

            #region  Opdracht 3.11 Leeftijd * 8
            //Console.WriteLine("Geef je naam in:");
            //string naam = Console.ReadLine();
            //Console.WriteLine("Geef je leeftijd in:");
            //int leeftijd = int.Parse(Console.ReadLine());
            //string leeftijd1 = "tussen 0 en 10 jaar";
            //string leeftijd2 = "tussen 11 en 20 jaar";
            //string leeftijd3 = "tussen 21 en 30 jaar";
            //string leeftijd4 = "tussen 31 en 40 jaar";
            //string leeftijd5 = "tussen 41 en 50 jaar";
            //string leeftijd6 = "tussen 51 en 60 jaar";
            //string leeftijd7 = "tussen 61 en 70 jaar";
            //string leeftijd8 = "tussen 71 en 80 jaar";
            //string leeftijd9 = "tussen 81 en 90 jaar";
            //string leeftijd10 = "tussen 91 en 100 jaar";
            //string tijd = string.Empty;


            //if (leeftijd <=10)
            //{
            //    tijd = leeftijd1;
            //}
            //else if (11 <= leeftijd && leeftijd <= 20)
            //{
            //    tijd = leeftijd2;
            //}
            //else if (21 <= leeftijd && leeftijd <= 30)
            //{
            //    tijd = leeftijd3;
            //}
            //else if (31 <= leeftijd && leeftijd <= 40)
            //{
            //    tijd = leeftijd4;
            //}
            //else if (41 <= leeftijd && leeftijd <= 50)
            //{
            //    tijd = leeftijd5;
            //}
            //else if (51 <= leeftijd && leeftijd <= 60)
            //{
            //    tijd = leeftijd6;
            //}
            //else if (61 <= leeftijd && leeftijd <= 70)
            //{
            //    tijd = leeftijd7;
            //}
            //else if (71 <= leeftijd && leeftijd <= 80)
            //{
            //    tijd = leeftijd8;
            //}
            //else if (81 <= leeftijd && leeftijd <= 90)
            //{
            //    tijd = leeftijd9;
            //}
            //else if (91 <= leeftijd && leeftijd <= 100)
            //{
            //    tijd = leeftijd10;
            //}
            //else
            //{
            //    Console.WriteLine("{0} is al volvasende", naam);

            //}

            //Console.WriteLine("{0} heeft een leeftijd {1}", naam, tijd);
            #endregion


            #region  Opdracht 3.11 Leeftijd * 8 TODO with switch & default!!!
            //Console.WriteLine("Geef je naam in:");
            //string naam = Console.ReadLine();
            //Console.WriteLine("Geef je leeftijd in:");
            //int leeftijd = int.Parse(Console.ReadLine());
            //string leeftijd1 = "tussen 0 en 10 jaar";
            //string leeftijd2 = "tussen 11 en 20 jaar";
            //string leeftijd3 = "tussen 21 en 30 jaar";
            //string leeftijd4 = "tussen 31 en 40 jaar";
            //string leeftijd5 = "tussen 41 en 50 jaar";
            //string leeftijd6 = "tussen 51 en 60 jaar";
            //string leeftijd7 = "tussen 61 en 70 jaar";
            //string leeftijd8 = "tussen 71 en 80 jaar";
            //string leeftijd9 = "tussen 81 en 90 jaar";
            //string leeftijd10 = "tussen 91 en 100 jaar";
            //string tijd = string.Empty;

            #endregion


            #region         Opdracht 3.12 Romeins getal *8

            //Console.WriteLine("Geef een Romeinse getal in:");
            //char romGetal = char.Parse(Console.ReadLine());
            //char.ToUpper(romGetal); //not working with lowercase

            //string input = Console.ReadLine().ToUpper();
            //char romGetal = char.Parse(input);
            //int arabicNum = 0;

            //switch (romGetal)
            //    {
            //        case 'I':
            //            arabicNum = 1;
            //            break;

            //        case 'V':
            //            arabicNum = 5;
            //            break;

            //        case 'X':
            //            arabicNum = 10;
            //            break;

            //        case 'L':
            //            arabicNum = 50;
            //            break;

            //        case 'C':
            //            arabicNum = 100;
            //            break;
            //        case 'D':
            //            arabicNum = 500;
            //            break;
            //        case 'M':
            //            arabicNum = 1000;
            //            break;
            //    }
            //Console.WriteLine($"{arabicNum}")




            #endregion

            #region Opdracht 3.13 decimaal naar binair * 8

            //Console.WriteLine("Geef een cijfer (0 => 8) in:");
            //int input = int.Parse(Console.ReadLine());//if i add a new varuiable as the 'input' , the input won't change
            //int cijfer = input;
            //int remainder;

            //string binary = string.Empty; //to hold the result

            //while (cijfer > 0) //loop
            //{
            //    remainder = cijfer % 2; //math to get binary
            //    cijfer /= 2; //math to get binary
            //    binary = remainder.ToString() + binary; //to append the result
            //}
            //if (input == 0)
            //{
            //    Console.WriteLine("Decimal: 0 = Binary:  0000");
            //}
            //else
            //{
            //    switch (binary.Length)
            //    {
            //        case 3:

            //            Console.WriteLine("Decimal: {0} = Binary:  0{1}", input, binary);

            //            break;

            //        case 4:

            //            Console.WriteLine("Decimal: {0} = Binary:  {1}", input, binary);

            //            break;
            //    }
            //}



            #endregion

            #region Opdracht 3.14 decimaal naar hexadecimaal * 9

            //Console.WriteLine("Geef een cijfer (0 => 15) in:");
            //string input = (Console.ReadLine());//if i add a new varuiable as the 'input' , the input won't change
            //string hexim = input;

            //switch (hexim)
            //{
            //    case "0":
            //    case "1":
            //    case "2":
            //    case "3":
            //    case "4":
            //    case "5":
            //    case "6":
            //    case "7":
            //    case "8":
            //    case "9":

            //        hexim = input;
            //        break;

            //    case "10":

            //        hexim = "A";

            //        break;

            //    case "11":


            //        hexim = "B";


            //        break;
            //    case "12":


            //        hexim = "C";


            //        break;
            //    case "13":


            //        hexim = "D";


            //        break;
            //    case "14":


            //        hexim = "E";


            //        break;
            //    case "15":


            //        hexim = "F";


            //        break;

            //}
            //Console.WriteLine("Decimal: {0} = hexim:  {1}", input, hexim);



            #endregion

            #region Opdracht 3.15 Temperatuur * 9

            //Console.WriteLine("Geef temperatuur in K in (geen negatieve gegevens:)");
            //float temperatuurK = int.Parse(Console.ReadLine());
            //const float kelvin = -273.15f;
            //float temperatuurC = temperatuurK + kelvin;
            //if (temperatuurK < 0)
            //{
            //    Console.WriteLine("Je hebt niet correte waarde ingegeven");
            //}
            //else
            //{
            //    Console.WriteLine("{0} K komt overeen met {1} C graden", temperatuurK, temperatuurC);
            //}

            #endregion

            #region Opdracht 3.16 Duurtijd * *9
            //Console.WriteLine("Geef het begin Uur in:");
            //int beginHours = int.Parse(Console.ReadLine());
            //Console.WriteLine("Geef het begin Min in:");
            //int beginMin = int.Parse(Console.ReadLine());
            //Console.WriteLine("Geef het duur van Uur in:");
            //int duurHours = int.Parse(Console.ReadLine());
            //Console.WriteLine("Geef het duur van Min in:");
            //int duurMin = int.Parse(Console.ReadLine());

            //int endMinuts;
            //int endHourss;

            //endMinuts = beginMin + duurMin;
            //endHourss = beginHours + duurHours;
            //if(endMinuts >= 60)
            //{
            //    endHourss = endHourss + endMinuts / 60;
            //    endMinuts = endMinuts % 60;
            //}
            //Console.WriteLine($"eindtijd is {endHourss}:{endMinuts}");



            #endregion

            #region Opdracht 3.17 Factuur * 10

            #endregion

            #region Opdracht 3.18 Deling * *10

            #endregion

            #region Opdracht 3.19 Examens * 10

            #endregion

            #region Opdracht 3.20 Kindergeld * *10

            #endregion


        }
    }
    }
