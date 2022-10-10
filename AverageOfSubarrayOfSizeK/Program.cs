using System;

namespace AverageOfSubarrayOfSizeK
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] {1, 3, 2, 6, -1, 4, 1, 8, 2 };

            double[] res = AverageOfSubarrayOfSizeK(test, 5);
            foreach(var item in res)
            {
                Console.Write(item + " ");
            }
        }

        static double[] AverageOfSubarrayOfSizeK(int[] arr, int k)
        {
            int sum = 0;
            int idx = 0;
            double[] res = new double[arr.Length - k + 1];

            for(int i=0; i < arr.Length; i++)
            {
                sum += arr[i];

                if(i >= k - 1)
                {
                    res[idx] = (double)sum / k;
                    sum -= arr[idx];
                    idx++;
                }
            }
            return res;
        }
    }
}
