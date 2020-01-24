using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Laborki12Programowanie
{
    class IOFileReader : IReader
    {
        public List<Person> ReadPeople(string filename)
        {
            string[] allData = File.ReadAllLines(filename);
            var people = allData.Select(x =>
            
                CSVStringToPersonConverter.Convert(x)
            );

            return people.ToList();
        }
    }
}
