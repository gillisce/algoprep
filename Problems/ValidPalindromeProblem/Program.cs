using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
string a = "A man, a plan, a canal: Panama";
string b = "race a car";
string c = " ";

Solution solution = new Solution();

Console.WriteLine($"Test A: {a}");
Console.WriteLine($"{solution.IsPalindrome(a)}");
Console.WriteLine($"Test B: {b}");
Console.WriteLine($"{solution.IsPalindrome(b)}");
Console.WriteLine($"Test C: {c}");
Console.WriteLine($"{solution.IsPalindrome(c)}");

// In-Place Cleaning and Comparison: Instead of creating intermediate strings and arrays (mystring, cleanedString), this approach cleans the string as it's being traversed by the pointers. 
//This avoids the overhead of creating new strings and arrays, which can be significant for very long input strings.
// char.IsLetterOrDigit(): This built-in C# method is specifically designed to check if a character is alphanumeric, making your cleaning logic more concise and readable than using a regular expression for this specific task.
// char.ToLower(): This handles the case-insensitivity directly during comparison, without needing to convert the entire string to lowercase beforehand.
// No Regex for cleaning: While Regex is powerful, for simply filtering alphanumeric characters, char.IsLetterOrDigit() is more efficient and easier to understand for this particular problem. 
//You correctly used GeneratedRegex, which is good for performance, but avoiding regex altogether when a simpler char method exists is generally more elegant for this specific task.
// Direct Character Comparison: You're comparing individual characters directly from the original string (after validating they are alphanumeric and converting to lowercase), 
//rather than elements of a string[]. Your cleanedString was an array of strings (words), but for a palindrome check, you need to compare characters one by one.
//  If your input was "A man, a plan, a canal: Panama", your cleanedString would be ["A", "man", "a", "plan", "a", "canal", "Panama"].
//   Comparing cleanedString[0] ("A") with cleanedString[cleanedString.Length-1] ("Panama") wouldn't work for the palindrome logic. 
//   The two-pointer approach needs to compare individual characters.


public partial class Solution
{
    public bool IsPalindrome(string s)
    {
        if (String.IsNullOrEmpty(s)) return true;

        //Remove whitespace and alphanumeric characters
        string mystring = MyRegex().Replace(s, " ").Trim().ToLower();
        string[] cleanedString = mystring.Split([' '], StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine($"String Array? {String.Join("", cleanedString)}");
        //Two Pointer (From front and end, and match letters)
        int head = 0;
        int tail = cleanedString.Length - 1;
        while (head <= tail)
        {
            if (cleanedString[head] != cleanedString[tail])
            {
                return false;
            }
            head++;
            tail--;
        }
        return true;

    }



    public bool ElegantIsPalindrom(string s)
    {
        if (String.IsNullOrEmpty(s)) return true;

        // Initialize two pointers
        int left = 0;
        int right = s.Length - 1;

        // Loop until the pointers meet or cross
        while (left < right)
        {
            // Move the left pointer inwards until it points to an alphanumeric character
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }

            // Move the right pointer inwards until it points to an alphanumeric character
            while (left < right && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }

            // If the characters at the pointers don't match (case-insensitively), it's not a palindrome
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }

            // Move both pointers inwards
            left++;
            right--;
        }

        // If the loop completes, it means all checked characters matched, so it's a palindrome
        return true;
    }

    [GeneratedRegex("[^a-zA-Z]+")]
    private static partial Regex MyRegex();

}