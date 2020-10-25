//https://acm.timus.ru/problem.aspx?space=1&num=1005
//resolved via bitmask

using System;
using System.Linq;

namespace timus_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int [] stones = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            int heap = (int) Math.Pow(2, n) - 1;
            int diff = stones.Sum();
            while (heap > 0)
            {
                heap--;
                int new_diff = GetDiff(stones, heap);
                if (diff > new_diff)
                    diff = new_diff;
            }
            Console.WriteLine(diff);
        }

        static int GetDiff (int [] s, int h)
        {
            string map = Convert.ToString(h, 2);
            while (map.Length < s.Length)
                map = "0" + map;

            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i<map.Length; i++)
            {
                if (map[i]=='1')
                {
                    sum1 += s[i];
                }
                else if (map[i] == '0')
                {
                    sum2 += s[i];
                }
            }
            return Math.Abs(sum1-sum2);
        }
    }
}
