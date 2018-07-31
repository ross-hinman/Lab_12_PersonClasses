using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Library
{
    public class Person1
    {
        public Person1(string name, string address)
        {
            Name = name;
            Address = address;
        }
        private string Name { get; set; }
        private string Address { get; set; }

        public override string ToString()
        {
            return $"{Name},{Address}";
        }
        public string GetName()
        {
            return Name;
        }
        public string GetAddress()
        {
            return Address;
        }
    }

}
