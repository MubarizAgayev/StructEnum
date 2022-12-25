using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Domain.Models;

namespace Task4.Service
{
    public class FindCustomers : IFindCustomers
    {
        
        public int GetCustomer(Customer[] customers)
        {
            var startsAge = 25;
            var endAge = 30;
            int count = 0;
            for(int i=0;i<customers.Length;i++)
            {
                if (customers[i].Age> startsAge && customers[i].Age<endAge)
                {
                    count++;
                }               
            }
            return count;
        }

        public int GetMiddleAgeCustomer(Customer[] customers)
        {
            int sum = 0;
            int result = 0;
            int count= 0;
            for(int i=0;i< customers.Length;i++)
            {
                sum += customers[i].Age;
            }
            result=sum/(customers.Length-1);
            return result;
        }
    }
}
