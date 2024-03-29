﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Zwierzę
    {
        // dotyczy => klasa Zwierzę [ class Zwierzę ] jest częścią programu z punktu nr 16 [ class Program ... static void Main ]
        // dotyczy => klasa Zwierzę [ class Zwierzę ] jest częścią programu z punktu nr 17 [ class Program ... static void Main ]

        public Zwierzę
            para,
            matka,
            ojciec
            ;
        HashSet<Zwierzę> dzieci = new HashSet<Zwierzę>();
        public Zwierzę Para
        {
            get => para;
            set
            {
                if (para != null)      // => niniejsza instrukcja
                    para.para = null;  // daje nam referencję zwrotną [1-2]
                para = value;
                if (para != null)      // => niniejsza instrukcja
                    para.para = this;  // daje nam referencję zwrotną [2-2]
            }
        }
        public HashSet<Zwierzę> Dzieci
        {
            get => new HashSet<Zwierzę>(dzieci);
        }
        public Zwierzę Matka
        {
            get => matka;
            set
            {
                if (matka != null)
                    matka.dzieci.Remove(this);
                matka = value;
                if (matka != null)
                    matka.dzieci.Add(this);
            }
        }
        public Zwierzę Ojciec
        {
            get => ojciec;
            set
            {
                if (ojciec != null)
                    ojciec.dzieci.Remove(this);
                ojciec = value;
                if (ojciec != null)
                    ojciec.dzieci.Add(this);
            }
        }


        public byte Wiek;
        public string
            Imię;

        // sposób nr 1 [dotyczy sposobu nr 3 z klasy pies]
        /*virtual public string Gatunek
        {
            get; set;
        }*/

        // sposób nr 2 [dotyczy sposobu nr 3 z klasy pies]
        /*string gatunek;
        virtual public string Gatunek
        {
            get { return gatunek; }
            set { gatunek = value; }
        }*/
        // sposób nr 3 [dotyczy sposobu nr 4 z klasy pies]
        /*internal string gatunek;*/
        /*protected string gatunek; // internal oraz protected => te modyfikatory ograniczają nas do klas pochodnych [można je używać w pochodnych, ale nie na zewnątrz] 
        virtual public string Gatunek
        {
            get { return gatunek; }
            set { gatunek = value; }
        }*/

        string gatunek;
        virtual public string Gatunek {
            get => gatunek;
            set => gatunek = value;
        } // funkcja strzałkowa

        public Zwierzę(
            string imię,
            string gatunek,
            byte wiek)
        {
            Imię = imię;
            // Gatunek = gatunek;
            // this.Gatunek = gatunek;
            this.gatunek = gatunek; // nowe ustawienie strzałkowe po dodaniu funkcji strzałkowej
            Wiek = wiek;
        }

        public override string ToString() // automatyczna konwersja na stringa, gdy chcemy użyć obiekt zamiast stringa ( do przeładowania )
        {
            return $"{Gatunek} {Imię}, {Wiek} lat(a)";
        }
    }
}
