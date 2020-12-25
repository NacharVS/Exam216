using System;

namespace Exam
{
	class Program
	{
		public static void Main(string[] args)
		{
			int k = 0;                      
			int k1 = 0;                     
			var r = new Random();
			int[,] matrx = new int[10, 10]; 
			int[,] matrx1 = new int[10, 10];

			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)    
				{
					matrx[i, j] = r.Next(0, 10);    
					k += matrx[i, j];               
					Console.Write(matrx[i, j] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)    
				{
					matrx1[i, j] = r.Next(0, 10);   
					k1 += matrx[i, j];              
					Console.Write(matrx1[i, j] + " ");
				}
				Console.WriteLine();
			}
			int sum = 0;
			sum = k + k1;

			Console.WriteLine("Sum = " + sum);  
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}