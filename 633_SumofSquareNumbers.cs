using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    class Solution
    {
        public bool JudgeSquareSum(int c)
        {
            int rest = 0;
            for (int starter = 0; starter <= (int)(Math.Sqrt(c)); starter++)
            {
                rest = (int)Math.Sqrt(c - starter * starter);
                if (rest * rest + starter * starter == c)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class SumofSquareNumbers
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int c = 8;
            Console.WriteLine(solution.JudgeSquareSum(c));
            Console.ReadKey();
        }
    }
}
