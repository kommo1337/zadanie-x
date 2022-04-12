using System;

namespace zadanie_x
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 2 };
            Summ(array);
        }
        static void Summ(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
    }
}
