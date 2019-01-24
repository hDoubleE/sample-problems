using System;
using System.Collections.Generic;

namespace Sorting
{
    static void Main()
    {
        int[] sampleArray = {5, 13, 8, 27, 43, 12, 23};
    }
    public class Sort
    {
        public static void BubbleSort(int[] arr)
        {
            int max = arr[0];
            bool swap = true;
            while (swap && i < arr.Length)
            {

                for (int j = 1; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        swap(arr[j], arr[j+1]);
                        swap = true;    
                    }
                    // swap = false;
                }
                i++;
            }
        }

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
                swap(arr[minPos], arr[0]);
            }
        }
        public static void InsertionSort(int[] arr)
        {
            int curr = arr[i];
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i - 1; j>=0 && arr[j] > curr; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = curr;
            }
        }
        public static void swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}