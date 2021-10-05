using System;

namespace lab_op_3_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Minutes: ");
            decimal x = Convert.ToDecimal(Console.ReadLine());
            if (x % 5 > 3)
            {
                Console.WriteLine("Red");
            }
            else
            {
                Console.WriteLine("Green");
            }
        }
    }
}
