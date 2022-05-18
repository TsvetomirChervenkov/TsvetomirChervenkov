using System;
using System.Linq;

namespace T03.Primary_Diagona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cubeSize = int.Parse(Console.ReadLine());
            int[,] cube = new int[cubeSize, cubeSize];
            for (int row = 0; row < cubeSize; row++)
            {
                int[] rowCube = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int column = 0; column < cubeSize; column++)
                {
                    cube[row, column] = rowCube[column];
                }
            }
            int sum = 0;
            for (int row = 0; row < cubeSize; row++)
            {
                for (int column = 0; column < cubeSize; column++)
                {
                    if (row == column)
                    {
                        sum += cube[row, column];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
