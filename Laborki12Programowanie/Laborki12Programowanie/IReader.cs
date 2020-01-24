using System;
using System.Collections.Generic;
using System.Text;

namespace Laborki12Programowanie
{
    interface IReader
    {
        List<Person> ReadPeople(string filename);
    }
}
