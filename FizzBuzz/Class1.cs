using System;

namespace FizzBuzz
{
    public class Class1
    {
        private readonly int three = 3;
        private readonly int five = 5;
        private readonly int seven = 7;
        public string FizzBuzzGame(int num)
        {
            if (
                (num % three == 0 && num % five == 0) ||
                (num % three == 0 && num % seven == 0) ||
                (num % seven == 0 && num % five == 0))
            {
                return "FizzBuzz";
            }

            if (num % seven == 0)
            {
                return "Whizz";
            }

            if (num % five == 0)
            {
                return "Buzz";
            }

            if (num % three == 0)
            {
                return "Fizz";
            }

            return num.ToString();
        }
    }
}
