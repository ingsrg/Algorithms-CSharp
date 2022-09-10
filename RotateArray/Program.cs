using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {1, 2, 3, 4, 5, 6, 7};
            RotateArray(nums, 3);
            for(int i=0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        static void RotateArray(int[] nums, int k)
        {
            k = k % nums.Length;

            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        static void Reverse(int[] nums, int start, int end)
        {
            while(start < end)
            {
                int tmp = nums[start];
                nums[start] = nums[end];
                nums[end] = tmp;
                start++;
                end--;
            }
        }
    }
}
