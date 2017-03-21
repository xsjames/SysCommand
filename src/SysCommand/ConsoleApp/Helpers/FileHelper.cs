﻿using System.IO;
using System.Reflection;

namespace SysCommand.ConsoleApp.Helpers
{
    public static class FileHelper
    {
        public static string GetCurrentDirectory<TRef>()
        {
#if NETCORE
            return Path.GetDirectoryName(typeof(TRef).GetTypeInfo().Assembly.Location);
#else
            return Directory.GetCurrentDirectory();
#endif
        }

        public static bool FileExists(string fileName)
        {
            return File.Exists(fileName);
        }

        public static string GetContentFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                return null;

            return File.ReadAllText(fileName);
        }
        
        public static void RemoveFile(string fileName)
        {
            if (File.Exists(fileName))
                File.Delete(fileName);
        }

        public static void SaveContentToFile(string content, string fileName)
        {
            CreateFolderIfNeeded(fileName);
            File.WriteAllText(fileName, content);
        }

        /// <summary>
        /// Create the folder if not existing for a full file name
        /// </summary>
        /// <param name="filename">full path of the file</param>
        public static void CreateFolderIfNeeded(string filename)
        {
            string folder = Path.GetDirectoryName(filename);
            if (!string.IsNullOrEmpty(folder) && !Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
        }

        private static string GetUniversalFileName(string fileName)
        {
            // fix to unix
            return fileName.Replace("\\", "/").Replace("//", "/");
        }

    }
}