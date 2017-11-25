
namespace Euler
{
    class Problem1
    {
        public static long Solve(string[] args)
        {
            long sum = 0;
            for (int naturalNumber = 1; naturalNumber < 1000; naturalNumber++)
            {
                if (naturalNumber % 3 == 0 || naturalNumber % 5 == 0) {
                    sum += naturalNumber;
                }
            }
            return sum;
        }
    }
}
