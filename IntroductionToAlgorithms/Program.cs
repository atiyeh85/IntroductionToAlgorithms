using IntroductionToAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();
            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            // Mergsort
            int p, q, r;
            r = 8;
            List<int> myList = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 100; ++i)
            {
                int rd = rnd.Next(1, 20);
                myList.Add(rd);
            }
            int len = rnd.Next(1, 20);
            //List<int> A = myList.GetRange(50, len);
            List<int> A = new List<int>() { 12, 3, 7, 9, 14, 6, 11, 2 };
            p = 0;
            r = A.Count() - 1;
            q = p + (r - p) / 2;
            var s = MergeSort.merge_sort(A, p, r);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
