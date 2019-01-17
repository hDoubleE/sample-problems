using System;

namespace Search
{
    public class Program
    {
        static void Main()
        {

        }
    }
    public class linearSearch
    {
        bool linearSearch(int[] c, int t)
        {
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == t)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class binarySearch
    {
        bool binarySearch(int[] c, int t)
        {
            int min = 0;
            int max = c.Length;

            while (min <= max)
            {
                int mid = Math.Floor((min + max)) / 2;
                int current = c[mid];
                if (current < t) 
                {
                    min = mid + 1;
                }
                else if (current < val) 
                {
                    max = mid - 1;
                }
                else 
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}