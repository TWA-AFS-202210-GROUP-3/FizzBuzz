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
    }
}