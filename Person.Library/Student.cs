using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Library
{
    public class Student : Person1
    {
        public Student(string name, string address, string program, int year, double fee) :base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        public override string ToString()
        {
            return $"{GetName()},{GetAddress()},{Program},{Year},{Fee}";
        }
    }
}
