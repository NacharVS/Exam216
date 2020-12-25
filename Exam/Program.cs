using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            long n = Convert.ToInt64(Console.ReadLine());
            long r = 1;
            for (int i = 2; i <= n; ++i)
                r *= i;
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}


