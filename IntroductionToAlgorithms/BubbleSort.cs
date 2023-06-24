using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToAlgorithms
{
    internal class BubbleSort
    {
        public static List<int> Bubble_Sort(List<int> A, int n)
        {
            var temp = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j >= i + 1; j--)
                {
                    if (A[j] < A[j - 1])
                    {
                        temp = A[j - 1];
                        A[j - 1] = A[j];
                        A[j] = temp;
                    }

                }
            }

            return A;
        }
    }
}
