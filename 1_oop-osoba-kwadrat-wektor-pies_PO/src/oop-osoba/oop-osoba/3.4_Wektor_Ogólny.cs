using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Wektor_Ogólny
    {
        // dotyczy => klasa Wektor_Ogólny [ class Wektor_Ogólny ] jest częścią programu z punktu nr 15 [ class Program ... static void Main ]

        readonly double[] współrzędne;
        public double this[byte indeks]
        {
            get { return współrzędne[indeks]; }
            set
            {
                switch (value)
                {
                    case double.NaN:
                    case double.PositiveInfinity:
                    case double.NegativeInfinity:
                        throw new Exception(
                            $"Niepoprawna wartość {value} na współrzędnej {indeks} wektora");
                    default:
                        współrzędne[indeks] = value;
                        break;
                }
            }
        }
        public byte Wymiar
        {
            get { return (byte)współrzędne.Length; }
        }
        public double Długość
        {
            get
            {
                return Math.Sqrt(
                    IloczynSkalarny(this, this)
                    );
            }
        }
        public Wektor_Ogólny(byte wymiar)
        {
            współrzędne = new double[wymiar];
        }
        public Wektor_Ogólny(params double[] współrzędne)
        {
            this.współrzędne = (double[])współrzędne.Clone();
        }
        public static double IloczynSkalarny(
            Wektor_Ogólny v,
            Wektor_Ogólny w)
        {
            if (v.Wymiar != w.Wymiar)
                return double.NaN;
            double suma = 0;
            for (byte indeks = 0; indeks < v.Wymiar; indeks++)
                suma += v.współrzędne[indeks] * w.współrzędne[indeks];
                // suma += v[indeks] * w[indeks];
            return suma;
        }
        public static Wektor_Ogólny Suma(
            Wektor_Ogólny v,
            Wektor_Ogólny w)
        {
            if (v.Wymiar != w.Wymiar)
                throw new Exception(
                    $"Niezgodne wymiary sumowanych wektorów {v.Wymiar} i {w.Wymiar}");

            Wektor_Ogólny nowy = new Wektor_Ogólny(v.Wymiar);
            for (byte indeks = 0; indeks < v.Wymiar; indeks++)
                nowy.współrzędne[indeks] = v.współrzędne[indeks] + w.współrzędne[indeks];
                // nowy[indeks] = v[indeks] + w[indeks];

            return nowy;
        }
    }
}
