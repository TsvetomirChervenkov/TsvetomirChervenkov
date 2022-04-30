using System;
using System.Collections.Generic;
using System.Linq;

namespace T10.Excercise._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int window = int.Parse(Console.ReadLine());
            Queue<List<char>> queue = new Queue<List<char>>();
            int counter = 0;

            string input = string.Empty;

             while ((input = Console.ReadLine()) != "END")
            {
                if (input != "green")
                {
                    queue.Enqueue(new List<char>(input));
                    continue;
                }
                else
                {
                    int currentGreenLight = greenLight;
                    while (currentGreenLight >= 0 && queue.Count > 0)
                    {
                        var currentCar = queue.Dequeue();
                        if (currentCar.Count -currentGreenLight == 0)
                        {
                            counter++;
                            break;
                        }
                        if (currentGreenLight-currentCar.Count > 0 )
                        {
                            currentGreenLight-= currentCar.Count;
                            counter++;
                            continue;
                        }
                        if (currentCar.Count - currentGreenLight - window <= 0)
                        {
                            currentGreenLight -= currentCar.Count;
                            counter++;
                            continue;
                        }
                        if (currentCar.Count - currentGreenLight - window >= 0)
                        {
                            int hittedChar = (currentGreenLight + window);
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{string.Join("", currentCar)} was hit at {currentCar[hittedChar]}.");
                            Environment.Exit(0);
                        }
                    }                                             
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}
