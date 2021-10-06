using System;

namespace lab_op_3_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1;
            Console.WriteLine("number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("root: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("precision: ");
            double prec = Convert.ToDouble(Console.ReadLine());
            double mark = Math.Pow(num,(1 / p));
            while (Math.Abs(x - mark) > prec)
            {
                x = 1 / p * Math.Floor((p - 1) * x + num / Math.Pow(x, p - 1));
                Console.WriteLine(x);
            }
            Console.Write("calculated with iterations: ");
            Console.WriteLine(x);
            Console.Write("the actual value: ");
            Console.WriteLine(mark);
        }
    }
}
