using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Wektor_Stereo
    {
        // dotyczy => klasa Wektor_Stereo [ class Wektor_Stereo ] jest częścią programu z punktu nr 14 [ class Program ... static void Main ]

        public double
            X,
            Y,
            Z;
        public double Długość
        {
            get
            {
                return Math.Sqrt(
                    IloczynSkalarny(this, this)
                    );
            }
        }
        public Wektor_Stereo(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static double IloczynSkalarny(
            Wektor_Stereo v,
            Wektor_Stereo w)
        {
            return v.X * w.X + v.Y * w.Y + v.Z * w.Z;
        }
        public static Wektor_Stereo Suma(
            Wektor_Stereo v,
            Wektor_Stereo w)
        {
            return new Wektor_Stereo(
                x: v.X + w.X,
                y: v.Y + w.Y,
                z: v.Z + w.Z
                );
        }
    }
}
