using System;

namespace lab_op_6_Csharp
{
    public class Program
    {
		public static double distance(int x, int y)
		{
			return Math.Pow(x*x + y*y, 0.5);
		}
        public static void Main(string[] args)
        {
			int i = 1;
			Console.Write("how many points?: ");
			int count = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("-------------");
			Console.Write("x{0}: ", i);
			int x = Convert.ToInt32(Console.ReadLine());
			Console.Write("y{0}: ", i);
			int y = Convert.ToInt32(Console.ReadLine());
			double dist_near = distance(x, y);
			int ind_near = 1;
			for (i = 2; i < count + 1; i++)
			{
        		Console.WriteLine("-------------");
        		Console.Write("x{0}: ", i);
				x = Convert.ToInt32(Console.ReadLine());
				Console.Write("y{0}: ", i);
				y = Convert.ToInt32(Console.ReadLine());
        		double dist_curr = distance(x, y);
        		if (dist_curr < dist_near)
				{
                	dist_near = dist_curr;
                	ind_near = i;
				}
			}
			Console.WriteLine("-------------");
			Console.WriteLine("nearest point to (0;0) is {0}", ind_near);
        }
    }
}