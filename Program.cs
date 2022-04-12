using System;

namespace zadanie_x
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random rand = new();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
            }

        }
    }
}
