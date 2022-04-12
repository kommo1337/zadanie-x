using System;

namespace zadanie_x
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,3,6,7,15 };
            int max = 0;
            int min = 0;
            int j;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[min])
                    min = i;
                else if (array[i] > array[max])
                    max = i;
            }
            j = array[min];
            array[min] = array[max];
            array[max] = j;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
