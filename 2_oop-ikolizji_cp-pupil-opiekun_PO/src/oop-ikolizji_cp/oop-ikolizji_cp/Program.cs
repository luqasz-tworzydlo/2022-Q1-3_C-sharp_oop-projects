using System;

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
                    Para = x
                };
            // poprawiona klasa CzłonekPary

            Console.WriteLine(
                $"{opiekun} ma pupila {opiekun.Pupil} [jest to jego zwierzątko].");
            Console.WriteLine(
                $"Natomiast {pupil} ma opiekuna {pupil.Opiekun}.");

            Console.WriteLine(
                $"{x.Identyfikacja} jest sparowany z {x.Para.Identyfikacja}."
                );
            Console.WriteLine(
                $"Z kolei {y.Identyfikacja} jest sparowany z {y.Para.Identyfikacja}."
                );
            // pomocniczy dodatek [2-2]
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n(1) Informacje o relacji właścicieli z ich zwierzątkiem\n");
            MojTest1();

            Console.WriteLine("\n(2) Informacje o kolizjach figury 1, figury 2 oraz figury 3 [jak i samych ze sobą]\n");
            MójTest2_kolizja();

            // przeładowania operatorów i null'owanie struktur [i ewentualnie struktury] na ostatnie zajęcaich
            // interfejsach operacjach pomiędzy danymi na kolejnych zajęciach [+ zad 5]

            Console.ReadKey();
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
    }
}
