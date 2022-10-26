using System;

namespace FizzBuzz
{
    public class Class1
    {
        public string FizzBuzzGame(int num)
        {
            if (num % 3 == 0)
            {
                return "Fizz";
            }

            return num.ToString();
        }
    }
}
