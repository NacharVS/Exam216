using System;
using 

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Cont int n = 10;

            int[,] maxtrix1 = FillArr(n);
            Thread.Sleep(100);
            int[,] maxtrxSum = SumMatrix(maxtrix1, matrix2, n);

            Console.WriteLine("Исходная матрица первая");
            PrintArr(matrix1);
            Console.WriteLine();

            Console.WriteLine("Сумма двух матриц");
            PrintArr(matrixSum);

            {
                static int[,] FillArr(int n)
                {
                    int[,] arr = new int[n, n];
                    Random rnd = new Random();
                     
                    for(int i = 0; i < n; i ++)
                    {
                        for(int j = 0; j < n; j++)
                        {
                            arr[i, j] += rnd.Next(1, 100);
                        }
                        {
                            return arr;
                        }
                         
                        static void PrintArr(int[,] matrix)
                        {
                            for( int i = 0; i < 10; i++)
                            {
                                for( int j = 0; j < 10; j ++)

                            }
                            Console.WriteLine(matrix[i, j] + "");
                        }
                        {
                            Console.WriteLine();

                        }
                        static int[,]
                            SumMatrix(int[,] matrix1,int[,] matrix2, int n)
                            int[,] MatrixSum = new int[n, n];
                        for(int i = 0; i < n; i ++)
                        {
                            for(int j = 0; j < n; j ++)

                        }
                        { 
                        MatrixSum[i, j] = matrix1[i, j] + matrix2[i, j];
                    
                        }
                }

            }

        }
    }
}
