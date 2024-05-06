using System;
using System.Text.RegularExpressions;

namespace HackerRank.programs.easy;

public static class MinimumNumberOfChars
{
    public static int MinimumNumber(int n, string password)
    {
        var numbers = new Regex("[0-9]");
        var lower_case = new Regex("[a-z]");
        var upper_case = new Regex("[A-Z]");
        var special_characters = new Regex(@"[!\@\#\$\%\^\&\*\(\)\-\+]");

        var isWithDigit = numbers.Match(password);
        var isWithLowerCase = lower_case.Match(password);
        var isWithUpperCase = upper_case.Match(password);
        var isWithSpecialCharacters = special_characters.Match(password);
        var count = 0;

        if (isWithDigit.Captures.Count == 0)
            count++;
        if (isWithLowerCase.Captures.Count == 0)
            count++;
        if (isWithUpperCase.Captures.Count == 0)
            count++;
        if (isWithSpecialCharacters.Captures.Count == 0)
            count++;

        var minLength = Math.Max(0, 6 - n);

        return Math.Max(count, minLength);
    }
}