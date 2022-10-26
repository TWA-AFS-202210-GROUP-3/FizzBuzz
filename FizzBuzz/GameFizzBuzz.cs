using System;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private int Three = 3;
        private int Five = 5;
        private int Seven = 7;

        public string CountOff(int number)
        {
            if (number.ToString().Contains("3"))
            {
                return "Fizz";
            }
            else if (number % (Three * Five * Seven) == 0)
            {
                return "FizzBuzzWhizz";
            }
            else if (number % (Five * Seven) == 0)
            {
                return "BuzzWhizz";
            }
            else if (number % (Three * Seven) == 0)
            {
                return "FizzWhizz";
            }
            else if (number % (Three * Five) == 0)
            {
                return "FizzBuzz";
            }
            else if (number % Seven == 0)
            {
                return "Whizz";
            }
            else if (number % Five == 0)
            {
                return "Buzz";
            }
            else if (number % Three == 0)
            {
                return "Fizz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
