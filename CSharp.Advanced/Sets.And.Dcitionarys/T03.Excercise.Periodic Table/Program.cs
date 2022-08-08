using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.Excercise.Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            HashSet<string> uniqueChemicals = new HashSet<string>();

            for (int i = 0; i < lines; i++)
            {
                string[] inputData = Console.ReadLine().Split(' ');
                foreach (var item in inputData)
                {
                    uniqueChemicals.Add(item);
                }
            }
            foreach (var item in uniqueChemicals.OrderBy(x=> x))
            {
                Console.Write($"{item} ");
            }
        }
    }
}
