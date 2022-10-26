using System;

namespace FizzBuzz
{
    public class GameFizzBuzz
    {
        public string Countoff(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            if (number % 7 == 0)
            {
                return "Whizz";
            }

            return number.ToString();
        }
    }
}
