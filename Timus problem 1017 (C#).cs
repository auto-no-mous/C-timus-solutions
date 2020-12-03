//https://acm.timus.ru/problem.aspx?space=1&num=1017
using System;


namespace timus_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[,] g = new long[n+1, n];
            for (int i = 2; i <= n; ++i)
            {
                g[i,0] = 1;
                for (int j = 1; j < i; ++j)
                {
                    g[i,0] += g[i - j, j];
                }
                for (int j = 1; j < i; ++j)
                {
                    g[i, j] = g[i, j - 1] - g[i - j, j];
                }
            }
            Console.WriteLine(g[n, 0] - 1);
            Console.Read();
        }
    }
}