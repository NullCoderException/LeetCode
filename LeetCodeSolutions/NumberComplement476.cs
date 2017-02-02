using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    /// <summary>
    /// Solutions for https://leetcode.com/problems/number-complement/
    /// </summary>
    public class NumberComplement476
    {
        /// <summary>
        /// Basic implementation using string manipulation [ACCEPTED]
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int FindComplement(int num)
        {
            var binaryStr = Convert.ToString(num, 2);
            var arr = binaryStr.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '0')
                    arr[i] = '1';
                else if (arr[i] == '1')
                    arr[i] = '0';
            }
            binaryStr = new string(arr);
            return Convert.ToInt32(new string(arr), 2);
        }
    }
}
