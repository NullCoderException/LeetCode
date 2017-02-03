using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class FindAllNumbersDisappearedinanArray448
    {
        /// <summary>
        /// Solution using Linq
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            return Enumerable.Range(1, nums.Length).Except(nums).ToList();
        }
    }
}
