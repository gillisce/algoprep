// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Hello, World!");

string test = "abcabcbb";

//Pulled from Gemini Response
//Clear I need more practice with the sliding window, I tried to be fancy using the bool array, should have switched gears to the hash map
        
    int GoodLengthOfLongestSubstring(string s)
    {
        // 1. Initialize our variables for the sliding window

        // charSet will store characters currently in our window.
        // HashSet<char> provides O(1) average time complexity for Add, Remove, and Contains operations.
        HashSet<char> charSet = new HashSet<char>();

        // 'left' is the left pointer of our sliding window.
        int left = 0;

        // 'maxLength' will store the maximum length found so far.
        int maxLength = 0;

        // 2. Iterate with the 'right' pointer to expand the window
        // The 'right' pointer will traverse the entire string from left to right.
        for (int right = 0; right < s.Length; right++)
        {
            // 3. Check for repeating characters and shrink the window if necessary
            // While the character at 's[right]' is already in our 'charSet',
            // it means we have a repeating character within our current window.
            while (charSet.Contains(s[right]))
            {
                // To resolve the repetition, we need to shrink the window from the left.
                // Remove the character at the 'left' pointer from our set.
                charSet.Remove(s[left]);
                // Move the 'left' pointer one step to the right.
                left++;
            }

            // 4. Add the current character to the set
            // Once the window is valid (no repeating characters), add the character
            // at the 'right' pointer to our set.
            charSet.Add(s[right]);

            // 5. Update the maximum length
            // The length of the current valid window is (right - left + 1).
            // We take the maximum between the current maxLength and the current window's length.
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        // 6. Return the result
        return maxLength;
    }

int LengthOfLongestSubstring(string s)
{
    int result = 0;
    int left = 0;
    while (left < s.Length)
    {
        for (int inner = left; inner < s.Length; inner++)
        {
            bool[] alpha = new bool[26];

            if (!alpha[s[inner] - 'a'])
            {
                alpha[s[inner] - 'a'] = true;
            }
            else
            {
                result = Math.Max(result, inner - left);
                left++;
            }
        }
        //left++;
    }
    // for (int i = 0; i < s.Length; i++)
    // {
    //     bool[] alpha = new bool[26];
    //     int count = 0;
    //     if (!alpha[s[i] - 'a'])
    //     {
    //         alpha[s[i] - 'a'] = true;
    //         count++;
    //     }
    //     else
    //     {
    //         result = Math.Max(result, count);
    //     }
    // }
    //Loop through the string
    //Mark if visited against array of "letters"
    //Once visited set to result if larger than current value
    return result;
}

Console.WriteLine($"{LengthOfLongestSubstring(test)}");
Console.WriteLine($"{GoodLengthOfLongestSubstring(test)}");