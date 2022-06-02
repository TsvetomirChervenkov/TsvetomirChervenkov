using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.PrintEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    queue.Enqueue(item);
                }
            }
            Console.WriteLine(String.Join(", ", queue));
        }
    }
}
