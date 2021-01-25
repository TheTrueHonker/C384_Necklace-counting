using System;
using System.Collections.Generic;
using System.Text;

namespace C384_Necklace_counting.Math
{
    public class PhiCalculator
    {
        public static ulong Phi(ulong a)
        {
            /**
             * phi(a) = a * Product of (p-1) / Product of (p)
             * for all distinct prime p that divide evenly into a.
             * 
             * phi(12) = 12 * ((2-1)*(3-1)) / (2*3) = 12 * 2 / 6 = 4
             */
            List<ulong> candidates = GetPrimes(a);
            List<ulong> primes = new List<ulong>();
            foreach(ulong candidate in candidates)
            {
                double tmpResult = Convert.ToDouble(a) / candidate;
                if(tmpResult % 1 == 0)
                {
                    primes.Add(candidate);
                }
            }

            ulong product1 = 1;
            foreach(ulong prime in primes)
            {
                product1 *= (prime - 1);
            }

            ulong product2 = 1;
            foreach(ulong prime in primes)
            {
                product2 *= prime;
            }

            return a * product1 / product2;
        }

        public static List<ulong> GetPrimes(ulong p)
        {
            List<ulong> primes = new List<ulong>();
            List<ulong> candidates = new List<ulong>();

            if (p >= 2)
                primes.Add(2);

            for(ulong i = 1; i <= p; i++)
            {
                if(i % 2 != 0)
                {
                    candidates.Add(i);
                }
            }

            foreach(ulong candidate in candidates)
            {
                if (candidate == 1)
                    continue;

                bool prime = true;
                ulong halfOfCandidte = candidate / 2;
                for(ulong i = 2; i < halfOfCandidte; i++)
                {
                    float result = Convert.ToSingle(candidate) / i;
                    if(result % 1 == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime == true)
                {
                    primes.Add(candidate);
                }
            }

            return primes;
        }
    }
}
