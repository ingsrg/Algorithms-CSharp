using System;

namespace FirstBadVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

         public int FirstBadVersion(int n) {
            int left = 1;
            int right = n;
            
            while(left < right)
            {
                int mid = left + (right-left)/2;
                
                if(!IsBadVersion(mid))
                    left = mid + 1;
                else
                    right = mid;
            }
            
            return left;
        }
    }
}
