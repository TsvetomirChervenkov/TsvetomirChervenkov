using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount 
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath); 

        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            StreamReader readWords = new StreamReader(wordsFilePath);
            StreamReader readText = new StreamReader(textFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);

            while (!readWords.EndOfStream)
            {
                string[] line = readWords.ReadLine().Split();
                for (int i = 0; i < line.Length; i++)
                {
                    if (!words.ContainsKey(line[i]))
                    {
                        words.Add(line[i], 0);
                    }
                }
            }
            string[] lineText = readText.ReadToEnd().Split(new char[] { '-', '?', '!' , ',', '.', ' '}, System.StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lineText.Length; i++)
            {
                string currentWord = lineText[i].ToLower();
                if (words.ContainsKey(currentWord))
                {
                    words[currentWord]++;
                }
            }
            foreach (var (word, times) in words.OrderByDescending(x=> x.Value))
            {
                writer.WriteLine($"{word} - {times}");
            }
            writer.Close();
            readText.Close();
            readWords.Close();
        }
    }
}