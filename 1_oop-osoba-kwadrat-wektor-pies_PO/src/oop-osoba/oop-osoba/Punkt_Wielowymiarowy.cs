using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Punkt_Wielowymiarowy
    {
        // dotyczy => klasa Punkt_Wielowymiarowy [ class Punkt_Wielowymiarowy ] jest częścią programu z punktu nr 13 [ class Program ... static void Main ]

        // będzie określać, ile wymiarowy jest punkt
        readonly double[] Współrzędne_Punktu; // readonly użyte w tym, celu aby nie było możliwośći modyfikacji [referencji] na zewnątrz
        public string Format_Punktu
        {
            get
            {
                /*string out_wyjście = "(" + String.Join(',', Współrzędne_Punktu) + ")";*/ // błąd w znakach
                // string out_wyjście = "(" + String.Join(",", Współrzędne_Punktu) + ")"; // prawidłowa instrukcja
                return "(" + String.Join(",", Współrzędne_Punktu) + ")"; // prawidłowa i skrócona instrukcja
            }
        }
        public Punkt_Wielowymiarowy(byte wymiar)
        {
            Współrzędne_Punktu = new double[wymiar];
        }
        public Punkt_Wielowymiarowy(params double [] wsp)
        {
            Współrzędne_Punktu = wsp;
        }
    }
}
