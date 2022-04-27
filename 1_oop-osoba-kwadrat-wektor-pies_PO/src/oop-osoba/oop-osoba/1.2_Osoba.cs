using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class OsobaJ
    {
        // dotyczy => klasa OsobaJ [ class OsobaJ ] jest częścią programu z punktu nr 8.5 [ class Program ... static void Main ]
        public const char SeparatorWyrazów = ' ';

        // użycie Kultury [ sposób nr 2 - użycie listy alias'ów ]
        // zamiast 'readonly static Dictionary<string, string> Kultury = new Dictionary<string, string>()'
        // można tutaj dokonywać modyfikacji oraz dodawać do listy alias'ów inne kultury [ niedostępne ]
        public readonly static Dictionary<string, string> kultury = new Dictionary<string, string>()
        {
            ["polska"] = "polska",
            ["polka"] = "polska",
            ["polak"] = "polska",
            ["pol"] = "polska",
            ["pl"] = "polska",
            ["polish"] = "polska",

            ["ukraińska"] = "ukraińska",
            ["ukrainiec"] = "ukraińska",
            ["ukrainka"] = "ukraińska",
            ["ukr"] = "ukraińska",
            ["ua"] = "ukraińska",
            ["ukrainian"] = "ukraińska",

            ["węgierska"] = "węgierska",
            ["węgierka"] = "węgierska",
            ["węgier"] = "węgierska",
            ["hun"] = "węgierska",
            ["hu"] = "węgierska",
            ["hungarian"] = "węgierska",

            ["japońska"] = "japońska",
            ["japonka"] = "japońska",
            ["japończyk"] = "japońska",
            ["jap"] = "japońska",
            ["jp"] = "japońska",
            ["japanese"] = "japońska",
        };
        // poniżej jest metoda dostępowa dla nowego użycia Kultury
        public static Dictionary<string,string> Kultury
        {
            get { return new Dictionary<string, string>(kultury); }
        }

        // zdefiniowany 
        readonly static HashSet<string> kulturyZNazwiskiemZPrzodu = new HashSet<string>
        {
            "węgierska", "japońska"
        };

        string
            imię,
            nazwisko,
            imięNazwisko,
            kultura;

        // poniższa instrukcja dotyczy użycia Kultury [ sposób nr 2 - gdzie są alias'y ( lista alias'ów ) ]
        // tutaj zmieniono 'wartość' na 'alias' oraz instrukcję dla if [ w tym lekko tekst dla wyjątku z else ]
        public string Kultura
        {
            get { return kultura; }
            set
            {
                string alias = value.ToLower(); // zamiana litery danej wartości na małe litery
                if (kultury.ContainsKey(alias))
                    kultura = kultury[alias];
                else
                    throw new Exception("Nieznana kultura / alias" + alias);
            }
        }

        public string Imię
        {
            get
            {
                return imię;
            }
            set
            {
                imię = value;
                sklejImięNazwisko();
            }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                nazwisko = value;
                sklejImięNazwisko();
            }
        }
        public string ImięNazwisko
        {
            get { return imięNazwisko; }
            set
            {
                string[] rozbicie = value.Split(SeparatorWyrazów);

                int
                    indeksImienia = 0,
                    indeksNazwiska = 0;

                if (kulturyZNazwiskiemZPrzodu.Contains(kultura))
                    indeksImienia = -1;
                else
                    indeksNazwiska = -1;

                imię = rozbicie[indeksImienia];
                if (rozbicie.Length > 1)
                    nazwisko = rozbicie[indeksNazwiska];
                else
                    nazwisko = "";
                sklejImięNazwisko();
            }
        }
        void sklejImięNazwisko()
        {
            /*if (nazwisko != "")
                imięNazwisko = imię;
            else*/ if (kulturyZNazwiskiemZPrzodu.Contains(kultura))
                imięNazwisko = nazwisko + SeparatorWyrazów + imię;
            else
                imięNazwisko = imię + SeparatorWyrazów + nazwisko;
        }
        public OsobaJ(string imię, string nazwisko, string kultura)
        {
            Kultura = kultura;
            this.imię = imię;
            this.nazwisko = nazwisko;
            sklejImięNazwisko();
        }
        public OsobaJ(string imięNazwisko, string kultura)
        {
            Kultura = kultura;
            ImięNazwisko = imięNazwisko;
            // Console.WriteLine("Wartość zmiennej statycznej"); // do testów
        }
    }
    class OsobaI
    {
        // dotyczy => klasa OsobaI [ class OsobaI ] jest częścią programu z punktu nr 8.3 [ class Program ... static void Main ]
        // dotyczy => klasa OsobaI [ class OsobaI ] jest częścią programu z punktu nr 8.4 [ class Program ... static void Main ]
        public const char SeparatorWyrazów = ' ';

        // użycie Kultury [ sposób nr 1 ]
        /*readonly static HashSet<string> Kultury = new HashSet<string>()
        {
            "polska",
            "rosyjska",
            "ukraińska",
            "niemiecka",
            "francuska",
            "węgierska",
            "japońska"
        };*/
        // użycie Kultury [ sposób nr 2 - użycie listy alias'ów ]
        // zamiast 'readonly static Dictionary<string, string> Kultury = new Dictionary<string, string>()'
        // można tutaj dokonywać modyfikacji oraz dodawać do listy alias'ów inne kultury [ niedostępne ]
        public readonly static Dictionary<string, string> Kultury = new Dictionary<string, string>()
        {
            ["polska"] = "polska",
            ["polka"] = "polska",
            ["polak"] = "polska",
            ["pol"] = "polska",
            ["pl"] = "polska",
            ["polish"] = "polska",

            ["ukraińska"] = "ukraińska",
            ["ukrainiec"] = "ukraińska",
            ["ukrainka"] = "ukraińska",
            ["ukr"] = "ukraińska",
            ["ua"] = "ukraińska",
            ["ukrainian"] = "ukraińska",

            ["węgierska"] = "węgierska",
            ["węgierka"] = "węgierska",
            ["węgier"] = "węgierska",
            ["hun"] = "węgierska",
            ["hu"] = "węgierska",
            ["hungarian"] = "węgierska",

            ["japońska"] = "japońska",
            ["japonka"] = "japońska",
            ["japończyk"] = "japońska",
            ["jap"] = "japońska",
            ["jp"] = "japońska",
            ["japanese"] = "japońska",
        };

        string
            imię,
            nazwisko,
            imięNazwisko,
            kultura;

        // poniższa instrukcja dotyczy użycia Kultury [ sposób nr 1 ]
        /*public string Kultura
        {
            get { return kultura; }
            set
            {
                string wartość = value.ToLower(); // zamiana litery danej wartości na małe litery
                if (Kultury.Contains(wartość))
                    kultura = wartość;
                else
                    throw new Exception("Nieznana kultura" + wartość);
            }
        }*/
        // poniższa instrukcja dotyczy użycia Kultury [ sposób nr 2 - gdzie są alias'y ( lista alias'ów ) ]
        // tutaj zmieniono 'wartość' na 'alias' oraz instrukcję dla if [ w tym lekko tekst dla wyjątku z else ]
        public string Kultura
        {
            get { return kultura; }
            set
            {
                string alias = value.ToLower(); // zamiana litery danej wartości na małe litery
                if (Kultury.ContainsKey(alias))
                    kultura = Kultury[alias];
                else
                    throw new Exception("Nieznana kultura / alias" + alias);
            }
        }

        public string Imię
        {
            get
            {
                return imię;
            }
            set
            {
                imię = value;
                sklejImięNazwisko();
            }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                nazwisko = value;
                sklejImięNazwisko();
            }
        }
        public string ImięNazwisko
        {
            get { return imięNazwisko; }
            set
            {
                string[] rozbicie = value.Split(SeparatorWyrazów);
                imię = rozbicie[0];
                if (rozbicie.Length > 1)
                    nazwisko = rozbicie[0];
                else
                    nazwisko = "";
                sklejImięNazwisko();
            }
        }
        void sklejImięNazwisko()
        {
            if (nazwisko != "")
                imięNazwisko = imię + SeparatorWyrazów + nazwisko;
            else
                imięNazwisko = imię;
        }
        public OsobaI(string imię, string nazwisko, string kultura)
        {
            Kultura = kultura;
            this.imię = imię;
            this.nazwisko = nazwisko;
            sklejImięNazwisko();
        }
        public OsobaI(string imięNazwisko, string kultura)
        {
            Kultura = kultura;
            ImięNazwisko = imięNazwisko;
            // Console.WriteLine("Wartość zmiennej statycznej"); // do testów
        }
    }
    class OsobaH2
    {
        // dotyczy => klasa OsobaH2 [ class OsobaH2 ] jest częścią programu z punktu nr 8.2 [ class Program ... static void Main ]
        public const char SeparatorWyrazów = ' ';
        public readonly static int[] Tablica = new int[]
        {
            1, 2, 3, 4, 5
        };
        public readonly static int JakaśZmienna = 0;
        public void JakaśMetoda()
        {
            Console.WriteLine("Wartość zmiennej statycznej wynosi " + JakaśZmienna);
        }
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
                sklejImięNazwisko();
            }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                nazwisko = value;
                sklejImięNazwisko();
            }
        }
        public string ImięNazwisko
        {
            get { return imięNazwisko; }
            set
            {
                string[] rozbicie = value.Split(SeparatorWyrazów);
                imię = rozbicie[0];
                if (rozbicie.Length > 1)
                    nazwisko = rozbicie[0];
                else
                    nazwisko = "";
                sklejImięNazwisko();
            }
        }
        void sklejImięNazwisko()
        {
            if (nazwisko != "")
                imięNazwisko = imię + SeparatorWyrazów + nazwisko;
            else
                imięNazwisko = imię;
        }
        public OsobaH2(string imię, string nazwisko)
        {
            this.imię = imię;
            this.nazwisko = nazwisko;
            sklejImięNazwisko();
        }
        public OsobaH2(string imięNazwisko)
        {
            ImięNazwisko = imięNazwisko;
            // Console.WriteLine("Wartość zmiennej statycznej"); // do testów
        }
    }
    class OsobaH1
    {
        // dotyczy => klasa OsobaH [ class OsobaH ] jest częścią programu z punktu nr 8.1 [ class Program ... static void Main ]
        public const char SeparatorWyrazów = ' ';
        public static int JakaśZmienna = 0;
        public void JakaśMetoda()
        {
            Console.WriteLine("Wartość zmiennej statycznej wynosi " + JakaśZmienna);
        }
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
                sklejImięNazwisko();
            }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                nazwisko = value;
                sklejImięNazwisko();
            }
        }
        public string ImięNazwisko
        {
            get { return imięNazwisko; }
            set
            {
                string[] rozbicie = value.Split(SeparatorWyrazów);
                imię = rozbicie[0];
                if (rozbicie.Length > 1)
                    nazwisko = rozbicie[0];
                else
                    nazwisko = "";
                sklejImięNazwisko();
            }
        }
        void sklejImięNazwisko()
        {
            if (nazwisko != "")
                imięNazwisko = imię + SeparatorWyrazów + nazwisko;
            else
                imięNazwisko = imię;
        }
        public OsobaH1(string imię, string nazwisko)
        {
            this.imię = imię;
            this.nazwisko = nazwisko;
            sklejImięNazwisko();
        }
        public OsobaH1(string imięNazwisko)
        {
            ImięNazwisko = imięNazwisko;
            // Console.WriteLine("Wartość zmiennej statycznej"); // do testów
        }
    }
    class OsobaG
    {
        // dotyczy => klasa OsobaG [ class OsobaG ] jest częścią programu z punktu nr 5.1 [ class Program ... static void Main ]
        // dotyczy => klasa OsobaG [ class OsobaG ] jest częścią programu z punktu nr 5.2 [ class Program ... static void Main ]
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
                sklejImięNazwisko();
            }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                nazwisko = value;
                sklejImięNazwisko();
            }
        }
        public string ImięNazwisko
        {
            get { return imięNazwisko; }
            set
            {
                string[] rozbicie = value.Split(' ');
                imię = rozbicie[0];
                if (rozbicie.Length > 1)
                    nazwisko = rozbicie[0];
                else
                    nazwisko = "";
                sklejImięNazwisko();
            }
        }
        void sklejImięNazwisko()
        {
            if (nazwisko != "")
                imięNazwisko = imię + " " + nazwisko;
            else
                imięNazwisko = imię;
        }
        public OsobaG(string imię, string nazwisko)
        {
            this.imię = imię;
            this.nazwisko = nazwisko;
            sklejImięNazwisko();
        }
        public OsobaG(string imięNazwisko)
        {
            ImięNazwisko = imięNazwisko;
        }
    }
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
}
