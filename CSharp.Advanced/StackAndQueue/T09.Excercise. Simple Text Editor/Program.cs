using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T09.Excercise._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operations = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < operations; i++)
            {
                string current = string.Empty;

                if (stack.Count != 0)
                {
                    current = stack.Peek();
                }
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "1")
                {
                    current += input[1];
                    stack.Push(current);
                }
                else if (input[0] == "2")
                {
                    int count = int.Parse(input[1]);
                    current = stack.Peek();
                    current = current.Remove(current.Length - count, count);
                    stack.Push(current);
                }
                else if (input[0] == "3")
                {
                    int index = int.Parse(input[1]);
                    current = stack.Peek();
                    Console.WriteLine(current[index - 1]);
                }
                else if (input[0] == "4")
                {
                    stack.Pop();
                }
            }
        }
    }
}
