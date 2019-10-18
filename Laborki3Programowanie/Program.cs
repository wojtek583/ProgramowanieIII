using System;

namespace Laborki3Programowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int iloscOcen = -1;
            int suma = 0;
            string tekst = string.Empty;
            while (tekst != "0")
            {
                tekst = Console.ReadLine();
                int ocena;
                bool czyPrzekonwertowano = int.TryParse(tekst, out ocena);
                if (czyPrzekonwertowano)
                {
                    // TODO
                    suma += ocena;
                    iloscOcen++;
                }
                else
                {
                    Console.WriteLine("Podano niepoprawno liczpe");
                }
            }
            float srednia = (float)suma / iloscOcen;
            Console.WriteLine(srednia);
        }
    }
}
