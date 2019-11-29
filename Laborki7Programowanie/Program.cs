using System;
using System.Collections.Generic;
using System.Linq;

namespace Laborki7Programowanie
{
    class Sala
    {
        public int numer;
        public int iloscMiejsc;




    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = Enumerable.Range(1, 100).ToList();
            IEnumerable<int> podzielnePrzez3=lista.Where ( x=> x % 3 == 0 ).ToList();
            IEnumerable<int> drugaStrona = podzielnePrzez3.Skip(10).Take(10);
            double srednia = lista.Average();
            double suma = lista.Sum();
            foreach (var element in drugaStrona)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine($"Srednia z calej listy to: {srednia} ");
            Console.WriteLine($"Suma z calej listy to: {suma}");

            List<Sala> sale = lista.Select(x => new Sala() { numer = x, iloscMiejsc = 50}).ToList();

            foreach (var item in sale)
            {
                Console.WriteLine($"Sala nr {item.numer} :  {item.iloscMiejsc}");
            }

            sale[45].iloscMiejsc = 100;
            List<Sala> pojemnosci = lista.Select(x => item.iloscMiejsc = 50).ToList();
            foreach (var item in pojemnosci)
            {
                Console.WriteLine(item);
            }


            List<int> pojemnosci = sale.Select(x => x.iloscMiejsc).ToList();

        }


    }
}
