using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Class1
    {
            public static void Add(); 
        {
              Random rnd = new Random();
              int[] array = new int[10];

              for(int i =0 ;i<10; i++)
              {
                array[i]= rnd.Next(0,25)  ;
                Console.WriteLine(Array[i]+"");
              }
        }
                static void Main(string[] args)
               {
                add();
               }

    }
}
