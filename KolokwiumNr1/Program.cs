using System;

namespace KolokwiumNr1
{
    class Program
    {
        static double Zad1(double z)
        {
            if (z==0)
            {
                return 1;
            }
            else
            {
               return 1.5*(Zad1(z-1))-1;
            }
        }

        static void WyswietlEbook(EBook ksiazka)
        {
            Console.WriteLine(ksiazka.Autor+" "
                             +ksiazka.Tytul+" "
                             +ksiazka.DataWydania+" "
                             +ksiazka.DataOstatniegoZakupu+" "
                             +ksiazka.CenaStandardowa+" "
                             +ksiazka.Obnizka
                             +ksiazka.AktualnaCena);
        }



        static void Main(string[] args)
        {
           Console.WriteLine(Zad1(10));

           Zad2.ZadanieDrugie();

           Zadanie3.DodajTablice();

           Zadanie4 zadanko4 = new Zadanie4();
           zadanko4.Zadanie_4(zadanko4.tab);

           EBook ksiazka1 = new EBook("B. Prus", "Lalka", new DateTime(1993,12,22), new DateTime(2020, 1, 10), 100.0, 10.0);
            ksiazka1.NowaDataZakupu(new DateTime(2019, 1, 1));
            WyswietlEbook(ksiazka1);

        }
    }
}
