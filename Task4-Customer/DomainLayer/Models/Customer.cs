using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Domain.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public Customer(int id,string name,string surname,int age,string position)
        {
            Id= id;
            Name= name; 
            Surname= surname;
            Age= age;
                Position= position;
        }

    }
}
