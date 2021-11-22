using System;

namespace lab_op_8_Csharp
{
    class Program
    {
        static int[,] form(ref int height, ref int width)
        {
            var rand = new Random();
            Console.Write("Height: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Width: ");
            width = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    array[i,j] = rand.Next(-999, 999);
                }
            }
            return array;
        }
        static int[,] change(int [,] array, int height, int width)
        {

            int[,] transposed = new int[width, height];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    transposed[j, i] = array[i, j];
                }
            }    
            return transposed;
        }
        static void print(int[,] array)
        {
            Console.WriteLine();
            int height = array.GetLength(0);
            int width = array.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < width; j++)
                {
                    Console.Write(String.Format("{0,5}", array[i, j]));
                }
            }
        }
        static void Main(string[] args)
        {
            int height = 0, width = 0;
            int[,] array = form(ref height, ref width);
            print(array);
            int [,] transposed = change(array, height, width);
            print(transposed);
        }
    }
}
