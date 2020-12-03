//https://acm.timus.ru/problem.aspx?space=1&num=1073
using System;
using System.Numerics;

namespace timus1073
{
    class Program
    {
        const int size = 60001;
        const int max = 245;
        static void Main(string[] args)
        {
            int[] data = new int[size];
            int n = int.Parse(Console.ReadLine());
            data[1] = 1;
            data[2] = 2;
            for (int i = 3; i <= n; ++i)
            {
                int min = data[i - 1] + 1;
                for (int j = 2; j <= max; ++j)
                {
                    if (i >= j * j)
                    {
                        if (min > data[i - j * j] + 1) min = data[i - j * j] + 1;
                    }
                    else break;
                }
                data[i] = min;
            }
            Console.WriteLine(data[n]);
        }
    }    
}
