using System;

namespace PalindromePerm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PalindromePerm("acaa"));
        }

        static bool PalindromePerm(string word)
        {
            int[] mem = new int[26];
            int countOdd = 0;

            for(int i=0; i < word.Length; i++)
            {
                if(word[i] >= 'a' && word[i] <= 'z')
                {
                    int val = word[i] - 'a';

                    mem[val]++;
                    if(mem[val] % 2 == 0)
                        countOdd --;
                    else
                        countOdd ++;
                }
            }

            return countOdd < 2;
        }
    }
}
