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
            MergeSort(data);

            // Print sorted data.
            Console.Write("\nSorted: ");
            foreach (var i in data)
            {
                Console.Write($"{i} ");
            }
        }
        public static void MergeSort(int[] arr)
        {
            int[] temp = new int[arr.Length];

            MergeSortRecurse(arr, temp, 0, arr.Length - 1);

        }

        public static void MergeSortRecurse(int[] arr, int[] temp, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSortRecurse(arr, temp, left, mid);
                MergeSortRecurse(arr, temp, mid + 1, right);

                Merge(arr, temp, left, mid + 1, right);
            }
        }

        public static void Merge(int[] arr, int[] temp, int left, int mid, int right)
        {

            int eol = mid - 1;
            int pos = 0;
            int num = right - left + 1;

            while (left < eol && mid <= right)
            {
                if (arr[left] < arr[mid])
                {
                    temp[pos++] = arr[left++];
                }
                else
                {
                    temp[pos++] = arr[mid++];
                }
            }
            while (left <= eol)
            {
                temp[pos++] = arr[mid++];
            }
            while (mid <= right)
            {
                temp[pos++] = arr[mid++];
                right--;
            }
            for (int i = 0; i < num; i++)
            {
                arr[right] = temp[right];
                right--;
            }
        }
        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }

            while (left <= eol)
                temp[pos++] = numbers[left++];

            while (mid <= right)
                temp[pos++] = numbers[mid++];

            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);

                MainMerge(numbers, left, (mid + 1), right);
            }
        }
    }
}