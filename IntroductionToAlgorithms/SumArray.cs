using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SumArray
    {

        public static int Sum_Array(int[] A)
        {
            var sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum+= A[i]; 
            }

            return sum;
        }
    }
}
