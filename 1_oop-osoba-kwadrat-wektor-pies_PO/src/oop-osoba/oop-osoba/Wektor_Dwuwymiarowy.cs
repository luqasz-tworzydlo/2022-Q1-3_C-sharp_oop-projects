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
        /*public void Pomnóż(double c)
        {
            X *= c;
            Y *= c;
        }*/
        /*public double IloczynSklarany(Wektor_Dwuwymiarowy that)
        {
            return this.X * that.X + this.Y * that.Y;
        }*/
        static public double IloczynSkalarny(Wektor_Dwuwymiarowy v, Wektor_Dwuwymiarowy w)
        {
            return v.X * w.X + v.Y * w.Y;
        }
        public double DługośćWektora
        {
            get { return Math.Sqrt(IloczynSkalarny(this, this)); }
        }
        /*public double Długość
        {
            get { return Math.Sqrt(X * X + Y * Y); }
        }*/
        /*public void DodajWektor (Wektor_Dwuwymiarowy that)
        {
            // dodawanie do siebie wektorów [ nadpisuje ]
            this.X += that.X;
            this.Y += that.Y;
        }*/
        public void DodajWektor(params Wektor_Dwuwymiarowy[] thats)
        {
            foreach (Wektor_Dwuwymiarowy that in thats)
            {
                this.X += that.X;
                this.Y += that.Y;
            }
        }
        public Wektor_Dwuwymiarowy DodajWektor(Wektor_Dwuwymiarowy that)
        {
            // łańcuchowe wywoływanie metody
            this.X += that.X;
            this.Y += that.Y;
            return this;
        }
        /*static public Wektor_Dwuwymiarowy DodajWektor (Wektor_Dwuwymiarowy v, Wektor_Dwuwymiarowy w)
        {
            // dodawanie do siebie wektorów [ tworzy nową instancję, nowy wektor ]
            return new Wektor_Dwuwymiarowy()
            {
                X = v.X + w.X,
                Y = v.Y + w.Y
            };
        }*/
        static public Wektor_Dwuwymiarowy Suma_Wektorów (params Wektor_Dwuwymiarowy[] wektory)
        {
            double
                x = 0,
                y = 0;
            foreach(Wektor_Dwuwymiarowy wektor in wektory)
            {
                x += wektor.X;
                y += wektor.Y;
            }
            return new Wektor_Dwuwymiarowy()
            {
                X = x,
                Y = y
            };
        }
    }
}
