using System;
using System.Collections.Generic;

namespace SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SingleNumber(new int[] {1, 2, 3, 2}));
        }

        static int SingleNumber(int[] nums) 
        {
            int r = 0;
            foreach(int item in nums)
            {
                r ^= item;
            }
            
            return r;
        }
    
        static int SingleNumber1(int[] nums) {
            HashSet<int> hs = new HashSet<int>();
            int r = 0;
            
            foreach(int item in nums)
            {
                if(hs.Contains(item))
                    hs.Remove(item);
                else
                    hs.Add(item);
            }
            
            foreach(int item in hs)
                r = item;
            
            return r;
        }


    }
}
