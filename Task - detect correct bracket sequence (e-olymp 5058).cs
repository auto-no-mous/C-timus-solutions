//solution to https://www.e-olymp.com/ru/problems/5058
//solved with using self-written stack, as example for data structures

using System;
using System.Globalization;

public class Stack <T>
{
    private T[] items;
    private int count;

    public Stack (int length)
    {
        items = new T[length];
        count = 0;
    }

    public bool IsEmpty
    {
        get
        {
            return count == 0;
        }
    }

    public void Push(T item)
    {
        if (count == items.Length)
            throw new InvalidOperationException("Стек полон, невозможно добавить элемент.");
        items[count++] = item;
    }

    public T Pop()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Стек пуст, нечего извлекать.");
        count--;
        return items[count];
    }
}

class Brackets
{
    static void Main(string[] args)
    {
        Stack<char> st = new Stack<char>(256);
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            if ((input[i] == '(') || (input[i] == '[') || (input[i] == '{'))
                st.Push(input[i]);
            else 
            {
                try
                {
                    switch (input[i])
                    {
                        case ')':
                            if (st.Pop() != '(')
                            {
                                Console.WriteLine("no");
                                return;
                            }
                            break;

                        case ']':
                            if (st.Pop() != '[')
                            {
                                Console.WriteLine("no");
                                return;
                            }
                            break;

                        case '}':
                            if (st.Pop() != '{')
                            {
                                Console.WriteLine("no");
                                return;
                            }
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("no");
                    return;
                }
            }          
        }
        if (st.IsEmpty)
            Console.WriteLine("yes");
        else Console.WriteLine("no");
    }
}
