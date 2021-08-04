using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.programs
{
    /// <summary>
    /// Программа может увеличивать число на 1 или умножать на 2.
    /// Необходимо найти минимальное количество шагов от 0 до указанного пользователем числа.
    /// Пример: 
    ///     Дано: 5. 
    ///     Вычисления: 0+1 -> 1+1 -> 2*2 -> 4+1 
    ///     Ответ: 4
    /// </summary>
    class MinSteps
    {
        ///Решение
        ///Делить число на 2 без остатка до тех пор, пока
        ///1. не получим простое число
        ///2. не получим 1
        ///в случаях выше шаг должен быть минус 1. 
        ///Делим на два если число даёт 0 в остатке. Т.е. if(numb % 2 == 0) { }
        ///

        static List<int> FindMinSteps(int number)
        {
            List<int> steps = new List<int>();

            while( number > 0 )
            {
                if((number % 2 ) == 0)
                {
                    number /= 2;
                }
                else
                {
                    number--;
                }
                steps.Add(number);
            }

            return steps;
        }

        public static void RunProgram()
        {
            Console.WriteLine($"Кол-во шагов. \t Шаги");
            List<int> steps = FindMinSteps(9);

            Console.WriteLine($" Количество шагов { steps.Count }");
            Console.Write(9);
            for(int i = 0; i < steps.Count; i++)
            {
                Console.Write($" -> {steps[i]} ");
            }

        }
    }
}
