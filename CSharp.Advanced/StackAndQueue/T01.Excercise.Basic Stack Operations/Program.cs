using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.Excercise.Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            int numsToPush = nums[0];
            int numsToPop = nums[1];
            int elementToLook = nums[2];

            for (int i = 0; i < numsToPush; i++)
            {
                stack.Push(array[i]);
            }
            for (int i = 0; i < numsToPop; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }
            else if(stack.Contains(elementToLook))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
