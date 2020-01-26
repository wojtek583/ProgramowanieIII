using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Laborki12Programowanie
{
    public class Writer
    {
        public void WriteToFile(Person person, string fileName)
        {
           using StreamWriter writer = new StreamWriter(fileName, false);

            writer.Write($"[{person.Name}]{person.Name}{person.LastName}");
        }


        public void PhonesToFile(List<Person> person, string fileName)
        {
            using StreamWriter writer = new StreamWriter(fileName, false);

            foreach (var item in person)
            {
                writer.Write($"[{item.Id}][{item.Phone}]\n");
            }
        }


        public void WriteToFilePhone(List<Person> person)
        {
            
            for (int i = 0; i < Math.Ceiling(person.Count()/10.0); i++)
            {
                var fileName = $"1/{i}.txt";
                using StreamWriter writer = new StreamWriter(fileName, false);

                foreach (var item in person.Skip(i*10).Take(10))
                    {
                         writer.Write($"[{item.Phone}]\n");
                         
                    }
            }
        }

        public void FileForEveryLetter(List<Person> person)
        {
            var litera = person.OrderBy(x => x.Name).Select(x => x.Name[0]).Distinct();

            foreach (var item in litera)
            {
                var fileName = $"2/{item}.txt";
                using StreamWriter writer = new StreamWriter(fileName, false);

                var dane = person.Where(x => x.Name[0] == item);
                foreach (var selected in dane)
                {
                    writer.WriteLine($"[{selected.Id}] [{selected.Phone}] |{selected.Name} {selected.LastName}|");
                }
            }
        }
    }
}
