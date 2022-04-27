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

        readonly static Dictionary<char, byte> osie = new Dictionary<char, byte>()
        {
            ['x'] = 0,
            ['y'] = 1,
            ['z'] = 2,
            ['t'] = 3,
        };

        // będzie określać, ile wymiarowy jest punkt
        readonly double[] Współrzędne_Punktu; // readonly użyte w tym, celu aby nie było możliwośći modyfikacji [referencji] na zewnątrz

        public double this[byte indeks]
        {
            get
            {
                return Współrzędne_Punktu[indeks];
            }
            set
            {
                Współrzędne_Punktu[indeks] = value;
            }
        }
        public double this[char nazwa]
        {
            get
            {
                return Współrzędne_Punktu[osie[nazwa]];
            }
            set
            {
                /*if (osie[nazwa] > Współrzędne_Punktu.Length);
                throw new Exception("Punkt ma zbyt mały wymiar by używać osi: " + nazwa);*/
                Współrzędne_Punktu[osie[nazwa]] = value;
            }
        }

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
            Współrzędne_Punktu = (double[]) wsp.Clone(); // rzutowanie
        }
    }
}
