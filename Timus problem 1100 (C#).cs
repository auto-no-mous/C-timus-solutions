using System;
using System.Collections.Generic;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>[] id = new List<int>[101];
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i<count; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (id[int.Parse(s[1])] == null)
                {
                    id[int.Parse(s[1])] = new List<int>();
                }

                id[int.Parse(s[1])].Add(int.Parse(s[0]));
            }
            for (int i = 100; i>=0; i--)
            {
                if (id[i] != null)
                {
                    for (int j = 0; j<id[i].Count;j++)
                    {
                        Console.WriteLine($"{id[i][j]} {i}");
                    }
                }

            }
        }

    }
}
