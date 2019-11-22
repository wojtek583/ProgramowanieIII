using System;
using System.Collections.Generic;
using System.Text;

namespace KolokwiumNr1
{
    class EBook
    {
        public readonly string Autor;
        public readonly string Tytul;
        public readonly DateTime DataWydania;
        public DateTime DataOstatniegoZakupu;
        public float CenaStandardowa;
        public float Obnizka;
        public EBook(string _Autor,string _Tytul,DateTime _DataWydania, DateTime _DataOstatniegoZakupu,float _CenaStandardowa,float _Obnizka)
        {
            Autor = _Autor;
            Tytul = _Tytul;
            DataWydania = _DataWydania;
            DataOstatniegoZakupu = _DataOstatniegoZakupu;
            CenaStandardowa = _CenaStandardowa;
            Obnizka = _Obnizka;
         }

    }
}
