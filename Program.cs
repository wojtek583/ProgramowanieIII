using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp11
{
    public interface IOperations
    {
        public List<double> CountNextItemFromTabByIteration(List<double> m, int end);
        public void CountNextItemFromTabByRecursion(List<double> m, int end);
    }
    class Program : IOperations
    {
        public enum OperationType
        {
            Iteration,
            Recursion,
            Interface,
            yieldRetrun,
            Linq,
            WyrażeniaRegularne
        }
        public List<double> CountNextItemFromTabByIteration(List<double> m, int end)
        {
            if (m.Count < 2)
            {
                m.Add(1.0);
                m.Add(-8.0);
            }
            else if (m.Count <= end)
                for (int i = m.Count; i <= end; i++)
                    m.Add((1.0 / 2.0 * m[m.Count - 1]) - (1.0 / 3.0 * m[m.Count - 2]));

            return m;
        }
        public void CountNextItemFromTabByRecursion(List<double> m, int end)
        {
            if (m.Count < 2)
            {
                m.Add(1.0);
                m.Add(-8.0);
                CountNextItemFromTabByRecursion(m, end);
            }
            else if (m.Count <= end)
            {
                m.Add((1.0 / 2.0 * m[m.Count - 1]) - (1.0 / 3.0 * m[m.Count - 2]));
                CountNextItemFromTabByRecursion(m, end);
            }

        }
        public static void ShowTab(IEnumerable<double> m, OperationType type)
        {
            Console.WriteLine($"\n{type} : ");
            foreach (var number in m)
            {
                Console.WriteLine($"| {number}  | ");
            }
            Console.WriteLine("\n------------------------------------------------------------------");
        }

        public static IEnumerable<double> ReturnMString(List<double> m) 
        {
            Console.WriteLine("yiled zapamiętuje iterator w którym znajduje się funkcja\n"+
                              "Deklaracja iteratora musi spełniać następujące wymagania:\n"+
                               "- Typem zwracanym musi być IEnumerable, IEnumerable<T>, IEnumeratorlub IEnumerator<T>.\n"+
                               "- Deklaracja nie może zawierać żadnych parametrów ref ani out .\n"+
                              "yield break -> przerywa zwracanie iteratora.");
            int i = 0;
            foreach (var item in m)
            {
                if (i == 3)
                    yield break;
                i++;
                yield return item;
            }
        }
        static void Main(string[] args)
        {
            OperationType type;
            List<double> m = new List<double> { 1.0, -8.0 };

            type = OperationType.Interface;
            IOperations program = new Program();


            type = OperationType.Iteration;
            m = program.CountNextItemFromTabByIteration(m, 10);
            ShowTab(m, type);

            type = OperationType.Recursion;
            program.CountNextItemFromTabByRecursion(m, 20);
            ShowTab(m, type);

            type = OperationType.yieldRetrun;
            ShowTab(ReturnMString(m), type);

            type = OperationType.Linq;
            List<double> m2 = new List<double> { 6.0, 3.0, 4.0, 7.0, 9.0 };
            m2 = m2.Where(x => x % 3 == 0).OrderByDescending(x => x).ToList();
            ShowTab(m2, type);


            type = OperationType.WyrażeniaRegularne;
            Console.WriteLine("http://kurs.aspnetmvc.pl/Csharp/Wyrazenia_regularne");
            Console.ReadKey();
        }
    }
}
