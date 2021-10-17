using System;
using System.Collections.Generic;
using System.Text;

namespace TasK2
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }
        public static bool operator >(Person p1, Person p2)
        {
            return p2.Age < p1.Age;
        }
    }
}
