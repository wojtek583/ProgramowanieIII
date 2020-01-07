using System;

namespace KolokwiumNr1
{
    class Zad2
    {
        public static void ZadanieDrugie()
        {
            int[] z = new int[200];

            for (int i = 0; i < 200; i++)
            {
                z[i] = i;
            }

            Console.WriteLine("Wpisz liczbę przez którą chcesz dzielić:");
            string s = Console.ReadLine();
            int ss = Convert.ToInt32(s);

            if (ss == 0)
            {
                Console.WriteLine("Nie można dzielić przez 0!");
            }

            else
            {
                Console.WriteLine($"z zakresu 1-200 Liczby podzielne przez {s}: ");

                   for (int i = 0; i < 200; i++)
                   {
                        if (i % ss == 0 && i != 0)
                        {   
                            Console.Write(z[i] + " ");
                        }
                   }
            }
            Console.WriteLine();
        }
    }
}
