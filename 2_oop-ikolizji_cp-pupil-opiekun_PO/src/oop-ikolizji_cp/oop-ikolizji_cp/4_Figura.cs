using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Figura
    {
        double
            środek_X,
            środek_Y;

        double Pole { get; }
        double Obwód { get; }
        double Średnica { get; }
        abstract public string Właściwości_Figury
        {
            get;
        }

    }
    class ProstokątF : Figura
    {
        public double
            BokA,
            BokB;

        // poniżej jest konstruktor
        public ProstokątF(
            double bokA,
            double bokB)
        {
            BokA = bokA;
            BokB = bokB;
        }

        public double Średnica
        {
            get => Math.Sqrt(
                BokA * BokA + BokB * BokB
                );
        }
        public double Obwód
        {
            get { return 2 * BokA + 2 * BokB; }
        }
        public double Pole
        {
            get { return BokA * BokB; }
        }
        public override string Właściwości_Figury
        {
            get { return $"=> Pole prostokątu wynosi: {Pole} \n=> Obwód prostokątu wynosi: {Obwód} \n=> Średnica prostokątu wynosi: {Średnica}"; }
        }
    }
    class KołoF : Figura
    {
        public double Promień;
        public (double x, double y) Środek { get; set; }

        // poniżej jest konstruktor
        public KołoF(
            double promień,
            (double x, double y) środek
            )
        {
            Promień = promień;
            Środek = środek;
        }

        public double Średnica
        {
            get => 2 * Promień;
        }
        const double PI = 3.14;
        public double Obwód
        {
            get { return 2 * PI * Promień * Promień; }
        }
        public double Pole
        {
            get { return PI * Promień * Promień; }
        }

        public override string Właściwości_Figury
        {
            get { return $"=> Pole koła wynosi: {Pole} \n=> Obwód koła wynosi: {Obwód} \n=> Średnica koła wynosi: {Średnica}"; }
        }
        /*public override string ToString()
        {
            return $"=> Pole koła wynosi: {Pole} \n=> Obwód koła wynosi: {Obwód} \n=> Średnica koła wynosi: {Średnica}";
        }*/
    }
    class TrójkątF_równoboczny : Figura
    {
        public double
            BokA;

        // poniżej jest konstruktor
        public TrójkątF_równoboczny(
            double bokA)
        {
            BokA = bokA;
        }

        public double Średnica
        {
            get { return (BokA * Math.Sqrt(3) / 2); }
        }
        public double Pole
        {
            get { return (BokA * Math.Sqrt(3) / 4); }
        }
        public double Obwód
        {
            get { return BokA + BokA + BokA; }
        }
        public override string Właściwości_Figury
        {
            get { return $"=> Pole trójkąta równobocznego wynosi: {Pole} \n=> Obwód trójkąta równobocznego wynosi: {Obwód} \n=> Średnica [wysokość] trójkąta równobocznego wynosi: {Średnica}"; }
        }
    }
    class TrójkątF_prostokątny : Figura
    {
        public double
            BokA,
            BokB,
            BokC;

        // poniżej jest konstruktor
        public TrójkątF_prostokątny(
            double bokA,
            double bokB,
            double bokC)
        {
            BokA = bokA;
            BokB = bokB;
            BokC = bokC;
        }

        public double Średnica
        {
            get { return BokC; }
        }
        public double Pole
        {
            get { return (BokA * BokB / 2); }
        }
        public double Obwód
        {
            get { return BokA + BokB + BokC; }
        }
        public override string Właściwości_Figury
        {
            get { return $"=> Pole trójkąta prostokątnego wynosi: {Pole} \n=> Obwód trójkąta prostokątnego wynosi: {Obwód} \n=> Średnica [wysokość] trójkąta prostokątnego wynosi: {Średnica}"; }
        }
    }
}
