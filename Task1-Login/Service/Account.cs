using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Account:IAccount
    {
        public int CheckRolls(int rollId)
        {
            rollId = 1;
            return rollId;
        }

        public bool Login(string email, string password)
        {
            if (email == "test@code.edu.az" && password == "test12345")
            {
                return true;
            }
            return false;
        }
    }
}
