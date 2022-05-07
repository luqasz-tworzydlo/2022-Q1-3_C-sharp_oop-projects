using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Spotkanie
    {
        public DateTime?
            początek,
            koniec
            ;

        public TimeSpan? długość
        {
            get
            {
                if (koniec == null)
                    return DateTime.Now - początek;
                else
                    return koniec - początek;
            }
        }


    }
}