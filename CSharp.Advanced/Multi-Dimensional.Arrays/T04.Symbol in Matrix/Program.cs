using System;

namespace T04.Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cubeSize = int.Parse(Console.ReadLine());
            char[,] cube = new char[cubeSize, cubeSize];
            for (int row = 0; row < cubeSize; row++)
            {
                string rowCube = Console.ReadLine();
                char[] chars = rowCube.ToCharArray();
                for (int column = 0; column < cubeSize; column++)
                {
                    cube[row, column] = chars[column];
                }
            }
            char searchedChar = char.Parse(Console.ReadLine());

            for (int row = 0; row < cubeSize; row++)
            {          
                for (int column = 0; column < cubeSize; column++)
                {
                    if (searchedChar == cube[row,column])
                    {
                        Console.WriteLine($"({row}, {column})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{searchedChar} does not occur in the matrix");
        }
    }
}
