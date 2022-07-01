using System;
using System.Collections.Generic;

namespace T01.Excercise.Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());

            HashSet<string> uniqueUsernames = new HashSet<string>();

            for (int row = 0; row < inputLines; row++)
                uniqueUsernames.Add(Console.ReadLine());      
            
            foreach (var username in uniqueUsernames)
                Console.WriteLine(username);            
        }
    }
}
