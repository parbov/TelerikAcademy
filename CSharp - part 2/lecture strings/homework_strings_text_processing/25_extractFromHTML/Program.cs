using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_extractFromHTML
{
    class Program
    {
        static void Main()
        {
            string html = "<html><head><title>News</title></head><body><p>textxtex</p></body>";
            int indexClosing = html.IndexOf('>');
            while (indexClosing > -1)
            {
                if (indexClosing < html.Length - 1 && html[indexClosing + 1] != '<')
                {
                    int nextOpeningIndex = html.IndexOf('<', indexClosing);
                    int textLength = nextOpeningIndex - indexClosing - 1;
                    Console.WriteLine(html.Substring(indexClosing + 1, textLength));
                }
                indexClosing = html.IndexOf('>', indexClosing + 1);
            }
        }
    }
}
