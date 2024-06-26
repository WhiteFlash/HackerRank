using System;
using System.Collections.Generic;

namespace HackerRank.LeetCode.Easy;
public static class TwoSums
{
    public static int[] CountTwoSum(int[] numbers, int target)
    {
        var dictionary = new Dictionary<int, int>();

        for (var number = 0; number < numbers.Length; number++)
        {
            var diff = target - numbers[number];

            if (dictionary.TryGetValue(diff, out int value))
            {
                return [value, number];
            }
            else
            {
                dictionary[numbers[number]] = number;
            }
        };

        return Array.Empty<int>();
    }
}
