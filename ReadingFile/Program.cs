using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr;
            try
            {
                sr = File.OpenText(@"c:\data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }catch(FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
