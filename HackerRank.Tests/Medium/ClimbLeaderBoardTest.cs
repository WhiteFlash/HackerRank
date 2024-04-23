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
        var expected = new List<RankScore>()
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
        //Assert
        Assert.Equal(expected, actual);

    }

    [Theory]
    [ClassData(typeof(ClimbLeaderBoardData))]
    public void ClimbingLeaderboardRunTest(List<int> tablo, List<int> playedGames, List<int> expected)
    {
        var actual = ClimbingLeaderboardRun(tablo, playedGames);
        //Assert
        Assert.Equal(expected, actual);
    }
}