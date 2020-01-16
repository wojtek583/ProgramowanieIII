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

            int[][] poszarpana = new int[2][] { new int[] {1022,322,211,344,522,322,333,1213 }, new int[] { 234,23423,234 } };
            Console.WriteLine("Najmniejsza liczba w poszarapnej: " + zadanko4.Zadanie_4(poszarpana));


            EBook ksiazka1 = new EBook("B. Prus", "Lalka", new DateTime(1993,12,22), new DateTime(2020, 1, 10), 100.0, 20.0);
           ksiazka1.NowaDataZakupu(new DateTime(2011, 1, 1));
           // ksiazka1.DataOstatniegoZakupu=new DateTime(1212, 2, 12);
           
           WyswietlEbook(ksiazka1);


        }
    }
}
