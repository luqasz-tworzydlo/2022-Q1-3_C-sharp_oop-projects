using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class C1
    {
        public string S1 { get; set; }
        public string S2 { get; set; }
    }
    class C2 : C1 { }
    class C3 : C2 { }
    // powyżej jest przedstawione sposobu dziedziczenia klas
    class B1
    {
        public string S1 { get; set; }
        public string S3 { get; set; }
    }
    class C4_1 // domieszkowanie [ sposób nr 1 ]
    {
        public C1 c1;
        public B1 b1;
    }
    class C4_2 // domieszkowanie [ sposób nr 2, ukryte, nuepubliczne ]
    {
        C1 c1;
        B1 b1;
        public string S1 => c1.S1; // przekierowanie
        public string S1b => b1.S1;
        public string S2 => c1.S2;
        public string S3 => b1.S3;
        // nie można dziedziczyć po kilku klasach naraz - powyżej jest jeden ze sposobów jak to ominąć
        // traci się jednak przez to hierarchię typów, nie jest zautomatyzowane
        // nie można składować dwóch elementów, ale można je umieścić we wspólnym interfejsie
    }
    class Program
    {
        static void MojTest1()
        {
            Opiekun opiekun = new Opiekun() { Imię = "Janek" };
            Pupil pupil = new Pupil() { Imię = "Reks", Opiekun = opiekun };

            /*CzłonekPary
                x = new CzłonekPary(),
                y = new CzłonekPary() { Para = x };*/
            // pomocniczy dodatek [1-2] - klasa nie używana
            CzłonekPary
                x = new Opiekun()
                {
                    Imię = "Anka",
                    Nazwisko = "Wiśniewska"
                },
                y = new Pupil()
                {
                    Imię = "Szarlik",
                    Gatunek = "pies",
                    Rasa = "jamnik-kundelek",
                    // Para = x
                };
            // poprawiona klasa CzłonekPary

            Console.WriteLine(
                $"{opiekun} ma pupila {opiekun.Pupil} [jest to jego zwierzątko].");
            Console.WriteLine(
                $"Natomiast {pupil} ma opiekuna {pupil.Opiekun}.");

            /*Console.WriteLine(
                $"{x.Identyfikacja} jest sparowany z {x.Para.Identyfikacja}."
                );
            Console.WriteLine(
                $"Z kolei {y.Identyfikacja} jest sparowany z {y.Para.Identyfikacja}."
                );*/
            // pomocniczy dodatek [2-2]
        }
        static void MójTest2_kolizja()
        {
            IKolizji
                figura_1 = new Koło()
                {
                    Środek = (1, 1),
                    Promień = 1
                },
                figura_3 = new Koło()
                {
                    Środek = (7, 1),
                    Promień = 1
                },
                figura_2 = new Prostokąt()
                {
                    Środek = (4, 1),
                    BokA = 2,
                    BokB = 4
                };

            /*Console.WriteLine(
                figura_1.CzyKoliduje(figura_2)
                );
            Console.WriteLine(
                figura_2.CzyKoliduje(figura_1)
                );*/

            Console.WriteLine(
                $"Czy koło figura1 koliduje z prostokątem figura2? {figura_1.CzyKoliduje(figura_2)}"
                );
            Console.WriteLine(
                $"Czy prostokąt figura2 koliduje z kołem figura1? {figura_2.CzyKoliduje(figura_1)}"
                );
            Console.WriteLine(
                $"Czy prostokąt figura2 koliduje z kołem figura3? {figura_2.CzyKoliduje(figura_3)}"
                );
            Console.WriteLine(
                $"Czy prostokąt figura2 koliduje sam ze sobą? {figura_2.CzyKoliduje(figura_2)}"
                );
            Console.WriteLine(
                $"Czy koło figura1 koliduje same ze sobą? {figura_1.CzyKoliduje(figura_1)}"
                );
            Console.WriteLine(
                $"Czy koło figura1 koliduje z kołem figura3? {figura_1.CzyKoliduje(figura_3)}"
                );
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine("\n(1) Informacje o relacji właścicieli z ich zwierzątkiem\n");
            MojTest1();

            Console.WriteLine("\n(2) Informacje o kolizjach figury 1, figury 2 oraz figury 3 [jak i samych ze sobą]\n");
            MójTest2_kolizja();*/

            // przeładowania operatorów i null'owanie struktur [i ewentualnie struktury] na ostatnie zajęcaich
            // interfejsach operacjach pomiędzy danymi na kolejnych zajęciach [+ zad 5]

            //Console.WriteLine("\n(3) Operaecje na kole, prostokącie oraz trójkątach [obliczanie pola, obwodu oraz średnicy]");
            //MójTest3_Figury();

            //Test3_5();

            //Test4();

            //Test5();

            //Test6();

            //Test7();

            //Test8();

            // Test9();

            //Test10();

            //Test11();

            //Test12();

            //Test13();

            //Test14();

            Test15();

            Console.ReadKey();
        }
        static void Test10()
        {
            // IEnumerable<> i Dictionary<>.Contains
            Dictionary<int, Wektor_Dwuwymiarowy> słownik = new Dictionary<int, Wektor_Dwuwymiarowy>()
            {
                [0] = new Wektor_Dwuwymiarowy() { X = -1, Y = 1 },
                [1] = new Wektor_Dwuwymiarowy() { X = 1, Y = -1 },
                [2] = new Wektor_Dwuwymiarowy() { X = 1, Y = 1 },
                [3] = new Wektor_Dwuwymiarowy() { X = -1, Y = -1 },
                [4] = new Wektor_Dwuwymiarowy() { X = 0, Y = 0 }
            };

            Console.WriteLine(
                $"Czy słownik zawiera v (0,1)? " +
                $"{słownik.ContainsValue(new Wektor_Dwuwymiarowy() { X = 0, Y = 1 })}"
                );
            Console.WriteLine(
                $"Czy słownik zawiera v (1,0)? " +
                $"{słownik.ContainsValue(new Wektor_Dwuwymiarowy() { X = 1, Y = 0 })}"
                );
            Console.WriteLine(
                $"Czy słownik zawiera v (0,0)? " +
                $"{słownik.ContainsValue(new Wektor_Dwuwymiarowy() { X = 0, Y = 0 })}"
                );

            // Dictionary<T1,T2>.ContainsValue(T2) akceptuje tylko typ zgodny z typem
            // wartości, a nie dowolny typ TX dla którego zdefiniowaliśmy,
            // że TW : IEquatable<TX>
            /*Console.WriteLine(
                $"Czy słownik zawiera v (0,0)? " +
                $"{słownik.ContainsValue((0,0))}"
                );*/
        }
        static void Test11()
        {
            // IEnumerable<> i Dictionary<>.Contains
            Dictionary<int, Wektor_Dwuwymiarowy> słownik = new Dictionary<int, Wektor_Dwuwymiarowy>()
            {
                [0] = new Wektor_Dwuwymiarowy() { X = -1, Y = 1 },
                [1] = new Wektor_Dwuwymiarowy() { X = 1, Y = -1 },
                [2] = new Wektor_Dwuwymiarowy() { X = 1, Y = 1 },
                [3] = new Wektor_Dwuwymiarowy() { X = -1, Y = -1 },
                [4] = new Wektor_Dwuwymiarowy() { X = 0, Y = 0 }
            };

            Console.WriteLine(
                $"Czy słownik[4] == (0,0)?" +
                $" {słownik[4] == new Wektor_Dwuwymiarowy() { X = 0, Y = 0 }}"
                );
        }
        static void Test12()
        {
            // zbiór jest sortowany pod kątem kluczy
            HashSet<Wektor_Dwuwymiarowy> zbiór = new HashSet<Wektor_Dwuwymiarowy>()
            {
                new Wektor_Dwuwymiarowy() { X = -1, Y = 1 },
                new Wektor_Dwuwymiarowy() { X = 1, Y = -1 },
                new Wektor_Dwuwymiarowy() { X = 1, Y = 1 },
                new Wektor_Dwuwymiarowy() { X = -1, Y = -1 },
                new Wektor_Dwuwymiarowy() { X = 0, Y = 0 }
            };

            Console.WriteLine(
                $"Czy zbiór zawiera v = (1,0)?" +
                $" {zbiór.Contains(new Wektor_Dwuwymiarowy() { X = 1, Y = 0 })}"
                );
            Console.WriteLine(
                $"Czy zbiór zawiera v = (0,0)?" +
                $" {zbiór.Contains(new Wektor_Dwuwymiarowy() { X = 0, Y = 0 })}"
                );
        }
        static void Test13()
        {
            // sortowan zbiór
            SortedSet<Wektor_Dwuwymiarowy> zbiór = new SortedSet<Wektor_Dwuwymiarowy>()
            {
                new Wektor_Dwuwymiarowy() { X = -1, Y = 1 },
                new Wektor_Dwuwymiarowy() { X = 1, Y = -1 },
                new Wektor_Dwuwymiarowy() { X = 1, Y = 1 },
                new Wektor_Dwuwymiarowy() { X = -1, Y = -1 },
                new Wektor_Dwuwymiarowy() { X = 0, Y = 0 }
            };
            // Sortowanie WYMAGA implementacji IEquatable<> lub osobno przekazanej
            // metody sortowania
            // IEquatable nie daje z automatu operatorów porównania <, >, <=, >=
            foreach (Wektor_Dwuwymiarowy wektor in zbiór)
                Console.WriteLine(wektor);
        }
        static void Test14()
        {
            //CzłonekPary członekPary = new CzłonekPary();
            CzłonekPary członekPary = new KońTrojański();
            Opiekun opiekun = new Opiekun()
            {
                Imię = "Janek",
                Nazwisko = "Nowak",
                // Para = (Pupil)członekPary
                // Para = członekPary
            };
            //członekPary.Para = opiekun;

            /*Console.WriteLine(
                opiekun.Pupil
                );*/
        }
        static void Test15()
        {
            Opiekun
                o1 = new Opiekun() { Imię = "Janek" },
                o2 = new Opiekun() { Imię = "Anka" }
                ;
            Pupil
                ps = new Pupil() { Imię = "Szarik", Opiekun = o1 },
                pn = new Pupil() { Imię = "Reks", Opiekun = o2 }
                ;
            Console.WriteLine(
                $"{o1} ma pupila {o1.Pupil}"
                );
            Console.WriteLine(
                $"{o2} ma pupila {o2.Pupil}"
                );
            Console.WriteLine(
                $"{ps} ma opiekuna {ps.Opiekun}"
                );
            Console.WriteLine(
                $"{pn} ma opiekuna {pn.Opiekun}"
                );

            Console.WriteLine("Zmieniam");

            Console.WriteLine(
                $"{o1} ma pupila {o1.Pupil}"
                );
            Console.WriteLine(
                $"{o2} ma pupila {o2.Pupil}"
                );
            Console.WriteLine(
                $"{ps} ma opiekuna {ps.Opiekun}"
                );
            Console.WriteLine(
                $"{pn} ma opiekuna {pn.Opiekun}"
                );
        }


        static void Test9()
        {
            // operatory
            Wektor_Dwuwymiarowy
                v = new Wektor_Dwuwymiarowy() { X = 1, Y = -1 },
                w = new Wektor_Dwuwymiarowy() { X = -10, Y = 10 },
                s = v + w,
                v2 = v * 2,
                v3 = 3 * v,
                m = -w,
                r = v - w
                ;
            Console.WriteLine(
                $"v = {v}"
                );
            Console.WriteLine(
                $"w = {w}"
                );
            Console.WriteLine(
                $"v+w = {s}"
                );
            Console.WriteLine(
                $"v*2 = {v2}"
                );
            Console.WriteLine(
                $"3*v = {v3}"
                );
            Console.WriteLine(
                $"-w = {m}"
                );
            Console.WriteLine(
                $"v-w = {r}"
                );
        }
        static void Test8()
        {
            Zwierzę
                z1 = new Zwierzę() { Imię = "Iks" },
                z2 = new Zwierzę() { Imię = "Igrek", Matka = z1 },
                z3 = new Zwierzę() { Imię = "Zet" }
                ;
            z1.dzieci.Add(z3);

            Console.WriteLine(
                $"{z2} ma matkę {z2.Matka}"
                );
            Console.WriteLine(
                $"{z3} ma matkę {z3.Matka}"
                );
            foreach (Zwierzę zwierzę in z1.dzieci.Zbiór)
                Console.WriteLine(
                    $"{z1} ma dziecko {zwierzę}"
                    );
        }
        static void Test7()
        {
            Spotkanie s = new Spotkanie()
            {
                początek = DateTime.Parse("5.05.2022 8:00"),
                koniec = DateTime.Parse("5.05.2022 11:15")
            };
            Console.WriteLine(
                s.długość
                );
        }
        static void Test6()
        {
            // opcja 1
            /*DateTime
                d1 = DateTime.Parse("4.05.2022"),
                d2 = DateTime.Now;
            TimeSpan
                s = d2 - d1;
            Console.WriteLine(s);*/
            // opcja 2
            DateTime?
                d1 = DateTime.Parse("2022.05.04"), // dla daty angielskiej
                d2 = null;
            TimeSpan?
                s
                ;
            if (d2 == null)
                d2 = DateTime.Now;

            s = d2 - d1;
            Console.WriteLine(s);
        }
        static void Test4()
        {
            // interfejst IComparable i sortowane: lista i słownik
            // 1-2
            /*SortedDictionary<int, Opiekun> słownik = new SortedDictionary<int, Opiekun>()
            {
                [0] = new Opiekun() { Imię = "Anna", Nazwisko = "Jabłońska" },
                [1] = new Opiekun() { Imię = "Adam", Nazwisko = "Wiśniewski" },
                [20] = new Opiekun() { Imię = "Julia", Nazwisko = "Sosnowska" },
                [3] = new Opiekun() { Imię = "Maciej", Nazwisko = "Dąbrowski" },
                [4] = new Opiekun() { Imię = "Maciej", Nazwisko = "Dąbrowski" },
                [5] = new Opiekun() { Imię = "Maciej", Nazwisko = "Dąbrowski" },
                [6] = new Opiekun() { Imię = "Henryk", Nazwisko = "Topolski" },
            };*/
            // 2-2
            SortedDictionary<Opiekun, int> słownik = new SortedDictionary<Opiekun, int>()
            {
                [new Opiekun() { Imię = "Anna", Nazwisko = "Jabłońska" }] = 1,
                [new Opiekun() { Imię = "Adam", Nazwisko = "Wiśniewski" }] = 2,
                [new Opiekun() { Imię = "Julia", Nazwisko = "Sosnowska" }] = 3,
                [new Opiekun() { Imię = "Maciej", Nazwisko = "Dąbrowski" }] = 4,
                [new Opiekun() { Imię = "Maciej", Nazwisko = "Dąbrowski" }] = 5,
                [new Opiekun() { Imię = "Marcin", Nazwisko = "Dąbrowski" }] = 6,
                [new Opiekun() { Imię = "Zofia", Nazwisko = "Dąbrowska" }] = 7,
                [new Opiekun() { Imię = "Henryk", Nazwisko = "Topolski" }] = 8,
            };
            // 1-2
            /*foreach(KeyValuePair<int, Opiekun> para in słownik)
                Console.WriteLine(
                    $"{para.Key}: {para.Value.Identyfikacja}"
                    );*/
            // 2-2
            // petla foreach powinna byc najczesciej stosowana ze wzgledu na to, ze jest zautomatyzowana i jest najmniejsze ryzyko bledu
            foreach (KeyValuePair<Opiekun, int> para in słownik)
                Console.WriteLine(
                    $"{para.Value}: {para.Key.Identyfikacja}"
                    );
            foreach (int wartość in słownik.Values)
                Console.WriteLine(wartość);
            foreach (Opiekun klucz in słownik.Keys)
                Console.WriteLine(
                    $"{słownik[klucz]}: {klucz}"
                    );
        }
        static void Test5()
        {
            // opcja nr 1
            /*LinkedList<Opiekun> lista = new LinkedList<Opiekun>();
            {

                lista.AddLast(new Opiekun() { Imię = "Anna", Nazwisko = "Jabłońska" }),
                lista.AddLast(new Opiekun() { Imię = "Adam", Nazwisko = "Wiśniewski" }),
                lista.AddLast(new Opiekun() { Imię = "Julia", Nazwisko = "Sosnowska" }),
                lista.AddLast(new Opiekun() { Imię = "Maciej", Nazwisko = "Dąbrowski" }),
                lista.AddLast(new Opiekun() { Imię = "Maciej", Nazwisko = "Dąbrowski" }),
                lista.AddLast(new Opiekun() { Imię = "Maciej", Nazwisko = "Dąbrowski" }),
                lista.AddLast(new Opiekun() { Imię = "Henryk", Nazwisko = "Topolski" }),
            };*/
            // opcja nr 2 
            /*LinkedList<Opiekun> lista = new LinkedList<Opiekun>();
            lista.AddLast(new Opiekun()
                { Imię = "Anna", Nazwisko = "Jabłońska" }
                );
            lista.AddLast(new Opiekun()
                { Imię = "Adam", Nazwisko = "Wiśniewski" }
                );
            lista.AddLast(new Opiekun()
                { Imię = "Julia", Nazwisko = "Sosnowska" }
                );
            lista.AddLast(new Opiekun()
                { Imię = "Maciej", Nazwisko = "Dąbrowski" }
                );
            lista.AddLast(new Opiekun()
                { Imię = "Maciej", Nazwisko = "Dąbrowski" }
                );
            lista.AddLast(new Opiekun()
                { Imię = "Maciej", Nazwisko = "Dąbrowski" }
                );
            lista.AddLast(new Opiekun()
                { Imię = "Henryk", Nazwisko = "Topolski" }
                );*/
            // opcja nr 3
            SortedList<Opiekun, int> lista = new SortedList<Opiekun, int>();
            lista.Add(new Opiekun()
            { Imię = "Anna", Nazwisko = "Jabłońska" },
                0
                );
            lista.Add(new Opiekun()
            { Imię = "Adam", Nazwisko = "Wiśniewski" },
                1
                );
            lista.Add(new Opiekun()
            { Imię = "Julia", Nazwisko = "Sosnowska" },
                2
                );
            lista.Add(new Opiekun()
            { Imię = "Maciej", Nazwisko = "Dąbrowski" },
                3
                );
            lista.Add(new Opiekun()
            { Imię = "Marcin", Nazwisko = "Dąbrowski" },
                4
                );
            /*lista.Add(new Opiekun()
                { Imię = "Maciej", Nazwisko = "Dąbrowski" },
                5
                );*/
            lista.Add(new Opiekun()
            { Imię = "Henryk", Nazwisko = "Topolski" },
                6
                );

            // opcja nr 2 [i1]
            /*foreach(Opiekun element in lista)
            {
                Console.WriteLine(
                    element.Identyfikacja);
            }*/
            // opcja nr 3
            foreach (KeyValuePair<Opiekun, int> element in lista)
            {
                Console.WriteLine(
                    $"{element.Value}: {element.Key.Identyfikacja}");
            }
        }
        static void Test3_5()
        {
            Console.WriteLine("\n(4) ///");
            SortedSet<int> zbiórLiczb = new SortedSet<int>() { 12, 3, 4, 10, 5, 11 };
            SortedSet<string> zbiórNapisów = new SortedSet<string>()
            { "Adam", "Beata", "Anna", "12", "3", "4", "10", "5", "11" };
            SortedSet<(double x, double y)> zbiórKrotek = new SortedSet<(double x, double y)>()
            {
                (0, 1),
                (1, 0),
                (-1, 0),
                (1, 1),
                (1, -1),
                (0.5, 0.5)
            };
            SortedSet<Opiekun> zbiórOpiekunów = new SortedSet<Opiekun>()
            {
                new Opiekun() { Imię = "Anna", Nazwisko = "Jabłońska" },
                new Opiekun() { Imię = "Adam", Nazwisko = "Wiśniewski" },
                new Opiekun() { Imię = "Julia", Nazwisko = "Sosnowska" },
                new Opiekun() { Imię = "Maciej", Nazwisko = "Dąbrowski" },
                new Opiekun() { Imię = "Maciej", Nazwisko = "Dąbrowski" },
                new Opiekun() { Imię = "Maciej", Nazwisko = "Dąbrowski" },
                new Opiekun() { Imię = "Henryk", Nazwisko = "Topolski" },
            };

            foreach (int element in zbiórLiczb)
                Console.WriteLine(element);
            Console.WriteLine();
            foreach (string element in zbiórNapisów)
                Console.WriteLine(element);
            Console.WriteLine();
            foreach ((double x, double y) element in zbiórKrotek)
                Console.WriteLine(element);
            Console.WriteLine();
            foreach (Opiekun element in zbiórOpiekunów)
                Console.WriteLine(element.Identyfikacja);
            Console.WriteLine();
        }
        static void MójTest3_Figury()
        {
            Figura
                k1 = new KołoF(środek: (2, 2), promień: 2);

            Figura
                p1 = new ProstokątF(bokA: 1, bokB: 2);

            Figura
                t1_r = new TrójkątF_równoboczny(bokA: 3);

            Figura
                t1_p = new TrójkątF_prostokątny(bokA: 1, bokB: 2, bokC: 3);

            Console.WriteLine("\n" + k1.Właściwości_Figury);
            Console.WriteLine("\n" + p1.Właściwości_Figury);
            Console.WriteLine("\n" + t1_r.Właściwości_Figury);
            Console.WriteLine("\n" + t1_p.Właściwości_Figury);
        }
    }
}