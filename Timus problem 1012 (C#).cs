/* https://acm.timus.ru/problem.aspx?space=1&num=1012
 * Variation of 1009 problem. I just replace long with BigInteger.
 * 
 */
using System;
using System.Numerics;

namespace timus1012
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(n, k)); 
        }

        static BigInteger Calculate(int n, int k)
        {
            BigInteger [] dp = new BigInteger [1800];
            dp[0] = 1;
            dp[1] = k - 1;
            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] * (k - 1) + dp[i - 2] * (k - 1);
            }
            return dp[n];
        }
    }
        
        
}
