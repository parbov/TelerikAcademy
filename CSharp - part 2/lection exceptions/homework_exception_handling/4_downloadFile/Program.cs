using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _4_downloadFile
{
    class Program
    {
        static void Main()
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "image.jpg");
                    Console.WriteLine("File successfully downloaded.");
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("The address parameter must not be null!");
                }
                catch (WebException e)
                {
                    Console.WriteLine("Error while downloading file.");
                }
                catch (NotSupportedException e)
                {
                    Console.WriteLine("The method DownloadFile() cannot be called simultaneously on multiple threads.");
                }
                finally
                {
                    Console.WriteLine("Bye-bye!");
                }
            }
        }
    }
}
