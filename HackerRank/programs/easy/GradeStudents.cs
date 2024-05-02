using System.Collections.Generic;

namespace HackerRank.programs.easy;

public static class GradeStudents
{
    public static List<int> GradingStudents(List<int> grades)
    {
        var gradesArray = grades.ToArray();

        for (var i = 0; i <= gradesArray.Length - 1; i++)
        {
            if (gradesArray[i] < 37)
                continue;
            else
            {
                var value = gradesArray[i] % 10;
                if (value != 5 | value < 3)
                    grades[i] = RoundGrade(grades[i]);
            }
        }

        return grades;
    }

    private static int RoundGrade(int grade)
    {
        var value = grade % 10;
        switch (value)
        {
            case 3:
                grade += 2;
                break;
            case 4:
                grade += 1;
                break;
            case 8:
                grade += 2;
                break;
            case 9:
                grade += 1;
                break;
        }

        return grade;
    }
}