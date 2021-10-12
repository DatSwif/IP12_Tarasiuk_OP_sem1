using System;

namespace lab_op_3_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Root: ");
            double p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Precision: ");
            double eps = Math.Pow(10,-1*Convert.ToDouble(Console.ReadLine()));
            double x = 1;
            double xprev = 99999;
            while (Math.Abs(xprev - x) > eps)
            {
                xprev = x;
                x = 1 / p * ((p - 1) * xprev + a / Math.Pow(xprev, p - 1));
            }
            Console.WriteLine(x);
        }
    }
}
