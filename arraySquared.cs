public void Main() 
{
    int[] a = { 1, 2, 3, 4, 5 };
    int[] b = { 1, 4, 9, 16, 25 };

    arraySquared(a, b);   
}
public class Method 
{
    public bool arraySquared(int [] arr1, int [] arr2) 
    {
        if (arr1.Length != arr2.Length) 
        {
            return false;
        }    

        Dictionary<int, int> frequencyCounter1 = new Dictionary<int, int>();
        {

            foreach (int i in arr1)
            {
                if (!frequencyCounter1.ContainsKey(i))
                {
                    frequencyCounter1.Add(i, 1);
                }
                else 
                {
                    frequencyCounter1[i]++;
                }
            }
        }

        Dictionary<int, int> frequencyCounter2 = new Dictionary<int, int>();
        {

            foreach (int j in arr2)
            {
                if (!frequencyCounter2.ContainsKey(j))
                {
                    frequencyCounter2.Add(j, 1);
                }
                else 
                {
                    frequencyCounter2[j]++;
                }
            }
        }

        // Stuck right here!
        // Can't convert the third loop from JS to C#!?
        foreach (int key in frequencyCounter1)
        {
            // if (frequencyCounter1.Values.SequenceEqual(Math.Pow(frequencyCounter2.Values, 2)))
            // {
            //     return false;
            // }
        }
        return true;
    }
}