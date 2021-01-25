using System;
using System.Numerics;

namespace C384_Necklace_counting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Can only test small numbers up to ulong because of how BigInteger works
            // I can not use BigInteger and double/float at the same time
            // I need to use double/float to check the modul (%) if the rest == 0
            Console.WriteLine("---- Challenge #384 [Intermediate] Necklace counting ----");
            Console.WriteLine();
            Console.WriteLine("Calculating count of necklaces with 3 number of pearls and a length of 7...");
            BigInteger answer = Necklace.NecklaceCalculator.Necklaces(99, 2);
            Console.WriteLine("Function returned {0}", answer);
        }
    }
}
