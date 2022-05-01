using System;
using System.Collections.Generic;
using System.Linq;

namespace T11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int numberOfBullets = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int value = int.Parse(Console.ReadLine());
            int counter = 0;
            int totalBullets = bullets.Count;

            while (bullets.Count != 0 && locks.Count != 0)
            {
                var currentBullet = bullets.Pop();

                counter++;
                var currentLock = locks.Peek();
                if (currentBullet <= currentLock)
                {                   
                    Console.WriteLine("Bang!");
                    locks.Dequeue();                   
                    value -= priceOfBullet;                  
                }
                if (currentBullet > currentLock)
                {
                    Console.WriteLine("Ping!");
                    value-= priceOfBullet;
                }
               
                if (bullets.Count == 0 && locks.Count != 0 )
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    Environment.Exit(0);
                }
                if (counter % numberOfBullets == 0 && counter < totalBullets)
                {
                    Console.WriteLine("Reloading!");
                }
            }
            
            if (bullets.Count >= 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${value}");
            }
        }
    }
}

