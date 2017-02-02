using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutions.Tests
{
    public class NumberComplement476Tests
    {
        private readonly NumberComplement476 _numbercomplement;

        public NumberComplement476Tests()
        {
            _numbercomplement = new NumberComplement476();
        }

        [Theory]
        [InlineData(5, 2)]
        [InlineData(1, 0)]
        public void TwoSum_TwoOrMoreElementsWithSolution_ReturnsCorrect(int num, int expected)
        {
            int result = _numbercomplement.FindComplement(num);
            Assert.Equal(expected, result);
        }
    }
}
