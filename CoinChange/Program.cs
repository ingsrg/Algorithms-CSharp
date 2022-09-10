using System;

namespace CoinChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 3;
            int[] M = new int[] {2, 4};

            Console.WriteLine(CoinChange(M, k));
        }

        static int CoinChange(int[] M, int k)
        {
            int[] dp = new int[k+1];

            for(int i=1; i <= k; i++)
            {
                dp[i] = k + 1;
            }

            for(int i=1; i <= k; i++)
            {
                for(int j=0; j < M.Length; j++)
                {
                    if(i - M[j] >= 0)
                    {
                        dp[i] = Math.Min(dp[i], 1 + dp[i - M[j]]);
                    }
                   // else
                   // {
                    //    dp[i] = -1;
                   // }
                }
            }
            return dp[k] > k ? -1 : dp[k];
        }
    }
}
