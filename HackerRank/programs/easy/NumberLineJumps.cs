namespace HackerRank.programs.easy;

public static class NumberLineJumps
{
    public static string Kangaroo(int x1, int v1, int x2, int v2)
    {
        if (v2 >= v1) return "NO";
        if ((x2 - x1) % (v1 - v2) == 0) return "YES";
        return "NO";
    }
}