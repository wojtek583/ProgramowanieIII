using System;
using System.Collections.Generic;
using System.Text;

namespace Laborki10Programowanie
{
    class OsobaStarsza
    {
        public string NrLegitymacji { get; set; }
        public bool ZwolnienieZOplaty { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string AdresZdjecia { get; set; }

        public (string nrlegitki , bool zwolnieniezoplaty, DateTime dataurodzenia, string adreszdj) ZwrocWszystkieDane()
        {
            return (NrLegitymacji, ZwolnienieZOplaty, DataUrodzenia, AdresZdjecia);
        }
        public void Deconstruct(out string nrLegitymacji, out bool zwolnienie,out DateTime urodziny,out string zdjecie )
        {
            nrLegitymacji = NrLegitymacji;
            zwolnienie = ZwolnienieZOplaty;
            urodziny = DataUrodzenia;
            zdjecie = AdresZdjecia;
        }

    }

}
