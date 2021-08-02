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
            CountFrequency("aaaabbcc");
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

        public static List<Frequency> Sorting(List<Frequency> frequencies)
        {
            for(int i = 0; i < frequencies.Count; i++)
            {
                var temp = frequencies.IndexOf(frequencies[i]);

                
            }
            
            return frequencies;
        }

        public static bool CompareFrequency(List<Frequency> frequencies)
        {
            ushort maxFrequency = frequencies.Max(charecter => charecter.quantity);
            ushort minFrequency = frequencies.Max(charecter => charecter.quantity);

            IEnumerable<ushort> iListOfFrequencies = frequencies.Where(charakter => charakter.quantity == maxFrequency)
                                                                  .Select(charackter => charackter.quantity);
            
            IEnumerable<ushort> iListOfMaxFrequencies = frequencies.Where(charakter => charakter.quantity == maxFrequency)
                                                                  .Select(charackter => charackter.quantity);

            IEnumerable<ushort> iListOfMinFrequencies = frequencies.Where(charakter => charakter.quantity == minFrequency)
                                                                  .Select(charackter => charackter.quantity);

            List<ushort> listOfFrequencies = iListOfFrequencies.ToList();       
            List<ushort> listOfMaxFrequencies = iListOfMaxFrequencies.ToList();       
            List<ushort> listOfMinFrequencies = iListOfMinFrequencies.ToList();


            //Если все частоты равны
            //Если все равны, а одна буква встречается 1 раз
            //Если все равны, но одна буква на 1 больше, чем другие частоты.

            var x = frequencies.ToArray();
            Frequency temp = new Frequency();

            for(int i = 0; i < x.Length; i++)
            {
                if(x[i].quantity == x[i + 1].quantity)
                {
                    continue;
                }
                else
                {
                    temp = x[i + 1];
                    break;
                }
            }

            if(x.First() == x.Last()) { }

            for(int k = 0; k < frequencies.Count; k++)
            {
                bool isEqual = frequencies[k].quantity == frequencies[k + 1].quantity; 
            }



            foreach(Frequency frequency in frequencies)
            {
                int frequencyIndex = frequencies.IndexOf(frequency);
                

                int modFrequency = maxFrequency - frequency.quantity;



                if (modFrequency >= 2)
                {
                    return false;
                }
                else
                {
                    if(listOfMaxFrequencies.Count >= 2)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

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
