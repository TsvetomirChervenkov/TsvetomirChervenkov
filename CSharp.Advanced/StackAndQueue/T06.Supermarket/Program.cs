using System;
using System.Collections.Generic;

namespace T06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Queue<string> queue = new Queue<string>();

            while ((input = Console.ReadLine())!= "End")
            {
                if (input == "Paid")
                {
                    while (queue.Count != 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    continue;
                }
                queue.Enqueue(input);
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
