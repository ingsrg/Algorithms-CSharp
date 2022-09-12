using System;
using System.Collections.Generic;

namespace Intersect
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] res = Intersect(new int[] {4, 9, 5}, new int[] {9, 4, 9, 8, 4});
            foreach(int item in res)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] Intersect(int[] nums1, int[] nums2) {
            Array.Sort(nums1);
            Array.Sort(nums2);
            List<int> res = new List<int>();
            
            int i=0, j=0;
            
            while(i < nums1.Length && j < nums2.Length)
            {
                if(nums1[i] == nums2[j])
                {
                    res.Add(nums1[i]);
                    i++;
                    j++;
                }
                else if(nums1[i] < nums2[j])
                    i++;
                else if(nums1[i] > nums2[j])
                    j++;
            }
            return res.ToArray();
        }
    

        static int[] Intersect2(int[] nums1, int[] nums2) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> result = new List<int>();
            
            foreach(int item in nums1)
            {
                if(!dict.ContainsKey(item))
                    dict[item] = 0;
                dict[item]++;
            }
            
            foreach(int item in nums2)
            {
                if(dict.ContainsKey(item) && dict[item] > 0)
                {
                    result.Add(item);
                    dict[item]--;
                }
            }
            return result.ToArray();
        }
    
        static int[] Intersect1(int[] nums1, int[] nums2) {
            List<int> res = new List<int>();
            
            Array.Sort(nums1);
            Array.Sort(nums2);
            
            for(int i=0; i < nums1.Length; i++)
                for(int j=0; j < nums2.Length; j++)
                {
                    if(nums1[i] == nums2[j])
                    {
                        res.Add(nums1[i]);
                        nums2[j] = -1;
                        break;
                    }
                }
            return res.ToArray();
        }
    }
}
