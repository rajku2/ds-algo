using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PacticeBook
{
    class Program
    {
        static void Main(string[] args)
        {
           //Initialize the objects to match the question.
            int[] profits= { 1, 3, 4, 5, 7 };
            int[] weights = {2, 3, 6, 8, 11 };
            int capacity = 11;
            Kanapsack ks = new Kanapsack();
            int maxprofit = ks.CalculateMaxProfit(profits, weights, capacity, 0); 
        }
     
    }
}
