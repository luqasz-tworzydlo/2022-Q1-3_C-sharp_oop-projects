using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Istota
    {
        public string Imię;
        public uint? Wiek;
        virtual public string Gatunek { get; set; }
        public override string ToString()
        {
            return $"{Imię}, {Gatunek}, {Wiek}";
        }
    }
}
