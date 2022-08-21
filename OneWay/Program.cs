using System;

namespace OneWay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OneWay("hello", "jello"));
            Console.WriteLine(OneWay("hello", "helo"));
            Console.WriteLine(OneWay("helo", "hello"));
            Console.WriteLine(OneWay("hel", "hello"));
            Console.WriteLine(OneWay("hello", "lo"));
            Console.WriteLine(OneWay("hello", "helxx"));
        }

        //w1 is the largest string
        static bool OneWay(string word1, string word2)
        {
            string w1;
            string w2;

            w1 = word1.Length >= word2.Length ? word1 : word2;
            w2 = word1.Length >= word2.Length ? word2 : word1;

            if(Math.Abs(w1.Length - w2.Length) > 1)
                return false;

            bool oneChange = false;
            int j = 0;

            for(int i=0; i < w1.Length; i++)
            {
                if(w1[i] != w2[j])
                {
                    if(oneChange == false)
                        oneChange = true;
                    else                  
                        return false; 

                    if(w1.Length > w2.Length)
                        j--;                  
                }

                j++;
            }
            return true;
        }
    }
}
