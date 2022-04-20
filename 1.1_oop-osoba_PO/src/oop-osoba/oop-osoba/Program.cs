using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class OsobaF
    {
        // dotyczy => klasa OsobaF [ class OsobaF ] jest częścią programu z punktu nr 4.3 [ class Program ... static void Main ]
        string
            imię,
            nazwisko,
            imięNazwisko;
        public string Imię
        {
            get
            {
                return imię;
            }
            set
            {
                imię = value;
                imięNazwisko = imię + " " + nazwisko;
            }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                nazwisko = value;
                imięNazwisko = imię + " " + nazwisko;
            }
        }
        public string ImięNazwisko
        {
            get { return imięNazwisko; }
        }
        public OsobaF(string imię, string nazwisko)
        {
            this.imię = imię;
            this.nazwisko = nazwisko;
            imięNazwisko = imię + " " + nazwisko;
        }
    }
    class OsobaE
    {
        // dotyczy => klasa OsobaE [ class OsobaE ] jest częścią programu z punktu nr 4.2 [ class Program ... static void Main ]
        string
            imię,
            nazwisko,
            imięNazwisko;
        public string Imię
        {
            get
            {
                return imię;
            }
            set
            {
                imię = value;
            }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public string ImięNazwisko
        {
            get { return imię + " " + nazwisko; }
        }
        public OsobaE(string imię, string nazwisko)
        {
            this.imię = imię;
            this.nazwisko = nazwisko;
            imięNazwisko = imię + " " + nazwisko;
        }
    }
    class OsobaD
    {
        // dotyczy => klasa OsobaD [ class OsobaD ] jest częścią programu z punktu nr 4.1 [ class Program ... static void Main ]
        string
            Imię,
            Nazwisko,
            ImięNazwisko;
        public string GetImię()
        {
            return Imię;
        }
        public void SetImię(string nowe)
        {
            Imię = nowe;
            ImięNazwisko = Imię + " " + Nazwisko;
        }
        public string GetNazwisko()
        {
            return Nazwisko;
        }
        public void SetNazwisko(string nowe)
        {
            Nazwisko = nowe;
            ImięNazwisko = Imię + " " + Nazwisko;
        }
        public string GetImięNazwisko()
        {
            return ImięNazwisko;
        }
        public OsobaD(string imię, string nazwisko)
        {
            Imię = imię;
            Nazwisko = nazwisko;
            ImięNazwisko = imię + " " + nazwisko;
        }
    }
    class OsobaC
    {
        // dotyczy => klasa OsobaC [ class OsobaC ] jest częścią programu z punktu nr 3.2 [ class Program ... static void Main ]
        readonly public string
            Imię,
            Nazwisko,
            ImięNazwisko;
        public OsobaC(string imię, string nazwisko)
        {
            Imię = imię;
            Nazwisko = nazwisko;
            ImięNazwisko = imię + " " + nazwisko;
        }
    }
    class OsobaB
    {
        // dotyczy => klasa OsobaB [ class OsobaB ] jest częścią programu z punktu nr 3.1 [ class Program ... static void Main ]
        public string Imię, Nazwisko;
        public string ImięNazwisko()
        {
            return Imię + " " + Nazwisko;
        }
        public OsobaB(string imię, string nazwisko)
        {
            Imię = imię;
            Nazwisko = nazwisko;
        }
    }
    class Osoba
    {
        // dotyczy => klasa Osoba [ class Osoba ] jest częścią programu z punktu nr 2.1 [ class Program ... static void Main ]
        // dotyczy => klasa Osoba [ class Osoba ] jest częścią programu z punktu nr 2.2 [ class Program ... static void Main ]
        public string Imię, Nazwisko;
            
        public string ImięNazwisko()
        {
            return Imię + " " + Nazwisko;
        }
    }
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

            // program posiada odniesienie do klasy Osoba [ class Osoba ]:

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

            // program posiada odniesienie do klasy Osoba [ class Osoba ]:

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

            // program posiada odniesienie do klasy OsobaB [ class OsobaB ]:

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(3.2) Wyświetlenie imienia oraz nazwiska [osobno i łącznie]\n");

            OsobaC osoba_3_2 = new OsobaC("Adam", "Mickiewicz");

            Console.WriteLine(osoba_3_2.Imię);
            Console.WriteLine(osoba_3_2.Nazwisko);
            Console.WriteLine(osoba_3_2.ImięNazwisko);

            // program posiada odniesienie do klasy OsobaC [ class OsobaC ]:

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(4.1) Zamiana imienia danej osoby innym imieniem [set]\n");

            OsobaD osoba_4_1 = new OsobaD("Adam", "Mickiewicz");
            osoba_4_1.SetImię("Jan");

            Console.WriteLine(osoba_4_1.GetImię());
            Console.WriteLine(osoba_4_1.GetNazwisko());
            Console.WriteLine(osoba_4_1.GetImięNazwisko());

            // program posiada odniesienie do klasy OsobaD [ class OsobaD ]:

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(4.2) Zamiana imienia danej osoby innym imieniem [drugi sposób]\n");

            OsobaE osoba_4_2 = new OsobaE("Adam", "Mickiewicz");
            osoba_4_2.Imię = "Jan";

            Console.WriteLine(osoba_4_2.Imię);
            Console.WriteLine(osoba_4_2.Nazwisko);
            Console.WriteLine(osoba_4_2.ImięNazwisko);

            // program posiada odniesienie do klasy OsobaE [ class OsobaE ]:

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n(4.3) Zamiana imienia danej osoby innym imieniem [drugi sposób, lekko zmieniony]\n");

            OsobaF osoba_4_3 = new OsobaF("Adam", "Mickiewicz");
            osoba_4_3.Imię = "Jan";

            Console.WriteLine(osoba_4_3.Imię);
            Console.WriteLine(osoba_4_3.Nazwisko);
            Console.WriteLine(osoba_4_3.ImięNazwisko);

            // program posiada odniesienie do klasy OsobaF [ class OsobaF ]:

            //////////////////////////////////////////////////////////////////////
            
            Console.ReadKey();
        }
    }
}
