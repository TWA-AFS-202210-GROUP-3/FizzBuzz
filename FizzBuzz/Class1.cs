using System;

namespace FizzBuzz
{
    public class Class1
    {
        public string Countoff(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }

            return number.ToString();
        }
    }
}
