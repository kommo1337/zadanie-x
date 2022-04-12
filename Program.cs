using System;

namespace zadanie_x
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,3,6,7,15 };
            int[] small = new int[array.Length - 1];
            for (int i = 0; i < small.Length; i++)
            {
                small[i] = array[i];
            }
            for (int i = 0; i < small.Length; i++)
            {
                Console.WriteLine(small[i]);
            }
        }
    }
}
