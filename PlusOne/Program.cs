using System;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int[] PlusOne(int[] digits)
        {
            for(int i=digits.Length -1; i >= 0; i--)
            {
                if(digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            
            int[] res = new int[digits.Length + 1];
            res[0] = 1;
            return res;
        }
    
        static int[] PlusOne1(int[] digits)
        {
            for(int i=digits.Length - 1; i >= 0; i--)
            {
                if(digits[i] < 9)
                {
                    digits[i] ++;
                    return digits;
                }
                
                digits[i] = 0;
            }
            
            int[] res = new int[digits.Length + 1];
            res[0] = 1;
            return res;
        }
    
        static int[] PlusOne2(int[] digits) {
            int c=1, i = digits.Length - 1;
            
            while(c > 0 && i >= 0)
            {
                if(digits[i] == 9)
                    digits[i] = 0;
                else
                {
                    digits[i]++;
                    c = 0;
                }
                
                i--;
            }
            
            if(c > 0)
            {
                int[] res = new int[digits.Length + 1];
                int j=0;
                res[j++] = 1;
                foreach(int item in digits)
                {
                    res[j++] = item;
                }
                
                return res;
            }
            else
            {
                return digits;
            }
        }
    }
}
