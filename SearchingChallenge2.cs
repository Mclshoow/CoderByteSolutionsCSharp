//CoderByte Searching Challenge 2 C#

using System;
using System.Linq;

class MainClass
{
    static void Main()
    {
        Console.WriteLine(SearchingChallenge(Console.ReadLine()));
    }

    public static string SearchingChallenge(string str)
    {
        string challengeToken = "SeuToken";

        string[] words = str.Split(' ');

        bool HasRepeatedLetters(string word)
        {
            return word.GroupBy(c => c)
                       .Any(group => group.Count() > 1);
        }

        string result = words.Where(HasRepeatedLetters)
                             .OrderByDescending(word => word.Count(c => char.IsLetter(c) && !char.IsDigit(c)))
                             .FirstOrDefault();

        if (result == null)
        {
            return "-1";
        }

        result = new string(result
                            .ToCharArray()
                            .Where(c => challengeToken.IndexOf(char.ToLower(c)) == -1)
                            .ToArray());

        if (string.IsNullOrEmpty(result))
        {
            return "EMPTY";
        }

        return result;
    }
}