using System;
using System.Collections.Generic;


namespace BinarySearch
{
    class BinarySearchTest
    {
        static void Main(string[] args)
        {
            int searchInt; // search key
            int position; // location of search key in array

            // create array and output it
            BinaryArray searchArray = new BinaryArray(15);
            Console.WriteLine(searchArray);

            // prompt and input first int from user
            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // repeatedly input an integer; -1 terminates the application
            while (searchInt != -1)
            {
                // use binary search to try to find integer
                position = searchArray.BinarySearch(searchInt);
                
                // return value of -1 indicates integer was not found
                if (position == -1)
                    Console.WriteLine("The integer {0} was not found.\n", searchInt);
                else
                    Console.WriteLine("The integer {0} was found in position {1}.\n", searchInt, position);

                // Prompt and input next int from user 
                Console.WriteLine("Please enter an integer value (-1 to quit): ");
                searchInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
          
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
                for (int i=0; i<size; i++) 
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
}