using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.programs
{
    public class SherlockAndValidString
    {
        
        public static void RunProgram()
        {
            CountFrequency("zaabbcc");
            CountFrequency("zzzaabbcc");
            CountFrequency("zzzaazzbbcc");
            CountFrequency("zzzyyyaabbcc");
            CountFrequency("zzzyyyabcc");
        }

        public static void CountFrequency(string x)
        {
            var sherlockCharArray = x.ToCharArray();
            Frequency frequency = new Frequency();
            List<Frequency> frequencies = new List<Frequency>();

            for(int i = 0; i < sherlockCharArray.Length; i++)
            {
                if(frequencies.Count == 0)
                {
                    frequency.letter = sherlockCharArray[i];
                    frequency.quantity++;
                    frequencies.Add(frequency);
                }
                else 
                {
                    frequency = frequencies.FirstOrDefault(character => character.letter == sherlockCharArray[i]);
                    
                    if (frequency == null)
                    {
                        frequency = new Frequency
                        {
                            letter = sherlockCharArray[i]
                        };
                        frequency.quantity++;
                        frequencies.Add(frequency);
                    }
                    else
                    {
                        int index = frequencies.IndexOf(frequency);
                        frequency.quantity++;
                        frequencies[index] = frequency;                        
                    }
                }
            }

            //Console.WriteLine($"Буква \t Встречается");
            //foreach (var x in frequencies)
            //    Console.WriteLine($"  {x.letter} \t {x.quantity}");

            if (CompareFrequency(frequencies))
            {
                Console.WriteLine($"Строка валидная");
            }
            else
            {
                Console.WriteLine($"Строка не валидная");
            }
        }

        public static bool CompareFrequency(List<Frequency> frequencies)
        {
            Frequency[] frequenciesArray = frequencies.ToArray();
        
            IOrderedEnumerable<Frequency> frequenciesArraySorted = from temp in frequenciesArray
                                                                        orderby temp.quantity
                                                                        select temp;
            frequenciesArray = frequenciesArraySorted.ToArray();

            //All frequencies are equal
            if(frequenciesArray[0].quantity == frequenciesArray[frequenciesArray.Length - 1].quantity)
                return true;

            //All frequencies are equal, and one letter meet's once 
            if (frequenciesArray[1].quantity == frequenciesArray[frequenciesArray.Length - 1].quantity)
                if(frequenciesArray[0].quantity == 1)                
                    return true;

            //All frequencies are equal, and one letter greater once then others
            if (frequenciesArray[0].quantity == frequenciesArray[frequenciesArray.Length - 2].quantity) 
               if((frequenciesArray[frequenciesArray.Length - 1].quantity - frequenciesArray[frequenciesArray.Length - 2].quantity) == 1 )
                    return true;

            return false;
        }

    }

    /// <summary>
    /// Вспомогательный класс для определения
    /// как часто одна и та же буква встречается в строке.
    /// </summary>
    public class Frequency
    {
        public char letter;
        public ushort quantity = 0;
    }
}
