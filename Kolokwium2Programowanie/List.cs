using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2Programowanie
{
    public class List : IPrzesylka
    {
        public List(string lokalizacja, string tresc)
        {
            Lokalizacja = lokalizacja;
            Tresc = tresc;
        }

        public string Lokalizacja { get; set; }
        public string Tresc { get; set; }
    }
}
