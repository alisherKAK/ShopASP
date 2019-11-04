using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HtmlTemplater
    {
        public string PlaceHtml(string path, string key, List<Product> items)
        {
            string template = FileServices.ReadTextFile(path);
            for(int i = 0; i < items.Count; i++)
            {

            }
            return "";
        }
    }
}
