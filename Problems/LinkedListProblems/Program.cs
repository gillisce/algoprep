using System;
using System.Collections.Generic;
using System.Data.SqlTypes; // For List<int> to easily build linked lists

// Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;

    // Constructor 1: Default
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    // Optional: A method to easily print the linked list for verification
    public void PrintList()
    {
        ListNode current = this;
        Console.Write("[");
        while (current != null)
        {
            Console.Write(current.val);
            if (current.next != null)
            {
                Console.Write(" -> ");
            }
            current = current.next;
        }
        Console.WriteLine("]");
    }
}

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {

        ListNode prev = null;
        ListNode current = head;
        while (current != null)
        {
            ListNode nextTemp = current.next; // Save next node
            current.next = prev;              // Reverse current node's pointer
            prev = current;                   // Move prev to current node
            current = nextTemp;               // Move current to next node
        }
        return prev;
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var dummyNode = new ListNode();
        var tail = dummyNode;

        var pointer1 = list1;
        var pointer2 = list2;

        while (pointer1 != null && pointer2 != null)
        {
            if (pointer1.val < pointer2.val)
            {
                tail.next = pointer1;
                pointer1 = pointer1.next;
            }
            else
            {
                tail.next = pointer2;
                pointer2 = pointer2.next;
            }

            tail = tail.next;
        }

        tail.next = pointer1 ?? pointer2;

        return dummyNode.next;
    }

    //Head [4,5,1,9]
    //NOde 5 .val = 5 .next = 1, Node()
    public void DeleteNode(ListNode node)
    {
        node.val = node.next.val;
        node.next = node.next.next;


    }

    public ListNode MiddleNode(ListNode head)
    {
        //Simple 2 pointer run
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;

    }

    public ListNode DeleteMiddle(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return null;
        }
        if (head.next.next == null)
        {
            head.next = null;
            return head;
        }
        ListNode fast = head;
        ListNode slow = head;
        ListNode prev = null;
        while (fast != null && fast.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        prev.next = slow.next;
        return head;

    }

    public ListNode OddEvenList(ListNode head)
    {
        ListNode originEven = head.next;
        ListNode odd = head;
        ListNode even = head.next;
        while (even != null && even.next != null)
        {
            odd.next = even.next;
            odd = odd.next;
            even.next = odd.next;
            even = even.next;
        }
        odd.next = originEven;

        return head;
    }

    public int PairSum(ListNode head)
    {
        //Empty List
        if (head == null)
        {
            return 0;
        }
        // 1 Item
        if (head.next == null)
        {
            return head.val;
        }
        //2 Items
        if (head.next.next == null)
        {
            return head.val + head.next.val;
        }
        int maxSum = 0;
        List<int> listVals = new();
        while (head != null)
        {
            listVals.Add(head.val);
            head = head.next;
        }
        int start = 0;
        int end = listVals.Count - 1;
        while (start < end)
        {
            maxSum = Math.Max(maxSum, listVals[start] + listVals[end]);
            start++;
            end--;
        }

        return maxSum;
    }

    public int PairSumFancy(ListNode head)
    {
        if (head == null)
        {
            return 0;
        }
        // 1 Item
        if (head.next == null)
        {
            return head.val;
        }
        //2 Items
        if (head.next.next == null)
        {
            return head.val + head.next.val;
        }
        ListNode fast = head;
        ListNode slow = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        ListNode prev = null;
        ListNode current = slow;
        while (current != null)
        {
            ListNode tempNext = current.next;
            current.next = prev;
            prev = current;
            current = tempNext;
        }
        int maxSum = 0;
        ListNode p1 = head;
        ListNode p2 = prev;
        while (p1 != null)
        {
            maxSum = Math.Max(maxSum, p1.val + p2.val);
            p1 = p1.next;
            p2 = p2.next;
        }
        return maxSum;
    }

}

// This is your main program to test your solution
class Program
{
    // Helper method to create a linked list from an array
    public static ListNode CreateLinkedList(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            return null;
        }

        ListNode head = new ListNode(arr[0]);
        ListNode current = head;
        for (int i = 1; i < arr.Length; i++)
        {
            current.next = new ListNode(arr[i]);
            current = current.next;
        }
        return head;
    }

    static void Main(string[] args)
    {
        Solution sol = new Solution();

        // // --- Test Case 1 ---
        int[] testArr1 = [1,3,4,7,1,2,6];
        Console.WriteLine($"Original List 1: {string.Join(", ", testArr1)}");
        ListNode head1 = CreateLinkedList(testArr1);
        Console.Write("Constructed List 1: ");
        head1?.PrintList(); // Using ?. for null check before calling PrintList

        ListNode reversedHead1 = sol.DeleteMiddle(head1);
        Console.Write("Reversed List 1:    ");
        reversedHead1?.PrintList();
        Console.WriteLine("------------------------------");

        // --- Test Case 2: Empty list ---
        int[] testArr2 = [1,2,3,4];
        Console.WriteLine($"Original List 2: {string.Join(", ", testArr2)}");
        ListNode head2 = CreateLinkedList(testArr2);
        Console.Write("Constructed List 2: ");
        head2?.PrintList();

        ListNode reversedHead2 = sol.DeleteMiddle(head2);
        Console.Write("Reversed List 2:    ");
        reversedHead2?.PrintList();
        Console.WriteLine("------------------------------");

        // // --- Test Case 3: Single element list ---
        int[] testArr3 = [2, 1];
        Console.WriteLine($"Original List 3: {string.Join(", ", testArr3)}");
        ListNode head3 = CreateLinkedList(testArr3);
        Console.Write("Constructed List 3: ");
        head3?.PrintList();

        ListNode reversedHead3 = sol.DeleteMiddle(head3);
        Console.Write("Reversed List 3:    ");
        reversedHead3?.PrintList();
        Console.WriteLine("------------------------------");

        // Add more test cases here as needed
        // int[] testArr3 = { 4,5,1,9 };
        // Console.WriteLine($"Original List 3: {string.Join(", ", testArr3)}");
        // ListNode head3 = CreateLinkedList(testArr3);
        // Console.Write("Constructed List 3: ");
        // head3?.PrintList();
    }
}