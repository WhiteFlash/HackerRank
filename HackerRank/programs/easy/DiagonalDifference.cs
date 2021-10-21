using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.programs.easy
{
    public class DiagonalDifference
    {
        public int CountDiagonalDifference(List<List<int>> arr)
        {
            int total = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int k = 0; k < arr.Count; k++)
                {
                    total = arr[i][k];

                }
            }

            return total;
        }
    }
}
