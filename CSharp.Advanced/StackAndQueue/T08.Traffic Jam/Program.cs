using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace T07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            int nth = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(input);

            int counter = 1;

            while (input.Count != 1)
            {
                string currentName = queue.Peek();
                if (counter == nth)
                {
                    queue.Dequeue();
                    input.Remove(currentName);
                    counter = 1;
                    Console.WriteLine($"Removed {currentName}");
                    continue;
                }
                queue.Dequeue();
                queue.Enqueue(currentName);
                
               
                counter++;
            }
            Console.WriteLine("Last is " + String.Join(" ", queue));
        }
    }
}
