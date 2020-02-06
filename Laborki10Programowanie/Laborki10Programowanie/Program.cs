using System;

namespace Laborki10Programowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Extensions
           
            int liczba = Convert.ToInt32(Console.ReadLine());

            (int wynik, int reszta) = liczba.Podziel(3);

            Console.WriteLine($"{liczba}/3={wynik} {reszta}");



            string text = "Ala ma kota.";

            int ile = text.Znajdz('a');
            

            Console.WriteLine($"{ile}=tyle jest liter");

            ile = text.Znajdz('a',true);

            Console.WriteLine($"{ile}=tyle jest liter");

            /*================================================
             * char t= 'a';
             * var w = char.ToUpper(t);       //albo to lower
             * 
             * string text2="asd";
             * var text3= text2.ToUpper();  //albo to lower
             ==================================================*/
             
            #endregion

            Reklama reklama = new Reklama(  "Kup Teraz", 
                                            TypOsoby.Dorosly | TypOsoby.Mlodzierz | TypOsoby.Dziecko, 
                                            Zainteresowania.Gaming);
            reklama.Test();

        }
    }
}
