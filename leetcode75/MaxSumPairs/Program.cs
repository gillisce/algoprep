// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;

Console.WriteLine("Hello, World!");
int[] case1 = [1, 2, 3, 4];
int sum1 = 5;
int[] case2 = [3, 1, 3, 4, 3];
int sum2 = 6;

Console.WriteLine($"{Soltuions.MaxOpsDictionary(case1, sum1)}");
Console.WriteLine($"{Soltuions.MaxOpsDictionary(case2, sum2)}");

public static class Soltuions
{
    //NOt ideal since Array.Sort is SLOWWWWWWWWW
    public static int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);
        int left = 0;
        int right = nums.Length - 1;
        int operationCount = 0;

        while (left < right)
        {
            int currentSum = nums[left] + nums[right];
            if (currentSum == k)
            {
                operationCount++; left++; right--;
            }
            else if (currentSum < k)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return operationCount;
    }

    public static int MaxOpsDictionary(int[] nums, int k)
    {
        //Key Complement, 
        // Dictionary<int, int> counts = [];
        // int operationCount = 0;
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (counts.TryGetValue(nums[i], out int value))
        //     {
        //         counts[nums[i]] = ++value;
        //     }
        //     else
        //     {
        //         counts.TryAdd(nums[i], 1);
        //     }

        //     int complement = k - nums[i];

        //     counts[nums[i]]--;
        //     if (counts.TryGetValue(complement, out int value))
        //     {
        //         operationCount++;
        //         counts[complement] = --value;
        //     }

        // }
        // return operationCount;
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }

        int operationCount = 0;
        foreach (int num in nums) {
            // If this number has already been used in a pair, skip it
            if (!counts.ContainsKey(num) || counts[num] <= 0) {
                continue;
            }

            int complement = k - num;

            // Mark 'num' as used (decrement its count)
            counts[num]--;

            // Check if complement exists and is available
            if (counts.ContainsKey(complement) && counts[complement] > 0) {
                operationCount++;
                counts[complement]--; // Mark 'complement' as used
            }
            // If complement was not found or already used up,
            // the 'num' we just decremented its count for is now effectively wasted.
            // This implicitly handles cases where num == complement as well.
        }

        return operationCount;
    }
}