using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.programs
{
    public static class Stairs
    {
        public static string CreateHashesString(int hashesQuantity, int maxCharsInString)
        {
            char[] data = new char[maxCharsInString];
            int stopDrowingSpaces = data.Length - hashesQuantity;

            for (int i = 0; i < data.Length; i++)
            {
                if (i >= stopDrowingSpaces)
                {
                    data[i] = '#';
                }
                else
                {
                    data[i] = ' ';
                }
            }

            return new string(data);
        }

        public static void StairsHashes(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(CreateHashesString(i, n));
            }
        }
    }
}
