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
        new public string Gatunek // ustawienie - zwrócenie bazowego gatunku
            // poprzez niniejszą instrukcję nie można ustawić kota jako gatunku psa
        {
            get { return base.Gatunek; } // trzeba użyć base, aby wracało do bazy
            set
            {
                /*throw new Exception(
                    $"Nie można typowi Pies zmienić gatunku ({value})");*/
            }
        }
        // poniżej sposób nr 2 - użycie konstruktora bezargumentowego [lepsze]
        public Pies()
        {
            base.Gatunek = "pies";
        }
    }
}
