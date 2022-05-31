using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Wektor_Dwuwymiarowy :
        IEquatable<Wektor_Dwuwymiarowy>,
        IEquatable<(double x, double y)>,
        IComparable<Wektor_Dwuwymiarowy>
    {
        public double
            X = 0,
            Y = 0;


        /*public int CompareTo(Wektor_Dwuwymiarowy other)
        {
            throw new NotImplementedException();
        }*/
        public int CompareTo(Wektor_Dwuwymiarowy that)
        {
            int pierwszePorównanie = this.X.CompareTo(that.X);
            if (pierwszePorównanie != 0)
                return pierwszePorównanie;
            else
                return this.Y.CompareTo(that.Y);
        }

        public override int GetHashCode()
        {
            return (X, Y).GetHashCode();
        }
        public override bool Equals(object that)
        {
            return
                that is Wektor_Dwuwymiarowy
                &&
                this.Equals((Wektor_Dwuwymiarowy)that);
        }

        public bool Equals(Wektor_Dwuwymiarowy that)
        {
            return this.X == that.X && this.Y == that.Y; // sposób nr 1
            // return this.X.Equals(that.X) && this.Y.Equals(that.Y); // sposób nr 2
            // return (this.Y, this.Y) == (that.X, that.Y); // sposób nr 3 => próba spakowania w krotkę
        }
        public bool Equals((double x, double y) that)
        {
            return this.X == that.x && this.Y == that.y; // sposób nr 1
            // return this.X.Equals(that.X) && this.Y.Equals(that.Y); // sposób nr 2
            // return (this.Y, this.Y) == (that.X, that.Y); // sposób nr 3 => próba spakowania w krotkę
        }
        static public bool operator ==(Wektor_Dwuwymiarowy v, Wektor_Dwuwymiarowy w)
        {
            return v.Equals(w);
        }
        static public bool operator !=(Wektor_Dwuwymiarowy v, Wektor_Dwuwymiarowy w)
        {
            return !v.Equals(w);
        }

        static public Wektor_Dwuwymiarowy operator +(Wektor_Dwuwymiarowy v, Wektor_Dwuwymiarowy w)
        {
            return new Wektor_Dwuwymiarowy()
            {
                X = v.X + w.X,
                Y = v.Y + w.Y
            };
        }
        // mnożenie przez skalę
        static public Wektor_Dwuwymiarowy operator *(Wektor_Dwuwymiarowy v, double s)
        {
            return new Wektor_Dwuwymiarowy()
            {
                X = v.X * s,
                Y = v.Y * s
            };
        }
        static public Wektor_Dwuwymiarowy operator *(double s, Wektor_Dwuwymiarowy v)
        {
            return v * s;
        }
        static public Wektor_Dwuwymiarowy operator -(Wektor_Dwuwymiarowy wektor)
        {
            // return -1 * wektor;
            return wektor * (-1);
        }
        static public Wektor_Dwuwymiarowy operator -(Wektor_Dwuwymiarowy v, Wektor_Dwuwymiarowy w)
        {
            return v + -w;
        }

        public override string ToString()
        {
            return $"({X};{Y}";
        }

    }
}
