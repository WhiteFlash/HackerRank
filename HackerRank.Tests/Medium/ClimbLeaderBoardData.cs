using System.Collections;
using System.Collections.Generic;

namespace HackerRank.Tests.Medium;

public class ClimbLeaderBoardData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        var data = new List<int> { 100, 100, 50, 40, 40, 20, 10 };
        var gameScores = new List<int> { 5, 25, 50, 120 };
        var expectedResults = new List<int> { 6, 4, 2, 1 };

        var data1 = new List<int> { 100, 90, 90, 80, 75, 60 };
        var gameScores1 = new List<int> { 50, 65, 77, 90, 102 };
        var expectedResults1 = new List<int> { 6, 5, 4, 2, 1 };

        var data2 = new List<int> { 100, 90, 90, 80, 75, 60, 50, 40 };
        var gameScores2 = new List<int> { 50, 65, 77, 90, 102 };
        var expectedResults2 = new List<int> { 6, 5, 4, 2, 1 };

        yield return new object[]
        {
            data2,
            gameScores2,
            expectedResults2
        };
        yield return new object[]
        {
            data,
            gameScores,
            expectedResults
        };
        yield return new object[]
        {
            data1,
            gameScores1,
            expectedResults1
        };

    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
