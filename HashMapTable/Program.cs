using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMapTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable
            {
                { "001", "Lars Wiegers" },
                { "002", "Ron Wiegers" },
                { "003", "Inge Wiegers" },
                { "004", "Sven Wiegers" }
            };

            if(table.ContainsValue("Sven Wiegers"))
            {
                Console.WriteLine("Sven is in the hashTable");
            }

            ICollection keys = table.Keys;

            foreach(String key in keys)
            {
                Console.WriteLine(key + ": " + table[key]);
            }

            Console.ReadLine();

        }
    }
}
