using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Opiekun : Pupil.COpiekun
    {
        // dotyczy => klasa Opiekun (z dziedziczeniem instrukcji COpiekun z klasy Pupil) [ class Opiekun : Pupil.COpiekun ] jest częścią programu z punktu nr 18 [ class Program ... static void Main ]

        /*public string Imię;
        Pupil pupil;
        public Pupil Pupil
        {
            get => pupil;
            set
            {
                if (pupil != null)
                    pupil.opiekun = null;
                pupil = value;
                if (pupil != null)
                    pupil.opiekun = this;
            }
        }*/
    }
}
