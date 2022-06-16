using System;
using System.Linq;

namespace T04.Excercise.Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int inputRow = matrixDimensions[0];
            int inputCol = matrixDimensions[1];
            string[,] matrix = new string[inputRow, inputCol];

            DrawMatrix(inputRow, inputCol, matrix);
            
            string input = string.Empty;

            while((input = Console.ReadLine()) != "END")
            {
                string[] inputArgs = input.Split();
               
                if (inputArgs[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                if (inputArgs.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int originRow = int.Parse(inputArgs[1]);
                int originCol = int.Parse(inputArgs[2]);
                int secondRow = int.Parse(inputArgs[3]);
                int secondCol = int.Parse(inputArgs[4]);
                if (inputRow < originRow || inputRow < secondRow)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                if (inputCol < originCol || inputCol < secondCol)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string firstNum = matrix[originRow, originCol];
                string secondNum = matrix[secondRow, secondCol];
                matrix[originRow, originCol] = secondNum;
                matrix[secondRow, secondCol] = firstNum;


                for (int row = 0; row < inputRow; row++)
                {
                    for (int col = 0; col < inputCol; col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void DrawMatrix(int inputRow, int inputCol, string[,] matrix)
        {
            for (int row = 0; row < inputRow; row++)
            {
                string[] currentRow = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < inputCol; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }
}
