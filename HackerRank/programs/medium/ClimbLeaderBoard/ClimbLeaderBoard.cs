using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.programs.medium
{
    /// <summary>
    /// An arcade game player wants to climb to the top of the leaderboard and track their ranking. The game uses Dense Ranking, so its leaderboard works like this:
    /// The player with the highest score is ranked number  on the leaderboard.
    /// Players who have equal scores receive the same ranking number, and the next player(s) receive the immediately following ranking number.
    /// </summary>
    public class ClimbLeaderBoard
    {
        // Test, remove it
        private readonly List<ClimbLeaderBoard> m_climbLeaderBoards = new List<ClimbLeaderBoard>();

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

        // There's no adequate decription what this function does and why it returns the same list as it accepts.
        public static List<RankScore> SetGameRanks(List<RankScore> rankings)
        {
            // << Never ever handle errors like this, you will never be able to debug that code properly
            // << This is a red flag for any code reviewer
            int rank = 1;
            for (int i = 0; i < rankings.Count - 1; i++) // The error you tried to handle was related to indexing
            {
                if (rankings[i].Score == rankings[i + 1].Score)
                {
                    rankings[i].Rank = rank;
                    rankings[i + 1].Rank = rank;
                }
                else
                {
                    rankings[i + 1].Rank = ++rank;
                }
            }
            return rankings;
        }

        // Same crap, what this function does?
        public static List<int> GetRanksInTable(List<RankScore> rankings, List<int> scores)
        {
            var matrix = new List<int>();
            var rank = rankings.LastOrDefault().Rank;

            for (int i = 0; i < scores.Count; i++)
            { // << Same here, it's a piece of shit error handling
                var found = rankings.FirstOrDefault(element => element.Score <= scores[i]);
                if (found is null)
                {
                    rankings.Add(new RankScore() { Score = scores[i], Rank = ++rank });
                    matrix.Add(rank++);
                }
                else
                {
                    matrix.Add(found.Rank);
                }
            }
            return matrix;
        }

        // << Why do you have second freaking entry point? Are you trying to mislead the reviewer? )))
        public void Main()
        {
            var gameScores = new List<int> { 100, 100, 50, 40, 40, 20, 10 }; // << Use implicit types as much as posisble
            var playerScores = new List<int> { 5, 25, 50, 120 }; // << Use implicit types as much as posisble

            // << Name freaking variables properly
            var rankings = gameScores.Select((x, i) => new RankScore { Rank = i + 1, Score = x }).ToList();
            var updatedRankings = SetGameRanks(rankings);
            var ranks = GetRanksInTable(updatedRankings, playerScores);
        }
    }
}
