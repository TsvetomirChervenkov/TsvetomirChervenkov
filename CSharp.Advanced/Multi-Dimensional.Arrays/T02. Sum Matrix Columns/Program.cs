using System;
using System.Linq;

namespace T02._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            for (int row = 0; row < matrixSize[0]; row++)
            {
                int[] firstRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int column = 0; column < matrixSize[1]; column++)
                {
                    matrix[row, column] = firstRow[column];
                }
            }
            int sum = 0;
            for (int column = 0; column < matrixSize[1]; column++)
            {
                sum = 0;
                for (int row = 0; row < matrixSize[0]; row++)
                {
                    sum+= matrix[row, column];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
