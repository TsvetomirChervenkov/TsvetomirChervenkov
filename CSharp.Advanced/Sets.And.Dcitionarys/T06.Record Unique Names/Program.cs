using System;
using System.Collections.Generic;

namespace T06.Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int names = int.Parse(Console.ReadLine());

            HashSet<string> uniqueNames = new HashSet<string>();

            for (int inputRow = 0; inputRow < names; inputRow++)
            {
                string inputLine = Console.ReadLine();
                uniqueNames.Add(inputLine);
            }

            foreach (var item in uniqueNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
