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


        public void WriteToFilePhone(List<Person> person, string fileName)
        {
            for (int i = 0; i < person.Count()/10; i++)
            {
                fileName = $"1/{i}.txt";
                using StreamWriter writer = new StreamWriter(fileName, false);

                   person.Skip(10);
           
                foreach (var item in person.Take(10))
                    {
                         writer.Write($"[{item.Phone}]\n");
                         
                    }
            }
            
        }
    }
}
