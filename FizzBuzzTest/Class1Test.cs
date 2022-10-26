using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class Class1Test
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
    }
}