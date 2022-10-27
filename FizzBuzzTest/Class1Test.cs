using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class Class1Test
    {
        [Fact]
        public void Should_return_normal_string_when_countoff_given_normal_number()
        {
            //given
            FizzBuzzWhizz class1 = new FizzBuzzWhizz();
            int number = 1;
            //when
            var result = class1.Countoff(number);
            //then
            Assert.Equal("1", result);
        }

        [Fact]
        public void Should_return_Fizz_when_countoff_given_number_of_multiple_of_3()
        {
            FizzBuzzWhizz class1 = new FizzBuzzWhizz();
            int number = 9;
            //when
            var result = class1.Countoff(number);
            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Buzz_when_countoff_given_number_of_multiple_of_5()
        {
            FizzBuzzWhizz class1 = new FizzBuzzWhizz();
            int number = 5;
            //when
            var result = class1.Countoff(number);
            //then
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_return_Whizz_when_countoff_given_number_of_multiple_of_7()
        {
            FizzBuzzWhizz class1 = new FizzBuzzWhizz();
            int number = 7;
            //when
            var result = class1.Countoff(number);
            //then
            Assert.Equal("Whizz", result);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_countoff_given_number_of_multiple_of_3_and_5()
        {
            FizzBuzzWhizz class1 = new FizzBuzzWhizz();
            int number = 15;
            //when
            var result = class1.Countoff(number);
            //then
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Should_return_FizzWhizz_when_countoff_given_number_of_multiple_of_3_and_7()
        {
            FizzBuzzWhizz class1 = new FizzBuzzWhizz();
            int number = 21;
            //when
            var result = class1.Countoff(number);
            //then
            Assert.Equal("FizzWhizz", result);
        }

        [Fact]
        public void Should_return_BuzzWhizz_when_countoff_given_number_of_multiple_of_5_and_7()
        {
            FizzBuzzWhizz class1 = new FizzBuzzWhizz();
            int number = 245;
            //when
            var result = class1.Countoff(number);
            //then
            Assert.Equal("BuzzWhizz", result);
        }

        [Fact]
        public void Should_return_FizzBuzzWhizz_when_countoff_given_number_of_multiple_of_3_and_5_and_7()
        {
            FizzBuzzWhizz class1 = new FizzBuzzWhizz();
            int number = 105;
            //when
            var result = class1.Countoff(number);
            //then
            Assert.Equal("FizzBuzzWhizz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_countoff_given_number_contains_3()
        {
            FizzBuzzWhizz class1 = new FizzBuzzWhizz();
            int number = 30;
            //when
            var result = class1.Countoff(number);
            //then
            Assert.Equal("Fizz", result);
        }
    }
}