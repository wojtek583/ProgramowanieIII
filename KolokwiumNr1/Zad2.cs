using System;

namespace KolokwiumNr1
{
    class Zad2
    {
        public void Zadanie()
        {
            int[] z = new int[200];

            for (int i = 0; i < 200; i++)
            {
                z[i] = i;
            }

            string s = Console.ReadLine();
            Console.WriteLine("z zakresu 1-200 Liczby podzielne przez: ");
            Convert.ToInt32(s);
            
                




            for (int i = 0; i < 200; i++)
            {


                if (i % 12 == 0 && i != 0)
                {
                    Console.Write(z[i] + " ");
                }

            }


        }

    }
}
