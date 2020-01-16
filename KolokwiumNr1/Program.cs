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
            Console.WriteLine("Autor: "+ ksiazka.Autor + "\nTytul: "
                             + ksiazka.Tytul + "\nData Wydania: "
                             + ksiazka.DataWydania + "\nData Ostatniego zakupu: "
                             + ksiazka.DataOstatniegoZakupu + "\nCena Standardowa: "
                             + ksiazka.CenaStandardowa + "\nObnizka: "
                             + ksiazka.Obnizka+"\nAktualna cena: "
                             +ksiazka.AktualnaCena);
        }



        static void Main(string[] args)
        {
           Console.WriteLine("Zadanie 1 -> Wynik: "+Zad1(10)+"\n");

           Console.WriteLine("Zadanie 2 : ");
           Zad2.ZadanieDrugie();

            Console.WriteLine("\nZadanie 3: Macierz wynikowa");
           Zadanie3.DodajTablice();

           Zadanie4 zadanko4 = new Zadanie4();
           zadanko4.Zadanie_4(zadanko4.tab);

           int[][] poszarpana = new int[2][] { new int[] {1022,322,211,344,522,322,333,1213 }, new int[] { 234,23423,234 } };
           Console.WriteLine("\nNajmniejsza liczba w poszarapnej: " + zadanko4.Zadanie_4(poszarpana) + "\n");


            EBook ksiazka = new EBook("B.Prus","Lalka",new DateTime(1992,12,21),new DateTime(2020,01,11),100.0,20.0 );
            ksiazka.DataOstatniegoZakupu = new DateTime(2019, 01, 11); //Zla data zakupu 
            ksiazka.CenaStandardowa = -12.0; //Zla cena standardowa
            ksiazka.Obnizka = 98.0; // Zla obnizka (nie mozna za darmo sprzedawac...)


            /* ksiazka.Autor = "Wojciech";
            ksiazka.Tytul = "Wojciech";
            ksiazka.DataWydania = new DateTime(); */ // Pol nie da sie zmienic.

            WyswietlEbook(ksiazka);


        }
    }
}
