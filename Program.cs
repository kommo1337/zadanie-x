using System;

namespace zadanie_x
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,3,6,7,15 };
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2!=0)
                {
                    res += array[i];
                }
            }
            Console.WriteLine(res);
        }
    }
}
