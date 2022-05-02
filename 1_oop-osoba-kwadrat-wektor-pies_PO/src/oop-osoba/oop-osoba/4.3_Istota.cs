using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Istota
    {
        // dotyczy => klasa Istota [ class Istota ] jest częścią programu z punktu nr 17 [ class Program ... static void Main ]

        public string Imię;
        public uint? Wiek;
        virtual public string Gatunek { get; set; }
        public override string ToString()
        {
            return $"{Imię}, {Gatunek}, {Wiek}";
        }
    }
}
