using System;

namespace BestTimeBuyAndSellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProfit(new int[] {7,1,5,3,6,4}));
        }

        static int MaxProfit(int[] prices) {
            int min = prices[0], maxHere = 0;
            
            for(int i=1; i < prices.Length; i++)
            {
                if(prices[i] < min)
                    min = prices[i];
                else if(prices[i] - min > maxHere)
                    maxHere = prices[i] - min;   
            }
        
            return maxHere;
        }
    
        static int MaxProfit2(int[] prices) {
            if(prices.Length == 1)
                return 0;
            
            int min = prices[0], max = 0;
            int maxHere = 0;
            
            for(int i=1; i < prices.Length; i++)
            {
                if(prices[i] < min)
                {
                    min = prices[i];
                    max = 0;
                }

                max = prices[i];   
                maxHere = Math.Max(maxHere, max - min);
            }
            
            return maxHere;
        }
    }
}
