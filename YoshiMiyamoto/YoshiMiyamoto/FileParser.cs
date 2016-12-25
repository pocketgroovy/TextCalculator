using System;
namespace YoshiMiyamoto
{
    public class FileParser
    {
        private string[] lines;

        public FileParser(string filePath)
        {
            parseFile(filePath);
        }

        private void parseFile(string filePath)
        {
            try
            {
                lines = System.IO.File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error with the file");
                Console.WriteLine(ex.Message);
            }
        }

        public string[] getLines()
        {
            return lines;
        }

        public string getContents()
        {
            string linesWithNewLine = "";

            foreach (string line in lines)
            {
                linesWithNewLine += line + "\n";
            }
            return linesWithNewLine;
        }
    }
}