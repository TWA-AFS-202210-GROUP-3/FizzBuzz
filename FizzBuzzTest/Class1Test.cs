using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class Class1Test
    {
        [Fact]
        public void Should_return_normal_num_when_input_normal_num()
        {
            // given
            Class1 class1 = new Class1();
            int num = 1;
            // when
            string res = class1.FizzBuzzGame(num);

            // then
            Assert.Equal("1", res);
        }

        [Fact]
        public void Should_return_Fizz_when_input_num_multiple_of_three()
        {
            // given
            Class1 class1 = new Class1();
            int num = 3;
            // when
            string res = class1.FizzBuzzGame(num);

            // then
            Assert.Equal("Fizz", res);
        }

        [Fact]
        public void Should_return_Buzz_when_input_num_multiple_of_five()
        {
            // given
            Class1 class1 = new Class1();
            int num = 5;
            // when
            string res = class1.FizzBuzzGame(num);

            // then
            Assert.Equal("Buzz", res);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_input_num_multiple_of_three_and_five()
        {
            // given
            Class1 class1 = new Class1();
            int num = 15;
            // when
            string res = class1.FizzBuzzGame(num);

            // then
            Assert.Equal("FizzBuzz", res);
        }
    }
}