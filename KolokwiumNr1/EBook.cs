using System;
using System.Collections.Generic;
using System.Text;

namespace KolokwiumNr1
{
    class EBook
    {
        public String Autor { get; private set; }
        public String Tytul { get; private set; }
        public DateTime DataWydania { get; private set; }
        public DateTime DataOstatniegoZakupu { get; private set; }
        public double CenaStandardowa { get; private set; }
        public double Obnizka { get; private set; }
        public double AktualnaCena { get; set; }

        public EBook(string autor, string tytul, DateTime dataWydania, DateTime dataOstatniegoZakupu, double cenaStandardowa, double obnizka)
        {
            Autor = autor;
            Tytul = tytul;
            DataWydania = dataWydania;

            if (CenaStandardowa < 0) Console.WriteLine("Podano złą cenę");
            else CenaStandardowa = cenaStandardowa;
            
            AktualnaCena=CenaStandardowa*((100-Obnizka)/100);
        }

        public void NowaDataZakupu(DateTime nowaDataZakupu)
        {
            if (DataOstatniegoZakupu < nowaDataZakupu) Console.WriteLine("Zła data zakupu");
            
            else DataOstatniegoZakupu = nowaDataZakupu;
        }


    }
}

