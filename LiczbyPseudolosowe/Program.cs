using System;

namespace LiczbyPseudolosowe
{
        //enum!

        enum Font
    {
        Italic=1<<0,
        Bold=1<<1,
        UnderLine=1<<2
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var rnd = new Random();

            //var lk = rnd.Next(100);
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("pojedjscie {0} ",i);
            //    Console.WriteLine("Podaj liczbe: ");
            //    if (!int.TryParse(s:Console.ReadLine(), out var nl))
            //    {
            //        continue;
            //    }
            //    if (nl > lk)
            //    {
            //        Console.WriteLine("za duzo");
            //    }
            //    else if (nl<lk)
            //    {
            //        Console.WriteLine("za malo");
            //    }
            //    else
            //    {
            //        Console.WriteLine("gz");
            //        break;
            //    }

            //Random rnd = null;
            //int? a = null;    //pytajnik oznacza ze to jest ten typ lub null

            var a = Font.Italic;

            Console.WriteLine(a.HasFlag(Font.Italic));   //sprawdza czy ma w sobie Italic  ... enum bardzo pozyteczny....

            }
        }
    }

