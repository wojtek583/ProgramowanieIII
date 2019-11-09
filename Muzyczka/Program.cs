using System;
using System.Threading;
namespace Muzyczka
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 250;
            int i = 37;
            Console.Title="Muzyczka";
            do
            {
                
                Console.Clear();
                Console.Beep(i, 500);
                Console.WriteLine(i+" Hz");
                
                i += 100;
            } while (true);
                
            
        }
    }
}
