using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_osoba
{
    class Produkt
    {
        // dotyczy => klasa Produkt [ class Produkt ] jest częścią programu z punktu nr 11 [ class Program ... static void Main ]

        readonly static Dictionary<string, decimal> Stawki_VAT = new Dictionary<string, decimal>()
        {
            ["podstawowa"] = 0.23M,
            ["budowlana"] = 0.08M,
            ["rolne"] = 0.08M,
            ["spożywcze"] = 0.08M,
            ["rekreacja"] = 0.08M,
            ["gastro"] = 0.05M,
            ["książki"] = 0.05M,
            ["zerowa"] = 0.00M
        };
        string kategoria_VAT = "podstawowa";
        public string Nazwa;
        decimal cena_Netto;
        public string Kategoria_VAT
        {
            get { return kategoria_VAT; }
            set
            {
                string kategoria = value.ToLower();
                if (Stawki_VAT.ContainsKey(kategoria))
                    kategoria_VAT = kategoria;
                else
                    throw new Exception(
                        "Nieznana kategoria VAT: " + kategoria);
            }
        }
        public decimal Cena_Netto
        {
            get { return cena_Netto; }
            set
            {
                if (value < 0)
                    throw new Exception(
                        "Nieprawidłowa (ujemna) cena: " + value
                        );
                else
                    cena_Netto = value;
            }
        }
        
        public decimal Cena_Brutto
        {
            get
            {
                return cena_Netto * (1 + Stawki_VAT[kategoria_VAT]);
            }
        }
    }
}
