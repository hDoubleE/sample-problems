// Runtime of my algo
// Merge is stable
using System;

namespace Sorting
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter some numbers, separated by spaces:");

            // Process input string into string array.
            string strInput = Console.ReadLine().Trim();
            string[] strArray = strInput.Split(' ');

            // Parse out string array into integer array.
            int[] data = new int[strArray.Length];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = int.Parse(strArray[i]);
            }

            // Print unsorted data.
            Console.Write("\nUnsorted: ");
            foreach (var i in data)
            {
                Console.Write($"{i} ");
            }

            // Sort data.
            QuickSort(data);

            // Print sorted data.
            Console.Write("\nSorted: ");
            foreach (var i in data)
            {
                Console.Write($"{i} ");
            }
        }
        static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }
        static void QuickSort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex) // At least two elements
            {
                int storeIndex = Partition(arr, leftIndex, rightIndex);
                QuickSort(arr, leftIndex, storeIndex - 1);
                QuickSort(arr, storeIndex, rightIndex);
            }
        }
        static int Partition(int[] arr, int leftIndex, int rightIndex) // Return new index of pivot.
        {
            int pivotValue = arr[rightIndex];
            int swapIndex = leftIndex - 1;
            for (int i = leftIndex; i < rightIndex; i++)
            {
                if (arr[i] <= pivotValue)
                {
                    swapIndex++;
                    SwapValues(ref arr[swapIndex], ref arr[i]);
                }
            }
            // swap arr[swapIndex + 1] with pivotValue(ie. arr[rightIndex])
            SwapValues(ref arr[swapIndex + 1], ref arr[rightIndex]);

            // return new index position for the pivot
            return swapIndex + 1;
        }
        static void SwapValues(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static bool ArrayContainsTwoValues(int[] arr, int i, int pivot)
        {
            return arr[i] <= pivot;
        }
    }
}

