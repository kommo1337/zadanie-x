using System;

namespace zadanie_x
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 2 };
            Console.WriteLine( SummSome(1, 1, 1, 1, 1, 2));
        }
        static int Multyplay()
        {
            Random rand = new();
            int[] array = new int[5];
            int res = 1;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
            }
            for (int i = 0; i < array.Length; i++)
            {
                res *= array[i];
            }
            return res;
        }
        static int SummSome(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
