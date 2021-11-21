using System;

namespace lab_op_6_Csharp
{
	class Program
	{
		static double Distance(double x, double y)
		{
			return Math.Pow(x * x + y * y, 0.5);
		}
		static void GetXY(ref double x, ref double y, ref int i)
        {
			Console.Write("x{0}: ", i);
			x = Convert.ToInt32(Console.ReadLine());
			Console.Write("y{0}: ", i);
			y = Convert.ToInt32(Console.ReadLine());
		}
		static void GetFirst(ref int count, ref double x, ref double y, ref int i)
        {
			Console.Write("how many points?: ");
			count = Convert.ToInt32(Console.ReadLine());
			GetXY(ref x, ref y, ref i);
		}
		static void Cycle(ref double x, ref double y, ref int i, ref int ind_near, ref double dist_near, int count)
        {
			for (i = 2; i < count + 1; i++)
			{
				GetXY(ref x, ref y, ref i);
				double dist_curr = Distance(x, y);
				if (dist_curr < dist_near)
				{
					dist_near = dist_curr;
					ind_near = i;
				}
			}
		}
		static void Out(int ind_near)
        {
			Console.WriteLine("nearest point to (0;0) is {0}", ind_near);
		}
		static void Main(string[] args)
		{
			int count = 0, i = 1;
			double x = 0, y = 0;
			GetFirst(ref count, ref x, ref y, ref i);
			double dist_near = Distance(x, y);
			int ind_near = 1;
			Cycle(ref x, ref y, ref i, ref ind_near, ref dist_near, count);
			Out(ind_near);
		}
	}
}