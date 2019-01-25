using System;
using System.Collections.Generic;

namespace Sorting
{
     public class Program
    {
        static void Main()
        {
            int[] sampleArray1 = { 5, 2, 43, 27, 8, 12, 23 };
            //int[] sampleArray2 = { 5, 7, 3, 2, 8, 12 };
            //int[] sampleArray3 = { 34, 16, 73, 45, 23, 78 };

            Console.Write("Unsorted: ");
            foreach (var item in sampleArray1)
            {
                Console.Write($"{item} ");
            }

            Sort.SelectionSort(sampleArray1);

            Console.Write("\nSorted: ");
            foreach (var item in sampleArray1)
            {
                Console.Write($"{item} ");
            }
        }
    }

    public class Sort
    {
        // Not working
        public static void BubbleSort(int[] arr)
        {
            for (int i = arr.Length; i > 0; i--)
            {
                bool swap = false;
                for (int j = 1; j < i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Sort.Swap(arr[j], arr[j + 1]);
                        swap = true;
                    }
                }
                if (!swap)
                {
                    break;
                }
            }
        }
        // Not Working
        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minPos = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < minPos)
                    {
                        minPos = j;
                    }
                }
                Sort.Swap(arr[minPos], arr[0]);
            }
        }
        // Working
        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = 0;
                int curr = arr[i];
                for (j = i - 1; j >= 0 && arr[j] > curr; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = curr;
            }
        }
        internal static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
    }
}