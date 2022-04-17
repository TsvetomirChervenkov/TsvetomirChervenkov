 using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.Excercise.Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDishes = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
           
            Console.WriteLine(orders.Max());

            while (orders.Count != 0)
            {
                if (numberOfDishes >= orders.Peek())
                {
                    numberOfDishes -= orders.Dequeue();
                }
                else
                {
                    Console.WriteLine("Orders left: " + String.Join(" ", orders));
                    return;
                }
            }
            Console.WriteLine($"Orders complete");
        }
    }
}
