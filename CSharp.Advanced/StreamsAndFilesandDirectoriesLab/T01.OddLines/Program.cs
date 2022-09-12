using System.IO;

namespace OddLines 
{
    public class OddLines
    {
        static void Main() 
        { 
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";
            ExtractOddLines(inputFilePath, outputFilePath);

        }
        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);
            int counter = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                counter++;
                if (counter %2 != 0)
                {
                    writer.WriteLine(line);
                }              
            }
            reader.Close();
            writer.Close();
        } 
    } 
}