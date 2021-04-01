using AutoPractice7.Common;
using System;
using System.IO;

namespace AutoPractice7.TextFile
{
    class Program
    {
        private static FileReader fileReader = new FileReader();

        static void Main()
        {
            var defaultFile = "myTxtFile.txt";

            Console.WriteLine("Create a file named {0} in the disk:", defaultFile);
            fileReader.CreateFile(defaultFile);

            Console.WriteLine("Delete file named {0} in the disk:", defaultFile);
            fileReader.DeleteFile(defaultFile);

            string filePath = Path.Combine(PathHelper.SolutionFolderPath, "Files", "txtFile.txt");
            //filePath = @"D:\TEAM working\Курсы\Practice\AutoPractice7\Files\txtFile";
            //filePath = $"{PathHelper.SolutionFolderPath}\\Files\\txtFile.txt";

            Console.WriteLine("Create a file with text and read file:");
            string[] content = new[]
            {
                "Hello and Welcome",
                "It is the first content",
                $"of the text file {Path.GetFileName(filePath)}"
            };

            fileReader.CreateFileWithText(filePath, content);
            fileReader.PrintFileContent(filePath);

            Console.WriteLine("Append some text to existing file:");
            fileReader.AppentText(filePath, "This is the new line at last line.");
            fileReader.PrintFileContent(filePath);

            Console.ReadLine();
        }
    }
}
