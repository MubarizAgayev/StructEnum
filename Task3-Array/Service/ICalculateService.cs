using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ICalculateService
    {
        int GetMulti(int[] arr);
        int GetSum(int[] arr);
    }
}
