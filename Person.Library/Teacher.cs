using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Library
{
    public class Teacher : Person1
    {
        public Teacher(string name, string address, string school, double pay) :base(name, address)
        {
            School = school;
            Pay = pay;
        }

        private string School { get; set; }
        private double Pay { get; set; }

        public override string ToString()
        {
            return $"{GetName()},{GetAddress()},{School},{Pay}";
        }
    }
}
