using System;
using System.Linq;

namespace T03.Excercise.Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowNumber = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowNumber[0], rowNumber[1]];

            for (int row = 0; row < rowNumber[0]; row++)
            {
                int[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int cols = 0; cols < rowNumber[1]; cols++)
                {
                    matrix[row, cols] = currentRow[cols];
                }
            }
            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0; row < rowNumber[0]-2; row++)
            {               
                for (int cols = 0; cols < rowNumber[1]-2; cols++)
                {
                    int currentMaxSum = matrix[row, cols] + matrix[row, cols + 1] + matrix[row, cols + 2]
                        + matrix[row + 1, cols] + matrix[row + 1, cols + 1] + matrix[row + 1, cols + 2]
                        + matrix[row + 2, cols] + matrix[row + 2, cols + 1] + matrix[row + 2, cols + 2];
                    if (currentMaxSum > maxSum)
                    {
                        maxSum = currentMaxSum;
                        maxRow = row;
                        maxCol = cols;
                    }
                }
            }
            Console.WriteLine("Sum = " + maxSum);
            for (int row = maxRow; row < maxRow+3; row++)
            {
                for (int col = maxCol; col < maxCol+3; col++)
                {
                    Console.Write(matrix[row,col]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
