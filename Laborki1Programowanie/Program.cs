using System;

namespace Laborki1Programowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Podaj Liczbe:");
            string odpowiedz = Console.ReadLine();
            int liczba = Convert.ToInt32(odpowiedz);
           

            bool czySieUdao = int.TryParse(odpowiedz, out liczba );
            if (czySieUdao)
            {
                if (liczba % 2 == 0)
                {
                    Console.WriteLine("Liczba jest parzysta");
                }
                else
                {
                    Console.WriteLine("Liczba nie jest parzysta");
                }
            }
            else
            {
                Console.WriteLine("Nie podano liczby!");
            }
            

            //if ternarny, przyjmuje 3 parametry np:    (WARUNEK) ? (WARTOSC JESLI TRUE) : (WARTOSC JESLI FALSE)

            Console.WriteLine((liczba % 2 == 0) ? "parzysta" : "nieparzysta");
            */

            /*
           
            double odleglosc = double.MinValue;
            double suma = 0, licznik = -1;
            while (odleglosc!=0)
            {
                string odlegloscTxt = Console.ReadLine();
                odleglosc = Convert.ToDouble(odlegloscTxt);
                suma += odleglosc;
                licznik++;
            }
            double wynik = suma / licznik;
            Console.WriteLine("Srednia wynosi: "+wynik);
          
             */

            int licznik = 1;
            int[] liczniki = { 1, 1, 1 };
            string linia = Console.ReadLine();
            int licz = 1;
            while (linia!="exit") // && licznik<=2000)
            {
                licz++;
               // Console.WriteLine(licznik++);
                linia = Console.ReadLine();
                Console.Clear();
                switch (linia)
                {
                    case "a":
                        Console.WriteLine("A : "+liczniki[0]++ +"   B : " + liczniki[1] +"  C : " + liczniki[2]);
                        break;
                    case "b":
                        Console.WriteLine("A : " + liczniki[0] + "  B : " + liczniki[1]++ + "   C : " + liczniki[2]);
                        break;
                    case "c":
                        Console.WriteLine("A : " + liczniki[0] + "  B : " + liczniki[1] + " C : " + liczniki[2]++);
                        break;
                    default:
                        break;
                }
                
                
            }
            Console.WriteLine("Żegnam");

        }
    }
}
