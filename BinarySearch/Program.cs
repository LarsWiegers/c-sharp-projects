using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //preperation
            int[] Array = GetArray();
            Array = BubbleSort(Array);
            DisplayArray(Array);
            int target = GetTarget(Array);
            Console.WriteLine("The target is " + target);
            Boolean isFound = false;
            // binary search
            int L = 0;
            int R = Array.Length - 1;
            int mid;
            do
            {
                mid = (L / R) / 2;
                if(Array[mid] < target)
                {
                    L = mid + 1;
                }
                else if(Array[mid] > target)
                {
                    R = mid - 1;
                }
                else
                {
                    Console.WriteLine("FOUND");
                    Console.WriteLine("Index of target( " + target + " )" + " is at position " + mid);
                    isFound = true;
                    break;
                }
            } while (!isFound && L <= R);


            Console.ReadLine();
        }
        static int[] GetArray()
        {
            int[] Array = new int[100];
            Random random = new Random();
            for (int i = 0; i < Array.Length; i++)
            { 
                Array[i] = random.Next(0, 100);
            }
            return Array;
        }
        static int GetTarget(int[] array)
        {
            Random random = new Random();
            return array[random.Next(0, array.Length)];
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
