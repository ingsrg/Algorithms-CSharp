using System;

namespace Knapsack
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] profits = {1, 6, 10, 16};
            int[] weights = {1, 2, 3, 5};
            int maxProfit = SolveKnapsack(profits, weights, 7);
            Console.WriteLine(maxProfit);
        }

        static int SolveKnapsack(int[] profits, int[] weights, int capacity)
        {
            int[][] dp = new int[profits.Length][];
            for(int i = 0; i < profits.Length; i++)
                dp[i] = new int[capacity+1];
            
            return SolveKnapsack(dp, profits, weights, capacity, 0);
        }
	
        static int SolveKnapsack(int[][] dp, int[] profits, int[] weights, int capacity, int index)
        {
            if(capacity <= 0 || index >= profits.Length)
                return 0;
            
            if(dp[index][capacity] != 0)
                return dp[index][capacity];
            
            int profits1 = 0;
            if(weights[index] <= capacity)
                profits1 = profits[index] + SolveKnapsack(dp, profits, weights, capacity - weights[index], index + 1);
            
            int profits2 = SolveKnapsack(dp, profits, weights, capacity, index + 1);
            
            dp[index][capacity] = Math.Max(profits1, profits2);
            return dp[index][capacity];
        }
    }
}
