// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] test = [1, 2, 3, 1];

Console.WriteLine($"{ContainsDuplicate(test)}");

///Took a whole 2 minutes to write
/// 

/*he key takeaway from LeetCode 217 (Contains Duplicate) to remember for pattern recognition with Hash Sets is:

When you need to efficiently check for the existence or uniqueness of elements in a collection, especially if you need to do so repeatedly as you iterate through the data, a HashSet is your go-to data structure for O(1) average time lookups.

In simpler terms:

Problem Clue: If the question involves finding duplicates, checking if an item is "already seen," or counting unique items.
Hash Set's Power: It acts like a super-fast "Did I see this before?" checker. You add items to it as you encounter them, and then you can ask set.Contains(item) in almost no time at all.
Why it's better than other options:
Looping (naive): O(N 
2
 ) - too slow.
Sorting: O(NlogN) - slower than hash set for time, but uses O(1) extra space if allowed to modify input.
Your Note for the Pattern Sheet:*/
bool ContainsDuplicate(int[] nums)
{
    Dictionary<int,int> dups = new Dictionary<int,int>();
    foreach (int num in nums)
    {
        if (dups.ContainsKey(num))
        {
            return true;
        }
        dups.TryAdd(num, 1);
    }
    return false;       
}