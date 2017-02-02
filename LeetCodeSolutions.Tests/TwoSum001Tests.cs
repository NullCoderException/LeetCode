using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace LeetCodeSolutions.Tests
{
    public class TwoSum001Tests
    {
        private readonly TwoSum001 _twosum;
        public TwoSum001Tests()
        {
            _twosum = new TwoSum001();
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        public void TwoSum_TwoOrMoreElementsWithSolution_ReturnsCorrect(int[] nums, int target, int[] expected)
        {
            int[] result = _twosum.TwoSum(nums, target);
            Assert.Equal(expected, result);
        }
    }
}
