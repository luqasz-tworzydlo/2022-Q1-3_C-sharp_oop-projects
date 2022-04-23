using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    
    class Program
    {
        static string ImięNazwisko((string imię, string nazwisko) osoba)
        {
            // dotyczy => jest to część programu z punktu nr 1.2 [class Program ... static void Main]
            return osoba.imię + " " + osoba.nazwisko;
        }
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(1.1) Zgrupowane imiona i nazwiska w jednym miejscu\n");

            string[] imiona1_1 = new string[] { "Adam", "Stefan" };
            string[] nazwiska1_1 = { "Mickiewifcz", "Żeromski" };
            // powyższy kod należy poprawić, lekko zmodyfikować

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(1.2) Etykietowanie pozycji (imiona i nazwiska)\n");
            // poniżej jest ukazany poprawiony, działający kod wraz z funkcją

            (string imię, string nazwisko) osoba1_1_2 = ("Adam", "Mickiewicz");
            (string nazwisko, string imię) osoba2_1_2 = ("Żeromski", "Stefan");

            Console.WriteLine(
                ImięNazwisko(osoba1_1_2)
                );

            Console.WriteLine(
                ImięNazwisko(osoba2_1_2)
                );

            // program posiada 1 odniesienie - odniesienie do [ class Program ]:
            // => static string ImięNazwisko((string imię, string nazwisko) osoba)

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(2.1) Wyświetlenie imienia oraz nazwiska\n");

            Osoba osoba2_1 = new Osoba();
            osoba2_1.Imię = "Adam";
            osoba2_1.Nazwisko = "Mickiewicz";

            Console.WriteLine(osoba2_1.ImięNazwisko());

            // program posiada odniesienie do klasy Osoba [ class Osoba ]

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(2.2) Połączenie oraz wyświetlenie imion wraz z nazwiskami\n");

            Osoba
                osoba1_2_2 = new Osoba(),
                osoba2_2_2 = new Osoba()
                ;
            osoba1_2_2.Imię = "Adam";
            osoba1_2_2.Nazwisko = "Mickiewicz";
            osoba2_2_2.Imię = "Stefan";
            osoba2_2_2.Nazwisko = "Żeromski";

            Console.WriteLine(osoba1_2_2.ImięNazwisko());
            Console.WriteLine(osoba2_2_2.ImięNazwisko());

            // program posiada odniesienie do klasy Osoba [ class Osoba ]

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(3.1) Przeniesienia nazwiska z pierwszej osoby dla trzeciej\n");
            
            OsobaB
                osoba1_3_1 = new OsobaB("Adam", "Mickiewicz"),
                osoba2_3_1 = new OsobaB("Stefan", "Żeromski"),
                osoba3_3_1
                ;
            osoba3_3_1 = osoba1_3_1;
            osoba3_3_1.Imię = "Jan";
            // powyżej zastosowano przeniesienie naziwska dla trzeciej osoby [ Jan ]

            Console.WriteLine(osoba1_3_1.ImięNazwisko());
            Console.WriteLine(osoba2_3_1.ImięNazwisko());
            Console.WriteLine(osoba3_3_1.ImięNazwisko());

            // program posiada odniesienie do klasy OsobaB [ class OsobaB ]

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(3.2) Wyświetlenie imienia oraz nazwiska [osobno i łącznie]\n");

            OsobaC osoba_3_2 = new OsobaC("Adam", "Mickiewicz");

            Console.WriteLine(osoba_3_2.Imię);
            Console.WriteLine(osoba_3_2.Nazwisko);
            Console.WriteLine(osoba_3_2.ImięNazwisko);

            // program posiada odniesienie do klasy OsobaC [ class OsobaC ]

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(4.1) Zamiana imienia danej osoby innym imieniem [set]\n");

            OsobaD osoba_4_1 = new OsobaD("Adam", "Mickiewicz");
            osoba_4_1.SetImię("Jan");

            Console.WriteLine(osoba_4_1.GetImię());
            Console.WriteLine(osoba_4_1.GetNazwisko());
            Console.WriteLine(osoba_4_1.GetImięNazwisko());

            // program posiada odniesienie do klasy OsobaD [ class OsobaD ]

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(4.2) Zamiana imienia danej osoby innym imieniem [drugi sposób]\n");

            OsobaE osoba_4_2 = new OsobaE("Adam", "Mickiewicz");
            osoba_4_2.Imię = "Jan";

            Console.WriteLine(osoba_4_2.Imię);
            Console.WriteLine(osoba_4_2.Nazwisko);
            Console.WriteLine(osoba_4_2.ImięNazwisko);

            // program posiada odniesienie do klasy OsobaE [ class OsobaE ]

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(4.3) Zamiana imienia danej osoby innym imieniem [drugi sposób, lekko zmieniony]\n");

            OsobaF osoba_4_3 = new OsobaF("Adam", "Mickiewicz");
            osoba_4_3.Imię = "Jan";

            Console.WriteLine(osoba_4_3.Imię);
            Console.WriteLine(osoba_4_3.Nazwisko);
            Console.WriteLine(osoba_4_3.ImięNazwisko);

            // program posiada odniesienie do klasy OsobaF [ class OsobaF ]

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(5.1) Inne operacje na imieniu oraz nazwisku [część 1-2]\n");

            OsobaG osoba_5_1 = new OsobaG("Adam", "Mickiewicz");
            osoba_5_1.ImięNazwisko = "Gilgamesz";

            Console.WriteLine(osoba_5_1.Imię);
            Console.WriteLine(osoba_5_1.Nazwisko);
            Console.WriteLine($"Niniejsza osoba nazywa się {osoba_5_1.ImięNazwisko}.");

            // program posiada odniesienie do klasy OsobaG [ class OsobaG ]

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(5.2) Inne operacje na imieniu oraz nazwisku [część 2-2]\n");

            OsobaG osoba_5_2 = new OsobaG("Gilgamesz Maria Poniatowski");
            osoba_5_2.Nazwisko = "Wiśniewski";

            Console.WriteLine(osoba_5_2.Imię);
            Console.WriteLine(osoba_5_2.Nazwisko);
            Console.WriteLine($"Niniejsza osoba nazywa się {osoba_5_2.ImięNazwisko}.");

            // program posiada odniesienie do klasy OsobaG [ class OsobaG ]

            //////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n//////////////////////////////////////////////////////////////////////");
            Console.WriteLine("\n(6) Zdefiniowana klasa Koło (w tym środek, double promień,\n" +
                "double obwód [do odczytu] oraz double pole [również do odczytu].\n" +
                "Poniżej jest test działania dla 4 różnych pul o konkretnych danych\n");

            Koło
                k1 = new Koło(1, (0, 0)),
                k2 = new Koło(promień: 1, środek: (1, 0)),
                k3 = new Koło(środek: (0, 1), promień: 2),
                k4 = new Koło(promień: 0.3, środek: (0, 0.5));

            MójTest(k1);
            MójTest(k2);
            MójTest(k3);
            MójTest(k4);

            // program posiada odniesienie do klasy Koło [ class Koło ],
            // jak i również do funkcji: static void MójTest(Koło k)

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(7) Nasza klasa Koło zostało wzbogacone o dodatkowe dwie metody, czyli:\n" +
                "public bool CzyWKole(double x, double y) oraz public bool CzyNaOkręgu(double x, double y).\n" +
                "Pierwsza z naszych metod [ CzyWKole ] sprawdza, czy podany punkt jest kole\n" +
                "zaś druga metoda sprawdza czy podany punkt jest na brzegu koła.\n");

            Koło k = new Koło(promień: 2, środek: (1, 1));
            DrugiMójTest(k, 1, 1);
            DrugiMójTest(k, 1, 3);
            DrugiMójTest(k, 1, 4);

            // program posiada odniesienie do klasy Koło [ class Koło ],
            // jak i również do funkcji: static void DrugiMójTest(Koło k, double px, double py)

            //////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n//////////////////////////////////////////////////////////////////////");
            Console.WriteLine("\n(8.1) Różne operacje na zmiennych statycznych\n" +
                "[opcja nr 1, podczas gdy chcemy zmienną statyczną modyfikować\n" +
                "to mamy publiczną statyczną zmienną, czyli public static]\n");

            OsobaH1
                osoba8_1_1 = new OsobaH1("Adam Mickiewicz"),
                osoba8_1_2 = new OsobaH1("Stefan Żeromski");

            OsobaH1.JakaśZmienna = 1;

            osoba8_1_1.JakaśMetoda();
            osoba8_1_2.JakaśMetoda();

            // program posiada odniesienie do klasy OsobaH1 [ class OsobaH1 ]

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(8.2) Różne operacje na zmiennych statycznych\n" +
                "[opcja nr 2, podczas gdy nie chcemy zmienną statyczną modyfikować\n" +
                "i mieć ją dostępną na zewnątrz to mamy publiczną stałą lub readonly].\n" +
                "Tutaj jest zablokowanie nadpisywanie nadanej już wartości.\n" +
                "Od stałej różni to się tym, iż można to nadpisać w statycznym\n" +
                "konstruktorze, jeśli będziemy mieć dostępną statyczną.\n" +
                "Stałe nie mogą przechowywać obiektów [tj. int'owa tablica].\n");

            OsobaH2
                osoba8_2_1 = new OsobaH2("Adam Mickiewicz"),
                osoba8_2_2 = new OsobaH2("Stefan Żeromski");

            // OsobaI.Tablica = new int[3]; // zablokowanie nadpisywanie tablicy
            OsobaH2.Tablica[0] = 3; // można modyfikować składowe tablicy

            osoba8_2_1.JakaśMetoda();
            osoba8_2_2.JakaśMetoda();

            // program posiada odniesienie do klasy OsobaH2 [ class OsobaH2 ]

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(8.3) Różne operacje na zmiennych statycznych\n" +
                "[opcja nr 1, podczas gdy chcemy zmienną statyczną modyfikować\n" +
                "to mamy publiczną statyczną zmienną, czyli public static]\n");

            /*OsobaI
                osoba8_3_1 = new OsobaI("Adam Mickiewicz")
                {
                    Kultura = "polska"
                },
                osoba8_3_2 = new OsobaI("Stefan Żeromski")
                {
                    Kultura = "Polska"
                };*/

            OsobaI
                osoba8_3_1 = new OsobaI("Adam", "Mickiewicz", "polska"),
                osoba8_3_2 = new OsobaI("Stefan", "Żeromski", "Polska");

            Console.WriteLine(
                $"Kulturą osoby {osoba8_3_1.ImięNazwisko} jest {osoba8_3_1.Kultura}");
            Console.WriteLine(
                $"Kulturą osoby {osoba8_3_2.ImięNazwisko} jest {osoba8_3_2.Kultura}");

            // program posiada odniesienie do klasy OsobaI [ class OsobaI ]

            //////////////////////////////////////////////////////////////////////



            Console.ReadKey();
        }
        static void MójTest(Koło k)
        {
            Console.WriteLine(
                "Koło ma obwód {0}, zaś pole {1}\n",
                k.Obwód_Koła,
                k.Pole_Koła
                );
            k.Środek_Koła.x = 2;
            k.Promień_Koła *= 2;
            Console.WriteLine(
                "Po zmianie promienia dwa razy koło ma obwód {0}, natomiast pole {1}",
                k.Obwód_Koła,
                k.Pole_Koła
                );
        }
        static void DrugiMójTest(Koło k, double px, double py)
        {
            Console.WriteLine(
                "Punkt ({0},{1}): czy jest w kole? {2} czy jest na okręgu? {3}",
                px,
                py,
                k.CzyWKole(px, py),
                k.CzyNaOkręgu(px, py)
                );
        }
    }
}
