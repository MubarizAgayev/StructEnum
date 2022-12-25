using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Domain.Models;

namespace Task4.Service
{
    internal interface IFindCustomers  
    {
        int GetCustomer(Customer[] customers);
        int GetMiddleAgeCustomer(Customer[] customers);
    }
}
