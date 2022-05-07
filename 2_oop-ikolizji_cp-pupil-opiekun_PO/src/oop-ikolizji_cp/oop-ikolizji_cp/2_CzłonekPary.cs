using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class CzłonekPary // można użyć tej klasy instancjowach, ale może służyć jako typ referencji, zmiennej [ale nie może użyć jako typ instancji]
    {
        protected CzłonekPary para; // pole
        // protected pozwala na dostęp klasom dziedziczącym
        // private nie pozwala na dostęp
        virtual public CzłonekPary Para // właściwość
        {
            get { return para; }
            set
            {
                if (para != null)
                    para.para = null;
                para = value;
                if (para != null)
                    para.para = this;
            }
        }
        /*abstract public string Identyfikacja();*/ // nasza metoda
        abstract public string Identyfikacja // nasza właściwość => może to być potrzebne, jeśli oczekujemy, aby ta własność miała dostęp do klasy, która nie jest zdefiniowana
        {
            get;
        }
    }
    class Pupil : CzłonekPary
    {
        public override CzłonekPary Para
        {
            get => base.Para;
            set
            {
                if (value is Opiekun)
                    base.Para = value;
                else
                    throw new Exception(
                        "Nieprawidłowy typ - Parą dla Pupil powinien być Opiekun"
                        );
            }
            // { get => base.Para; set => base.Para = value; } // autouzupełnianie
        }
        public Opiekun Opiekun
        {
            get { return (Opiekun)Para; }
            set { Para = value; }
        }
        public string
            Imię,
            Gatunek,
            Rasa;
        // poniżej zdefyniowana identyfikacja
        public override string Identyfikacja
        {
            get { return $"{Gatunek} {Rasa} {Imię}"; }
        }
        public override string ToString()
        {
            return Imię;
        }
    }
    // virtual musi mieć zaimplementowaną metodą, zaś abstract deleguje implementację na klasy dziedziczące
    class Opiekun :
        CzłonekPary,
        IComparable<Opiekun>
    {
        public override CzłonekPary Para
        {
            get => base.Para;
            set
            {
                if (value is Pupil)
                    base.Para = value;
                else
                    throw new Exception(
                        "Nieprawidłowy typ - Parą dla Opiekun powinien być Pupil"
                        );
            }
        }
        public Pupil Pupil
        {
            get { return (Pupil)Para; }
            set { Para = value; }
        }
        public string
            Imię,
            Nazwisko;
        public override string Identyfikacja
        {
            get { return $"{Imię} {Nazwisko}"; }
        }
        public override string ToString()
        {
            return Imię;
        }
        public int CompareTo(Opiekun that)
        {
            int wynik;
            wynik = this.Nazwisko.CompareTo(that.Nazwisko);
            if (wynik == 0)
                wynik = this.Imię.CompareTo(that.Imię);
            return wynik;
        }
    }
}