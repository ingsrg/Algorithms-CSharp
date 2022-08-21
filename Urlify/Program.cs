using System;

namespace Urlify
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Urlify("He llo World!      ", 13));
        }

        static string Urlify(string str, int len)
        {
            int idx = len - 1;
            int lastIdx = str.Length - 1;
            char[] strArray = new char[str.Length];

            for(int i=idx; i >= 0; i--)
            {
                if(str[i] == ' ')
                {
                    strArray[lastIdx] = '0';
                    strArray[lastIdx - 1] = '2';
                    strArray[lastIdx - 2] = '%';
                    lastIdx = lastIdx - 3;
                }
                else
                {
                    strArray[lastIdx--] = str[i];
                }
            }

            return new String(strArray);
        }   
    }
}
