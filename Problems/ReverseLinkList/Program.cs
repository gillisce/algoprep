using System;
using System.Collections.Generic; // For List<int> to easily build linked lists

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

    public ListNode MiddleNode(ListNode head) {
        //Simple 2 pointer run
        ListNode slow = head;
        ListNode fast = head;
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        } 
        
        return slow;

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
        // int[] testArr1 = { 1, 2, 3, 4, 5 };
        // Console.WriteLine($"Original List 1: {string.Join(", ", testArr1)}");
        // ListNode head1 = CreateLinkedList(testArr1);
        // Console.Write("Constructed List 1: ");
        // head1?.PrintList(); // Using ?. for null check before calling PrintList

        // ListNode reversedHead1 = sol.ReverseList(head1);
        // Console.Write("Reversed List 1:    ");
        // reversedHead1?.PrintList();
        // Console.WriteLine("------------------------------");

        // // --- Test Case 2: Empty list ---
        // int[] testArr2 = { };
        // Console.WriteLine($"Original List 2: {string.Join(", ", testArr2)}");
        // ListNode head2 = CreateLinkedList(testArr2);
        // Console.Write("Constructed List 2: ");
        // head2?.PrintList();

        // ListNode reversedHead2 = sol.ReverseList(head2);
        // Console.Write("Reversed List 2:    ");
        // reversedHead2?.PrintList();
        // Console.WriteLine("------------------------------");

        // // --- Test Case 3: Single element list ---
        // int[] testArr3 = { 7 };
        // Console.WriteLine($"Original List 3: {string.Join(", ", testArr3)}");
        // ListNode head3 = CreateLinkedList(testArr3);
        // Console.Write("Constructed List 3: ");
        // head3?.PrintList();

        // ListNode reversedHead3 = sol.ReverseList(head3);
        // Console.Write("Reversed List 3:    ");
        // reversedHead3?.PrintList();
        // Console.WriteLine("------------------------------");

        // Add more test cases here as needed
        int[] testArr3 = { 4,5,1,9 };
        Console.WriteLine($"Original List 3: {string.Join(", ", testArr3)}");
        ListNode head3 = CreateLinkedList(testArr3);
        Console.Write("Constructed List 3: ");
        head3?.PrintList();
    }
}