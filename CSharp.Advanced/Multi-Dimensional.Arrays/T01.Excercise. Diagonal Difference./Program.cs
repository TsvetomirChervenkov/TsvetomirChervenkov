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
            int sumDiagonalLeft = 0;
            for (int row = 0; row < cubeSize; row++)
            {
                for (int column = 0; column < cubeSize; column++)
                {
                    if (row == column)
                    {
                        sumDiagonalLeft += cube[row, column];
                    }
                }
            }
            int sumDiagonalRight = 0;
            int counter = 0;
            for (int row = 0; row < cubeSize; row++)
            {
                for (int column = 0; column < cubeSize; column++)
                {
                    if (column == cubeSize - 1 - counter)
                    {
                        sumDiagonalRight += cube[row, column];
                        counter++;
                    }
                }
            }
            Console.WriteLine(Math.Abs(sumDiagonalRight - sumDiagonalLeft));
        }
    }
}
