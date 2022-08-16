using System;
using System.Collections.Generic;
using System.Linq;

namespace T07.Excercise.The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            Dictionary<string, List<string>> followers = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> following = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] inputData = input.Split();
                string vlogger = inputData[0];
                string action = inputData[1];
                string secondVlogger = inputData[2];
                if (action == "joined")
                {
                    if (followers.ContainsKey(vlogger))
                        continue;
                    else
                    {
                        followers.Add(vlogger, new List<string>());
                        following.Add(vlogger, new List<string>());
                    }
                }
                else if (action == "followed")
                {
                    if (!followers.ContainsKey(vlogger) || !following.ContainsKey(secondVlogger))
                        continue;
                    else if (vlogger == secondVlogger)
                        continue;
                    else if (followers[secondVlogger].Contains(vlogger))
                        continue;
                    else if (following[vlogger].Contains(secondVlogger))
                        continue;
                    else
                    {
                        followers[secondVlogger].Add(vlogger);
                        following[vlogger].Add(secondVlogger);
                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {followers.Count} vloggers in its logs.");
            int counter = 1;
            foreach (var vloger in followers.OrderByDescending(x => x.Value.Count).ThenBy(name => following[name.Key].Count))
            {
                Console.WriteLine($"{counter}. {vloger.Key} : {vloger.Value.Count} followers, {following[vloger.Key].Count} following");
                if (counter == 1)
                    foreach (var follower in vloger.Value.OrderBy(x => x))
                        Console.WriteLine($"*  {follower}");

                counter++;
            }

        }
    }

}
