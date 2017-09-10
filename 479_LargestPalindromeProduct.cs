using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    class Solution
    {
        private long convert2Palindrom(int half)
        {
            String num = half.ToString();
            char[] c = num.ToCharArray();
            Array.Reverse(c);
            num = num + new string(c);
            return long.Parse(num);
        }
        public int LargestPalindrome(int n)
        {
            int result = 9, firstHalf = 0, upperBound = (int)Math.Pow(10, n) - 1, lowerBound = upperBound / 10;
            long maxNum = (long)upperBound * (long)upperBound, palindrom = 0;
            bool find = false;
            if (n == 1)
            {
                return result;
            }
            firstHalf = (int)(maxNum / (long)Math.Pow(10, n));
            while (!find)
            {
                palindrom = convert2Palindrom(firstHalf);
                for (long i = upperBound; upperBound > lowerBound; i--)
                {
                    if ((palindrom / i > maxNum) || (i * i < palindrom))
                        break;
                    if (palindrom % i == 0)
                    {
                        find = true;
                        break;
                    }
                }
                firstHalf--;
            }
            result = (int)(palindrom % 1337);
            return result;
        }
    }
    class LargestPalindromeProduct
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int n = 2;
            Console.WriteLine(solution.LargestPalindrome(n));
            Console.ReadKey();
        }
    }
}
