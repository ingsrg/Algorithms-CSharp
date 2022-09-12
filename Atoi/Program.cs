using System;

namespace Atoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyAtoi("   -234 asdf"));
        }

        static int MyAtoi(string s) {
            int i=0;
            int sign = 1;
            int basee = 0;
            
            if(s == null || s.Trim() == "")
                return basee;
            
            while(i < s.Length && s[i] == ' ') i++;
            
            if(i < s.Length && s[i] == '+' || s[i] == '-')
            {
                int tmp = 0;
                if(s[i++] == '-') tmp = 1;
                sign = 1 - 2 * tmp;
            }
            
            while(i < s.Length && s[i] >= '0' && s[i] <= '9')
            {
                if(basee > int.MaxValue / 10 || (basee == int.MaxValue / 10 && s[i] - '0' > 7))
                    return sign == 1 ? int.MaxValue : int.MinValue;
                basee = basee * 10 + (s[i++] - '0');
            }
            
            return basee * sign;
        }
    }
}
