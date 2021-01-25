using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace C384_Necklace_counting.Math
{
    public class BigIntegerOperations
    {
        public BigInteger GetRest(BigInteger x, BigInteger y)
        {
            BigInteger divideOperation = x / y; // 5:2=2
            BigInteger multipliedDivider = divideOperation * y; // 2*2=4
            return x - multipliedDivider; // 5-4=1
        }
    }
}
