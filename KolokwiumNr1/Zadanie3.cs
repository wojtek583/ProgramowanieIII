using System;
using System.Collections.Generic;
using System.Text;

namespace KolokwiumNr1
{
    class Zadanie3
    {
       public static int[,] tablica1 = new int[3, 10];

       public static int[,] tablica2 = new int[10, 8];

        public void DodajTablice()
        {


            for (int i = 0; i < tablica1.GetLength(0); i++)
            {
                for (int j = 0; j < tablica1.GetLength(1); j++)
                {
                    tablica1[i,j]=i+3;
                }
            }
            for (int i = 0; i < tablica2.GetLength(0); i++)
            {
                for (int j = 0; j < tablica2.GetLength(1); j++)
                {
                    tablica2[i, j] = i + 3;
                }
            }


            for (int i = 0; i < tablica1.GetLength(0); i++)
            {
                for (int j = 0; j < tablica2.GetLength(1); j++)
                {
                    tablica1[i,j] += tablica2[i,j];

                    Console.Write(tablica1[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
