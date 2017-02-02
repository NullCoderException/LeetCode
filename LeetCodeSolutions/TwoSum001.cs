using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    /// <summary>
    /// Solutions for https://leetcode.com/problems/two-sum/
    /// </summary>
    public class TwoSum001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //return TwoSumBruteForce(nums, target);
            return TwoSumImproved(nums, target);

        }

        /// <summary>
        /// Slow Brute Force solution using array [ACCEPTED]
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSumBruteForce(int[] nums, int target)
        {
            if (nums == null) throw new ArgumentNullException();
            int count = nums.Count();
            for (int i = 0; i <= count - 1; i++)
            {
                for (int j = i + 1; j <= count - 1; j++)
                {
                    if (nums[i] + nums[j] == target) return new int[] { i, j };
                }
            }
            return null;
        }

        /// <summary>
        /// Improved implementation using Hash Map (Dictionary) [ACCEPTED]
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSumImproved(int[] nums, int target)
        {
            if (nums == null) throw new ArgumentNullException();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dictionary[nums[i]] = i;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int compliment = target - nums[i];
                if (dictionary.ContainsKey(compliment) && dictionary[compliment] != i)
                {
                    return new int[] { i, dictionary[compliment] };
                }
            }
            return null;
        }
    }
}
