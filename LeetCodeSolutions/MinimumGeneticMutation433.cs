using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class MinimumGeneticMutation433
    {
        /// <summary>
        /// Attempted solution, can't pass all test cases [NOT ACCEPTED]
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="bank"></param>
        /// <returns></returns>
        public int MinMutation(string start, string end, string[] bank)
        {
            int mutations = 0;
            bool isValidMutation = false;
            if (bank.Contains(end))
            {
                for (int i = 0; i < start.Length; i++)
                {
                    if (start[i] != end[i])
                    {
                        mutations++;

                        foreach (string s in bank)
                        {
                            if (s[i] == end[i])
                            {
                                isValidMutation = true;
                            }
                        }
                        if (!isValidMutation) return -1;
                    }
                }
            }
            else return -1;

            return mutations;
        }
    }
}
