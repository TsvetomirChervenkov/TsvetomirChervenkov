using System;
using System.Collections;

namespace T01.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Stack stack = new Stack();

            for (int i = 0; i < word.Length; i++)
            {
                stack.Push(word[i]);
            }
            for (int i = stack.Count; i > 0; i--)
            {
                Console.Write(stack.Peek());
                stack.Pop();
            }
        }
    }
}
   