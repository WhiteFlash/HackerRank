using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.programs.easy;

public static class DiagonalDifference
{
    public static int CountDiagonalDifference(List<List<int>> arr)
    {
        var maxSize = arr.Max(a => a.Count);
        var correctArray = arr.Where(x => x.Count == maxSize);
        var primary = correctArray.Select((x, i) => x[i]).Sum();
        var secondary = correctArray.Reverse().Select((x, i) => x[i]).Sum();
        var result = primary - secondary;

        return Math.Abs(result);
    }
}
