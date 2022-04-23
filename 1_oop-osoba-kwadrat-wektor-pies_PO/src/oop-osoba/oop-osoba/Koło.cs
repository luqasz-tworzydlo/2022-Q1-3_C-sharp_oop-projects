using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Koło
    {
        // dotyczy => klasa Koło [ class Koło ] jest częścią programów z punktu nr 6 oraz nr 7 [ class Program ... static void Main ]
        public (double x, double y) Środek_Koła = (0,0);
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
            // jest to nasz konstruktor
        }
        public bool CzyWKole(double x, double y)
        {
            double
                dx = x - Środek_Koła.x,
                dy = y - Środek_Koła.y,
                odległość = Math.Sqrt(dx * dx + dy * dy)
                ;
            return odległość < Promień_Koła;
        }
        public bool CzyNaOkręgu(double x, double y)
        {
            double
                dx = x - Środek_Koła.x,
                dy = y - Środek_Koła.y,
                odległość = Math.Sqrt(dx * dx + dy * dy)
                ;
            // return odległość == Promień; // dla próby
            return odległość - Promień_Koła < double.Epsilon;
        }
    }
}
