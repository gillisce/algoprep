Console.WriteLine("Hello, World!");

//Brute Force Version (INitial Thought)
int[] numsStarter = [2, 5, 7, 11, 15];
int targetValue = 9;
Solutions solutions = new Solutions();
int[] bruteForceResult = solutions.TwoSumBruteForce(numsStarter, targetValue);
int[] dictionaryResult = solutions.TwoSumDictionary(numsStarter, targetValue);

Console.WriteLine($"Brute Force: [{bruteForceResult[0]}, {bruteForceResult[1]}]");
Console.WriteLine($"Dictionary: [{dictionaryResult[0]}, {dictionaryResult[1]}]");



//Things to take away from this problem:
//At face value the brute force nested loop comes to mind and in theory would work
// But there is a faster solution using Dictionary, this is because we need a value pair and this allows us to store in a hash map
// 

public class Solutions
{
    public int[] TwoSumBruteForce(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
            for (int j = i + 1; j < nums.Length; j++)
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };

        return new int[] { };
    }

    public int[] TwoSumDictionary(int[] nums, int target)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            //Gemini: Get the inline comments to help look back on
            int complement = target - nums[i];

            // Check if the complement exists in our map
            if (result.ContainsKey(complement))
            {
                // If it exists, we found the pair!
                // The index of the complement is numMap[complement]
                // The current number's index is i
                return [result[complement], i];
            }
            else
            {
                // If the complement doesn't exist, add the current number and its index to the map
                // So that future numbers can check against it.
                // Using numMap[nums[i]] = i; is also common and works well here,
                // as we only add if the key isn't already found as a complement.
                result.TryAdd(nums[i], i);
            }
            //My Code:
            // if (result.ContainsKey(target - nums[i]))
            // {
            //     return [result[target - nums[i]], i];
            // }
            // else
            //     result.TryAdd(nums[i], i);
        }
        return default;
    }

}