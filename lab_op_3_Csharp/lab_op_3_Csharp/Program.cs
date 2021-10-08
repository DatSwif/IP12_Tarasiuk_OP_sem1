using System;

namespace lab_op_3_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("root: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("10^(-eps), eps=precision: ");
            double eps = Math.Pow(10, -1 * Convert.ToDouble(Console.ReadLine()));
            sbyte ceil_pos(int a, int p, int num)
            {
                if ((Math.Pow(a - 1, p) < num) && (Math.Pow(a, p) >= num))
                {
                    return 0;
                }
                else if (Math.Pow(a - 1, p) >= num)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            double mult(int p, int n)
            {
                double res = 1;
                for (int i = 0; i < n; i++)
                {
                    res = res * (1/Convert.ToDouble(p)-Convert.ToDouble(i));
                }
                return res;
            }
            double fact(int n)
            {
                double res = 1;
                for (int i = 1; i <= n; i++)
                {
                    res = res * i;
                }
                return res;
            }
            double add (int a, int p, double b, int n)
            {
                double power = Math.Pow(b / Math.Pow(a, p), n);
                double other = mult(p, n) / fact(n);
                return power * other;
            }
            int p2 = -1;
            int a = 0;
            while (ceil_pos(a, p, num) == -1)
            {
                p2 += 1;
                a = Convert.ToInt32(Math.Pow(2, p2));
            }
            while (ceil_pos(a, p, num) != 0)
            {
                if (ceil_pos(a, p, num) == 1)
                {
                    p2 -= 1;
                    a -= Convert.ToInt32(Math.Pow(2, p2));
                }
                else if (ceil_pos(a, p, num) == -1)
                {
                    p2 -= 1;
                    a += Convert.ToInt32(Math.Pow(2, p2));
                }
            }

            int b = num - Convert.ToInt32(Math.Pow(a, p));
            int n = 0;
            double ans = 1;
            do
            {
                n += 1;
                ans += add(a, p, b, n);
            }
            while (Math.Abs(add(a, p, b, n)) >= eps);
            Console.Write("approximation: ");
            Console.WriteLine(ans * Convert.ToDouble(a));
        }
    }
}
