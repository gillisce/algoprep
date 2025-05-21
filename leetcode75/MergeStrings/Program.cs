string word1a = "abc";
string word1b = "pqr";
string word2a = "ab";
string word2b = "pqrs";
string word3a = "abcd";
string word3b = "pq";

Console.WriteLine($"{Solutions.MergeAlternately(word1a, word1b)}");
Console.WriteLine($"{Solutions.MergeAlternately(word2a, word2b)}");
Console.WriteLine($"{Solutions.MergeAlternately(word3a, word3b)}");
public static class Solutions
{
    //2 Misses of thigns I could have used
    // Could have used stringBuilder
    // Could have used Math.Max instead of the diff calc
    public static string MergeAlternately(string word1, string word2)
    {
        //can use word1[] and word2[]
        int diff = word2.Length - word1.Length;
        int length = diff > 0 ? word2.Length : word1.Length;
        //if positive diff word2, if negative diff word1, if 0 same length
        string final = "";
        for (int i = 0; i < length; i++)
        {
            if (i < word1.Length)
            {
                final += word1[i];
            }
            if (i < word2.Length)
            {
                final += word2[i];
            }
        }


        return final;
    }
}
