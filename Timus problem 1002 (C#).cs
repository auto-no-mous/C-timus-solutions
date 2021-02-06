// https://acm.timus.ru/problem.aspx?space=1&num=1002
// I solved this problem with the following hint:
// https://acm.timus.ru/forum/thread.aspx?id=35072&upd=636122368728323003

using System;
using System.Collections.Generic;
using System.Linq;

class timus1002
{
    //static members, for visibility in functions
    static List<int[]> solutions = new List<int[]>();
    static List<string> words;
    static Dictionary<int, List<int>> inclusions = new Dictionary<int, List<int>>();
    static List<int> used = new List<int>();
    static int best = int.MaxValue;
    static string number;

    public static void Main()
    {
        //main loop   
        number = Console.ReadLine();
        while (number !="-1")
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < count; i++)
            {
                string value = Console.ReadLine();
                string key = CharConvert(value);
                if (!dict.ContainsKey(key))
                    dict.Add(key, value);
            }

            words = dict.Keys.ToList();
            //sort converted words by length
            words.Sort((w1, w2) => w2.Length.CompareTo(w1.Length));

            //find all word inclusions in phone number
            for (int i = 0; i < number.Length; i++)
            {
                string n = number.Substring(i);
                for (int j = 0; j < words.Count; j++)
                {
                    if (n.StartsWith(words[j]))
                    {
                        if (inclusions.ContainsKey(i))
                        {
                            inclusions[i].Add(j);
                        }
                        else
                        {
                            inclusions.Add(i, new List<int>());
                            inclusions[i].Add(j);
                        }
                    }
                }
            }

            //recursive function call
            FindSolutions(0);

            //show result
            if (solutions.Count != 0)
            {
                solutions.Sort((i1, i2) => i1.Length.CompareTo(i2.Length));
                string s = "";
                foreach (int i in solutions[0])
                {
                    s += dict[words[i]] + " ";
                }
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("No solution.");
            }
            
            //clear static members for next input
            used.Clear();
            solutions.Clear();
            words.Clear();
            inclusions.Clear();
            best = int.MaxValue;
            number = Console.ReadLine();
        }
    }
    
    public static void FindSolutions(int start)
    {
        //if function called with end-length index, we find one of solutions
        if (start == number.Length)
        {
            solutions.Add(used.ToArray());
            //remember count of words, to eliminate redundant calls
            if (best > used.Count)
                best = used.Count;
        }

        if (inclusions.ContainsKey(start))
        {
            for (int i = 0; i < inclusions[start].Count; i++)
            {
                used.Add(inclusions[start][i]);
                if (used.Count<best)
                {
                    FindSolutions(start + words[inclusions[start][i]].Length);
                    if (used.Count > 0)
                        used.RemoveAt(used.Count - 1);
                }               
            }
        }
    }

    public static string CharConvert (string input)
    {
        input = input.ToLower();
        char[] chars = input.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] =='i' || chars[i] == 'j')
                chars[i] = '1';
            else if (chars[i] == 'a' || chars[i] == 'b' || chars[i] == 'c')
                chars[i] = '2';
            else if (chars[i] == 'd' || chars[i] == 'e' || chars[i] == 'f')
                chars[i] = '3';
            else if (chars[i] == 'g' || chars[i] == 'h')
                chars[i] = '4';
            else if (chars[i] == 'k' || chars[i] == 'l')
                chars[i] = '5';
            else if (chars[i] == 'm' || chars[i] == 'n')
                chars[i] = '6';
            else if (chars[i] == 'p' || chars[i] == 'r' || chars[i] == 's')
                chars[i] = '7';
            else if (chars[i] == 't' || chars[i] == 'u' || chars[i] == 'v')
                chars[i] = '8';
            else if (chars[i] == 'w' || chars[i] == 'x' || chars[i] == 'y')
                chars[i] = '9';
            else if (chars[i] == 'o' || chars[i] == 'q' || chars[i] == 'z')
                chars[i] = '0';
        }
        return new string(chars);
    }
}

