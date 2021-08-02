using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.programs
{
    /// <summary>
    /// Программа вычисляет самое маленькое количество выложений в проект.
    /// Исходные данные:
    ///     У предпринимателя есть n число проектов, которые он выставил на бирже.
    ///     Каждый из разработчиков выставляет счёт за свои услуги по проекту. 
    ///     Найти минимальную стоимость за выполнение проектов.
    ///     Если проекта нет, то вернуть -1.
    /// Пример:
    ///     Число проектов: 3
    ///     Проекты: [2,1,0,2]
    ///     Ставки разработчиков: [7,8,4,9]
    ///     Вычисления: 7 + 8 + 4 = 19
    ///     Пояснение: За проект №2 ставки 7 и 9. Надо выбрать 7, потому что это дешевле, чем 9.
    /// </summary>
    class FreeLance
    {
        private static long CountMinCost(int numberOfProjects, List<int> projectIds, List<int> bidings)
        {
            ProjectsBids projectsBidings = new ProjectsBids();
            List<ProjectsBids> projectsBidingsList = new List<ProjectsBids>();

            for (int i = 0; i < projectIds.Count; i++)
            {
                if(projectsBidingsList.Count == 0)
                {
                    projectsBidings.ProjectNumber = projectIds[i];
                    projectsBidings.Bid.Add(bidings[i]);
                    projectsBidingsList.Add(projectsBidings);
                }
                else
                {
                    var temp = projectsBidingsList.FirstOrDefault(project => project.ProjectNumber == projectIds[i]);
                    
                    if(temp == null)
                    {
                        projectsBidings = new ProjectsBids();
                        projectsBidings.ProjectNumber = projectIds[i];
                        projectsBidings.Bid.Add(bidings[i]);
                        projectsBidingsList.Add(projectsBidings);
                    }
                    else
                    {
                        int tempIndex = projectsBidingsList.IndexOf(temp);
                        temp.Bid.Add(bidings[i]);
                        projectsBidingsList[tempIndex] = temp;
                    }
                }
            }

            int maxProject = projectsBidingsList.Count;
            if(maxProject == numberOfProjects) { }

            int sum = 0;
            foreach(var item in projectsBidingsList)
            {
                sum += item.Bid.Min();
            }


            return sum;
        }
        public static void RunProgram()
        {
            Console.WriteLine(CountMinCost(3, new List<int> { 2, 1, 1, 2 }, new List<int> { 7, 8, 4, 9 }).ToString());
        }

        class ProjectsBids
        {
            public int ProjectNumber { get; set; }
            public List<int> Bid { get; set; } = new List<int>();
        }
    }
}
