using System;
using System.Collections.Generic;
using System.Text;

namespace Laborki10Programowanie
{
    static public class ExtensionMethods
    {
        public static (int,int) Podziel(this int dzielna, int dzielnik)
        {

            return ( dzielna/dzielnik, dzielna %dzielnik);
        
        
        }
        public static int Znajdz(this string wyraz, char szukana)
        {
            int ile = 0;
            for (int i = 0; i < wyraz.Length; i++)
            {
                if (wyraz[i]==szukana)
                {
                    ile++;
                }
            }
            return ile;
            /*lub


            if(character.Lenght>1)
            {
                throw new ArgumentException();
            }
            return ZliczZnaki(text,character[0]);
            
            */
        }
        public static int Znajdz(this string wyraz, char szukana, bool WazneDuzark)
        {
            if (WazneDuzark)
            {
                wyraz = wyraz.ToLower();
                szukana = char.ToLower(szukana);
            }
            return wyraz.Znajdz(szukana);
        }
        public static int SumaTypowOsob(this TypOsoby typ)
        {
            int suma = 0;
            foreach (var item in Enum.GetValues(typeof(TypOsoby)))
            {
                suma += (int)item;
            }
            return suma;
        }
        

    }
}
