using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Zwierzę
    {
        // dotyczy => klasa Zwierzę [ class Zwierzę ] jest częścią programu z punktu nr 16 [ class Program ... static void Main ]

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
