/*
Function takes two strings and compares to see if they are valid anagrams.
Returns true or false. 

Runtime is O(2n) = O(n)

*/
private class Program
{
    static void Main()
    {
        
        // Does not work at all in C#, fix it!
        bool checkAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;
            
            Dictionary<char, int> lookup = new Dictionary<char, int>();
            
            for (int i = 0; i < str1.Length; i++)
            {
                const int letter = str1[i];
                lookup[letter] ? lookup[letter] += 1 : lookup[letter] = 1;
            }

            for (int j = 0; j < str2.Length; j++)
            {
                const int letter = str2[j];
                if (!lookup[letter]) 
                {
                return false;
                } 
                else 
                {
                    lookup[letter] -= 1;
                }
            }
            return true;
        }
    }
}