using System;

namespace Euler
{
    class Problem3
    {
        public static long Solve(string[] args)
        {
            long targetNumber = 600851475143;
            long squareRoot = (long) Math.Sqrt(targetNumber) + 1;
            for (long i = squareRoot ; i > 1 ; i--)
            {
                if ((targetNumber % i == 0) && IsPrime(i))
                {
                    return i;
                }
            }
            throw new Exception("Should not reach here");
        }

        static bool IsPrime(long number)
        {
            for (long i = 2; i <= (long) Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

