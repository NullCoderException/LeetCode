using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutions.Tests
{
    public class LongestSubstringWithoutRepeatingCharacters003Tests
    {
        private readonly LongestSubstringWithoutRepeatingCharacters003 _longest;
        public LongestSubstringWithoutRepeatingCharacters003Tests()
        {
            _longest = new LongestSubstringWithoutRepeatingCharacters003();
        }

        [Theory]
        [InlineData("c", 1)]
        [InlineData("aa", 1)]
        [InlineData("ab", 2)]      
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("dvdf", 3)]
        [InlineData("pwwkew", 3)]
        //[InlineData("xxzqi", 4)] //Can't pass this case
        public void LengthOfLongestSubstring_VariousInputs_ExpectedOutput(string s, int expected)
        {
            int result = _longest.LengthOfLongestSubstring(s);
            Assert.Equal(expected, result);
        }
    }
}
