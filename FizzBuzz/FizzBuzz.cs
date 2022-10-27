using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string GetString(int number)
        {
            string result = string.Empty;

            if (number.ToString().Contains('3'))
            {
                return "Fizz";
            }
            else
            {
                if (number % 3 == 0)
                {
                    result += "Fizz";
                }

                if (number % 5 == 0)
                {
                    result += "Buzz";
                }

                if (number % 7 == 0)
                {
                    result += "Whizz";
                }
            }

            if (result.Length == 0)
            {
                result = number.ToString();
            }

            return result;
        }
    }
}
