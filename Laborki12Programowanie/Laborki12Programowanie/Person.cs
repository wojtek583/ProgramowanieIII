using System;
using System.Collections.Generic;
using System.Text;

namespace Laborki12Programowanie
{
    public class Person
    {
        public Person(int id, string name, string lastname, string phone)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            Phone = phone;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
