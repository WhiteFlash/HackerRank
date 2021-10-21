using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using HackerRank.programs;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Stairs.StairsHashes(6);
            //FreeLance.RunProgram();
            //MinSteps.RunProgram();
            //SherlockAndValidString.RunProgram();


            Console.WriteLine(new programs.easy.DiagonalDifference().CountDiagonalDifference(new System.Collections.Generic.List<System.Collections.Generic.List<int>>()));
            
            //experimental shit




            Console.ReadKey();
        }
    }
}
