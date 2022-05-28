using System;
using System.Linq;

namespace T05._Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]  matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            for (int row = 0; row < matrixSize[0]; row++)
            {
                int[] matrixRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int column = 0; column < matrixSize[1]; column++)
                {
                    matrix[row, column] = matrixRow[column];
                }
            }
            int biggestSum = 0;
            int[,] biggestSumCombo = new int[2,2];

            for (int row = 0; row < matrixSize[0]-1; row++)
            {
                int[,] currentSumCombo = new int[1,1];
                for (int column = 0; column < matrixSize[1]-1; column++)
                {
                    if (matrix[row, column] + matrix[row, column + 1] + matrix[row + 1, column] + matrix[row + 1, column + 1] > biggestSum)
                    {
                        biggestSum = matrix[row, column] + matrix[row, column + 1] + matrix[row + 1, column] + matrix[row + 1, column + 1];
                        biggestSumCombo[0, 0] = matrix[row, column];
                        biggestSumCombo[1, 0] = matrix[row+1, column];
                        biggestSumCombo[0, 1] = matrix[row, column+1];
                        biggestSumCombo[1 , 1] = matrix[row+1, column+1];                        
                    }
                }
            }
            for (int row = 0; row < 2; row++)
            {
                for (int column = 0; column < 2; column++)
                {
                    Console.Write($"{biggestSumCombo[row, column]} ");
                }               
                Console.WriteLine();
            }
            Console.WriteLine(biggestSum);
        }
    }
}
