using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    class Solution
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int low = 0, high = letters.Length, mid = 0;
            while (low < high)
            {
                mid = low + (high - low) / 2;
                if (letters[mid] <= target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            return letters[low % letters.Length];
        }
    }
    class FindSmallestLetterGreaterThanTarget
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            char[] letters = { 'c', 'f', 'j' };
            char target = 'a';
            Console.WriteLine(solution.NextGreatestLetter(letters, target));
            Console.ReadKey();
        }
    }
}
