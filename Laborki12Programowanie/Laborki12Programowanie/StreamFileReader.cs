using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Laborki12Programowanie
{
    class StreamFileReader : IReader
    {
        public List<Person> ReadPeople(string filename)
        {

            using var reader = new StreamReader(filename);
            string data = reader.ReadToEnd();

            string[] lines = data.Split(new[] { '\n','\r'},StringSplitOptions.RemoveEmptyEntries);

            var people = lines.Select(x => CSVStringToPersonConverter.Convert(x));

            return people.ToList();
        }
    }
}
