
# Common Algorithm Patterns in C#

## Two Pointers: One Input, Opposite Ends
```csharp
int[] arr = {1, 2, 3, 4, 5};
int left = 0, right = arr.Length - 1;
while (left < right)
{
    // Process elements at arr[left] and arr[right]
    left++;
    right--;
}
```

## Two Pointers: Two Inputs, Exhaust Both
```csharp
int[] arr1 = {1, 3, 5};
int[] arr2 = {2, 4, 6};
int i = 0, j = 0;
while (i < arr1.Length && j < arr2.Length)
{
    if (arr1[i] < arr2[j])
    {
        // Process arr1[i]
        i++;
    }
    else
    {
        // Process arr2[j]
        j++;
    }
}
```

## Sliding Window
```csharp
int[] arr = {1, 2, 3, 4, 5};
int windowSize = 3;
int sum = 0;
for (int i = 0; i < windowSize; i++)
{
    sum += arr[i];
}
for (int i = windowSize; i < arr.Length; i++)
{
    sum += arr[i] - arr[i - windowSize];
    // Process sum
}
```

## Build a Prefix Sum
```csharp
int[] arr = {1, 2, 3, 4, 5};
int[] prefixSum = new int[arr.Length];
prefixSum[0] = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    prefixSum[i] = prefixSum[i - 1] + arr[i];
}
```

## Efficient String Building
```csharp
using System.Text;

StringBuilder sb = new StringBuilder();
sb.Append("Hello");
sb.Append(" ");
sb.Append("World");
string result = sb.ToString();
```

## Linked List: Fast and Slow Pointer
```csharp
class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

ListNode slow = head;
ListNode fast = head;
while (fast != null && fast.next != null)
{
    slow = slow.next;
    fast = fast.next.next;
}
// 'slow' is now at the middle node
```

## Reversing a Linked List
```csharp
ListNode prev = null;
ListNode current = head;
while (current != null)
{
    ListNode nextTemp = current.next;
    current.next = prev;
    prev = current;
    current = nextTemp;
}
head = prev;
```

## Find Number of Subarrays That Fit an Exact Criteria
```csharp
int CountSubarraysWithSumK(int[] nums, int k)
{
    var dict = new Dictionary<int, int> { { 0, 1 } };
    int count = 0, sum = 0;
    foreach (var num in nums)
    {
        sum += num;
        if (dict.ContainsKey(sum - k))
            count += dict[sum - k];
        if (!dict.ContainsKey(sum))
            dict[sum] = 0;
        dict[sum]++;
    }
    return count;
}
```

## Monotonic Increasing Stack
```csharp
int[] arr = {1, 3, 2, 4};
Stack<int> stack = new Stack<int>();
foreach (int num in arr)
{
    while (stack.Count > 0 && stack.Peek() > num)
    {
        stack.Pop();
    }
    stack.Push(num);
}
```

## Binary Tree: DFS (Recursive)
```csharp
void DFS(TreeNode node)
{
    if (node == null) return;
    // Process node.val
    DFS(node.left);
    DFS(node.right);
}
```

## Binary Tree: DFS (Iterative)
```csharp
Stack<TreeNode> stack = new Stack<TreeNode>();
stack.Push(root);
while (stack.Count > 0)
{
    TreeNode node = stack.Pop();
    // Process node.val
    if (node.right != null) stack.Push(node.right);
    if (node.left != null) stack.Push(node.left);
}
```

## Binary Tree: BFS
```csharp
Queue<TreeNode> queue = new Queue<TreeNode>();
queue.Enqueue(root);
while (queue.Count > 0)
{
    TreeNode node = queue.Dequeue();
    // Process node.val
    if (node.left != null) queue.Enqueue(node.left);
    if (node.right != null) queue.Enqueue(node.right);
}
```
