using System;
using System.Linq;

namespace T06._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] matrix = new long[rows][];

            for (int row = 0; row < rows; row++)
            {
                long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
                matrix[row] = numbers;
                if (row > 0 && matrix[row].Length == matrix[row - 1].Length)
                {
                    for (int currRow = row - 1; currRow < row + 1; currRow++)
                    {
                        for (int currCol = 0; currCol < matrix[row].Length; currCol++)
                        {
                            matrix[currRow][currCol] *= 2;
                        }
                    }
                }
                else if (row > 0 && matrix[row].Length != matrix[row - 1].Length)
                {
                    for (int currRow = row - 1; currRow < row + 1; currRow++)
                    {
                        for (int currCol = 0; currCol < matrix[currRow].Length; currCol++)
                        {
                            matrix[currRow][currCol] /= 2;
                        }
                    }
                }
            }
            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commArgs = command.Split();
                if (commArgs[0] == "Add")
                {
                    int row = int.Parse(commArgs[1]);
                    int col = int.Parse(commArgs[2]);
                    int value = int.Parse(commArgs[3]);
                    if (row < 0 || row > rows || col < 0 || col >= matrix[row].Length)
                    {
                        continue;
                    }
                    matrix[row][col] += value;
                }
                else if (commArgs[0] == "Subtract")
                {
                    int row = int.Parse(commArgs[1]);
                    int col = int.Parse(commArgs[2]);
                    int value = int.Parse(commArgs[3]);
                    if (row < 0 || row > rows || col < 0 || col >= matrix[row].Length)
                    {
                        continue;
                    }
                    matrix[row][col] -= value;
                }
            }


            foreach (long[] item in matrix)
            {
                Console.WriteLine(String.Join(" ", item));
            }


        }
    }
}
