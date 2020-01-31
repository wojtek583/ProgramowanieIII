using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2Programowanie
{
    public class Gracz
    {
        public Gracz(int punkty, int zwyciestwa, DateTime ostatniaAktywnosc)
        {
            Punkty = punkty;
            Zwyciestwa = zwyciestwa;
            OstatniaAktywnosc = ostatniaAktywnosc;
        }

        public int Punkty { get; set; }
        public int Zwyciestwa { get; set; }
        public DateTime OstatniaAktywnosc { get; set; }
    }
}
