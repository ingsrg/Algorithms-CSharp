using System;

namespace MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tmp = new int[] {0,1,0,3,12};
            MoveZeroes(tmp);
            foreach(int item in tmp)
                Console.WriteLine(item);
        }

        static void MoveZeroes(int[] nums) {
            int idx = 0;
            
            if(nums.Length == 1)
                return;
            
            for(int i=0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    nums[idx] = nums[i];
                    if(idx != i) 
                        nums[i] = 0;
                    idx++;
                }
                
            }
        }
    }
}
