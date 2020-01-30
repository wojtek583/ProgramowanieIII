using System;

namespace LaborkiProgramowanie8
{
    class Program
    {
        private static bool _canPrint = true;
        static void PaperJammedEventHandler(object sender, PaperJammedEventArgs args)
        {
            Console.WriteLine($"Main: Paper Jammed at page {args.Page}");
            _canPrint = false;
        }

        static void OutOfInkEventHandler(object sender, OutOfInkEventArgs args)
        {
            Console.WriteLine($"Main: Replace {args.EmptyInk} Ink Cartrige");
            _canPrint = false;
        }

        static void Main(string[] args)
        {
            var printer = new Printer();
            printer.PaperJammed += PaperJammedEventHandler;
            printer.OutOfInk += OutOfInkEventHandler;
            for (int i = 0; i < 500; i++)
            {
                if (!_canPrint)
                {
                    break;
                }
                printer.Print(i);
            }
        }
    }
}
