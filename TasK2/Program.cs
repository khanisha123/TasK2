using System;

namespace TasK2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Khanisha", "Alasgarov", 16);
            Person p2 = new Person("Husein", "Bagirov", 17);
            Person p4 = new Person("Kamran", "Esgerov", 25);
            Person p3 = new Person("Murad", "Memmedov", 20);

            Person[] people = { p2, p1, p4, p3 };

            for (int k = 0; k < people.Length - 1; k++)
            {
                if (people[k] > people[k + 1])
                {
                    var verify = people[k];
                    people[k] = people[k + 1];
                    people[k + 1] = verify;
                }

            }
            foreach (var substance in people)
            {
                Console.WriteLine(substance.Age);
            }
        }
    }
}
