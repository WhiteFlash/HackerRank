using Xunit;
using HackerRank.programs.easy;

namespace HackerRank.Tests.easy;

public class GradeStudentsTest
{
    [Fact]
    public void GradingStudentsTest()
    {
        var expected = new int[] { 75, 67, 40, 33 };
        var actual = GradeStudents.GradingStudents([73, 67, 38, 33]);

        Assert.Equal(expected, actual);
    }
}