using System;
using System.IO;

namespace ReTakeLineNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"..\..\..\input.txt";
            string outputPath = @"..\..\..\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputPath, string outputPath)
        {
            StreamReader reader = new StreamReader(inputPath);
            StreamWriter writer = new StreamWriter(outputPath);

            int counter = 0;
            while (!reader.EndOfStream)
            {
                counter++;
                string line = reader.ReadLine();
                writer.WriteLine($"{counter}. {line}");
            }
            reader.Close();
            writer.Close();
        }
    }
}
