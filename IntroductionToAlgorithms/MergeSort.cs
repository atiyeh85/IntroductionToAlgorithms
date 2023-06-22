using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToAlgorithms
{
    internal class MergeSort
    {
        public static List<int> merge(List<int> A, int p, int q, int r)
        {

            var nL = q - p + 1;// length of A[p:q]
            var nR = r - q ;// length of A[q+1:r]
            int[] L=new int[nL]; // L[0:nL-1]
            int[] R=new int[nR]; // L[0:nL-1]
            for (int i = 0; i < nL ; i++)
            {
                L[i]= A[p + i];
            }
            for (int j = 0; j < nR;  j++)
            {
                R[j] = A[q+ j + 1];

            }
            int c = 0;// c indexes the smallest remaining element in L
            int d = 0;// d indexes the smallest remaining element in R
            int k=p; //k indexes the location in A to fill
            // As long as each of the arrays L and R contains an unmerged element,
            // copy the smallest unmerged element back into A[p:r].
            while (c<nL && d< nR){

                if (L[c] < R[d])
                {
                    A[k] = L[c];
                    c++;
                }
                 else
                 {
                    A[k] = R[d];
                    d++;
                 }
            k++;
            }
            // Having gone through one of L and R entirely, copy the
            // remainder of the other to the end of A[p:r].

            while (c < nL )
            {
                A[k] = L[c];
                c++;
                k++;
            }
            while (d <  nR )
            {
                A[k] = R[d];
                d++;
                k++;
            }
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
            
            merge_sort(A,q+1, r);
           var List= merge(A, p, q,r);
            return List;
        }
    }
}
