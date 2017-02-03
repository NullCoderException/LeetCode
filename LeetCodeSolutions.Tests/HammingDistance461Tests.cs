using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutions.Tests
{
    public class HammingDistance461Tests
    {
        private readonly HammingDistance461 _hammingdistance;
        public HammingDistance461Tests()
        {
            _hammingdistance = new HammingDistance461();
        }

        [Theory]
        [InlineData(1, 4, 2)]
        [InlineData(3, 1, 1)]
        public void HammingDistance_SmallNumbers_ReturnsCorrect(int x, int y, int expected)
        {
            int result = _hammingdistance.HammingDistance(x, y);
            Assert.Equal(expected, result);
        }
    }
}
