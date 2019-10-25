using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator
{
    class Kalkulator
    {
        public static double dodaj(int x, int y)
        {
            return x + y;
        }
        public static double dodaj(string x, string y)
        {
            int liczba1 = Convert.ToInt32(x);
            int liczba2 = Convert.ToInt32(y);
            return dodaj(liczba1, liczba2);
        }
        public static double odejmij(int x, int y)
        {
            return x - y;
        }
        public static double mnoz(int x, int y)
        {
            return x * y;
        }
        public static double dziel(int x, int y, out bool powodzenie)
        {

            if (y == 0)
            {
                powodzenie = false;
                return 0;
            }
            powodzenie = true;
            return (double)x / y;

        }
        public static double PodzielZWyjatkiem(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)x / y;
        }

        public static string wczytajLiczbe(string licznik)
        {
            Console.WriteLine("Podaj Liczbe " + licznik + ":");
            string tekst = Console.ReadLine();
            return tekst;
            //return Console.readline()
        }

    }
}
