using System;
using System.Collections.Generic;
using System.Text;

namespace Laborki6Programowanie
{
    public class Samochod
    {
        public static int iloscModeli;
        public readonly string Model;
        //private int _przebieg;
        public int Przebieg { get; private set; }
        public int VIN;
        public void ZwiekszPrzebieg(int dystans)
        {
            if (dystans<0)
            {
                throw new ArgumentException("zla liczba");
            }
            else
            {
                Przebieg += dystans;
            }
        }
        public Samochod(int id)
        {
            //var dane = Baza.GetById(id)
            // Przebieg = dane.Przebieg;
        }
        private Samochod()
        {
            VIN = iloscModeli++;
        }
        public Samochod(int iloscDrzwi, int waga):this("Multipla",0,iloscDrzwi,waga)
        {
        }
        //public int Przebieg 
        //{ 
        //    get 
        //    { 
        //        return _przebieg; 
        //    } 
        //    set
        //    {
        //        if (value>_przebieg)
        //        {
        //            _przebieg = value;
        //        }
        //    }
        //}
        private int _waga;

        public Samochod(string model, 
                        int przebieg, 
                        int waga, 
                        int iloscDrzwi):this()
        {
            Model = model;
            Przebieg = przebieg;
            Waga = waga;
            Waga = waga;
            IloscDrzwi = iloscDrzwi;
            VIN = iloscModeli++;
        }

        public int Waga
        {
            get
            {
                return _waga;
            }
            set
            {
                _waga = value;
                if (_waga<=0)
                {
                    _waga = 0;
                }
            }
        }
        public int IloscDrzwi { get; private set; }



    }
}
