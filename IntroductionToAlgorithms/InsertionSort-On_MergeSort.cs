using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToAlgorithms
{
    //Insertion sort on small arrays in merge sort
    internal class InsertionSort_On_MergeSort
    {

        public static List<int> insertsort_on_merge(List<int> A, int p, int q, int r)
        {   
            var nL = q - p + 1;// length of A[p:q]
            var nR = r - q;// length of A[q+1:r]
            int[] L = new int[nL]; // L[0:nL-1]
            int[] R = new int[nR]; // L[0:nL-1]
            int[] B = new int[A.Count]; // L[0:nL-1]
            for (int i = 0; i < nL; i++)
            {
                L[i] = A[p + i];
            }
            for (int j = 0; j < nR; j++)
            {
                R[j] = A[q + j + 1];

            }
            int key=0;
            int c = 0;
            int d = 0;
            int k = p;
            
            return A;
        }
        public static List<int> merge_sort(List<int> A, int p, int r)
        {
            if (p>=r)
            {
                return A;
            }
            var q = Math.Abs((p + r) / 2);
            merge_sort(A, p, q);

            merge_sort(A, q + 1, r);
            var List = insertsort_on_merge(A, p, q, r);
            return List;
        }
    }
}
