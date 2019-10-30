using System.IO;

namespace Services
{
    public class FileServices
    {
        public static string ReadTextFile(string path)
        {
            using(var streamReader = new StreamReader(path))
            {
                return streamReader.ReadToEnd();
            }
        }

        public static byte[] ReadFile(string path)
        {
            return File.ReadAllBytes(path);
        }
    }
}
