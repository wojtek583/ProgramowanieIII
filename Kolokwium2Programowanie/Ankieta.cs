using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2Programowanie
{
    class Ankieta
    {
        public Ankieta(int glos1, int glos2, int glos3, int glos4)
        {
            Glos1 = glos1;
            Glos2 = glos2;
            Glos3 = glos3;
            Glos4 = glos4;
        }

        public int Glos1 { get; set; }
        public int Glos2 { get; set; }
        public int Glos3 { get; set; }
        public int Glos4 { get; set; }
        public int suma4 { get; set; }


        public void Deconstruct(out int _glos, out int _glos2, out int _glos3, out int _glos4, out int suma)
        {
            _glos = Glos1;
           _glos2 = Glos2;
           _glos3 = Glos3;
           _glos4 = Glos4;
            suma = Glos1 + Glos2 + Glos3 + Glos4;
        }

    }
}

