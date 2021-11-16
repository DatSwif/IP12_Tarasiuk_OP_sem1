using System;
​
namespace lab_op_5_Csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int binary = 0;
            while (num > 0)
            {
                binary *= 10;
                binary += num % 2;
                num = num / 2;
            }
            double power = 0;
            int res = 0;
            while (binary > 0)
            {
                if (binary % 2 != 0)
                {
                    res += Convert.ToInt32(Math.Pow(2,power));
                }
                power += 1;
                binary = binary / 10;
            }
            Console.Write("Result: ");
            Console.Write(res);
        }
    }
}