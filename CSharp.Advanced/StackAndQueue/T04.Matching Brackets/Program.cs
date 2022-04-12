using System;
using System.Collections.Generic;

namespace T04.Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack <int> indices = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {               
                char current = input[i];
                if (current == '(')
                {
                    indices.Push(i);
                }
                if (current == ')')
                {
                    Console.WriteLine($"{input.Substring(indices.Peek(), 1+ i - indices.Peek())}");
                    indices.Pop();
                }
            }
        }
    }
}
