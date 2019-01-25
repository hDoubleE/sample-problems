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
            ReverseBubbleSort(data);

            // Print sorted data.
            Console.Write("\nSorted: ");
            foreach (var i in data)
            {
                Console.Write($"{i} ");
            }
        }

        public static void ReverseBubbleSort(int[] arr)
        {
            long numCompare = 0;
            for (int i = arr.Length; i > 0; i--)
            {
                bool swap = false;
                for (int j = 0; j < i - 1; j++)
                {
                    numCompare++;
                    if (arr[j] < arr[j + 1])
                    {
                        swap = true;
                        int lowValue = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = lowValue;
                    }
                }

                if (!swap)
                {
                    Console.WriteLine($"\nNumber of Comparisons: {numCompare}");
                    break;
                }
            }
        }
    }
}