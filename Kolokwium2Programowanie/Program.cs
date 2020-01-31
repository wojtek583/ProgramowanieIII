using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Kolokwium2Programowanie
{
    class Program
    {
        static void odczytajSumujZapisz(string path)
        {


            using (StreamReader sr=new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
                int wynik;
                             
            }


        }
        static void Main(string[] args)
        {
            //--------------- 1D----------------//
            Random rnd = new Random();
            RandomDateTime date = new RandomDateTime();

            List<Gracz> gracz = new List<Gracz>();
            for (int i = 0; i < 100; i++)
            {
                gracz.Add(new Gracz(rnd.Next(0,100), rnd.Next(0,80),date.Next()));
            }


            Console.WriteLine("\t|PKT\t|WIN === Data");
            foreach (var item in gracz)
            {
                Console.WriteLine($"\t|{item.Punkty}\t|{item.Zwyciestwa}  === {item.OstatniaAktywnosc}");
            }


            //Console.WriteLine("Ranking graczy w ost. 7 dniach:");
            //foreach (var item in gracz)
            //{
            //    if (item.OstatniaAktywnosc<=DateTime.Now())
            //    {
            //        Console.WriteLine($"\t|{item.Punkty}\t|{item.Zwyciestwa}  === {item.OstatniaAktywnosc}");
            //    }
            //}

            //--------------- 2D----------------//
            Paczka paczka = new Paczka("Starosty 12",17);
            Console.WriteLine(   paczka.Lokalizacja); //dotychczasowa lokalizacja paczki
            IPrzesylka.Nadaj(paczka, "Mickiewicza 112");
            IPrzesylka.Odbierz();
            IPrzesylka.Info(paczka);



            //--------------- 3D----------------//
            Ankieta ankieta = new Ankieta(4,2,4,6);
            Console.WriteLine(ankieta.suma4);

            //--------------- 4D----------------//
            Skrzyzowanie skrzyzowanie = new Skrzyzowanie();
            //--------------- 5D----------------//

            using (StreamWriter sw = new StreamWriter("10dowolnychliczb.txt"))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(i);
                }
            }
            odczytajSumujZapisz("10dowolnychliczb.txt");
        }
    }
}
