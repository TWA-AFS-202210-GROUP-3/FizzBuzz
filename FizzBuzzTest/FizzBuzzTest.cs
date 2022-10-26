using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class GameFizzBuzzTest
    {
        [Fact]
        public void Should_return_normal_number_given_normal_number()
        {
            //given
            GameFizzBuzz game = new GameFizzBuzz();
            int number = 1;

            //when
            var result = game.Countoff(number);

            //then
            Assert.Equal("1", result);
        }
    }
}