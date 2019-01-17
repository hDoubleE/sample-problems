using System.Collections.Generic;

//Ask the user to enter a string(e.g. “Welcome to Saint Martin’s U!”).
//Your program should count and display the total number of vowels(A, E, I, O, U)
//– count both uppercase and lowercase vowels – in that given input.In the example above, the output should 9.

namespace Homework1
{
    class Program
    {
        //public List<char> vowels = new List<char> {'a', 'e', 'i', 'o', 'u' };

        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine().ToLower();
            //Console.WriteLine(input);
            Console.WriteLine(removeVowels(input));
            Console.WriteLine(removeVowelsArray(input));



            int removeVowels(string s)
            {

                int vowelCount = 0;
                List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
                
                for (int i = 0; i < s.Length; i++)
                {
                    if (vowels.Contains(s[i]))
                    {
                        vowelCount++;
                    }
                }
                return vowelCount;
            }

            int removeVowelsArray(string s)
            {
                int count = 0;
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < vowels.Length; j++)
                    {
                        if (s[i] == vowels[j])
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
        }
    }
}