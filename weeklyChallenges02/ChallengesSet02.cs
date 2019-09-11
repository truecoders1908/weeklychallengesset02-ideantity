using System;
using System.Collections.Generic;
using System.Linq;

namespace weeklyChallenges02
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c) => Char.IsLetter(c);

        public bool CountOfElementsIsEven(string[] vals) => vals.Length % 2 == 0;

        public bool IsNumberEven(int number) => number % 2 == 0;


        public bool IsNumberOdd(int num) => num % 2 != 0;

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else if (numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                return numbers.Max() + numbers.Min();
            }
        }
        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length <= str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                return numbers.Sum();
            }
        }
        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                return numbers.Where(i => i % 2 == 0).Sum();
            }
        }
        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                long num = number / 2;
                return num;
            }
        }
    }
}
