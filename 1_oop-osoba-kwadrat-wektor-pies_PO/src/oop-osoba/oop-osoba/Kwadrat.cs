using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Kwadrat
    {
        // dotyczy => klasa Kwadrat [ class Kwadrat ] jest częścią programu z punktu nr 10 [ class Program ... static void Main ]

        static double
            pierwiastekZDwóch = Math.Sqrt(1.41),
            półPierwiastkaZDwóch = pierwiastekZDwóch/2;

        double
            bok,
            przekątna,
            obwód,
            pole;

        ////////////////////////////////////////////////////////////////////////////
        ///!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!///
        /// /// /// /// !!! PONIŻSZY KONSTRUKTOR JEST DO POPRAWY !!! /// /// /// ///
        ///!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!///
        ////////////////////////////////////////////////////////////////////////////
        public Kwadrat(
            double bok1,
            double przekątna1,
            double obwód1,
            double pole1
            )
        {
            bok = bok1;
            przekątna = przekątna1;
            obwód = obwód1;
            pole = pole1;
            // jest to nasz konstruktor
        }
        ////////////////////////////////////////////////////////////////////////////
        ///!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!///
        ////////////////////////////////////////////////////////////////////////////

        /*public double Bok
        {
            get { return bok; }
            set { bok = value; }
        }*/
        public double Bok
        {
            get { return bok; }
            set
            {
                bok = value;
                przekątna = bok * pierwiastekZDwóch;
                obwód = bok * 4;
                pole = bok * bok;
            }
        }

        /*public double Przekątna
        {
            get { return bok * pierwiastekZDwóch; }
            set { bok = value * półPierwiastkaZDwóch; }
        }*/
        public double Przekątna
        {
            get { return przekątna; }
            set
            {
                przekątna = value;
                bok = przekątna * półPierwiastkaZDwóch;
                obwód = bok * 4;
                pole = przekątna * przekątna / 2;
            }
        }
        public double Obwód
        {
            get { return obwód; }
            set
            {
                obwód = value;
                bok = obwód / 4;
                przekątna = bok * pierwiastekZDwóch;
                pole = bok * bok;
            }
        }
        public double Pole
        {
            get { return pole; }
            set
            {
                pole = value;
                bok = Math.Sqrt(pole); // sposób nr 1
                // bok = bok * pierwiastekZDwóch; // sposób nr 2
                przekątna = Math.Sqrt(2 * pole); // sposób nr 1
                // przekątna = bok * półPierwiastkaZDwóch; // sposób nr 2
                // przekątna = pierwiastekZDwóch * Math.Sqrt(pole); // sposób nr 3
                obwód = 4 * bok;
            }
        }
    }
}
