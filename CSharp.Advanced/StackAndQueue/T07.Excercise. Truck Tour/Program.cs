using System;
using System.Collections.Generic;
using System.Linq;

namespace T07.Excercise._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int petrolStations = int.Parse(Console.ReadLine());
            int pump = 0;
            int counter = 0;
            bool enough = false;

            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < petrolStations; i++)
            {
                int[] station = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(station);
            }

            for (int i = 0; i < petrolStations; i++)    
            {
                pump = 0;              
                foreach (var cicle in queue)
                {
                    int fuel = cicle[0];
                    int distance = cicle[1];
                    pump += fuel;
                    pump -= distance;
                    if (pump < 0)
                    {
                        break;
                    }
                }
                if (pump >= 0)
                {
                    Console.WriteLine(counter);
                    return;
                }
                else
                {
                    var currentStart = queue.Dequeue();
                    queue.Enqueue(currentStart);
                    counter++;
                }
            }
        }
    }
}
