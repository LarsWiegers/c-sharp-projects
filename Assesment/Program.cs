using System;
using System.Collections.Generic;

namespace Assesment
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> first = new Queue<int>();//vul first met de getallen 7, 11, 45, 50(in deze volgorde)
            first.Enqueue(7);
            first.Enqueue(11);
            first.Enqueue(45);
            first.Enqueue(50);
            Queue<int> second = new Queue<int>();
            second.Enqueue(12);
            second.Enqueue(32);
            second.Enqueue(65);
            second.Enqueue(67);
            //vul second met de getallen 12, 32, 65, 67(in deze volgorde)
            ProcessInOrder(first, second); //deze laat de getallen alsvolgt zien:
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static void ProcessInOrder(Queue<int> first, Queue<int> second)
        {
           while(first.Count > 0)
            {
                int firstValue = first.Dequeue();
                int secondValue = second.Dequeue();
                if (firstValue > secondValue)
                {
                    if(first.Peek() > second.Peek())
                    {
                        Console.Write(first.Peek() + " , ");
                        Console.Write(secondValue + " , ");
                    }
                    Console.Write(firstValue + " , ");
                    Console.Write(secondValue + " , ");
                }
                else
                {
                    Console.Write(firstValue + " , ");
                    Console.Write(secondValue + " , ");  
                }
            }
           
           
        }
    }
}
