using System;

/*
        klasy, nauczyc sie

        petla foreach //w kazdej iteracji zwraca 1 element

        



*/
namespace Laborki3Programowanie
{
    class Program
    {
        public class Przedmiot
        {
            string nazwaPrzedmiotu = string.Empty;
            public void ustawNazwe(string n1)
            {
                nazwaPrzedmiotu = n1;
            }
            static float Srednia()
            {
                int iloscOcen = 0;
                float suma = 0;
                string tekst = string.Empty;
                while (tekst != "0")
                {
                    tekst = Console.ReadLine();
                    float ocena;
                    bool czyPrzekonwertowano = float.TryParse(tekst, out ocena);
                    if (czyPrzekonwertowano)
                    {
                        if (ocena > 0 && ocena <= 6)
                        {
                            suma += ocena;
                            iloscOcen++;
                        }
                        else if (ocena == 0)
                        {
                            Console.WriteLine("Wynik: ");
                        }
                        else
                        {
                            Console.WriteLine("Podano niepoprawno liczbe");
                        }
                        // TODO

                    }
                    else
                    {
                        Console.WriteLine("Podano niepoprawna liczbe");
                    }

                }
                float srednia = suma / iloscOcen;
                return srednia;
            }
            
        }
        static void Main(string[] ar4gs)
        {
            Przedmiot przedmiot1 = new Przedmiot();
            Przedmiot przedmiot2 = new Przedmiot();
            Przedmiot przedmiot3 = new Przedmiot();
            string txt = Console.ReadLine();
            przedmiot2.ustawNazwe(txt);
            
            Console.WriteLine(przedmiot1.nazwaPrzedmiotu);
            

        }
    }
}
