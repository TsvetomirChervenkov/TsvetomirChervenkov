using System;

namespace T07.Knights_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            char[,] matrix = new char[dimensions, dimensions];

            for (int row = 0; row < dimensions; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < dimensions; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            // now we go through the knights and how manny times they attack

            int erasedKnight = 0;
            while (true)
            {

                int mostAttacks = 0;
                int[] knightWithMostAttacks = new int[2];


                for (int row = 0; row < dimensions; row++)
                {
                    for (int col = 0; col < dimensions; col++)
                    {
                        //checking every possible attack of current K and if in range of board
                        if (matrix[row, col] == 'K')
                        {
                            int currentAttacks = 0;
                            if (InRange(row - 2, col - 1, dimensions, matrix) && matrix[row - 2, col - 1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (InRange(row - 2, col + 1, dimensions, matrix) && matrix[row - 2, col + 1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (InRange(row - 1, col + 2, dimensions, matrix) && matrix[row - 1, col + 2] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (InRange(row + 1, col + 2, dimensions, matrix) && matrix[row + 1, col + 2] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (InRange(row + 2, col + 1, dimensions, matrix) && matrix[row + 2, col + 1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (InRange(row + 2, col - 1, dimensions, matrix) && matrix[row + 2, col - 1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (InRange(row + 1, col - 2, dimensions, matrix) && matrix[row + 1, col - 2] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (InRange(row - 1, col - 2, dimensions, matrix) && matrix[row - 1, col - 2] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (currentAttacks > mostAttacks)
                            {
                                mostAttacks = currentAttacks;
                                knightWithMostAttacks[0] = row;
                                knightWithMostAttacks[1] = col;
                            }
                        }
                    }
                }

                if (mostAttacks == 0)
                {
                    break;
                }
                if (mostAttacks > 0)
                {
                    matrix[knightWithMostAttacks[0], knightWithMostAttacks[1]] = '0';
                    erasedKnight++;
                }
            }
            Console.WriteLine(erasedKnight);

        }
        static bool InRange(int row,int col, int dimensions, char[,] matrix)
        {
            if (row >= 0 && row < dimensions && col >= 0 && col < dimensions)
            {
                return true;
            }
            return false;   
        }
    }
}
