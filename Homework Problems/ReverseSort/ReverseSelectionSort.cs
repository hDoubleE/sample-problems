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
            ReverseSelectionSort(data);

            // Print sorted data.
            Console.Write("\nSorted: ");
            foreach (var i in data)
            {
                Console.Write($"{i} ");
            }
        }

        public static void ReverseSelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int lowValIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[lowValIndex] < arr[j])
                        // 5, 0              7, 4
                    {
                        lowValIndex = j;
                    }
                }
                if (i != lowValIndex)
                {
                    int temp = arr[lowValIndex];
                    arr[lowValIndex] = arr[i];
                    arr[i] = temp;
                }
            }
        }
    }
}