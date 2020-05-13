using System;
using System.IO;
using System.Reflection;

namespace ImageResizer.Api.Util
{
    public class PathValidator
    {
        public PathValidator(string filePathStorage, string name, bool fileExists)
        {
            FilePathStorage = filePathStorage;
            Name = name;
            FileExists = fileExists;
        }

        public static string FilePathStorage  { get; private set; } 
        public string Name { get; private set; }
        public bool FileExists { get; private set; }
        public void GetImageDirectory(string  Name)
        {
            FilePathStorage = Path.Combine(Directory.GetCurrentDirectory(),"Images",Name);
            FileExists = System.IO.File.Exists(FilePathStorage);
            if(FileExists == false)
            {
                throw new ArgumentException("image is invalid");
            }

        }
    }
}