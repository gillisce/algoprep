// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numsStarter1 = [2, 7, 11, 15];
int targetValue1 = 9;
int[] numsStarter2 = [2, 3,4];
int targetValue2 = 6;
int[] numsStarter3 = [-1,0];
int targetValue3 = -1;

Console.WriteLine($"Test Case A: {string.Join(",",Solutions.TwoSum(numsStarter1, targetValue1))}");
Console.WriteLine($"Test Case B: {string.Join(",",Solutions.TwoSum(numsStarter2, targetValue2))}");
Console.WriteLine($"Test Case C: {string.Join(",",Solutions.TwoSum(numsStarter3, targetValue3))}");

public static class Solutions
{
    public static int[] TwoSumSlow(int[] nums, int target)
    {
        //Array is sorted
        //Since I need value pair is Dictionary worth it?

        //In theory
        //Start at beginning i
        //Get difference of target - i
        //Start at i+1, loop and see if option.
        //Move to next one

        for (int i = 0; i < nums.Length; i++)
        {
            int differnce = target - nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == differnce)
                {
                    return [i + 1, j + 1];
                }
                else if (nums[j] >= differnce)
                {
                    break;
                }
            }
        }
        return [];
    }

    public static int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;
        while (left < right)
        {
            int sum = numbers[left] + numbers[right];
            if (sum == target)
            {
                return [left + 1, right + 1];
            }
            else if (sum < target)
            {
                left++;
            }
            else if (sum > target)
            {
                right--;
            }
        }


        return [];
    
    }
}