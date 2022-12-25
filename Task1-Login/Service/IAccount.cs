﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IAccount
    {
        int CheckRolls(int rollId);
        bool Login(string email, string password);
    }
}
