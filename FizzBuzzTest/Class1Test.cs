using FizzBuzz;
using Moq;
using System;
using Xunit;

namespace FizzBuzzTest
{
    public class Class1Test
    {
        [Fact]
        public void Should_return_Fizz_When_CountOff_Given_Multiple_of_Three()
        {
            // given
            FizzBuzz.FizzBuzz result = new FizzBuzz.FizzBuzz();
            // when
            var number = result.CountOff(18);
            // then
            Assert.Equal("Fizz", number);
        }

        [Fact]
        public void Should_return_Fizz_When_CountOff_Given_Multiple_of_Five()
        {
            // given
            FizzBuzz.FizzBuzz result = new FizzBuzz.FizzBuzz();
            // when
            var number = result.CountOff(5);
            // then
            Assert.Equal("Buzz", number);
        }

        [Fact]
        public void Should_return_Fizz_When_CountOff_Given_Multiple_of_Seven()
        {
            // given
            FizzBuzz.FizzBuzz result = new FizzBuzz.FizzBuzz();
            // when
            var number = result.CountOff(7);
            // then
            Assert.Equal("Whizz", number);
        }

        [Fact]
        public void Should_return_Fizz_When_CountOff_Given_Multiple_of_Three_and_Five()
        {
            // given
            FizzBuzz.FizzBuzz result = new FizzBuzz.FizzBuzz();
            // when
            var number = result.CountOff(15);
            // then
            Assert.Equal("FizzBuzz", number);
        }

        [Fact]
        public void Should_return_Fizz_When_CountOff_Given_Multiple_of_Three_and_Seven()
        {
            // given
            FizzBuzz.FizzBuzz result = new FizzBuzz.FizzBuzz();
            // when
            var number = result.CountOff(21);
            // then
            Assert.Equal("FizzBuzz", number);
        }

        [Fact]
        public void Should_return_Fizz_When_CountOff_Given_Multiple_of_Five_and_Seven()
        {
            // given
            FizzBuzz.FizzBuzz result = new FizzBuzz.FizzBuzz();
            // when
            var number = result.CountOff(70);
            // then
            Assert.Equal("FizzBuzz", number);
        }

        [Fact]
        public void Should_return_Fizz_When_CountOff_Given_Multiple_of_Five_and_Seven_and_Three()
        {
            // given
            FizzBuzz.FizzBuzz result = new FizzBuzz.FizzBuzz();
            // when
            var number = result.CountOff(105);
            // then
            Assert.Equal("FizzBuzzWhizz", number);
        }

        [Fact]
        public void Should_return_Fizz_When_CountOff_Given_contain_Three()
        {
            // given
            FizzBuzz.FizzBuzz result = new FizzBuzz.FizzBuzz();
            // when
            var number = result.CountOff(3);
            // then
            Assert.Equal("Fizz", number);
        }

        [Fact]
        public void Should_return_Fizz_When_CountOff_Given_Multiple_of_Noneof_Five_and_Seven_and_Three()
        {
            // given
            FizzBuzz.FizzBuzz result = new FizzBuzz.FizzBuzz();
            // when
            var number = result.CountOff(1);
            // then
            Assert.Equal("1", number);
        }

        [Fact]
        public void Should_return_result_When_CountOff_Given_number_list()
        {
            // given
            FizzBuzz.FizzBuzz result = new FizzBuzz.FizzBuzz();

            int studentnum = 10;
            string list = string.Empty;
            for (int i = 1; i < studentnum; i++)
            {
                list += i;
            }

            // when
            var outputresult = result.Result(list);
            // then
            Assert.Equal("1\n2\nFizz\n4\nBuzz\nFizz\nWhizz\n8\nFizz\nBuzz\n", outputresult);
        }

    }
}