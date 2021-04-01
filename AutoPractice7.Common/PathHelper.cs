using System;
using System.IO;

namespace AutoPractice7.Common
{
    public static class PathHelper
    {
        public static string SolutionFolderPath
        {
            get
            {
                var currentFolderPath = Path.GetDirectoryName(Environment.CurrentDirectory);
                var directory = new DirectoryInfo(currentFolderPath);

                while (directory != null && directory.GetFiles("*.sln").Length == 0)
                {
                    directory = directory.Parent;
                }

                return directory?.FullName ?? string.Empty;
            }
        }
    }
}
