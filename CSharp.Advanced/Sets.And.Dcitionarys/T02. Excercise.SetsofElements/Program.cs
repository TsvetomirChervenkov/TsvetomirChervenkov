using System;
using System.Collections.Generic;
using System.Linq;

namespace T02._Excercise.Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] setDimensions = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            decimal n = setDimensions[0];
            decimal m = setDimensions[1];
            HashSet<decimal> nSet = new HashSet<decimal>();
            
            HashSet<decimal> uniqueNums = new HashSet<decimal>();

            for (int i = 0; i < n+m; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                if (i< n)
                {
                    nSet.Add(num);
                }
                if (i >= n)
                {
                    uniqueNums.Add(num);
                }
            }
            nSet.IntersectWith(uniqueNums);
            Console.WriteLine(String.Join(" ", nSet));
        }
    }
}
