using System;
namespace Laborki10Programowanie
{
    class Program
    {
       static bool Zad1(double x, double y)
        {
            if (x*x+y*y==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int Zad2(int[] tab)
        {
            int nwe = tab[0]; // Najczesciej wystepujacy element
            int x = 0;
            int y = 0;
            foreach (var item in tab)
            {
                if (tab[item]==tab[item+1])
                {
                    nwe = tab[item];
                }
            }
            return nwe;
        }

        static void Zad3(int[,] tab)
        {
                    int sumPonad = 0;
                    int sumPod = 0;

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = i + j;
                    tab[1, 1] = 11; //liczba wprowadzona na przekatnej, nie jest wliczana 
                    sumPonad += tab[1, j];
                    sumPod += tab[i, 1];
                    Console.Write(tab[i,j]+" ");

                }
                Console.WriteLine();
            }

            if (sumPonad == sumPod)     Console.WriteLine("Suma elementow ponad przekatna jest rowna sumie elementow tablicy pod przekatna");
            else                        Console.WriteLine("Suma elementow ponad przekatna nie jest rowna sumie elementow tablicy pod przekatna");

            Console.WriteLine($"{sumPod} <= Suma Pod przekatna \n{sumPonad} <= Suma Ponad przekatna");
        }

        static void Zad5(double[,] tabZ5,int x, bool KorW)
        {
            if (KorW==true)
            {
                for (int i = 0; i < tabZ5.GetLength(0); i++)
                {
                    for (int j = 0; j < tabZ5.GetLength(1); j++)
                    {
                        tabZ5[x, j] = 0;
                    }
                }
            }
            else
            {
                for (int i = 0; i < tabZ5.GetLength(0); i++)
                {
                    for (int j = 0; j < tabZ5.GetLength(1); j++)
                    {
                        tabZ5[i, x] = 0;
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            double x = 1;
            double y = 0;
            Console.WriteLine(Zad1(x,y));

            int[] tabZ2 = new int[] { 1, 2, 3, 2, 2, 6, 6, 6,6,8};

            int[,] tabZ3 = new int[10,10];

            

            double[,] tabZ5 = new double[3, 3]; 
            for (int i = 0; i < tabZ5.GetLength(0); i++)
            {
                for (int j = 0; j < tabZ5.GetLength(1); j++)
                {
                    tabZ5[i, j]+=1;

                }
            }
           
           Console.WriteLine(Zad2(tabZ2));
            Zad3(tabZ3);
            Zad5(tabZ5, 2, true); //true kolumna false wiersz
            for (int i = 0; i < tabZ5.GetLength(0); i++)
            {
                for (int j = 0; j < tabZ5.GetLength(1); j++)
                {
                    Console.Write(tabZ5[i,j]+"  ");
                }
                Console.WriteLine();
            }
        }
    }
}
