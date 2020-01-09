using System;
using System.Collections.Generic;
using System.Text;

namespace KolokwiumNr1
{
    //4. Napisz funkcję, która przyjmie jako parametr tablicę dwuwymiarową prostokątną int i wypisze jej najmniejszy element.
    //Stwórz przeładowanie funkcji, które przyjmie tablicę poszarpaną.Stwórz testowe dane.
    class Zadanie4
    {
        public int[,] tab = new int[3, 5];


        public void Zadanie_4(int[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    int rnd = new Random().Next(10, 30);
                    tab[i, j] = rnd;
                }
            }

            int min = int.MaxValue;

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    min = tab[0, 0];
                    if (min > tab[i, j])
                    {
                        min = tab[i, j];
                    }
                }
            }

            Console.WriteLine($"Najmniejsza liczba jest {min}");
        }

        public int Zadanie_4(int[][] tablica)
        {
            int min = int.MaxValue;
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    if (tablica[i][j] < min)
                    {
                        min = tablica[i][j];
                        Console.WriteLine(min);
                    }
                }
            }
            return min;
        }
    }
}
