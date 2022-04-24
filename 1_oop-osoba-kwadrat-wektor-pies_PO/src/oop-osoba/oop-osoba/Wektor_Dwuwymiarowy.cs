using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Wektor_Dwuwymiarowy
    {
        public double
            X = 0,
            Y = 0;
        public void Pomnóż(double c)
        {
            X *= c;
            Y *= c;
        }
    }
}
