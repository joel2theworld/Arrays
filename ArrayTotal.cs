using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_Assessment1
{
    public class ArrayTotal
    {
        public static int SumArray(int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    total += 1;
                }
                else
                {
                    total += 3;
                }
                if (numbers[i] == 8)
                {
                    total += 5;
                }
            }
            return total;
        }
    }
}
