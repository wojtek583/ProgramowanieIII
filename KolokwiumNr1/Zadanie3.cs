
using System;
using System.Collections.Generic;
using System.Text;

namespace KolokwiumNr1
{
    class Zadanie3
    {
       

        static public void DodajTablice()
        {
            int[,] tab1 = new int[3, 10];
            int[,] tab2 = new int[10, 8];

            int szer = Math.Max(tab1.GetLength(0), tab2.GetLength(0));
            int wys = Math.Max(tab1.GetLength(1), tab2.GetLength(1));

            int[,] tab3 = new int[szer,wys];

            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    tab1[i, j] = 1;
                    tab3[i, j] += tab1[i, j];
                }
            }

            for (int i = 0; i < tab2.GetLength(0); i++)
            {
                for (int j = 0; j < tab2.GetLength(1); j++)
                {
                    tab2[i, j] = 2;
                    tab3[i, j] += tab2[i, j];
                }
            }

            for (int i = 0; i < tab3.GetLength(0); i++)
            {
                for (int j = 0; j < tab3.GetLength(1); j++)
                {
                    Console.Write(tab3[i,j]+" ");
                }
                Console.WriteLine();
            }



        }
    }
}
