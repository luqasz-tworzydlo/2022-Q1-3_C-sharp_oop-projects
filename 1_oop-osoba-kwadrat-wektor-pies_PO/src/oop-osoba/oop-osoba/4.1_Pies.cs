using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Pies : Zwierzę
    {
        // dotyczy => klasa Pies (z dziedziczeniem z klasy Zwierzę) [ class Pies : Zwierzę ] jest częścią programu z punktu nr 16 [ class Program ... static void Main ]

        public string
            Rasa;
        /*new readonly public string Gatunek = "pies";*/ // sposób nr 1 - konstruktor bezwarunkowy

        // poniżej sposób nr 2.1 [lepsze]
        /*new public string Gatunek // ustawienie - zwrócenie bazowego gatunku
            // poprzez niniejszą instrukcję nie można ustawić kota jako gatunku psa
        {
            get { return base.Gatunek; } // trzeba użyć base, aby wracało do bazy
            set
            {
               throw new Exception(
                    $"Nie można typowi Pies zmienić gatunku ({value})");
            }
        }
        // poniżej sposób nr 2.2 - użycie konstruktora bezargumentowego [lepsze]
        public Pies()
        {
            base.Gatunek = "pies";
        }*/

        // poniżej jest sposób nr 3.1
        /*override public string Gatunek // ustawienie - zwrócenie bazowego gatunku
            // poprzez niniejszą instrukcję nie można ustawić kota jako gatunku psa,
            // zarówno przy wykorzystaniu klasy Pies, jak i klasy Zwierzę
        {
            get { return gatunek; } // trzeba użyć base, aby wracało do bazy
            set
            {
                throw new Exception(
                    $"Nie można typowi Pies zmienić gatunku ({value})");
            }
        }
        // poniżej jest sposób nr 3.2
        public Pies()
        {
            gatunek = "pies";
        }*/
        // poniżej jest sposób nr 4.1
        /*override public string Gatunek // ustawienie - zwrócenie bazowego gatunku
            // poprzez niniejszą instrukcję nie można ustawić kota jako gatunku psa,
            // zarówno przy wykorzystaniu klasy Pies, jak i klasy Zwierzę
        {
            get { return gatunek; } // trzeba użyć base, aby wracało do bazy
            set
            {
                throw new Exception(
                    $"Nie można typowi Pies zmienić gatunku ({value})");
            }
        }
        // poniżej jest sposób nr 4.2
        public Pies()
        {
            gatunek = "pies";
        }*/

        // sposób nr 5.1
        override public string Gatunek // ustawienie - zwrócenie bazowego gatunku
                                  // poprzez niniejszą instrukcję nie można ustawić kota jako gatunku psa
        {
            get { return base.Gatunek; } // trzeba użyć base, aby wracało do bazy
            set
            {
                throw new Exception(
                     $"Nie można typowi Pies zmienić gatunku ({value})");
            }
        }
        // poniżej sposób nr 5.2
        public Pies(
            string imię,
            string rasa,
            byte wiek
            ) : base(imię,"pies",wiek)
        {
            Rasa = rasa;
        }
        public override string ToString()
        {
            return $"{Rasa} {Imię}, {Wiek} lat(a)";
        }
    }
}
