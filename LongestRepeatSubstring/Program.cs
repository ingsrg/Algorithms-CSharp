using System;
using System.Collections.Generic;

namespace LongestRepeatSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestRepeatSubstring("banana"));
        }

        static private string LongestRepeatSubstring(string s)
        {
            HashSet<string> hs = new HashSet<string>();

            string result = "";

            for(int i=0; i < s.Length; i++)
            {
                for(int j=1; j <= s.Length - i; j++)
                {
                    string tmp = s.Substring(i, j);
                    if(hs.Contains(tmp))
                    {
                        if(tmp.Length > result.Length)
                            result = tmp;
                    }
                    else
                        hs.Add(tmp);
                }
            }
            return result;
        }
    }


}
