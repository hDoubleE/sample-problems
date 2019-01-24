// Write an efficient function to find the first nonrepeated character
// in a string. Example: "total", return: 'o'. "teeter", return 'r'.
// O(2n) -> O(n) 
namespace RomanNumeralConverter
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine());
        }
    }

    public class StringProcessor
    {
        internal static char printFirstDuplicate(string s)
        {
            int[] arr = new int[s.Length + 1];
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                arr[c]++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (arr[c] == 1)
                {
                    return arr[s[i]];
                }
            }
        }
        internal static char firstSingleChar(string s)
        {
            if (s == string.Empty)
            {
                return char.MaxValue;
            }

            Dictionary<char, int> table = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!table.ContainsKey(s[i]))
                {
                    table[s[i]] = 1;
                }
                else
                {
                    table[s[i]] += 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (table[s[i]] == 1)
                {
                    return s[i];
                }
            }
            return char.MaxValue;
        }
    }
}


