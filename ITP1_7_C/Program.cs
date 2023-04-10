using System;
using System.Linq;
using System.Collections.Generic;

namespace ITP1_7_C
{
    class Program
    {
        static void Main()
        {
            string[] Line = Console.ReadLine().Split(' ');
            int r = int.Parse(Line[0]);
            int c = int.Parse(Line[1]);

            int[,] Array = new int[r + 1, c + 1];

            for (int i = 0; i < r; i++)
            {
                string[] Value = Console.ReadLine().Split(' ');

                for (int j = 0; j < c; j++)
                {
                    Array[i, j] = int.Parse(Value[j]);
                }
            }
            for (int i = 0; i <= r; i++)
            {
                for(int j = 0; j <= c; j++)
                {
                    Console.Write(string.Join(" ", Array[i, j]));
                }
                Console.WriteLine();
            }
            
            //int Count_1 = 0;
            //int Count_2 = 0;

            //for (int i = 0; i < r; i++)
            //{              
            //    for (int j = 0; j < c; j++)
            //    {  
            //        Count_1 += Array[i, j];
            //    }
            //    Array[i, c + 1] = Count_1;
            //}

            //for(int k = 0; k < c; k++)
            //{               
            //    for (int l = 0; l < r; l++)
            //    {   
            //        Count_2 += Array[l, k];    
            //    }
            //    Array[r + 1, k] = Count_2;
            //}

            //int Sum1 = 0;
            //int Sum2 = 0;
            //for (int m = 0; m < c; m++)
            //{
            //    Sum1 += Array[r + 1, m];
            //}

            //for (int o = 0; o < r; o++)
            //{
            //    Sum2 += Array[o, c + 1];
            //}
            //Array[r + 1, c + 1] = Sum1 + Sum2;

            //for(int p = 0; p < r + 1; p++)
            //{
            //    for(int q = 0; q < c + 1; q++)
            //    {
            //        Console.Write(string.Join(' ', Array[p, q]));
            //    }
            //}



        }
    }
}