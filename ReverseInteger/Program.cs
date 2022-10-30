using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int Reverse(int x) {
            long rev = 0;
            bool neg = false;
            
            if(x < 0){
                neg = true;
                x *= -1;
            }
            
            while(x > 0)
            {
                rev = rev * 10 + x % 10;            
                x /= 10;
            }
            
            if(rev > int.MaxValue) return 0;

            return neg ? (int)rev * -1 : (int)rev;
        }
    
    
    
        public int Reverse2(int x) {
            int rev = 0, tmp = 0;
            
            while (x != 0)
            {
                rev = rev * 10 + x % 10;
                
                if((rev - rev % 10) / 10 != tmp )
                    return 0;
                
                tmp = rev;
                x = x / 10;
            }
            
            return rev;
        }
    }
}
