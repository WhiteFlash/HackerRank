using System.Linq;

namespace HackerRank.programs.easy;

public static class ElectronicsShop
{
    public static int GetMoneySpent(int[] keyboards, int[] drives, int b)
    {
        var keyboardsUpdated = keyboards.Where(x => x < b).ToArray();
        var driversUpdated = drives.Where(x => x < b).ToArray();
        var highestValue = 0;
        var value = 0;

        for (var i = 0; i <= keyboardsUpdated.Length - 1; i++)
        {
            for (var j = 0; j <= driversUpdated.Length - 1; j++)
            {
                value = keyboardsUpdated[i] + driversUpdated[j];
                if (highestValue < value & value <= b)
                    highestValue = value;
            }
        }

        return highestValue == 0 ? -1 : highestValue;
    }
}