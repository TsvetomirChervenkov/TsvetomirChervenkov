using System;
using System.Collections.Generic;

namespace T06.Excercise.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int line = 0; line < lines; line++)
            {
                string[] inputData = Console.ReadLine().Split(" -> ");
                if (!wardrobe.ContainsKey(inputData[0]))
                {
                    wardrobe.Add(inputData[0], new Dictionary<string, int>());
                }
                string[] clothes = inputData[1].Split(",");
                foreach (var cloth in clothes)
                {
                    if (!wardrobe[inputData[0]].ContainsKey(cloth))
                    {
                        wardrobe[inputData[0]].Add(cloth, 0);
                    }
                    wardrobe[inputData[0]][cloth]++;
                }
            }
            string[] searched = Console.ReadLine().Split();

            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var cloths in kvp.Value)
                {
                    if (searched[0] == kvp.Key && searched[1] == cloths.Key)
                    {
                        Console.WriteLine($"* {cloths.Key} - {cloths.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {cloths.Key} - {cloths.Value}");
                }
            }
        }
    }
}
