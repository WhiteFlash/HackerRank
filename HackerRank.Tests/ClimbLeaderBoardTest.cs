using System.Collections.Generic;
using System.Linq;
using Xunit;
using static HackerRank.programs.medium.ClimbLeaderBoard;

namespace HackerRank.Tests
{
    public class ClimbLeaderBoardTest
    {
        [Fact]
        public void SetGameRanksTest()
        {
            // Arrange
            var expected = new List<RankScore>() // Use implicit types as much as possible
            {
                new RankScore() { Rank = 1, Score = 100 },
                new RankScore() { Rank = 1, Score = 100 },
                new RankScore() { Rank = 2, Score = 50 },
                new RankScore() { Rank = 3, Score = 40 },
                new RankScore() { Rank = 3, Score = 40 },
                new RankScore() { Rank = 4, Score = 20 },
                new RankScore() { Rank = 5, Score = 10 }
            };
            var actual = new List<int> { 100, 100, 50, 40, 40, 20, 10 } // Use linq, train yourself
                .Select((x, i) => new RankScore { Rank = i + 1, Score = x })
                .ToList(); // << this is arrangement!

            // Act << Separate sections
            actual = SetGameRanks(actual);

            // Assert << Separate sections
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetRanksInTableTest()
        {
            // Arrange
            var expected = new List<int>() { 6, 4, 2, 1 };

            // Act
            var actual = GetRanksInTable(new List<RankScore>()
            {
                new RankScore() { Rank = 1, Score = 100 },
                new RankScore() { Rank = 1, Score = 100 },
                new RankScore() { Rank = 2, Score = 50 },
                new RankScore() { Rank = 3, Score = 40 },
                new RankScore() { Rank = 3, Score = 40 },
                new RankScore() { Rank = 4, Score = 20 },
                new RankScore() { Rank = 5, Score = 10 }
            }, new int[] { 5, 25, 50, 120 }.ToList());

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}