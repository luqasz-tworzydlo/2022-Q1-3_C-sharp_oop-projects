using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Pupil
    {
        // dotyczy => klasa Pupil [ class Pupil ] jest częścią programu z punktu nr 18 [ class Program ... static void Main ]

        public string Imię;
        internal COpiekun opiekun;
        public COpiekun Opiekun
        {
            get => opiekun;
            set
            {
                if (opiekun != null)
                    opiekun.Pupil = null;
                opiekun = value;
                if (opiekun != null)
                    opiekun.Pupil = this;
            }
        }

        public class COpiekun
        {
            public string Imię;
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
            }
        }
    }
}
