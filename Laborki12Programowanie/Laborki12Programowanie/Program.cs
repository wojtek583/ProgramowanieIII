using System;
using System.Linq;

namespace Laborki12Programowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new IOFileReader();
            var people = reader.ReadPeople("dane.txt");

            var sortedPeople = people.OrderBy(x => x.LastName).ThenBy(x => x.Name);
            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"{person.Name}\t{person.LastName}");
            }

            Writer writer = new Writer();
            writer.WriteToFile(sortedPeople.First(), "result.txt");
            PhoneWriter writer1 = new PhoneWriter();

            writer1.WriteToFilePhone(people.ToList(), "numery.txt");






        }
    }
}
