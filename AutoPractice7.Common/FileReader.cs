using System;
using System.IO;

namespace AutoPractice7.Common
{
    public class FileReader
    {
        public void CreateFile(string filePath)
        {
            using (FileStream fileStream = File.Create(filePath))
            {
                Console.WriteLine("\tA file created with name {0}\n\n", Path.GetFileName(filePath));
            }
        }

        public void DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("\tThe file {0} deleted successfully.\n\n", filePath);
            }
            else
            {
                Console.WriteLine("\tFile does not exist");
            }
        }

        public void CreateFileWithText(string fileName, string[] textLines)
        {
            using (StreamWriter streamWriter = File.CreateText(fileName))
            {
                foreach (string text in textLines)
                {
                    streamWriter.WriteLine(text);
                }
            }
        }

        public void PrintFileContent(string filePath)
        {
            using (StreamReader streamReader = File.OpenText(filePath))
            {
                string s = string.Empty;
                Console.WriteLine("\tHere is the content of the file {0}:", Path.GetFileName(filePath));
                while((s = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine($"\t{s}");
                }
                Console.WriteLine("\n");
            }
        }

        public void AppentText(string filePath, params string[] textLines)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (string text in textLines)
                {
                    writer.WriteLine(text);
                }
            }
        }
    }
}
