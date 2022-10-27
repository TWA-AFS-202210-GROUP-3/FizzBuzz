using System;

namespace FizzBuzz
{
    public class FizzBuzzWhizz
    {
        private readonly int three = 3;
        private readonly int five = 5;
        private readonly int seven = 7;
        public string FizzBuzzGame(int num)
        {
            string numStr = num.ToString();
            if (numStr.Contains("3"))
            {
                return "Fizz";
            }
            else
            {
                if (num % three == 0 && num % five == 0 && num % seven == 0)
                {
                    return "FizzBuzzWhizz";
                }

                if (num % three == 0 && num % five == 0)
                {
                    return "FizzBuzz";
                }

                if (num % three == 0 && num % seven == 0)
                {
                    return "FizzWhizz";
                }

                if (num % five == 0 && num % seven == 0)
                {
                    return "BuzzWhizz";
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
            }

            return num.ToString();
        }
    }
}
