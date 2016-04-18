using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculator
{
    static class Factors
    {
        public static BigInteger gcf(BigInteger a, BigInteger b)
        {
            List<BigInteger> a_factors = getPrimeFactors(a);
            List<BigInteger> b_factors = getPrimeFactors(b);
            IEnumerable<BigInteger> intersection = a_factors.Intersect(b_factors);
            if (intersection.Count() != 0)
                return intersection.ElementAt(intersection.Count() - 1);
            else
                return new BigInteger(1);
        }
        public static List<BigInteger> getPrimeFactors(BigInteger n)
        {
            n = BigInteger.Abs(n);
            List<BigInteger> factors = new List<BigInteger>();
            while (n % 2 == 0) { factors.Add(2); n /= 2; }
            for (BigInteger i = new BigInteger(3); i <= n/i; i+=2)
            {
                while (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }
            }
            if (n > 1)
                factors.Add(n);
            return factors;
        }

        public static bool FermatPrimalityTest(BigInteger p, BigInteger b)
        {
            p = BigInteger.ModPow(b, p - 1, p); // If this is 1 it's prime or a charmichael number
            if (p == 1)
                return true;
            else
                return false;
        }
    }
}
