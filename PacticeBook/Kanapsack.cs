using System;
using System.Collections.Generic;
using System.Text;

namespace PacticeBook
{
  public class Kanapsack
    {
        // This method will return the maximum profit
        
        public int CalculateMaxProfit(int[] profit, int[] weights, int capacity, int startIndex) 
        {
            int[,] dp = new int[profit.Length ,capacity + 1];
            return this.KnapsackRecursive(profit, weights, capacity, startIndex, dp);
        }

        private int KnapsackRecursive(int[] profit, int[] weights, int capacity, int startIndex, int[,] dp)
        {
            if (capacity == 0 || startIndex >= profit.Length) 
            {
                return 0;
            }
            if (dp[startIndex, capacity] > 0)
                return dp[startIndex, capacity];
            int profit1 = 0;
            if (weights[startIndex] <= capacity)
            {
                profit1 = profit[startIndex] + KnapsackRecursive(profit, weights, capacity - weights[startIndex], startIndex + 1, dp);
            }
            int profit2 = KnapsackRecursive(profit, weights, capacity, startIndex + 1,dp);
            dp[startIndex, capacity]= Math.Max(profit1, profit2);

            return dp[startIndex, capacity];
        }      

    }
}
