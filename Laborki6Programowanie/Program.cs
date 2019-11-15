using System;

namespace Laborki6Programowanie
{
    class Program
    {
        static void OpiszStrone(Cwiczenie str)
        {
            Console.WriteLine(str.StronaInternetowa+ str.);
        }
        static void OpiszSamochod(Samochod auto)
        {
            Console.WriteLine
             (
                "["+auto.VIN+"] "+
            auto.Model+": Przebieg: "+auto.Przebieg+
            "km Waga: "+auto.Waga+"kg "+"Ilosc drzwi: "+auto.IloscDrzwi
            );
        }
        static void Main(string[] args)
        {
            Samochod mojSamochod = new Samochod("Multipla",10000,1812,5);
            Samochod s2 = new Samochod("Punto", 3452, 1389, 3);
            Samochod s3 = new Samochod("Doblo", 100000, 1299, 3);
            Samochod s4 = new Samochod(5,1372);
            
            //mojSamochod.Przebieg = 300000;
            mojSamochod.ZwiekszPrzebieg(86234);
            s2.ZwiekszPrzebieg(34532);
            s3.ZwiekszPrzebieg(534736);
            OpiszSamochod(mojSamochod);
            OpiszSamochod(s2);
            OpiszSamochod(s3);
            OpiszSamochod(s4);
            Console.WriteLine("Wyprodukowano: "+Samochod.iloscModeli);


            Cwiczenie strona = new Cwiczenie("www.fufufuf.pl",2.7f,200,4096,"Angular");

            OpiszStrone(strona);
        }
    }
}