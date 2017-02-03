using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutions.Tests
{
    public class FindAllNumbersDisappearedinanArray448Tests
    {
        private readonly FindAllNumbersDisappearedinanArray448 _disappeared;
        public FindAllNumbersDisappearedinanArray448Tests()
        {
            _disappeared = new FindAllNumbersDisappearedinanArray448();   
        }

        [Theory]
        [InlineData(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new int[] { 5, 6 })]
        public void FindDisappearedNumbers_SmallArray_CorrectResult(int[] nums, int[] expected)
        {
            var result = _disappeared.FindDisappearedNumbers(nums);
            Assert.Equal(result, expected.ToList());
        }
    }
}
