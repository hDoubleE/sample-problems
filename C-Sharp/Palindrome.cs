using System;

using System;
using System.Collections.Generic;
using System.IO;

namespace Palindrome
{
    public class Program
    {
        public static void Main()
        {

            LinkedList<char> rcll = new LinkedList<char>();
            string r = "racecar";
            foreach (char c in r)
            {
                rcll.AddFirst(c);
            }

            Solutions solution = new Solutions();

            Console.WriteLine(solution.isPalindrome(rcll.First));


            string d = "deed";
            string q = "dadd";

            char[] rc = r.ToCharArray();
            char[] da = d.ToCharArray();
            char[] qa = q.ToCharArray();
            char[] empty = new char[0];

            Console.WriteLine(solution.isPalindromeArray(empty));
            Console.WriteLine(solution.isPalindromeArray(rc));
            Console.WriteLine(solution.isPalindromeArray(da));
            Console.WriteLine(solution.isPalindromeArray(qa));
        }
    }
    public class Solutions
    {
        public bool isPalindromeArray(char[] arr)
        {
            if (arr.Length == 0)
            {
                return false;
            }

            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                if (arr[start] == arr[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool isPalindrome(LinkedListNode<char> head)
        {
            LinkedListNode<char> reversed = ReverseClone(head);
            isEqual(head, reversed);
            return true;
        }

        public LinkedListNode<char> ReverseClone(LinkedListNode<char> node)
        {
            LinkedListNode<char> head = null;
            LinkedList<char> ll = new LinkedList<char>();
            while (node != null)
            {
                LinkedListNode<char> n = new LinkedListNode<char>(node.Value);
                ll.AddLast(head);
                head = n;
                node = node.Next;
            }
            return head;
        }

        public bool isEqual(LinkedListNode<char> orig, LinkedListNode<char> reversed)
        {
            while (orig != null && reversed != null)
            {
                if (orig.Value != reversed.Value)
                {
                    return false;
                }
                orig = orig.Next;
                reversed = reversed.Next;
            }
            return true;
        }


    }

}