using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Dictionary<double, int> occurances = new Dictionary<double, int>();

            foreach (var digit in input)
            {
                if (!occurances.ContainsKey(digit))
                    occurances.Add(digit, 0);
                occurances[digit]++;
            }

            foreach (var kvp in occurances)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
