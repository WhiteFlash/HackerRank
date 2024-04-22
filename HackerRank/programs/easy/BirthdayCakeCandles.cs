using System.Collections.Generic;
using System.Linq;

namespace HackerRank.programs.easy;
public static class BirthdayCakeCandles
{
    public static int RunProgram(List<int> candles)
    {
        return candles.Where(x => x == candles.Max()).Count();            
    }
}
