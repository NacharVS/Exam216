﻿using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
            
        }
        static int Factorial (int x)
        {
            if (x==0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
                
            }
            
        }
    }
}
