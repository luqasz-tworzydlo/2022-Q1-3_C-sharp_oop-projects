using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Koło
    {
        // niniejsza klasa Koło została lekko zmodyfikowana - nadano wartość stałą, statyczną PI,
        // jak i również lekko zmieniono instrukcję public double Obwód_Koła, gdzie zmieniono Math.PI na PI

        // dotyczy => klasa Koło [ class Koło ] jest częścią programów z punktu nr 6 oraz nr 7 [ class Program ... static void Main ]
        // dotyczy => klasa Koło [ class Koło ] jest częścią programu z punktu nr 9 [ class Program ... static void Main ]

        // const jest zawsze wartością statyczną
        // const double PI = Math.PI; // pierwszy sposób użycia [ stała maski ] - dokładna wartość PI
        const double PI = 3.14; // drugi sposób, gdzie ustalamy jaka ma być dokładność dla PI
        // aby wartość PI była bardziej dokładna należy wpisać więcej wartości po przecinku


        public (double x, double y) Środek_Koła = (0,0);
        public double Promień_Koła;
        public double Obwód_Koła
        {
            get { return 2 * PI * Promień_Koła * Promień_Koła;  }
        }
        public double Pole_Koła
        {
            get { return PI * Promień_Koła * Promień_Koła;  }
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
