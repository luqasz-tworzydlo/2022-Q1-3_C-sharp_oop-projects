using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Zwierzę
    {
        public class ZbiórDzieci : ISet<Zwierzę>
        {
            // zbiór sortowany
            Zwierzę matka;
            HashSet<Zwierzę> zbiór = new HashSet<Zwierzę>();
            public HashSet<Zwierzę> Zbiór
            {
                get => new HashSet<Zwierzę>(zbiór);
            }

            public int Count => ((ICollection<Zwierzę>)Zbiór).Count;

            public bool IsReadOnly => ((ICollection<Zwierzę>)Zbiór).IsReadOnly;

            public /*bool*/ void Add(Zwierzę nowy)
            {
                if (zbiór.Contains(nowy))
                    ;
                //return false;
                if (nowy.matka != null)
                    /*nowy.matka = null;*/
                    nowy.matka.dzieci.Remove(nowy);
                zbiór.Add(nowy);
                nowy.matka = matka;
                //return true;
            }
            public bool Remove(Zwierzę zwierzę)
            {
                if (zbiór.Contains(zwierzę))
                {
                    zwierzę.matka = null;
                    zbiór.Remove(zwierzę);
                    return true;
                }
                else
                    return false;
            }
            public bool Contains(Zwierzę zwierzę)
            {
                return zbiór.Contains(zwierzę);
            }

            bool ISet<Zwierzę>.Add(Zwierzę item)
            {
                return ((ISet<Zwierzę>)Zbiór).Add(item);
            }

            public void UnionWith(IEnumerable<Zwierzę> other)
            {
                ((ISet<Zwierzę>)Zbiór).UnionWith(other);
            }

            public void IntersectWith(IEnumerable<Zwierzę> other)
            {
                ((ISet<Zwierzę>)Zbiór).IntersectWith(other);
            }

            public void ExceptWith(IEnumerable<Zwierzę> other)
            {
                ((ISet<Zwierzę>)Zbiór).ExceptWith(other);
            }

            public void SymmetricExceptWith(IEnumerable<Zwierzę> other)
            {
                ((ISet<Zwierzę>)Zbiór).SymmetricExceptWith(other);
            }

            public bool IsSubsetOf(IEnumerable<Zwierzę> other)
            {
                return ((ISet<Zwierzę>)Zbiór).IsSubsetOf(other);
            }

            public bool IsSupersetOf(IEnumerable<Zwierzę> other)
            {
                return ((ISet<Zwierzę>)Zbiór).IsSupersetOf(other);
            }

            public bool IsProperSupersetOf(IEnumerable<Zwierzę> other)
            {
                return ((ISet<Zwierzę>)Zbiór).IsProperSupersetOf(other);
            }

            public bool IsProperSubsetOf(IEnumerable<Zwierzę> other)
            {
                return ((ISet<Zwierzę>)Zbiór).IsProperSubsetOf(other);
            }

            public bool Overlaps(IEnumerable<Zwierzę> other)
            {
                return ((ISet<Zwierzę>)Zbiór).Overlaps(other);
            }

            public bool SetEquals(IEnumerable<Zwierzę> other)
            {
                return ((ISet<Zwierzę>)Zbiór).SetEquals(other);
            }

            public void Clear()
            {
                ((ICollection<Zwierzę>)Zbiór).Clear();
            }

            public void CopyTo(Zwierzę[] array, int arrayIndex)
            {
                ((ICollection<Zwierzę>)Zbiór).CopyTo(array, arrayIndex);
            }

            public IEnumerator<Zwierzę> GetEnumerator()
            {
                return ((IEnumerable<Zwierzę>)Zbiór).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)Zbiór).GetEnumerator();
            }

            public ZbiórDzieci(Zwierzę matka)
            {
                this.matka = matka;
            }
        }
        public Zwierzę()
        {
            dzieci = new ZbiórDzieci(this);
        }

        public Zwierzę
            para,
            matka
            ;
        public readonly ZbiórDzieci dzieci;
        public Zwierzę Para
        {
            get => para;
            set
            {
                if (para != null)      // => niniejsza instrukcja
                    para.para = null;  // daje nam referencję zwrotną [1-2]
                para = value;
                if (para != null)      // => niniejsza instrukcja
                    para.para = this;  // daje nam referencję zwrotną [2-2]
            }
        }
        public Zwierzę Matka
        {
            get => matka;
            set
            {
                if (matka != null)
                    matka.dzieci.Remove(this);
                matka = value;
                if (matka != null)
                    matka.dzieci.Add(this);
            }
        }

        public byte Wiek;
        public string
            Imię;

        string gatunek;
        virtual public string Gatunek
        {
            get => gatunek;
            set => gatunek = value;
        } // funkcja strzałkowa

        public Zwierzę(
            string imię,
            string gatunek,
            byte wiek)
        {
            Imię = imię;
            // Gatunek = gatunek;
            // this.Gatunek = gatunek;
            this.gatunek = gatunek; // nowe ustawienie strzałkowe po dodaniu funkcji strzałkowej
            Wiek = wiek;
            dzieci = new ZbiórDzieci(this);
        }

        public override string ToString() // automatyczna konwersja na stringa, gdy chcemy użyć obiekt zamiast stringa ( do przeładowania )
        {
            return $"{Gatunek} {Imię}, {Wiek} lat(a)";
        }
    }
}