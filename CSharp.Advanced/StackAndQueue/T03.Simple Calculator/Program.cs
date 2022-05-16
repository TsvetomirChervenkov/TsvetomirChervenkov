using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            Array.Reverse(array);
            Stack<string> stack = new Stack<string>(array);
            int result = int.Parse(stack.Pop());

            while (stack.Count != 0)
            {
                string currentOperator = stack.Pop();
                if (currentOperator == "-")
                {
                    int currentDigit = int.Parse(stack.Pop());
                    result -= currentDigit;
                }
                if (currentOperator == "+")
                {
                    int currentDigit = int.Parse(stack.Pop());
                    result += currentDigit;
                }             
            }
            Console.WriteLine(result);
        }
    }
}
