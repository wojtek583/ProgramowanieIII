using System;
using System.Collections.Generic;
using System.Linq;
namespace Kolokwium2Poprawa
{
    class Program
    {
        public static int firstDigit(int n)
        {
            // Remove last digit from number 
            // till only one digit is left 
            while (n >= 10)
                n /= 10;

            // return the first digit 
            return n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1:");
            #region Zad1
            Random rnd = new Random();
            RandomDateTime date = new RandomDateTime();

            List<Polaczenie> polaczony = new List<Polaczenie>();
            for (int i = 0; i < 50; i++)
            {
                polaczony.Add(new Polaczenie(rnd.Next(100000000,999999999), date.Next(), new TimeSpan(0,0,rnd.Next(1,60))));
            }

            foreach (var item in polaczony)
            {
                Console.WriteLine($"{item.Numer}\t{item.Data}\t{item.Czas}");
            }

            var posortowane = polaczony.OrderBy(x => x.Data);

            Console.WriteLine("\nChronologicznie:\n");

            foreach (var item in posortowane)
            {
                Console.WriteLine($"{item.Numer}\t{item.Data}\t{item.Czas}");
            }

            var poDlugosci = polaczony.OrderBy(x => x.Czas);

            Console.WriteLine("\nPosortowane wg czasu polaczenia:\n");

            foreach (var item in poDlugosci)
            {
                Console.WriteLine($"{item.Numer}\t{item.Data}\t{item.Czas}");
            }

            var numer5 = polaczony.Select(x=>x).Where(x=>firstDigit(x.Numer)==5).ToList();
            
            foreach (var item in numer5)
            {
                Console.WriteLine($"{item.Numer}\t{item.Data}\t{item.Czas}");
            }
            
            var sredniaCzasu = numer5.Average(x=>x.Czas.Seconds);   
            Console.WriteLine(sredniaCzasu);
            #endregion
            Console.WriteLine("Zadanie 2:");
            #region Zad2
            decimal kasa = 1242.5m;
            kasa.Netto(23);
            Console.WriteLine(kasa);
            #endregion
            Console.WriteLine("Zadanie 3:");
            #region Zad3
            Postac chopek = new Postac();
            #endregion
            Console.WriteLine("Zadanie 4:");
            #region Zad4
            var wiadomosc = new Wiadomosc("Siabadabababdbabda", "Gal Anonim",new DateTime(1992,12,13));
            //var (string cas,string nazwa, Data) = wiadomosc;
            #endregion
        }
    }
}
