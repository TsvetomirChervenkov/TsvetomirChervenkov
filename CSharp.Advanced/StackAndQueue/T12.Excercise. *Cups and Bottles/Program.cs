using System;
using System.Collections.Generic;
using System.Linq;

namespace T12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int wastedWatter = 0;

            while (cups.Count != 0 && bottles.Count != 0)
            {
                var currentBottle = bottles.Peek();
                var currentCup = cups.Peek();
                if (currentBottle >= currentCup)
                {
                    cups.Dequeue();
                    bottles.Pop();
                    wastedWatter += currentBottle- currentCup;
                    continue;
                }
                if (currentBottle < currentCup)
                {
                    while (currentCup> 0)
                    {
                        currentBottle = bottles.Peek();
                        currentCup -= currentBottle;
                        bottles.Pop();
                    }
                    wastedWatter+= Math.Abs(currentCup);
                    cups.Dequeue();
                }
            }
            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");               
            }
            if (cups.Count > 0 )
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine("Wasted litters of water: " + wastedWatter);
        }
    }
}
