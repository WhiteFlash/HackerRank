using System.Collections.Generic;
using System.Linq;

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
    public class RankScore
    {
        public int Rank { get; set; }
        public int Score { get; set; }
    }

    public static bool CompareObjectsRanksAndScores(List<RankScore> listOne, List<RankScore> listTwo)
    {
        if (listOne.Count == listTwo.Count)
        {
            for (int i = 0; i < listOne.Count; i++)
            {
                if (listOne[i].Rank == listTwo[i].Rank &
                    listOne[i].Score == listTwo[i].Score)
                    continue;
                else
                    return false;
            }
            return true;
        }
        return false;
    }

    public static List<RankScore> ParseRankingArray(List<int> gamesScores)
    {
        var rankScoreList = new List<RankScore>();

        for (int i = 0; i < gamesScores.Count; i++)
        {
            rankScoreList.Add(new RankScore()
            {
                Rank = i + 1,
                Score = gamesScores[i]
            });
        }
        return rankScoreList;
    }
    public static List<RankScore> SetGameRanks(List<RankScore> list)
    {
        try
        {
            int rank = 1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Score == list[i + 1].Score)
                {
                    list[i].Rank = rank;
                    list[i + 1].Rank = rank;
                }
                else
                {
                    list[i + 1].Rank = ++rank;
                }
            }
        }
        catch { }
        return list;
    }

    public static List<int> ClimbingLeaderboard(List<RankScore> table, List<int> playerScores)
    {
        List<int> matrix = new List<int>();
        int rank = table.LastOrDefault().Rank;

        for (int i = 0; i < playerScores.Count; i++)
        {
            try
            {
                RankScore found = table.FirstOrDefault(element => element.Score <= playerScores[i]);
                if (found is null)
                {
                    table.Add(new RankScore() { Score = playerScores[i], Rank = ++rank });
                    matrix.Add(rank++);
                }
                else
                {
                    matrix.Add(found.Rank);
                }
            }
            catch { }
        }
        return matrix;
    }
    public void Main()
    {
        List<int> gameScores = new List<int> { 100, 100, 50, 40, 40, 20, 10 };
        List<int> playerScores = new List<int> { 5, 25, 50, 120 };

        var temp = ParseRankingArray(gameScores);
        var temp2 = SetGameRanks(temp);
        var result = ClimbingLeaderboard(temp2, playerScores);
    }
}
