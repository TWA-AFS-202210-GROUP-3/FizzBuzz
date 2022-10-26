using System;

namespace FizzBuzz
{
    public class GameFizzBuzz
    {
        public string Countoff(int number)
        {
            var result = string.Empty;

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

            return result.Length == 0 ? number.ToString() : result;
        }
    }
}
