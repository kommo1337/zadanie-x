using System;

namespace zadanie_x
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
