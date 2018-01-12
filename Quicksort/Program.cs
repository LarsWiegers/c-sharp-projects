using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Input = new int[10];
            Input[0] = 10;
            Input[1] = 10;
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
            DisplayArray(QuickSort(Input,0,Input.Length - 1));

            Console.ReadLine();
        }
        static int[] QuickSort(int[] numbers,
       int left, int right)
        {
            if (right > left)
            {
                int pivotIndex = left + (right - left) / 2;
                //partition the array
                pivotIndex = Partition(
                      numbers, left, right, pivotIndex);
                //sort the left partition
                QuickSort(numbers, left, pivotIndex - 1);
                // sort the right partition
                QuickSort(
                      numbers, pivotIndex + 1, right);
            }
            return numbers;
        }
        static int Partition(int[] numbers, int left, int right, int pivotIndex)
{
            int pivotValue = numbers[pivotIndex];
            // move pivot element to the end
            int temp = numbers[right];
            numbers[right] = numbers[pivotIndex];
            numbers[pivotIndex] = temp;
            // newPivot stores the index of the first
            // number bigger than pivot
            int newPivot = left;
            for (int i = left; i < right; i++)
            {
                if (numbers[i] <= pivotValue)
                {
                    temp = numbers[newPivot];
                    numbers[newPivot] = numbers[i];
                    numbers[i] = temp;
                    newPivot++;
    ;
                }
            }
            //move pivot element to its sorted position
            temp = numbers[right];
            numbers[right] = numbers[newPivot];
            numbers[newPivot] = temp;
            return newPivot;
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
