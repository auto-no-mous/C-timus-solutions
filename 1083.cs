using System;
using System.Collections.Generic;

namespace problem1083
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int k = s[1].Length;
            int answer = n;
            int current = k;
            while ((n - current) >= 1)
            {
                answer *= (n - current);
                current += k;
            }

            Console.WriteLine(answer);
        }

    }
}