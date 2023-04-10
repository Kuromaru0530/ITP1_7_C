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
        }
    }
}
