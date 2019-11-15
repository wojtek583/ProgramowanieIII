using System;
using System.Collections.Generic;
using System.Text;

namespace Laborki6Programowanie
{
    class Cwiczenie
    {
        //Strona Internetowa
        //Serwer  ()
        //  SzybkoscProcka(ghz)
        //  Lacze (w Mbps)
        //  Ram
        //  Technologia np Angular
        //Domena
        //  Nazwa
        //  Waznosc (DateTime)





        public static string StronaInternetowa;

        public float SzybkoscProcka;
        public readonly float Lacze;
        public readonly string Technologia;
        public string NazwaDomeny;
        public int Ram;
        public DateTime Waznosc;
        private string v;

        public Cwiczenie(string _StronaInternetowa,float _SzybkoscProcka , float _Lacze, int _Ram, string _Technologia)
        {
            StronaInternetowa = _StronaInternetowa;
            SzybkoscProcka = _SzybkoscProcka;
            Lacze = _Lacze;
            Ram = _Ram;
            Technologia = _Technologia;
        }

        public void Serwer(float _SzybkoscProcka,float Lacze, float Ram, string Technologia)
        {
            SzybkoscProcka = _SzybkoscProcka;
        }

        public void Domena(string _Nazwa, DateTime _Waznosc)
        {
            NazwaDomeny = _Nazwa;
            Waznosc = _Waznosc;
        }

    }
}
