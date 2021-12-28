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
            //string s = "This : is a car123";
            ////s.Remove()
            //s = string.Concat(s.Where(char.IsLetterOrDigit));
            //s = Regex.Replace(s, "[^a-zA-Z0-9]", string.Empty);
            ////s[0].Equals(s[1],StringComparison.OrdinalIgnoreCase)
            ////Console.WriteLine(s.ToLower());
            ////char ape = '5';
            ////string.Equals()
            //HashSet<char> hschar = new HashSet<char>
            //{'a','e','i','o','u','A','E','I','O','U'};

            int[] profits= { 1, 3, 5, 7 };
            int[] weights = { 3, 6, 8, 11 };
            int capacity = 11;
            Kanapsack ks = new Kanapsack();
            int maxprofit = ks.CalculateMaxProfit(profits, weights, capacity, 0); 
        }

        //public bool CheckIfPalindrome(string input)
        //{
        //    char s = 'a';
        //    s.GetType();
        //}
    }
}
