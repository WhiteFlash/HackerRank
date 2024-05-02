using System.Collections.Generic;
using System.Linq;

namespace HackerRank.programs.easy;

public static class BreakingTheRecords
{
    public static List<int> BreakingRecords(List<int> scores)
    {
        var highestScore = scores.First();
        var lowestScore = scores.First();
        var lowCount = 0;
        var highCount = 0;

        scores.ForEach(currentScore =>
        {
            if (currentScore > highestScore)
            {
                highestScore = currentScore;
                highCount++;
            }

            if (currentScore < lowestScore)
            {
                lowestScore = currentScore;
                lowCount++;
            }
        });

        return [highCount, lowCount];
    }
}