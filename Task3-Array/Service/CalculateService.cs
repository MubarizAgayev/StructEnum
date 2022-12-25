using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CalculateService:ICalculateService
    {
        public int GetMulti(int[] arr)
        {
            int result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 1 && arr[i] < 20)
                {
                    result *= arr[i];
                }
            }
            return result;
        }

        public int GetSum(int[] arr)
        {
            int sum = 0;
            int result1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            result1 = sum * sum;
            return result1;
        }
    }
}
