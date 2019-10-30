using System;
using System.Text;

namespace Services
{
    public class Base64EncoderDecoder
    {
        public static string Encode(string text)
        {
            var bytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(bytes);
        }
        public static string Encode(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }
        public static string Decode(string encodedText)
        {
            var bytes = Convert.FromBase64String(encodedText);
            return Encoding.UTF8.GetString(bytes);
        }

    }
}
