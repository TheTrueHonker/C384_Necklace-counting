using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using C384_Necklace_counting.Exceptions;
using C384_Necklace_counting.Math;

namespace C384_Necklace_counting.Necklace
{
    public class NecklaceCalculator
    {
        public static BigInteger Necklaces(long letters, ulong length)
        {
            Dictionary<ulong, ulong> products = GetProducts(length);
            ulong SumOfPhi = 0;
            foreach(KeyValuePair<ulong, ulong> product in products)
            {
                ulong pow = 1;
                for(ulong i = 0; i < product.Value; i++)
                {
                    pow *= Convert.ToUInt64(letters);
                }
                SumOfPhi += PhiCalculator.Phi(product.Key) * pow;
            }

            return SumOfPhi/length;
        }

        public static Dictionary<ulong, ulong> GetProducts(ulong value)
        {
            Dictionary<ulong, ulong> products = new Dictionary<ulong, ulong>();

            ulong half = value / 2;

            for(ulong i = 1; i <= half; i++)
            {
                float resultTmp = value / Convert.ToSingle(i);
                if(resultTmp % 1 == 0)
                {
                    ulong result = value / i;
                    if (!products.ContainsKey(i) && !products.ContainsKey(result))
                    {
                        products.Add(i, result);
                        products.Add(result, i);
                    }
                }

                float nextResultTmp = value / Convert.ToSingle(i + 1);
                if (nextResultTmp % 1 == 0)
                {
                    ulong nextResult = value / (i + 1);
                    if(nextResult == i)
                    {
                        if (!products.ContainsKey(i + 1) && !products.ContainsKey(nextResult))
                        {
                            products.Add(i + 1, nextResult);
                            products.Add(nextResult, i + 1);
                            break;
                        }
                    }
                }
            }
            return products;
        }
    }
}
