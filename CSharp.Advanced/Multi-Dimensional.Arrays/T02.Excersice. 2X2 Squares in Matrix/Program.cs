using System;
using System.Linq;

namespace T02.Excersice._2X2_Squares_in_Matri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[rowNumber[0], rowNumber[1]];

            for (int row = 0; row < rowNumber[0]; row++)
            {
                string[] currentRow = Console.ReadLine().Split();
                for (int cols = 0; cols < rowNumber[1]; cols++)
                {     
                    matrix[row, cols] = currentRow[cols];                  
                }
            }
            int counter = 0;
            for (int row = 0; row < rowNumber[0]-1; row++)
            {
                for (int cols = 0; cols < rowNumber[1]-1; cols++)
                {
                    string searched = matrix[row, cols];
                    if (searched == matrix[row+1,cols] && searched == matrix[row + 1, cols+1] && searched == matrix[row, cols +1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);

        }
    }
}
