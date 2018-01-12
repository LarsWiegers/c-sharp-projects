using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionTest_Start();
        }

        private static void ExceptionTest_Start()
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(@"C:\Users\MTA_C#\Lesson01\data.txt");
                Console.WriteLine(sr.ReadToEnd());

                Console.WriteLine();
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\MTA_C#\Lesson01\data.txt");
                Console.WriteLine("Lees het bestand data.txt in de array lines en zet die met foreach in je console");
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }

                Console.WriteLine();
                Console.WriteLine("Maak een while loop die de getallen 1 t/m 20 achter elkaar op het scherm zet");
                int index = 1;
                while(index <= 20)
                {
                    Console.WriteLine(index);
                    index++;
                }
                Console.WriteLine();
                Console.WriteLine("Maak een for loop die de getallen 1 t/m 5 onder elkaar op het scherm zet. Voor elk getal komt -- te staan");
               
                 for (int index2 = 0; index2 <= 5; index2++)
                {
                    Console.WriteLine("-- " + index2);
                }

                Console.WriteLine();
                Console.WriteLine("Zet alle regels van data.txt op het scherm, zet voor iedere regel 1e regel, de 2e regel: enz.");
                int index3 = 1;
                foreach (string line in lines)
                {
                    Console.WriteLine(index3 + "e regel: " + line);
                    index3++;
                }

                Console.WriteLine();
                Console.WriteLine("Zet  op de plek waar de tekst '<zetjouwnaamhier>' staat jouw eigen naam");
                // gebruik line.Replace() je mag niet de tekst overschrijven. Lees dus de regel uit het tekst bestand en vervang '<zetjouwnaamhier>' door jouw naam
                foreach (string line in lines)
                {
                   String nieuweRegel = line.Replace("<zetjouwnaamhier>", "Lars Wiegers");
                    if(nieuweRegel == "")
                    {
                        Console.WriteLine(line);
                    }else
                    {
                        Console.WriteLine(nieuweRegel);
                    }
                   
                }
                Console.WriteLine();
                Console.WriteLine("lees de systeemdatum uit en zet de dagvan de week en de datum ook op het scherm");
                foreach (string line in lines)
                {
                    String result = line.Replace("<zetdagnaamhier>", DateTime.Today.ToString("dddd"));
                    result = result.Replace("<zetdaghier>", DateTime.Today.ToString("dd"));
                    result = result.Replace("<zetmaandhier>", DateTime.Today.ToString("MMMM"));
                    Console.WriteLine(result);
                }

                Console.WriteLine("zet de regeles op het scherm tot de regel Deze regel mag je dus niet weergeven.");
                // doe dit met een if 
                foreach (string line in lines)
                {
                    if(!line.Contains("Deze regel mag je dus niet weergeven"))
                    {
                        Console.WriteLine(line);
                    }
                }

                Console.WriteLine("test of je exception werkt");

            } catch (System.IO.FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
