using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRank.programs
{
    public static class Encription
    {
        public static void MainEncription()
        {
            string stroka = "  have a nice day     ";
            
            stroka = stroka.Replace(" ", string.Empty);
            var squareRoot = Math.Sqrt(stroka.Length);
            var span = new double[] { Math.Round(squareRoot), Math.Round(squareRoot) + 1 }; 

            if(span[0] * span[1] >= stroka.Length)
            {
                Console.WriteLine("{0}, {1}", squareRoot, stroka);

                

            }
           

        }
    }
}
