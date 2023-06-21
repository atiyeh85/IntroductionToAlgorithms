using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class LinearSearch
    {
        public static int Linear_Search(int x, int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                    if (x == nums[i])
                    {
                        return i;
                    }
            }

            return 0;
        }
    }
}
