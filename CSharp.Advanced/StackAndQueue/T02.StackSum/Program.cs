using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            string commands = string.Empty;
            while(commands != "end")
            {
                commands = Console.ReadLine().ToLower();
                string[] command = commands.Split().ToArray();  
                string commandArgs = command[0].ToLower();
                if (commandArgs == "add")
                {
                    int first = int.Parse(command[1]);
                    int second = int.Parse(command[2]);
                    stack.Push(first);
                    stack.Push(second);
                }
                if (commandArgs == "remove")
                {
                    int count = int.Parse(command[1]);
                    if (count> stack.Count)
                    {
                        
                        continue;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        stack.Pop();
                    }
                }
            }
            int sum = 0;
            foreach (var item in stack)
            {
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
