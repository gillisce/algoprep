int[] testa = [0, 1, 0, 3, 12];
int[] testb = [0];
int[] testc = [0, 1, 0];

public static class Solutions
{
    //IN this scenario for 2 pointers we need slow and fast to iterate quickly
    //When fast hits a nonzero, move it to the slow index, in increment slow. 
    //Slow++ gives us a counter of how many shifts we made
    //After a loop throuhg, we do a quick and didrty loop based on the slow count to fill the rest
    //of the array in with 0s?
    public static void MoveZeroes(int[] nums)
    {
        int len = nums.Length;
        int slow = 0;
        int fast = 0;
        while (fast < len)
        {
            if (nums[fast] != 0)
            {
                nums[slow] = nums[fast];
                slow++;
            }
            fast++;

        }
        for (int i = slow; i < len; i++) nums[i] = 0;
    }


    public static void MoveZeroesRefined(int[] nums)
    {
        int slow = 0; // 'slow' pointer: Tracks the position for the next non-zero element.

        // 'fast' pointer iterates through the entire array
        for (int fast = 0; fast < nums.Length; fast++)
        {
            // If the element at 'fast' is non-zero
            if (nums[fast] != 0)
            {
                // Only perform a swap IF 'slow' is behind 'fast'.
                // This condition means we've encountered at least one zero that 'slow' skipped.
                // If slow == fast, it means nums[fast] is already in its correct "non-zero" position
                // relative to other non-zero numbers processed so far, so no swap is needed.
                if (slow != fast) // Crucial check to avoid unnecessary swaps/writes onto self
                {
                    // Perform a swap: move the non-zero element from 'fast'
                    // to the current position of 'slow', and put the (presumed) zero
                    // that was at 'slow' into 'fast''s original spot.
                    int temp = nums[slow];
                    nums[slow] = nums[fast];
                    nums[fast] = temp;
                }
                slow++; // Increment 'slow' to point to the next slot for a non-zero element.
            }
        }
        // No second loop needed, as zeros are implicitly moved to the end by swapping.
    }
}
