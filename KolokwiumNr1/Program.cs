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
               return Zad1(1.5*(Zad1(z-1))-1);
            }
        }


        static void WyswietlEbook(EBook ksiazka)
        {
            Console.WriteLine(ksiazka.Autor+" "+ksiazka.CenaStandardowa+" "+ksiazka.DataOstatniegoZakupu+" "+ksiazka.DataWydania+" "+ksiazka.Obnizka);
        }



        static void Main(string[] args)
        {
            //Console.WriteLine(Zad1(10));

            //Zad2 zadanie2 = new Zad2();
            Zadanie3 zadanie3 = new Zadanie3();
            zadanie3.DodajTablice();

           // EBook ksiazka = new EBook("Jan Janiszewski","Nad wodami",new DateTime(12,29,1997), new DateTime(22,11,2019),149.99f,0f);
            //WyswietlEbook(ksiazka);
                

                


            //zadanie.Zadanie();
        }
    }
}
