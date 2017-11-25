
namespace Euler
{
    class Problem2
    {
        public static long Solve(string[] args)
        {
            long sumOfEvenValuedTerms = 0;
            int term1 = 1;
            int term2 = 2;
            while (term2 < 4000000)
            {
                if (term2 % 2 == 0)
                {
                    sumOfEvenValuedTerms += term2;
                }

                int newTerm2 = term1 + term2;
                term1 = term2;
                term2 = newTerm2;
            }

            return sumOfEvenValuedTerms;
        }
        
    }
}
