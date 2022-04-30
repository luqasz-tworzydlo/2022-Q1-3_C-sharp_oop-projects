﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Osoba2 : Istota
    {
        public string Nazwisko;
        public string Narodowość;
        public override string Gatunek
        {
            get => base.Gatunek;
            set => throw new Exception(
                $"Nie można zmienić gatunku Osoba2 (na {value})"
                );
        }
        public Osoba2(
            string imię,
            string nazwisko,
            string narodowość,
            uint? wiek
            )
        {
            Imię = imię;
            Nazwisko = nazwisko;
            Narodowość = narodowość;
            Wiek = wiek;
            base.Gatunek = "człowiek";
        }
        public override string ToString()
        {
            return $"{Imię} {Nazwisko}, {Narodowość}, {Wiek}";
        }
    }
}
