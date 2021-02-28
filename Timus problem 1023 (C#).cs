// https://acm.timus.ru/problem.aspx?space=1&num=1023
using System;

namespace timus1023
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int divisor = k;
            for (int i = 3; i <(k/2)+1; i++)
            {
                if (k % i == 0)
                {
                    divisor = i;
                    break;
                }
            }
            Console.WriteLine(divisor - 1);
            
        }
    }


}