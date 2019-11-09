using System;


namespace Laborki3Programowanie
{
    class Program
    {
        static float sredniacala = 0;
        public class Przedmiot
        {
            string nazwaPrzedmiotu = string.Empty;
            public void ustawNazwe(string n1)
            {
                nazwaPrzedmiotu = n1;
            }
            public float Srednia()
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
                            Console.WriteLine("Srednia z przedmiotu: ");
                        }
                        else
                        {
                            Console.WriteLine("Podano niepoprawno liczbe");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Podano niepoprawna liczbe");
                    }
                }

                float srednia = suma / iloscOcen;
                sredniacala += srednia;
                return srednia;
            }
        }
        static void Main(string[] ar4gs)
        {
            Przedmiot przedmiot1 = new Przedmiot();
            Console.Write("Ilość przedmiotów: ");
            int nr_przedmiotow = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nr_przedmiotow; i++)
            {
                Console.Write("Podaj nazwe przedmiotu: ");
                przedmiot1.ustawNazwe(Console.ReadLine());
                Console.Write("Wpisz oceny: ");
                Console.WriteLine(przedmiot1.Srednia());
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("============================================ \nSrednia ze wszystkich przedmiotów wynosi: " + sredniacala / nr_przedmiotow+ "\n============================================");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
