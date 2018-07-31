using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using People.Library;

namespace Lab_12_PersonClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person1>
            {
                new Student("Ross Hinman", "1835 Evergreen St.", "Engineering", 3, 12000),
                new Teacher("Amy Tacoma", "610 Parkwood St.", "GVSU", 30000),
                new Person1("Kyle Fitton", "1234 Road St."),
                new Student("Jimmy Jones", "473 Road Dr.", "Sports and Activities", 2, 1000)
            };

            foreach (Person1 x in people)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
}
