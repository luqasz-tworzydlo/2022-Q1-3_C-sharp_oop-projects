using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Koło
    {
        public (double x, double y) Środek_Koła;
        public double Promień_Koła;
        public double Obwód_Koła
        {
            get { return 2 * Math.PI * Promień_Koła * Promień_Koła;  }
        }public double Pole_Koła
        {
            get { return Math.PI * Promień_Koła * Promień_Koła;  }
        }
        public Koło(
            double promień,
            (double x, double y) środek
            )
        {
            Promień_Koła = promień;
            Środek_Koła = środek;
        }
    }
}
