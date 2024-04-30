using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace HackerRank.programs.medium;

/// <summary>
///     An arcade game player wants to climb to the top of the leaderboard and track their ranking. The game uses Dense Ranking, so its leaderboard works like this:
///     The player with the highest score is ranked number  on the leaderboard.
///     Players who have equal scores receive the same ranking number, and the next player(s) receive the immediately following ranking number.
/// </summary>
public class ClimbLeaderBoard
{
    /// <summary>
    /// Class helper for converting data from array of integers to objects with wto fields.
    /// </summary>
    public class RankScore : IEquatable<RankScore>
    {
        public int Rank { get; set; }
        public int Score { get; set; }

        public bool Equals(RankScore other) => other is not null && Rank == other.Rank && Score == other.Score;

        public override bool Equals(object obj) => Equals(obj as RankScore);

        public override int GetHashCode() => HashCode.Combine(Rank, Score);
    }

    public static List<RankScore> ParseRankingArray(List<int> gamesScores)
    {
        var groupId = 0;

        return gamesScores
             .Select((x, i) => new RankScore
             {
                 Score = x,
                 Rank = (i > 0 && gamesScores[i - 1] == x) ? groupId : ++groupId
             })
             .ToList();
    }

    public static List<int> ClimbingLeaderboardRun(List<int> ranked, List<int> playerScores)
    {
       var result = new List<int>();

        var cleanerRank = ranked.ToHashSet().ToArray();
        int i = cleanerRank.Length - 1;

        for (int j = 0; j < playerScores.Count; j++)
        {
            bool rankFound = false;
            while (!rankFound && i >= 0)
            {
                if (playerScores[j] < cleanerRank[i])
                {
                    result.Add(i + 2);
                    rankFound = true;
                }
                else if (playerScores[j] == cleanerRank[i])
                {
                    result.Add(i + 1);
                    rankFound = true;
                }
                else
                {
                    i--;
                }
            }

            if (!rankFound)
            {
                result.Add(1);
            }
        }

        return result;
    }
}
