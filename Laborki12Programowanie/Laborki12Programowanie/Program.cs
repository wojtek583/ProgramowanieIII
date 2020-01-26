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
                Console.WriteLine($"{person.Name} {person.LastName}");
            }

            Writer writer = new Writer();

            writer.WriteToFile(sortedPeople.First(), "result.txt");
            writer.PhonesToFile(people.ToList(), "numery.txt");
            writer.WriteToFilePhone(people.ToList());

            writer.FileForEveryLetter(people.ToList());


        }
    }
}
