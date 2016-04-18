using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Numerics;

namespace Calculator
{
    static class Sums
    {
        /// <summary>
        /// Takes the sum of every natural number from 1 to n
        /// </summary>
        /// <param name="n">finite upper value</param>
        /// <returns></returns>
        static public BigInteger Naturals(BigInteger n)
        {
            n = BigInteger.Abs(n);
            n *= (n + 1);
            n /= 2;
            return n;
        }

        /// <summary>
        /// Takes the sum of every natural number from k to n
        /// </summary>
        /// <param name="k">finite lower value (inclusive)</param>
        /// <param name="n">finite upper value</param>
        /// <returns></returns>
        static public BigInteger Naturals(BigInteger k, BigInteger n)
        {
            n = BigInteger.Abs(n);
            n *= (n + 1);
            n /= 2;

            k = BigInteger.Abs(k - 1);
            k *= (k + 1);
            k /= 2;

            n -= k;
            return n;
        }

        /// <summary>
        /// Returns the value the sum of the sequence involving a and r approach
        /// For the value to make any sense, r < 1
        /// </summary>
        /// <param name="a">The first element of the sequence</param>
        /// <param name="r">The ratio of 2 elements; (n+1)/n in the sequence</param>
        /// <returns></returns>
        static public BigRational GeometricLimit(BigInteger a, BigInteger r)
        {
            return new BigRational(a, new BigInteger(1) - r);
        }
        /// <summary>
        /// Returns whether the Geometric Limit meets the r criteria.
        /// 1 = convergent series
        /// 0 = indeterminate
        /// -1 = divergent series
        /// </summary>
        /// <param name="r">The ratio of 2 elements; (n+1)/n in the sequence</param>
        /// <returns></returns>
        static public int GeometricLimit(BigInteger r)
        {
            if (r > 1)
                return -1;
            else if (r == 1)
                return 0;
            else
                return 1;
        }

    }
}

//TODO: Add a way to analyze a sequence, and form a series limit to tell whether it's convergent, and if so converges to what.
// ex. if (n+1)/n does not equal (n+2)/(n+1) then the sequence is not a geometric series