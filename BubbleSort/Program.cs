using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
             int[] Input = new int[10];
            Input[0] = 10;
            Input[1] = 4;
            Input[2] = 50;
            Input[3] = 40;
            Input[4] = 32;
            Input[5] = 1;
            Input[6] = 123;
            Input[7] = 65;
            Input[8] = 25;
            Input[9] = 235;
            Console.Write("Niet gesoorteerd : ");
            DisplayArray(Input);
            Console.Write("Gesorteerd : ");
            DisplayArray(BubbleSort(Input));

            Console.ReadLine();
        }
        static int[] BubbleSort(int[] numbers)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        //swap
                        int temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
            return numbers;

        }
        static void DisplayArray(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number.ToString() + "  ");
            }
            Console.WriteLine("");
        }
    }
}
