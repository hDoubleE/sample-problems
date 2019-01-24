public class Solution {

    static void Main()
    {
        int[] a = { 1, 2, 3, 4 };
        int[] result = Solution.rotateArrayLeft(a, 2);

        Console.WriteLine(string.Join(" ", result));
    }
    public static int[] rotateArrayLeft(int[] origArr, int k)
    {
        int len = origArr.Length;
        int numberOfRotations = k;
        int[] newArr = new int[len];

        for (int i = 0; i < len; i++)
        {
            int newIndex = (i + numberOfRotations) % len;
            newArr[i] = origArr[newIndex];
        }
        return newArr;
    }
}

// Initial assignments:
  // origArr = [1, 2, 3, 4]
  // len = origArr.length = 4
  // numberOfRotations = k = 2
  // newArr = new int[len]
  // newArr: [nil, nil, nil, nil]

// NOTE:
  // Loop through length of origArr
  // for (int i = 0; i < len; i++)

// Calculate newIndex and update newArr at index (i):
  // newIndex = (i + numberOfRotations) % len
  // newArr[i] = origArr[newIndex]

// LOOP1:
  // i = 0
  // newIndex = (0 + 2) % 4 = 2
  // newArr[i = 0] = origArr[newIndex = 2] = 3
  // newArr: [3, nil, nil, nil]

// LOOP2:
  // i = 1
  // newIndex = (1 + 2) % 4 = 3
  // newArr[i = 1] = origArr[newIndex = 3] = 4
  // newArr: [3, 4, nil, nil]

// LOOP3:
  // i = 2
  // new_index = (2 + 2) % 4 = 0
  // newArr[i = 2] = origArr[newIndex = 0] = 1
  // newArr: [3, 4, 1, nil]

// LOOP4:
  // i = 3
  // new_index = (3 + 2) % 4 = 1
  // newArr[i = 3] = origArr[newIndex = 1] = 2
  // newArr: [3, 4, 1, 2]

// After final loop our newArr = [3, 4, 1, 2]
// You can return the output and join in Main.