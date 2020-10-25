//this is not my solution (for the most part), I use main logic from here:
//https://acm.timus.ru/forum/thread.aspx?id=21289&upd=635094716421249579
using System;
using System.Collections.Generic;
namespace problem1003
{
    class Program
    {
        //for existing sequences
        static SortedDictionary<int, bool> exist = new SortedDictionary<int, bool>();
        //for expected parity
        static SortedDictionary<int, bool> odd = new SortedDictionary<int, bool>();
        //for all sequences
        static SortedDictionary<int, int> prev = new SortedDictionary<int, int>();
        static void Main(string[] args)
        {
            while (true)
            {
                //clear all dicts, just in case
                exist.Clear();
                odd.Clear();
                prev.Clear();
                int len = int.Parse(Console.ReadLine());
                //for program terminate by -1 string
                if (len == -1) { System.Environment.Exit(0); }
                //if flag == false until the end, all sequences are correct
                bool flag = false;
                int questions = int.Parse(Console.ReadLine());
                //if answer not change in loop, all sequences are correct
                int answer = questions;
                for (int i = 0; i < questions; i++)
                {
                    string[] line = Console.ReadLine().Split();
                    //break by -1, to avoid incorrect tests with wrong number of questions
                    if (line.Length == 1) { break; }
                    int left = int.Parse(line[0]);
                    int right = int.Parse(line[1]);
                    bool parity = true;
                    if (line[2] == "even") { parity = false; }
                    //check, if add func returns false result, and this happens first time
                    if (Add(left, right, parity) == false && (flag == false))
                    {
                        //remember incorrect question, mark first incorrect sequence
                        answer = i;
                        flag = true;
                    }
                }
                Console.WriteLine(answer);
            }
        }
        //add new sequence, b must >= a
        static bool Add(int a, int b, bool c)
        {
            if (!exist.ContainsKey(b))//if right border not exist yet
            {
                exist[b] = true;//mark new right border
                odd[b] = c;//(true = odd)
                prev[b] = a;//mark left border
                return true;//true because we went beyond the known sequence
            }
            //because the right border already exists, extract the corresponding left border into the variable i
            int i = prev[b];
            //compare the current and previously specified left borders
            if (i == a) return (odd[b] == c);
            // if the left border is to the right of the previous one, recursively call subsequence with the old left border,
            // and as right - the new left border-1, with the expected parity
            if (i < a) return Add(i, a - 1, (c != odd[b]));
            //otherwise, the left new border remains unchanged, and as the right border, use previous left border-1,
            //with the expected parity
            return Add(a, i - 1, (c != odd[b]));
        }
    }
}
