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
            Class1 class1 = new Class1();
            int number = 1;
            //when
            var result = class1.Countoff(number);
            //then
            Assert.Equal("1", result);
        }

        [Fact]
        public void Should_return_Fizz_when_countoff_given_number_of_multiple_of_3()
        {
            Class1 class1 = new Class1();
            int number = 9;
            //when
            var result = class1.Countoff(number);
            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_countoff_given_number_of_multiple_of_5()
        {
            Class1 class1 = new Class1();
            int number = 5;
            //when
            var result = class1.Countoff(number);
            //then
            Assert.Equal("Buzz", result);
        }
    }
}