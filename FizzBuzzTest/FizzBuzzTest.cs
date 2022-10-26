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

        [Fact]
        public void Should_return_Fizz_given_multiple_of_3()
        {
            //given
            GameFizzBuzz game = new GameFizzBuzz();
            int number = 3;

            //when
            var result = game.Countoff(number);

            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Buzz_given_multiple_of_5()
        {
            //given
            GameFizzBuzz game = new GameFizzBuzz();
            int number = 5;

            //when
            var result = game.Countoff(number);

            //then
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_return_Buzz_given_multiple_of_7()
        {
            //given
            GameFizzBuzz game = new GameFizzBuzz();
            int number = 7;

            //when
            var result = game.Countoff(number);

            //then
            Assert.Equal("Whizz", result);
        }

        [Fact]
        public void Should_return_Buzz_given_multiple_of_3_and_5()
        {
            //given
            GameFizzBuzz game = new GameFizzBuzz();
            int number = 15;

            //when
            var result = game.Countoff(number);

            //then
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Should_return_Buzz_given_multiple_of_3_and_7()
        {
            //given
            GameFizzBuzz game = new GameFizzBuzz();
            int number = 21;

            //when
            var result = game.Countoff(number);

            //then
            Assert.Equal("FizzWhizz", result);
        }
    }
}