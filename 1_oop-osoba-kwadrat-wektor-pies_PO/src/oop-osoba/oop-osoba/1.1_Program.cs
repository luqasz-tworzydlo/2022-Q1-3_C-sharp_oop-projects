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
                "[wykorzystanie nowej kategorii Kultura i użycie alias'ów]\n");
             
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
                osoba8_3_2 = new OsobaI("Stefan", "Żeromski", "Pol"); // zmieniono tutaj Polska na Pol po wprowadzeniu listy alias'ów

            Console.WriteLine(
                $"Kulturą osoby {osoba8_3_1.ImięNazwisko} jest {osoba8_3_1.Kultura}");
            Console.WriteLine(
                $"Kulturą osoby {osoba8_3_2.ImięNazwisko} jest {osoba8_3_2.Kultura}");

            // program posiada odniesienie do klasy OsobaI [ class OsobaI ]

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(8.4) Różne operacje na zmiennych statycznych\n" +
                "[wykorzystanie nowej kategorii Kultura i użycie alias'ów]\n" +
                "[ dodawanie nowych kultur do istniejącej listy alias'ów ]\n" +
                "[ usuwanie istniejących już kultur z listy alias'ów ]\n");

            OsobaI
                osoba8_4_1 = new OsobaI("Adam", "Mickiewicz", "polska"),
                osoba8_4_2 = new OsobaI("Stefan", "Żeromski", "Pol");

            // poniżej jest używa operacja dodania nowej kultury
            OsobaI.Kultury.Add("sumeryjska", "sumeryjska");
            OsobaI osoba8_4_3 = new OsobaI("Gilgamesz", "sumeryjska");

            // poniżej jest użyta operacja usuwania już istniejącej kultury
            // dla wcześniej wskazanych osób nie będzie to działać i obowiązywać [ nie będzie wyjątku ],
            // jednak dla osób, które dopiero będą użyte z danym alias'em, który został wcześnikej usunięty będzie wyjątek
            /*OsobaI.Kultury.Remove("pol");
            OsobaI osoba8_4_4 = new OsobaI("Michał", "pol");
            Console.WriteLine(
                $"Kulturą osoby {osoba8_4_4.ImięNazwisko} jest {osoba8_4_4.Kultura}");*/

            Console.WriteLine(
                $"Kulturą osoby {osoba8_4_1.ImięNazwisko} jest {osoba8_4_1.Kultura}");
            Console.WriteLine(
                $"Kulturą osoby {osoba8_4_2.ImięNazwisko} jest {osoba8_4_2.Kultura}");
            Console.WriteLine(
                $"Kulturą osoby {osoba8_4_3.ImięNazwisko} jest {osoba8_4_3.Kultura}");

            // program posiada odniesienie do klasy OsobaI [ class OsobaI ]

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(8.5) Operacje na zmiennych statycznych\n" +
                "[ z użyciem typu kolekcji statycznej - HashSet, który\n" +
                "[ będzie informować, które nazwiska są pisane z przodu]\n" +
                "[ można użyć tutaj także, przykładowo, switch'a,\n" +
                "który jest w praktyce łatwiej używalny]\n");

            OsobaJ
                osoba8_5_1 = new OsobaJ("Adam", "Mickiewicz", "polska"),
                osoba8_5_2 = new OsobaJ("Oda", "Nobunaga", "jap");

            Console.WriteLine(
                $"=> Kulturą osoby {osoba8_5_1.ImięNazwisko} jest {osoba8_5_1.Kultura}\n" +
                $"Jego imię to {osoba8_5_1.Imię}, a nazwisko to {osoba8_5_1.Nazwisko}\n");
            Console.WriteLine(
                $"=> Kulturą osoby {osoba8_5_2.ImięNazwisko} jest {osoba8_5_2.Kultura}\n" +
                $"Jej imię to {osoba8_5_2.Imię}, a nazwisko to {osoba8_5_2.Nazwisko}\n");

            // program posiada odniesienie do klasy OsobaJ [ class OsobaJ ]

            //////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n//////////////////////////////////////////////////////////////////////");
            Console.WriteLine("\n(9) Testowanie działania klasy Koło,\n" +
                "wraz z dwoma funkcjami [ użyto dane z punktów 6 i 7 ]\n");

            Koło
                k9_1 = new Koło(1, (0, 0)),
                k9_2 = new Koło(promień: 1, środek: (1, 0)),
                k9_3 = new Koło(środek: (0, 1), promień: 2),
                k9_4 = new Koło(promień: 0.3, środek: (0, 0.5));

            MójTest(k9_1);
            MójTest(k9_2);
            MójTest(k9_3);
            MójTest(k9_4);

            Console.WriteLine("\n");

            Koło k9 = new Koło(promień: 2, środek: (1, 1));
            DrugiMójTest(k9, 1, 1);
            DrugiMójTest(k9, 1, 3);
            DrugiMójTest(k9, 1, 4);

            // program posiada odniesienie do klasy Koło [ class Koło ],
            // jak i również do poniższych funkcji:
            // => static void MójTest(Koło k)
            // => static void DrugiMójTest(Koło k, double px, double py)

            //////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n//////////////////////////////////////////////////////////////////////");

            ////////////////////////////////////////////////////////////////////////////
            ///!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!///
            // /// /// /// !!! PONIŻSZA POZYCJA NR 10 JEST DO POPRAWY !!! /// /// /// //
            ///!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!///
            ////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(10) Operacje na klasie Kwadrat\n" +
                "[odczyt oraz zapis konkretnych danych]\n");
            /*Kwadrat
                k10_1 = new Kwadrat(bok1: 1, 0, 0, 0),
                k10_2 = new Kwadrat(0, przekątna1: 2, 0, 0),
                k10_3 = new Kwadrat(0, 0, obwód1: 5, 0),
                k10_4 = new Kwadrat(0, 0, 0, pole1: 8);

            TestKwadratu(k10_1);
            TestKwadratu(k10_2);
            TestKwadratu(k10_3);
            TestKwadratu(k10_4);*/

            // program posiada odniesienie do klasy Kwadrat [ class Kwadrat ]
            // jak i również do poniższej funkcji:
            // => static void TestKwadratu(Kwadrat k)

            ////////////////////////////////////////////////////////////////////////////
            ///!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!///
            ////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n//////////////////////////////////////////////////////////////////////");
            Console.WriteLine("\n(11) Operacje na klasie Produkt z użyciem statycznej kolekcji,\n" +
                "tj. Dictionary<string,decimal>, która przechowuje informacje o stawkach VAT\n" +
                "[m.in. stawka podstawowa = 23%, stawki obniżone = 8% i stawkę zerową = 0%]\n");

            TestowanieProduktów();

            // program posiada odniesienie do klasy Produkt [ class Produkt ]
            // jak i również do poniższej funkcji:
            // => static void TestowanieProduktów()

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n//////////////////////////////////////////////////////////////////////");
            Console.WriteLine("\n(12) Operacje na wektorach dwuwymariowych\n" +
                "[dodawanie dwóch wektorów, wyświetlanie ich długości itd.]\n");

            TestWektora_2d();

            // program posiada odniesienie do klasy Wektor_Dwuwymiarowy [ class Wektor_Dwuwymiarowy ]
            // jak i również do poniższej funkcji:
            // => static void TestWektora_2d()

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n//////////////////////////////////////////////////////////////////////");
            Console.WriteLine("\n(13) Operacje na punktach wielowymariowych\n" +
                "[dodawanie dwóch wektorów, wyświetlanie ich długości itd.]\n");

            TestPunku_Wielowymiarowego();

            // program posiada odniesienie do klasy Punkt_Wielowymiarowy [ class Punkt_Wielowymiarowy ]
            // jak i również do poniższej funkcji:
            // => static void TestPunku_Wielowymiarowego()

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n//////////////////////////////////////////////////////////////////////");
            Console.WriteLine("\n(14) Operacje na klasie Wektor_Stereo\n");

            Test_Wektora_Stereo();

            // program posiada odniesienie do klasy Wektor_Stereo [ class Wektor_Stereo ]
            // jak i również do poniższej funkcji:
            // => static void Test_Wektora_Stereo()

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n//////////////////////////////////////////////////////////////////////");
            Console.WriteLine("\n(15) Operacje na klasie Wektor_Ogólny\n");

            Test_Wektora_Ogólnego();

            // program posiada odniesienie do klasy Wektor_Ogólny [ class Wektor_Ogólny ]
            // jak i również do poniższej funkcji:
            // => static void Test_Wektora_Ogólnego()


            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n//////////////////////////////////////////////////////////////////////");
            Console.WriteLine("\n(16) Dziedziczenie (zwierzątka) => operacje z użyciem dwóch klas\n");

            TestDziedziczenia_Zwierzę();

            // program posiada odniesienie do następujących klas:
            // => klasy Pies z dziedziczeniem klasy Zwierzę [ class Pies : Zwierzę ]
            // => klasy Zwierzę [ class Zwierzę ]
            // jak i również do poniższej funkcji:
            // => static void TestDziedziczenia_Zwierzę()

            //////////////////////////////////////////////////////////////////////
            Console.ReadKey();
        }
        static void TestDziedziczenia_Zwierzę()
        {
            /*Zwierzę
                z = new Zwierzę()
                {
                    Gatunek = "koń",
                    Imię = "Pikuś",
                    Wiek = 6
                };*/
            Zwierzę // tutaj trzeba użyć już argumentów [!!!]
                z = new Zwierzę(
                    imię: "Czarnulek",
                    gatunek: "kot",
                    wiek: 6
                );

            /*Pies
                p = new Pies()
                {
                    Imię = "Myszka",
                    Wiek = 15,
                    Rasa = "jamnik-kundelek"
                };*/
            Pies // trzeba tutaj już użyć argumentów [!!!]
                p = new Pies(
                    imię: "Myszka",
                    wiek: 15,
                    rasa: "jamnik-kundelek"
                );
            Zwierzę z2 = p;
            // p.Gatunek = "kot"; // zmiana gatunku na nową wersję (brak możliwości)
            // z2.Gatunek = "kot"; // tutaj (w klasie zwierzę) można już zmienić gatunek 

            Console.WriteLine("=> Pierwsze zwierzątko");
            Console.WriteLine(
                $"{p.Rasa} {p.Imię}, {p.Wiek} lat(a)");
            Console.WriteLine(p);
            Console.WriteLine(
                $"{p.Gatunek} {p.Rasa} {p.Imię}, {p.Wiek} lat(a)");
            Console.WriteLine(
                $"{z2.Gatunek} {z2.Imię}, {z2.Wiek} lat(a)"); // niedozwolone użycie {z2.Rasa}
            Console.WriteLine(z2);

            Console.WriteLine("=> Drugie zwierzątko:");
            Console.WriteLine(
                $"{z.Gatunek} {z.Imię}, {z.Wiek} lat(a)");
            Console.WriteLine(z);
        }
        static void Test_Wektora_Ogólnego()
        {
            Wektor_Ogólny
                v = new Wektor_Ogólny(1, 2),
                w = new Wektor_Ogólny(3, 4),
                ss = Wektor_Ogólny.Suma(v,w);

            Console.WriteLine("Iloczyn skalarny dla dwóch wektorów, czyli:\n" +
                "v o wymiarze (" + v.Wymiar + ") oraz dla w o wymiarze (" + w.Wymiar + ") wynosi: ");
            Console.WriteLine(
                $"v = {Wektor_Ogólny.IloczynSkalarny(v,w)}");

            Console.WriteLine("Po dodaniu dwóch wektorów ich rozmiar wygląda następująco: \n" +
                $"|ss| = {ss.Długość}");

            Console.WriteLine("Natomiast iloczyn dla ss (czyli sumy dwóch wektorów v i w) oraz wektora w wynosi: ");
            Console.WriteLine(
                $"w = {Wektor_Ogólny.IloczynSkalarny(ss,w)};");

        }
        static void Test_Wektora_Stereo()
        {
            Wektor_Stereo
                v = new Wektor_Stereo(1, 2, 3),
                w = new Wektor_Stereo(6, -5, 4),
                s = Wektor_Stereo.Suma(v, w);

            Console.WriteLine(
                $"v = ({v.X};{v.Y};{v.Z}); |v| = {v.Długość}");
            Console.WriteLine(
                $"w = ({w.X};{w.Y};{w.Z}); |w| = {w.Długość}");
            Console.WriteLine(
                $"<v,w> = ({Wektor_Stereo.IloczynSkalarny(v,w)})");

            Console.WriteLine(
                $"w = ({s.X};{s.Y};{s.Z}); |s| = {s.Długość}");
        }
        static void TestPunku_Wielowymiarowego()
        {
            // testowanie klasy Punkt_Wielowymiarowy
            double[] tab = { 1.5, 2 };

            Punkt_Wielowymiarowy
                p = new Punkt_Wielowymiarowy(tab),
                q = new Punkt_Wielowymiarowy(3)
                {
                    [0] = 1.25,
                    [1] = 0.33,
                    [2] = 2.3
                },
                s = new Punkt_Wielowymiarowy(3)
                {
                    ['x'] = 1,
                    ['y'] = 2,
                    ['z'] = 3/*,
                    ['t'] = 4*/
                };

            tab[0] = 0;
            p[0] = 1;
            Console.WriteLine("Nasz punkt to: ");
            Console.WriteLine(p.Format_Punktu);
            Console.WriteLine(
                $"Współrzędna x punktu p to {p[0]}, zaś y to {p[1]}");

            Console.WriteLine("Inny nasz punkt to: ");
            Console.WriteLine(q.Format_Punktu);

            Console.WriteLine("Z kolei jeszcze inny punkt to: ");
            Console.WriteLine(s.Format_Punktu);
        }
        static void TestWektora_2d()
        {
            Wektor_Dwuwymiarowy
                v = new Wektor_Dwuwymiarowy() { X = 1, Y = 2 },
                w = new Wektor_Dwuwymiarowy() { X = 0, Y = 1 },
                // wyprodukowanie nowego wektora, jednocześnie zachowując poprzednie instancje
                /*vpw = Wektor_Dwuwymiarowy.DodajWektor(v, w);*/
                vpw = Wektor_Dwuwymiarowy.Suma_Wektorów(v, w);


            /*Wektor_Dwuwymiarowy
                v = new Wektor_Dwuwymiarowy() { X = 1, Y = 2 };
            v.Pomnóż(3);
            Console.WriteLine(
                $"v = ({v.X};{v.Y})");*/

            // poniższa instrukcja dodaje wektor v do wektora w
            /*v.DodajWektor(w);*/ // dodanie do wektora v wektora w
            v.DodajWektor(w).DodajWektor(w); // łańcuchowe wywoływanie metody

            Console.WriteLine(
                $"v = ({v.X};{v.Y}); |w| = {v.DługośćWektora}");
            Console.WriteLine(
                $"w = ({w.X};{w.Y}); |w| = {w.DługośćWektora}");
            Console.WriteLine(
                $"v+w = ({vpw.X};{vpw.Y}); |v+w| = {vpw.DługośćWektora}");
            /*Console.WriteLine(
                $"<v,w> = {v.IloczynSklarany(w)}");*/
            Console.WriteLine(
                $"<v,w> = {Wektor_Dwuwymiarowy.IloczynSkalarny(v,w)}");
        }
        static void TestowanieProduktów()
        {

            Produkt
                P1_1 = new Produkt()
                {
                    Nazwa = "Jabłko",
                    Cena_Netto = 1M,
                    Kategoria_VAT = "rolne"
                },
                P1_2 = new Produkt()
                {
                    Nazwa = "Jabłka Premium",
                    Cena_Netto = 3M,
                    Kategoria_VAT = "rolne"
                },
                P2_1 = new Produkt()
                {
                    Nazwa = "Usługa parkieciarska [podstawowa]",
                    Cena_Netto = 1M,
                    Kategoria_VAT = "budowlana"
                },
                P2_2 = new Produkt()
                {
                    Nazwa = "Usługa parkieciarska [profesjonalna]",
                    Cena_Netto = 90M,
                    Kategoria_VAT = "budowlana"
                },
                P3_1 = new Produkt()
                {
                    Nazwa = "Mąka",
                    Cena_Netto = 1M,
                    Kategoria_VAT = "gastro"
                },
                P3_2 = new Produkt()
                {
                    Nazwa = "Limonka Premium",
                    Cena_Netto = 5M,
                    Kategoria_VAT = "gastro"
                },
                P4_1 = new Produkt()
                {
                    Nazwa = "Chleb tradycyjny",
                    Cena_Netto = 1M,
                    Kategoria_VAT = "spożywcze"
                },
                P5_1 = new Produkt()
                {
                    Nazwa = "Książka kucharska",
                    Cena_Netto = 1M,
                    Kategoria_VAT = "książki"
                },
                P6_1 = new Produkt()
                {
                    Nazwa = "Gra Cyberpunk",
                    Cena_Netto = 1M
                };

            Console.WriteLine(P1_1.Cena_Brutto + " => cena brutto za " + P1_1.Nazwa);
            Console.WriteLine("=> Cena brutto za " + P1_2.Nazwa + " wynosi: " + P1_2.Cena_Brutto);
            Console.WriteLine("=> " + P2_1.Nazwa + " => koszt (cena brutto):" + P2_1.Cena_Brutto);
            Console.WriteLine("=> " + P2_2.Nazwa + " => koszt (cena brutto): " + P2_2.Cena_Brutto);
            Console.WriteLine(P3_1.Cena_Brutto + " => cena brutto za " + P3_1.Nazwa);
            Console.WriteLine("=> Cena brutto za " + P3_2.Nazwa + " wynosi: " + P1_2.Cena_Brutto);
            Console.WriteLine("=> " + P4_1.Cena_Brutto + " => koszt (cena brutto) za: " + P4_1.Nazwa);
            Console.WriteLine("=> W celu kupna " + P5_1.Nazwa + " należy zapłacić: " + P5_1.Cena_Brutto + "\n[ cena netto wynosi " + P5_1.Cena_Netto + " oraz stawka VAT " + P5_1.Kategoria_VAT + " ]");
            Console.WriteLine(P6_1.Cena_Brutto + " => cena brutto za " + P6_1.Nazwa);
        }
        ////////////////////////////////////////////////////////////////////////////
        ///!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!///
        // /// /// /// /// !!! PONIŻSZA INSTRUKCJA DO POPRAWY !!! /// /// /// /// //
        ///!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!///
        ////////////////////////////////////////////////////////////////////////////
        /*static void TestKwadratu(Kwadrat k)
        {
            Console.WriteLine(
                "Nasz kwadrat ma bok {0}, w tym:\n" +
                "=> przekątna: {1}\n" +
                "=> obwód {2}\n" +
                "=> pole {3}\n" +
                k,
                k.Przekątna,
                k.Obwód,
                k.Pole);
        }*/
        ////////////////////////////////////////////////////////////////////////////
        ///!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!///
        ////////////////////////////////////////////////////////////////////////////
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
