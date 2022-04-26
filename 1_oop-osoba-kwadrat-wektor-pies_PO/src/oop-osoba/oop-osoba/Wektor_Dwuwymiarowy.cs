﻿using System;
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
        /*public double IloczynSklarany(Wektor_Dwuwymiarowy that)
        {
            return this.X * that.X + this.Y * that.Y;
        }*/
        static public double IloczynSkalarny(Wektor_Dwuwymiarowy v, Wektor_Dwuwymiarowy w)
        {
            return v.X * w.X + v.Y * w.Y;
        }
        public double Długość
        {
            get { return Math.Sqrt(IloczynSkalarny(this, this)); }
        }
        /*public double Długość
        {
            get { return Math.Sqrt(X * X + Y * Y); }
        }*/
    }
}
