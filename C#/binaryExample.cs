using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some integers, sorted & separated by spaces:");
            string input = Console.ReadLine();
            string[] integers = input.Split(' ');
            int[] data = new int[integers.Length];
            for (int i = 0; i < data.Length; i++)
                data[i] = int.Parse(integers[i]);

            while (true)
            {
                Console.WriteLine("\nEnter a number to find? (blank line to end):");
                input = Console.ReadLine();
                if (input.Length == 0)
                    break;
                int searchItem = int.Parse(input);
                int foundPos = BSI(data, searchItem);
                if (foundPos < 0)
                    Console.WriteLine("Item {0} not found", searchItem);
                else
                    Console.WriteLine("Item {0} found at position {1}", searchItem, foundPos);
            }
        }

        public static int BSI(int[] data, int item)
        {
            int min = 0;
            int N = data.Length;
            int max = N - 1;
            do
            {
                int mid = min + (max - min) / 2;
                if (item > data[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (data[mid] == item)
                    return mid;
            } while (min <= max);
            return -1;
        }
    }
    class BinaryArray
        {
            private int[] data; // array of values
            private static Random generator = new Random();

            // Create an array of given size fill with random integers
            // Binary Search constructor
            public BinaryArray(int size)
            {
                data = new int[size]; // allocate space for array

                // fill array with random ints
                for (int i = 0; i < size; i++)
                {
                    data[i] = generator.Next(10, 100);
                }
                Array.Sort(data);
            }

            // perform a binary search on array
            public int BinarySearch(int searchElement)
            {
                int low = 0; // 0 is always going to be the first element
                int high = data.Length - 1; // Find highest element
                int middle = (low + high + 1) / 2; // Find middle element
                int location = -1; // Return value -1 if not found

                do // Search for element
                {
                    // Print remaining elements in array
                    Console.Write(RemainingElements(low, high));

                    // output spaces for alignment
                    for (int i = 0; i < middle; i++)
                        Console.Write("   ");

                    Console.WriteLine(" * "); // Indicate current middle

                    // if element is found at middle
                    if (searchElement == data[middle])
                        location = middle; // location is current middle

                    // middle element is too high
                    else if (searchElement < data[middle])
                        high = middle - 1; // eliminate lower half
                    else // middle element is too low
                        low = middle + 1; // eleminate lower half

                    middle = (low + high + 1) / 2; // recalculate the middle  
                } while ((low <= high) && (location == -1));

                return location; // return location of search key
            }

            public string RemainingElements(int low, int high)
            {
                string temporary = string.Empty;

                // output spaces for alignment
                for (int i = 0; i < low; i++)
                    temporary += "    ";

                // output elements left in array 
                for (int i = low; i <= high; i++)
                    temporary += data[i] + " ";

                temporary += "\n";
                return temporary;
            }

            // Method to output values in array
            public override string ToString()
            {
                return RemainingElements(0, data.Length - 1);
            }
        }
}