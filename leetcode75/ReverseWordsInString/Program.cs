using System.Text;

string word1a = "the sky is blue";
string word2a = "  hello world  ";
string word3a = "a good   example";

Console.WriteLine($"{Solutions.ReverseWords(word1a)}");
Console.WriteLine($"{Solutions.ReverseWords(word2a)}");
Console.WriteLine($"{Solutions.ReverseWords(word3a)}");
public static class Solutions
{
    public static string ReverseWords(string s)
    {
        StringBuilder sb = new();
        //Create an array of words
        //Then reverse loop array to append to string builder
        s = s.Trim(); //Get rid of leading / trailing spaces
        string[] words = s.Split([' '], StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"{words.Length} words");
        Console.WriteLine($"{string.Join(',',words)}");

        for (int i = words.Length - 1; i >= 0; i--)
        {
            sb.Append(words[i]);
            if (i != 0)
            {
                sb.Append(' ');
            }
        }


        return sb.ToString();
    }
}
