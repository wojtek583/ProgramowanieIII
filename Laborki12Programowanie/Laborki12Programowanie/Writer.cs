using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laborki12Programowanie
{
    public class Writer
    {
        public void WriteToFile(Person person, string fileName)
        {
           using StreamWriter writer = new StreamWriter(fileName, true);

            writer.Write($"[{person.Name}]{person.Name}{person.LastName}");
        }
       
    }
}
