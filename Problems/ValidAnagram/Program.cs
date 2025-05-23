string s = "aacc";
string t = "ccac";

bool IsAnagram(string s, string t)
{
    if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length != t.Length)
    {
        return false;
    }
    Dictionary<char, int> baseSet = new();
    foreach (char c in s)
    {
        if (baseSet.ContainsKey(c))
        {
            baseSet[c]++;
        }
        else
        {
            baseSet.Add(c, 1);
        }
    }

    foreach (char c in t)
    {
        if (baseSet.ContainsKey(c) && baseSet[c] > 0)
        {
            baseSet[c]--;
        }
        else
        {
            return false;
        }
    }
    //Create collection from string s
    //Loop through by character on string t
    //If it doesn't exist return false
    return true;
}

bool IsAnagramArrayBase(string s, string t)
{
            // Initial checks: null, empty, or different lengths immediately indicate not an anagram.
        if (s == null || t == null || s.Length != t.Length) {
            return false;
        }

        // Using an array of size 26 for lowercase English letters
        // 'a' corresponds to index 0, 'b' to index 1, ..., 'z' to index 25
        int[] charCounts = new int[26];

        // First pass: Count characters in string 's'
        foreach (char c in s) {
            charCounts[c - 'a']++; // Increment count for the corresponding character
        }

        // Second pass: Decrement counts for characters in string 't'
        foreach (char c in t) {
            // If the count for 'c' is already 0, it means 't' has more of this character
            // than 's', or 's' didn't have this character at all.
            if (charCounts[c - 'a'] == 0) {
                return false;
            }
            charCounts[c - 'a']--; // Decrement count
        }

        // After both loops, if all counts are zero, it's an anagram.
        // However, the second loop already handles this implicitly.
        // If we reached this point, it means all characters in 't' had a corresponding
        // character in 's' (with sufficient counts).
        // If 's' and 't' have the same length, and all characters in 't' could be
        // "removed" from 's's counts, then 's' must have had the same characters.
        // Therefore, no need for a final loop to check if all counts are zero.
        return true;
}

Console.WriteLine($"{IsAnagram(s,t)}");
Console.WriteLine($"{IsAnagramArrayBase(s,t)}");