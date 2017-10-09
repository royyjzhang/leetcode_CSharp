using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    class Solution
    {
        public int[,] ImageSmoother(int[,] M)
        {
            int[,] result = new int[M.GetLength(0), M.GetLength(1)];
            int sum = 0, count = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    sum = M[i, j];
                    count = 1;
                    if (i > 0)
                    {
                        if (j > 0)
                        {
                            sum += M[i - 1, j - 1];
                            count++;
                        }
                        sum += M[i - 1, j];
                        count++;
                        if (j < M.GetLength(1) - 1)
                        {
                            sum += M[i - 1, j + 1];
                            count++;
                        }
                    }
                    if (i < M.GetLength(0) - 1)
                    {
                        if (j > 0)
                        {
                            sum += M[i + 1, j - 1];
                            count++;
                        }
                        sum += M[i + 1, j];
                        count++;
                        if (j < M.GetLength(1) - 1)
                        {
                            sum += M[i + 1, j + 1];
                            count++;
                        }
                    }
                    if (j > 0)
                    {
                        sum += M[i, j - 1];
                        count++;
                    }
                    if (j < M.GetLength(1) - 1)
                    {
                        sum += M[i, j + 1];
                        count++;
                    }
                    result[i, j] = sum / count;
                }
            }
            return result;
        }
    }
    class ImageSmoother
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[,] M = { { 1, 1, 1 }, { 1, 2, 1 }, { 1, 1, 1 } }, result;
            result = solution.ImageSmoother(M);
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write(result[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
