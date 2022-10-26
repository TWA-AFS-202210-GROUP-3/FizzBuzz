using System;

namespace FizzBuzz
{
    public class GameFizzBuzz
    {
        public string Countoff(int number)
        {
            var result = string.Empty;
            var numberAsString = number.ToString();

            if (numberAsString.Contains('3'))
            {
                result = "Fizz";
            }
            else
            {
                result += number % 3 == 0 ? "Fizz" : string.Empty;
                result += number % 5 == 0 ? "Buzz" : string.Empty;
                result += number % 7 == 0 ? "Whizz" : string.Empty;
            }

            return result.Length == 0 ? numberAsString : result;
        }
    }
}
