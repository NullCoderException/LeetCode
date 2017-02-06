using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class LongestSubstringWithoutRepeatingCharacters003
    {
        /// <summary>
        /// Attempted solution with tons of edge cases...not passing all test cases [NOT ACCEPTED]
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            int longest = 0;
            int currentlength = 0;
            string substring = "";
            for (int i = 0; i < s.Length; ++i)
            {
                int indexOf = substring.IndexOf(s[i]);
                if (indexOf > -1)
                {
                    //so ugly
                    substring = s.Length - 1 > indexOf + 2 && s[indexOf + 1] != s[indexOf + 2]
                                ? s.Substring(indexOf + 1, 2)
                                : s.Substring(indexOf + 1, 1);
                    currentlength = substring.Length;
                    if (currentlength > longest)
                    {
                        longest = currentlength;
                        currentlength = 0;
                    }
                }
                else
                {
                    substring += s[i].ToString();
                    currentlength = substring.Length;
                    if (currentlength > longest)
                    {
                        longest = currentlength;
                    }
                }

            }
            return longest;
        }
    }
}
