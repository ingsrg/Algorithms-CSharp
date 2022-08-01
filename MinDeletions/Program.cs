using System;

namespace MinDeletions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinDeletions("bbaaabbabb"));
        }

        static int MinDeletions(string word)
        {
            int n = word.Length;
            int bCount = 0;
            int[] dp = new int[n + 1];

            for(int i=0; i < n; i++)
            {
                if(word[i] == 'a')
                    dp[i+1] = Math.Min(dp[i] + 1, bCount);
                else
                {
                    dp[i+1] = dp[i];
                    bCount++;
                }
            }

            return dp[n];
        }
    }
}
