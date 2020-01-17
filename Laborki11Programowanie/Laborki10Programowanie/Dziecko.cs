using System;
using System.Collections.Generic;
using System.Text;

namespace Laborki10Programowanie
{
    class Dziecko
    {
        public double Znizka { get; set; }

        public DateTime DataUrodzenia { get; set; }

        public void Deconstruct(out DateTime dataurodzenia,out string klasa)
        {
            dataurodzenia = DataUrodzenia;
            klasa = "Nie chodzi do szkoly";
            if (DateTime.Now.Year - dataurodzenia.Year>=6 && DateTime.Now.Year - dataurodzenia.Year <= 14)
            {
                klasa = "Podstawowka";
            }
            else if (DateTime.Now.Year - dataurodzenia.Year >= 15 && DateTime.Now.Year - dataurodzenia.Year <= 19)
            {
                klasa = "Srednia";
            }
            else if (DateTime.Now.Year - dataurodzenia.Year >= 20 && DateTime.Now.Year - dataurodzenia.Year <= 29)
            {
                klasa = "Wyzsza";
            }



        }
    }
}
