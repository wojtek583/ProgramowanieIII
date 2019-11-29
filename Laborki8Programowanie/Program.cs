using System;
using System.Collections.Generic;
using System.Linq;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;
using System.Diagnostics;


namespace Laborki8Programowanie
{
    public class Osoba
    {
        public int id;
        public string imie;
        public string nazwisko;
        public string kraj;
        public int wiek;

        public Osoba(int id, string imie, string nazwisko,string kraj,int wiek)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.kraj = kraj;
            this.wiek = wiek;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            

            var nameGen = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var lastnameGen = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());
            var country = RandomizerFactory.GetRandomizer(new FieldOptionsCountry());
            var numbers = RandomizerFactory.GetRandomizer(new FieldOptionsInteger{ Min = 1, Max = 100 });

            var sw = Stopwatch.StartNew();
            List<Osoba> osoby = Enumerable.Range(100, 15000)
                .Select(x =>
                           new Osoba(
                               x,
                               nameGen.Generate(),
                               lastnameGen.Generate(),
                               country.Generate(),
                               numbers.Generate().Value
                               )
                        ).ToList();

            sw.Stop();
            foreach (var item in osoby)
            {
                Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko} {item.kraj} {item.wiek}");
            }
            //wyszukiwanie po kraju, wieku min i max 
            Console.WriteLine("Wpisz kraj, min i max wiek");
            string kraj1=Console.ReadLine();
            int min = Convert.ToInt32(Console.ReadLine());
            int max = Convert.ToInt32(Console.ReadLine());

            List<Osoba> wyszukane = osoby.Where(x => x.kraj == kraj1 && x.wiek >= min && x.wiek <= max).ToList();

            foreach (var item in wyszukane)
            {
                Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko} {item.kraj} {item.wiek}");
            }

            //foreach (var item in osoby)
            //{
            //    Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko}");
            //}

            //List<Osoba> posortowane = osoby.OrderBy(x => x.nazwisko).ThenBy(x => x.imie).ToList();
            //foreach (var item in posortowane)
            //{
            //    Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko}");
            //}

            Console.WriteLine(sw.Elapsed);

            //List<int> lista = Enumerable.Range(100, 150).ToList();

            //List<Osoba> osoby = lista.Select(
            //    x => new Osoba()
            //    {
            //        id = x,
            //        imie = x.ToString(),
            //        nazwisko = "UwU"


            //    }
            //    ).ToList();

            ////List<string> nazwiska = osoby.Select(x => x.nazwisko).ToList();
            ////List<string> unikalneNazwiska = osoby.Select(x => x.nazwisko).Distinct().ToList();
            ////foreach (var item in unikalneNazwiska)
            ////{
            ////    Console.WriteLine($"{item}");
            ////}
            //Osoba szukana = osoby.Where(x => x.nazwisko == "UwU").First();

            //Osoba wyszukana = osoby.FirstOrDefault(x => x.nazwisko == "ccc");
            //Console.WriteLine($"{szukana.id} {szukana.imie} {szukana.nazwisko}");
            


            //foreach (var item in osoby)
            //{
            //    Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko}");
            //}




            /*=================================*/
            /*int nrStrony = 2;
            int elemNaStronie = 10;

            var strona = lista.Skip(elemNaStronie * (nrStrony - 1)).Take(elemNaStronie);  //var = IEnumerable<int> ale nie ma w nim niektorych funkcji np.Add
            foreach (var item in strona)
            {
                Console.WriteLine(item);
            }
            */
            /*
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            List<int> podzielnePrzez3 = lista.Where(x => x % 3 == 0).ToList();
            
            
            foreach (var item in podzielnePrzez3)
            {
                Console.WriteLine(item);
            }

            double srednia = podzielnePrzez3.Average();
            int suma = podzielnePrzez3.Sum();
            Console.WriteLine($"Srednia to {srednia}");
            Console.WriteLine($"Suma to {suma}");


            */

        }
    }
}