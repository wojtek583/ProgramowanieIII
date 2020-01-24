using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laborki12Programowanie
{
    public class TenPhoneNumbers
    {
        public void PhonesToFile(List<Person> person, string fileName)
        {
            using StreamWriter writer = new StreamWriter(fileName, false);

            foreach (var item in person)
            {

               writer.Write($"[{item.Id}][{item.Phone}]\n");

            }
        }
    }
}
