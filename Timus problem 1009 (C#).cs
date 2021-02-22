/* https://acm.timus.ru/problem.aspx?space=1&num=1009
 * If we consider this problem only for the binary number system,
 * then it turns out that this is the usual Fibonacci sequence.
 * 
 */
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(n, k)); 
        }

        static long Calculate(int n, int k)
        {
            int [] dp = new int [17];
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
