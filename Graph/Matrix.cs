using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Matrix
    {
        private int[,] matrix = new int[,] {   {0,1,1,0,0},
                                               {1,0,0,0,0},
                                               {0,0,0,1,1}, 
                                               {0,0,0,0,0}, 
                                               {0,1,0,1,0} };


        public void PrintMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.Write("\n");
            }
        }

        public void PrintAsList(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"~{i+1} -> ");
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j] != 0) { Console.Write($"{j + 1} "); }
                }
                Console.Write("\n");
            }
        }
    }
}
