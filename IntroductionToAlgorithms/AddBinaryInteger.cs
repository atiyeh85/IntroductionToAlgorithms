using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class AddBinaryInteger
    {
        public static int[] ADD_BINARY_INTEGERS(int[] A, int[] B)
        {

            var carry = 0;
            var n = Math.Max(B.Length, A.Length);
            int[] C = new int[n+1];
            for (int i = 0; i < n; i++)
            {
                var a = A.Length>i ? A[i] : 0;
                var b = B.Length > i ? B[i] : 0;

                C[i] = ((a + b + carry) % 2);
                carry = (a + b + carry) / 2;
            }
            C[n]= carry;
            return C;
        }
    }
}
