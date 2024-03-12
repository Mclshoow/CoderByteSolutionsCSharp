//CoderByte Searching Challenge C#

using System;
using System.Linq;
using System.Text;

class MainClass
{
    static void Main()
    {
        string result = SearchingChallenge(Console.ReadLine());
        Console.WriteLine(result);
    }

    static string SearchingChallenge(string str)
    {
        string longestPalindrome = "none";
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i + 2; j <= str.Length; j++)
            {
                string substring = str.Substring(i, j - i);
                if (IsPalindrome(substring) && substring.Length > longestPalindrome.Length)
                {
                    longestPalindrome = substring;
                }
            }
        }

        string challengeToken = "SeuToken";

        StringBuilder filteredString = new StringBuilder();
        foreach (char c in longestPalindrome)
        {
            if (challengeToken.IndexOf(char.ToLower(c)) == -1)
            {
                filteredString.Append(c);
            }
        }

        if (filteredString.Length == 0)
        {
            return "EMPTY";
        }

        return filteredString.ToString();
    }

    static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}