namespace Algorithms
{
    public class InsertionSort
    {
        public static int[] Insertion_Sort(int[] num)
        {
            int j, key, n = num.Length;

            //for (int i = 1; i < num.Length; i++)
            //{
            //    key = num[i];
            //    j = i - 1;
            //    while (j >= 0 && num[j] > key)
            //    {
            //        num[j + 1] = num[j];
            //        j = j - 1;
            //    }
            //    num[j + 1] = key;
            //}
            for (int i = 1; i < num.Length; i++)
            {
                key = num[i];
                j = i - 1;
                while (j >= 0 && num[j] < key)
                {
                    num[j + 1] = num[j];
                    j = j - 1;
                }
                num[j + 1] = key;
            }
            return num;
        }
    }
}
