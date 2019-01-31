using System;
using System.Collections.Generic;

namespace Palindrome
{
    public class Program
    {
        public static void Main()
        {
            MyList<char> charList1 = new MyList<char>();
            string r = "racecar";
            foreach (char c in r)
            {
                charList1.AddLast(c);
            }
            MyList<char> charList2 = new MyList<char>();
            string t = "tattatattat";
            foreach (char c in t)
            {
                charList2.AddLast(c);
            }

            MyList<char> charList3 = new MyList<char>();
            string q = "queen";
            foreach (char c in q)
            {
                charList3.AddLast(c);
            }

            Console.WriteLine(charList3.ReverseAndCopy(charList3));
            //Solutions solution = new Solutions();

<<<<<<< HEAD
            Console.WriteLine(solution.isPalindrome(rcll.First));
=======
>>>>>>> 5f04358729e373dfe6b7c5f5250dfc12dc039e7e


            //string d = "deed";
            //string q = "dadd";

            //char[] rc = r.ToCharArray();
            //char[] da = d.ToCharArray();
            //char[] qa = q.ToCharArray();
            //char[] empty = new char[0];

            //Console.WriteLine(solution.isPalindromeArray(empty));
            //Console.WriteLine(solution.isPalindromeArray(rc));
            //Console.WriteLine(solution.isPalindromeArray(da));
            //Console.WriteLine(solution.isPalindromeArray(qa));
        }
    }


    public class MyList<T> : LinkedList<T>
    {

        public class Node<T>
        {
            public T data;
            public Node<T> next;

            public Node(T val)
            {
                data = val;
                next = null;
            }

        }

        public Node<T> head;

        public bool isPalindrome(MyList<T> list)
        {
            MyList<T> reversed = ReverseAndCopy(list);
            return isEqual(list.head, reversed.head);
        }

        public void Push(Node<T> node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                head = node;
                head.next = temp;
            }
        }

        public Node<T> Pop()
        {
            Node<T> current = head;
            if (current == null)
            {
                throw new IndexOutOfRangeException("No items in list to pop.");
            }
            else
            {
                while (current.next != null)
                {
                    current = current.next;
                }
                Node<T> temp = current;
                current = null;
                return temp;
            }
        }


        public MyList<T> ReverseAndCopy(MyList<T> oldList)
        {
            MyList<T> newList = new MyList<T>();
            while (!oldList.isEmpty())
            {
                newList.Push(oldList.Pop());
            }
            return newList;
        }

        public bool isEqual(Node<T> nodeOne, Node<T> nodeTwo)
        {
            while (nodeOne != null && nodeTwo != null)
            {
                if (EqualityComparer<T>.Default.Equals(nodeOne.data, nodeTwo.data))
                {
                    return false;
                }
                else
                {
                    nodeOne = nodeOne.next;
                    nodeTwo = nodeTwo.next;
                }
            }
            return true;
        }


        public bool isEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

<<<<<<< HEAD
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
=======
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
>>>>>>> 5f04358729e373dfe6b7c5f5250dfc12dc039e7e
            }
            return true;
        }




        //public class SingleLinkedList
        //{


        //    public LinkedList<char> checkPalindrome(LinkedList<char> oldList)
        //    {
        //        LinkedList<char> newList = new LinkedList<char>();
        //        while (!isEmpty(oldList))
        //        {
        //            newList.Push(oldList, Pop());
        //        }
        //    }


        //    public static bool isEmpty(LinkedList<char> list)
        //    {
        //        if (list.Count >= 1)
        //        {
        //            return false;
        //        }
        //        return true;
        //    }

        //    public static void Push(LinkedListNode<char> node)
        //    {
        //        LinkedList<Type>.AddLast(node);
        //    }

        //    public static void Pop()
        //    {
        //        LinkedList<Type> list = new LinkedList<Type>();
        //        list.RemoveLast();
        //    }
        //}




        //public bool isPalindrome(LinkedListNode<char> head)
        //{
        //    LinkedListNode<char> reversed = ReverseClone(head);
        //    isEqual(head, reversed);
        //    return true;
        //}

        //public LinkedListNode<char> ReverseAndClone(LinkedListNode<char> node)
        //{
        //    LinkedListNode<char> head = null;
        //    LinkedList<char> ll = new LinkedList<char>();
        //    while (node != null)
        //    {
        //        LinkedListNode<char> n = new LinkedListNode<char>(node.Value);
        //        ll.AddFirst(n);
        //        if (n.Next == null)
        //        {
        //            continue;
        //        }
        //        ll.AddBefore(n, node.Value);

        //        head = n;
        //        node = node.Next;
        //    }
        //    return head;
        //}

        //public bool isEqual(LinkedListNode<char> one, LinkedListNode<char> two)
        //{
        //    while (one != null && two != null)
        //    {
        //        if (one.Value != two.Value)
        //        {
        //            return false;
        //        }
        //        one = one.Next;
        //        two = two.Next;
        //    }
        //    return true;
        //}


    }

}