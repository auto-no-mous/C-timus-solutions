//https://acm.timus.ru/problem.aspx?space=1&num=1084
//resolve this problem, using formulas from:
//https://ru.wikipedia.org/wiki/Сегмент_круга

using System;
using System.Linq;

namespace timus_1084
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double square = double.Parse(input[0]);

            double R = double.Parse(input[1]);
            double d = square/2;
            double circle = Math.PI * R * R;
            double hypo = Math.Sqrt(2 * d * d);
            if (d>=R)//checking if the circle has no cut segments
            {
                Console.WriteLine("{0:f3}", circle);
                return;
            }
            else if (R>=hypo)//checking if the radius allows to eat the whole square
            {
                Console.WriteLine("{0:f3}", square*square);
                return;
            }
            double theta = Math.Acos(d / R)*2;
            double segment = 0.5 * R * R * (theta - Math.Sin(theta));
            Console.WriteLine("{0:f3}", circle-4*segment);
        }
    }
}
