using System.Text;
using System.IO;

namespace Models
{
    public class Logger
    {
        public static async void Log(string path, string content, string model)
        {
            using (var streamWriter = new StreamWriter(File.Open($"{path}log_{model}.log", FileMode.OpenOrCreate), Encoding.UTF8))
            {
                await streamWriter.WriteLineAsync(content);
            }
        }
    }
}
