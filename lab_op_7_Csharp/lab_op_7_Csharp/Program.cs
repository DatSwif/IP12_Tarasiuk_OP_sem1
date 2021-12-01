using System;

namespace lab_op_7_Csharp
{
    class Program
    {
        static int[] form()
        {
            var rand = new Random();
            Console.Write("Size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(-999,999);
            }
            return array;
        }
        static int find_diff(int[] array)
        {
            int small = array[0];
            int big = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < small)
                {
                    small = array[i];
                }
                else if (array[i] > big)
                {
                    big = array[i];
                }
            }
            return big - small;
        }
        static int[] change_the_array(int[] array, int diff)
        {
            for (int i = 0; i < (array.Length + 1) / 2; i++)
            {
                array[i * 2] = diff;
            }
            return array;
        }
        static void print(int[] array)
        {
            string s = "";
            for(int i = 0; i < array.Length; i++)
            {
                s += Convert.ToString(array[i]) + ' ';
            }
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            int[] array = form();
            print(array);
            int diff = find_diff(array);
            Console.WriteLine(diff);
            array = change_the_array(array, diff);
            print(array);
        }
    }
}
