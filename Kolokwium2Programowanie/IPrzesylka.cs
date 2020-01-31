using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2Programowanie
{
    public interface IPrzesylka
    {
         static int Nadaj(Paczka paczka,string nacoNadac)
        {
            int idPrzesylki = 1;
            paczka.Lokalizacja = nacoNadac;
          
            Console.WriteLine($"Nadano  paczke na: {paczka.Lokalizacja}");
            return idPrzesylki;
        }

        static void Przekaz(Paczka paczka, string gdziePrzekazac)
        {
            paczka.Lokalizacja = gdziePrzekazac;
        }
        static void Info(Paczka paczka)
        {
            Console.WriteLine(paczka.Lokalizacja,paczka.Waga);
        }

        static void Odbierz()
        {
            Console.WriteLine("Paczka odebrana");
        }


    }
}
