using System;
using System.Linq;

namespace T05.Excercise.Snaske_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensionsInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = dimensionsInput[0];
            int m = dimensionsInput[1];

            string snakeName = Console.ReadLine();
            int snakeCounter = 0;

            char[,] matrix = new char[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    
                    if (row % 2 != 0)
                    {
                        for (int col1 = m-1; col1 >= 0; col1--)
                        {
                            if (snakeCounter == snakeName.Length)
                            {
                                snakeCounter = 0;
                            }
                            matrix[row, col1] = snakeName[snakeCounter];
                            snakeCounter++;
                            continue;
                        }
                        row++;
                        col = 0;
                    }
                    if (row >= n)
                    {
                        break;
                    }
                    if (snakeCounter == snakeName.Length)
                    {
                        snakeCounter = 0;
                    }
                    matrix[row, col] = snakeName[snakeCounter];
                    snakeCounter++;
                }               
            }
            int counter = 0;
            foreach (var item in matrix)
            {
                if (counter == m)
                {
                    Console.WriteLine();
                    counter = 0;
                }
                Console.Write(item);
                counter++;
            }
            //NOT DONE
            //NOT DONE
            //NOT DONE
            //NOT DONE
            //NOT DONE
            //NOT DONE
        }
    }
}
