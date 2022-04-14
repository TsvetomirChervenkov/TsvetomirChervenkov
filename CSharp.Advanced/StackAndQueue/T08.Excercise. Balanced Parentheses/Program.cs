using System;
using System.Collections.Generic;

namespace T08.Excercise._Balanced_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] paranthesis = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            if (paranthesis.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }
            for (int i = 0; i < paranthesis.Length; i++)
            {
                char current = paranthesis[i];
                int asciiChar = (int)current;
                if (current == '(' || current == '{' || current == '[')
                {
                    stack.Push(current);
                }
                else if (asciiChar == (int)stack.Peek()+2 || asciiChar == (int)stack.Peek()+1)
                {
                    stack.Pop();
                }
                else
                {   
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
