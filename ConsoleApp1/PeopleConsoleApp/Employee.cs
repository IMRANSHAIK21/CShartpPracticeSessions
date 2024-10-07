using PacktLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleConsoleApp
{
    // inheritance concept
    public class Employee : Person
    {
        public string EmployeeCode { get; set; }
        public new void WriteToConsole()
        {
            WriteLine("This is the Child Class");
        }
        public override string ToString()
        {
            return $"{Name} and code is {EmployeeCode}";
        }
    }
}
