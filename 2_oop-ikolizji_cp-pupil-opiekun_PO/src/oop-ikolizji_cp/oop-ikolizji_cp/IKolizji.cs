using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    interface IKolizji
    {
        double Średnica { get; }
        (double x, double y) Środek { get; set; }
        bool CzyKoliduje(IKolizji that);
    }
    class Koło : IKolizji
    {
        public double Promień;
        public double Średnica
        {
            get => 2 * Promień;
        }
        public (double x, double y) Środek { get; set; }
        /*te implementacje mogą nie być poprawne z punktu widzenia geometrii*/
        public bool CzyKoliduje(IKolizji that)
        {
            double
                delta_x = this.Środek.x - that.Środek.x,
                delta_y = this.Środek.y - that.Środek.y,
                odległośćŚrodków = Math.Sqrt(delta_x * delta_x + delta_y * delta_y);
            return odległośćŚrodków < (this.Średnica + that.Średnica) / 2;
        }
    }
    class Prostokąt : IKolizji
    {
        public double
            BokA,
            BokB;
        public double Średnica
        {
            get => Math.Sqrt(
                BokA * BokA + BokB * BokB
                );
        }
        public (double x, double y) Środek { get; set; }
        public bool CzyKoliduje(IKolizji that)
        {
            double
                delta_x = this.Środek.x - that.Środek.x,
                delta_y = this.Środek.y - that.Środek.y,
                odległośćŚrodków = Math.Sqrt(delta_x * delta_x + delta_y * delta_y);
            return odległośćŚrodków < (this.Średnica + that.Średnica) / 2;
        }
    }
}
