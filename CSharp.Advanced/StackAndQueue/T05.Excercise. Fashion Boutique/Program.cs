using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.Excercise._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> stackOfClothes = new Stack<int>(clothes);
            int rackCounter = 0;
            while (stackOfClothes.Count != 0)
            {
                int currentRack = rackCapacity;     
                rackCounter++;
                while (currentRack > 0)
                {            
                    if (stackOfClothes.Count == 0 || currentRack - stackOfClothes.Peek() < 0)
                    {
                        break;
                    }
                    else
                    {
                        currentRack -= stackOfClothes.Pop();
                    }
                }
            }
            Console.WriteLine(rackCounter);
        }
    }
}
