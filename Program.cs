using System;

namespace zadanie_x
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a%2==0&&b%2==0)
                Console.WriteLine(a+b);
            else
                Console.WriteLine(b*a);
        }
    }
}
