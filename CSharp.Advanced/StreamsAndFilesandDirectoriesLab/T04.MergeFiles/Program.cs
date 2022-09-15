using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);

        }
        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            StreamReader reader1 = new StreamReader(firstInputFilePath);
            StreamReader reader2 = new StreamReader(secondInputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);

            while (!reader1.EndOfStream || !reader2.EndOfStream)
            {
                string lineR1 = reader1.ReadLine();
                string lineR2 = reader2.ReadLine();
                if (lineR1 != null)
                {
                    writer.WriteLine(lineR1);
                }
                if (lineR2 != null)
                {
                    writer.WriteLine(lineR2);
                }

            }

            reader1.Close();
            reader2.Close();
            writer.Close();
        }
    }
}