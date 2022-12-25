using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2_ClassTask
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Employee(string name,string surname,int age,String address)
        {
            Name= name;
            Surname= surname;
            Age= age;
            Address= address;
        }
        public override string ToString()
        {
            return $"{Name} {Surname} {Age} {Address}";
        }

    }
}
