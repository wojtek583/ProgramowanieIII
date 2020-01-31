using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2Programowanie
{
    public class Paczka : IPrzesylka
    {
        public Paczka(string lokalizacja, int waga)
        {
            Lokalizacja = lokalizacja;
            Waga = waga;
        }

        public string Lokalizacja { get; set; }
        public int Waga { get; set; }
    }
}
