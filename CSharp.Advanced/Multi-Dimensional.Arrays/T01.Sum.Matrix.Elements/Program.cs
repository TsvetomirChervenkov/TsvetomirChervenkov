using System;
using System.Linq;

namespace T01_
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
            Console.WriteLine(matrixSize[0]);
            Console.WriteLine(matrixSize[1]);
            int sum = 0;
            foreach (var digit in matrix)
            {
                sum += digit;
            }
            Console.WriteLine(sum);
        }
    }
}
