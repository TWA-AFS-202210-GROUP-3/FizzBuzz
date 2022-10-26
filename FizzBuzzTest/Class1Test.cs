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
    }
}