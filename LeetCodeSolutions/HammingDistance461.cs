using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{

    public class HammingDistance461
    {
        public int HammingDistance(int x, int y)
        {
            //return HammingDistanceBruteForce(x, y);
            return HammingDistanceBitwise(x, y);
        }
        /// <summary>
        /// Slow and ugly version using string comparison [ACCEPTED]
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int HammingDistanceBruteForce(int x, int y)
        {
            var xBin = Convert.ToString(x, 2);          
            var yBin = Convert.ToString(y, 2);
            if (xBin.Length > yBin.Length) {
                yBin = yBin.PadLeft(xBin.Length, '0');
            }
            else if (yBin.Length > xBin.Length)
            {
                xBin = xBin.PadLeft(yBin.Length, '0');
            }
            int count = 0;
            for (int i = 0; i < xBin.Length; i++)
            {
                if (xBin[i] != yBin[i])
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Partially bitwise implementation, much nicer but not faster [ACCEPTED]
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int HammingDistanceBitwise(int x, int y)
        {
            //x XOR y, result to binary string
            var result = Convert.ToString(x ^ y, 2);
            int count = result.Where(c => c == '1').Count();
            return count;
        }
    }
}
