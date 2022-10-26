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
    }
}