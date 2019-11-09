using System;

namespace Kalkulator
{
    class Komputer
    {
            public double predkosc;
            public int ram;
            public int dysk;
        public void Opisz()
        {
            Console.WriteLine(predkosc + " Ghz " + ram + " GB ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Komputer komputer1 = new Komputer();
            komputer1.predkosc = 3.5;
            komputer1.ram = 16;
            komputer1.dysk = 3500;


            Komputer komputer2 = new Komputer();
            komputer2.predkosc = 4.5;
            komputer2.ram = 15;
            komputer2.dysk = 300;


            komputer1.Opisz();
            komputer2.Opisz();

            string tekst1 = Kalkulator.wczytajLiczbe("1");
            string tekst2 = Kalkulator.wczytajLiczbe("2");

            Console.WriteLine("Wybierz operacje:  +  -  *  / ");
            string operacja = Console.ReadLine();

            int liczba1 = Convert.ToInt32(tekst1);
            int liczba2 = Convert.ToInt32(tekst2);

            switch (operacja)
            {
                case "+":
                    Console.WriteLine(Kalkulator.dodaj(liczba1, liczba2));


                    break;

                case "-":
                    Console.WriteLine(Kalkulator.odejmij(liczba1, liczba2));

                    break;

                case "*":
                    Console.WriteLine(Kalkulator.mnoz(liczba1, liczba2));
                    break;

                case "/":
                 
                    try
                    {
                        Console.WriteLine(Kalkulator.PodzielZWyjatkiem(liczba1, liczba2));
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Nie dziel przez 0");

                    }
                    break;

                default:
                    Console.WriteLine("Wybrano zly typ operacji");

                    break;
            }
        }
    }
}
