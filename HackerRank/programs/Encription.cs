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
                char[,] arrayOfStrok = new char[(int)span[0], (int)span[1]];

                Console.WriteLine("{0}, {1}", squareRoot, stroka);

                //arrayOfStrok[0,0] = new char[] { { stroka.Substring(0, (int)span[1]).ToCharArray() } };

                foreach (var x in arrayOfStrok)  
                {  
                    Console.WriteLine(x.ToString());
                } 

                stroka = stroka.Remove(0, (int)span[1]);
                Console.WriteLine("{0}, {1}", squareRoot, stroka);
                

            }
           

        }
    }
}
