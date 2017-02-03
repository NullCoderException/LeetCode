using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutions.Tests
{
    public class FizzBuzz412Tests
    {
        private readonly FizzBuzz412 _fizzbuzz;
        public FizzBuzz412Tests()
        {
            _fizzbuzz = new FizzBuzz412();
        }

        [Theory]
        [InlineData(1, new string[] { "1" })]
        [InlineData(3, new string[] { "1", "2", "Fizz" })]
        [InlineData(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
        [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
        public void FizzBuzz_SmallInteger_ExpectedOutput(int num, string[] expected)
        {
            string[] result = _fizzbuzz.FizzBuzz(num).ToArray();
            Assert.Equal(expected, result);
        }
    }
}
