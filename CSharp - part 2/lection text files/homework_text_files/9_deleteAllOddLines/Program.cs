using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _9_deleteAllOddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = Console.ReadLine();

            using (StreamReader Read = new StreamReader("../../" + FileName))
            {
                using (StreamWriter Write = new StreamWriter("../../" + FileName + "arh"))
                {

                    int Count = 0;
                    string LineContent = Read.ReadLine();

                    while (LineContent != null)
                    {
                        if (Count % 2 == 0)
                        {
                            Count++;
                        }
                        else
                        {
                            Write.WriteLine(LineContent);
                            Count++;
                        }
                        //Count++;
                        LineContent = Read.ReadLine();
                    }

                }
            }

            File.Replace("../../" + FileName + "arh", "../../" + FileName, "../../" + "backup" + FileName, true);
 
           
        }
    }
}
