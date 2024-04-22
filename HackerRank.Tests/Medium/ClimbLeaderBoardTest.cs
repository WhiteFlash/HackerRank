using System.Collections.Generic;
using Xunit;
using static HackerRank.programs.medium.ClimbLeaderBoard;

namespace HackerRank.Tests.Medium;

public class ClimbLeaderBoardTest
{
    private readonly List<int> _rankingArray = [100, 100, 50, 40, 40, 20, 10];

    [Trait("Medium", "ClimbLeaderBoard")]
    [Fact]
    public void ParseRankingArrayTest()
    {
        //Arrange
        List<RankScore> expected = new List<RankScore>()
        {
            new RankScore() { Rank = 1, Score = 100 },
            new RankScore() { Rank = 2, Score = 100 },
            new RankScore() { Rank = 3, Score = 50 },
            new RankScore() { Rank = 4, Score = 40 },
            new RankScore() { Rank = 5, Score = 40 },
            new RankScore() { Rank = 6, Score = 20 },
            new RankScore() { Rank = 7, Score = 10 }
        };
        //Act
        List<RankScore> actual = ParseRankingArray(_rankingArray);
        //Assert
        Assert.True(CompareObjectsRanksAndScores(expected, actual));

    }

    [Fact]
    public void SetGameRanksTest()
    {
        //Arrange
        List<RankScore> expected = new List<RankScore>()
        {
            new RankScore() { Rank = 1, Score = 100 },
            new RankScore() { Rank = 1, Score = 100 },
            new RankScore() { Rank = 2, Score = 50 },
            new RankScore() { Rank = 3, Score = 40 },
            new RankScore() { Rank = 3, Score = 40 },
            new RankScore() { Rank = 4, Score = 20 },
            new RankScore() { Rank = 5, Score = 10 }
        };
        //Act
        List<RankScore> actual = ParseRankingArray(_rankingArray);
        actual = SetGameRanks(actual);
        //Assert
        Assert.True(CompareObjectsRanksAndScores(expected, actual));
    }

    [Fact]
    public void GetRanksInTableTest()
    {
        //Arrange
        List<int> expected = new List<int>() { 6, 4, 2, 1 };
        //Act
        var actual = ClimbingLeaderboard(new List<RankScore>()
        {
            new RankScore() { Rank = 1, Score = 100 },
            new RankScore() { Rank = 1, Score = 100 },
            new RankScore() { Rank = 2, Score = 50 },
            new RankScore() { Rank = 3, Score = 40 },
            new RankScore() { Rank = 3, Score = 40 },
            new RankScore() { Rank = 4, Score = 20 },
            new RankScore() { Rank = 5, Score = 10 }
        }, new List<int> { 5, 25, 50, 120 });
        //Assert
        Assert.Equal(expected, actual);
    }


}