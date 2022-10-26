using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string CountOff(int number)
        {
            string numtostring = number.ToString();
            if (numtostring.Contains("3") || number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 3 == 0 && number % 5 == 0 && number % 7 == 0)
            {
                return "FizzBuzzWhizz";
            }
            else if ((number % 3 == 0 && number % 5 == 0) || (number % 5 == 0 && number % 7 == 0) || (number % 3 == 0 && number % 7 == 0))
            {
                return "FizzBuzz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else if (number % 7 == 0)
            {
                return "Whizz";
            }
            else
            {
                return numtostring;
            }
        }
    }
}
