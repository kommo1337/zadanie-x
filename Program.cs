using System;

namespace zadanie_x
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 2 };
            Console.WriteLine(Multyplay());
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
    }
}
