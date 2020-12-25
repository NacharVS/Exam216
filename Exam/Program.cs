using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            Random rnb = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int f = 0; f < array.GetLength(1); f++)
                {
                    array[i, f] = rnb.Next(10, 30);
                    Console.Write($" {array[i, f]}");
                }
                Console.WriteLine();
            }
            int Sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                
                Sum = Sum + array[i, i];
            }
            Console.WriteLine($"The sum of the main diagonal: {Sum}");
        }
    }
}
