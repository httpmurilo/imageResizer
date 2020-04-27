using System.IO;
using System.Reflection;

namespace ImageResizer.Services.Helpers
{
    public class DefaultPath
    {
        public string folderName => "Images";
        public string filePath => Path.Combine(Directory.GetDirectoryRoot(Assembly.GetExecutingAssembly().Location),folderName);
    }
}