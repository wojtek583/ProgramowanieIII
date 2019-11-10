using System;
using System.Collections.Generic;
using System.Text;

namespace Laborki5Programowanie
{
    class Ksiazka
    {
        public string Tytul;
        public string Autor;
        public int Regal;
        public int Polka;
        public int Miejsce;

        public Ksiazka(string tytul, string autor, int R, int P, int M)
        {
            Tytul = tytul;
            Autor = autor;
            Regal = R;
            Polka = P;
            Miejsce = M;
        }
        public Ksiazka()
        {

        }
    }
}
