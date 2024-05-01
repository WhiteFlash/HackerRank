namespace HackerRank.programs.easy;

public static class CountValleys
{
    public static int CountingValleys(int steps, string path)
    {
        var (prev, current) = (0, 0);
        var valleyCount = 0;

        foreach (var step in path)
        {
            switch (step)
            {
                case 'U':
                    prev = current;
                    current++;
                     if (current == -1 & prev == 0)
                        valleyCount++;
                    break;
                case 'D':
                    prev = current;
                    current--;
                    if (current == -1 & prev == 0)
                        valleyCount++;
                    break;
            }
        }

        return valleyCount;
    }
}