using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2Poprawa
{
    class Polaczenie
    {
        public Polaczenie(int numer, DateTime data, TimeSpan czas)
        {
            Numer = numer;
            Data = data;
            Czas = czas;
        }

        public int Numer { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Czas { get; set; }

    }
}
