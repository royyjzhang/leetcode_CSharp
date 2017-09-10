using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    class Solution
    {
        public int CountSegments(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] != ' ') && ((i == 0) || (s[i - 1] == ' ')))
                {
                    result += 1;
                }
            }
            return result;
        }
    }
    class NumberofSegmentsinaString
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "Hello, my name is John";
            Console.WriteLine(solution.CountSegments(s));
            Console.ReadKey();
        }
    }
}
