using System.Collections.Generic;
using System.Linq;

namespace HackerRank.programs.easy;

public static class AppleAndOrange
{
    public static (int, int) CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        var applesUpdated = apples.Select(x => x += a).ToList();
        var orangesUpdated = oranges.Select(x => x += b).ToList();

        var resultApples = applesUpdated.Where(x => x >= s & x <= t).ToList();
        var resultOranges = orangesUpdated.Where(x => x >= s & x <= t).ToList();
        return (resultApples.Count, resultOranges.Count);
    }
}