using System.Text;
using System.IO;

namespace Models
{
    public class Logger
    {
        public static void Log(string content, string model)
        {
            using (var streamWriter = new StreamWriter(File.Open($"log_{model}.log", FileMode.OpenOrCreate), Encoding.UTF8))
            {
                streamWriter.WriteLineAsync(content);
            }
        }
    }
}
