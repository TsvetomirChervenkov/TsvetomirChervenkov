using System;
using System.Collections.Generic;
using System.Linq;

namespace T04._Excercise.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<int,int> map = new Dictionary<int, int>();   

            for (int i = 0; i < lines; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!map.ContainsKey(num))
                {
                    map.Add(num, 0);
                }
                map[num]++;
            }
            foreach (var item in map)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
            
            
        }
    }
}
