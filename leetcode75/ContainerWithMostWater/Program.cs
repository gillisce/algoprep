// See https://aka.ms/new-console-template for more information

// int[] case1 = [1, 8, 6, 2, 5, 4, 8, 3, 7];
// int[] case2 = [1, 1];
int[] case1 = [8, 7, 2, 1];

Console.WriteLine($"Case A: {Solution.MaxArea(case1)}");
// Console.WriteLine($"Case B: {Solution.MaxArea(case2)}");

public static class Solution
{
    public static int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int area = 0;
        while (left < right)
        {
            int distance = right - left;
            int tmpArea  = Math.Min(height[left], height[right]) * distance;
            if (tmpArea > area)
            {
                area = tmpArea;
            }
            //Left is shorter
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return area;
    }
}