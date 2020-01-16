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

        DateTime _DataOstZakupu;
        public DateTime DataOstatniegoZakupu
        {
            get
            {
                return _DataOstZakupu;
            }
            set
            {
                if (value.Date > _DataOstZakupu)
                {
                    _DataOstZakupu = value;
                }
                else
                {
                    Console.WriteLine("Zła data zakupu\n");
                }
            }
        }


        double _CenaStandardowa;
        public double CenaStandardowa
        {
            get
            {
                return _CenaStandardowa;
            }

            set
            {
                if (value > 0)
                {
                    _CenaStandardowa = value;
                }
                else
                {
                    Console.WriteLine("Nie mozna ustawic ujemnej ceny\n");
                }
            }

        }

        double _Obnizka;
        public double Obnizka
        {
            get
            {
                return _Obnizka;
            }
            set
            {
                if (value>0&& value<=99)
                {
                    _Obnizka = value;
                }
                else Console.WriteLine("Bledna obnizka\n");
            }
        }

        double _AktualnaCena;

        public double AktualnaCena
        {
            get
            {
                return CenaStandardowa * ((100 - Obnizka) / 100);
            }
        }



        public EBook(string autor, string tytul, DateTime dataWydania, DateTime dataOstatniegoZakupu, double cenaStandardowa, double obnizka)
        {
            Autor = autor;
            Tytul = tytul;
            DataWydania = dataWydania;
            DataOstatniegoZakupu = dataOstatniegoZakupu;
            CenaStandardowa = cenaStandardowa;
            Obnizka = obnizka;
        }
    }
}

