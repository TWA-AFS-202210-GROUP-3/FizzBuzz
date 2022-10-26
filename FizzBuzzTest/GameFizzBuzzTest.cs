using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class GameFizzBuzzTest
    {
        [Fact]
        public void Should_return_normal_number_when_count_off_given_normal_number()
        {
            //given
            int number = 1;

            //when
            var result = new FizzBuzz.FizzBuzz().CountOff(number);

            //then
            Assert.Equal(number.ToString(), result);
        }

        [Fact]
        public void Should_return_Fizz_when_count_off_given_only_multiple_of_3()
        {
            //given
            int number = 3;

            //when
            var result = new FizzBuzz.FizzBuzz().CountOff(number);

            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Buzz_when_count_off_given_only_multiple_of_5()
        {
            //given
            int number = 5;

            //when
            var result = new FizzBuzz.FizzBuzz().CountOff(number);

            //then
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_return_Whizz_when_count_off_given_multiple_of_7()
        {
            //given
            int number = 7;

            //when
            var result = new FizzBuzz.FizzBuzz().CountOff(number);

            //then
            Assert.Equal("Whizz", result);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_count_off_given_multiple_of_3_and_5()
        {
            //given
            int number = 15;

            //when
            var result = new FizzBuzz.FizzBuzz().CountOff(number);

            //then
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Should_return_FizzWhizz_when_count_off_given_multiple_of_3_and_7()
        {
            //given
            int number = 21;

            //when
            var result = new FizzBuzz.FizzBuzz().CountOff(number);

            //then
            Assert.Equal("FizzWhizz", result);
        }

        [Fact]
        public void Should_return_BuzzWhizz_when_count_off_given_multiple_of_5_and_7()
        {
            //given
            int number = 70;

            //when
            var result = new FizzBuzz.FizzBuzz().CountOff(number);

            //then
            Assert.Equal("BuzzWhizz", result);
        }

        [Fact]
        public void Should_return_FizzBuzzWhizz_when_count_off_given_multiple_of_3_and_5_and_7()
        {
            //given
            int number = 105;

            //when
            var result = new FizzBuzz.FizzBuzz().CountOff(number);

            //then
            Assert.Equal("FizzBuzzWhizz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_count_off_given_a_number_contains_3()
        {
            //given
            int number = 130;

            //when
            var result = new FizzBuzz.FizzBuzz().CountOff(number);

            //then
            Assert.Equal("Fizz", result);
        }
    }
}