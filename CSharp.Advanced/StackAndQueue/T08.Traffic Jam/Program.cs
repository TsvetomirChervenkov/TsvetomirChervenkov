using System;
using System.Collections.Generic;

namespace T08.Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passingCars = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int counter = 0;

            Queue<string> cars = new Queue<string>();

            while ((input = Console.ReadLine())!= "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < passingCars; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        counter++;
                    }
                    continue;
                }
                cars.Enqueue(input);
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
