using System;

namespace OP_lab_1_C__
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int ia = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int ib = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int d = (a - b) / (ia - ib);
            int a1 = a - d * (ia - 1);
            int an = a1 + d * (n - 1);
            int suma = (a1 + an) * n / 2;
            Console.WriteLine(suma);
        }
    }
}
