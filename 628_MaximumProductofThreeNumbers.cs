using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    class Solution
    {
        public int MaximumProduct(int[] nums)
        {
            int max1 = Int32.MinValue, max2 = Int32.MinValue, max3 = Int32.MinValue, min1 = Int32.MaxValue, min2 = Int32.MaxValue;
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                if (nums[i] > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = nums[i];
                }
                else if (nums[i] > max2)
                {
                    max3 = max2;
                    max2 = nums[i];
                }
                else if (nums[i] > max3)
                {
                    max3 = nums[i];
                }
                if (nums[i] < min1)
                {
                    min2 = min1;
                    min1 = nums[i];
                }
                else if (nums[i] < min2)
                {
                    min2 = nums[i];
                }
            }
            return Math.Max(max1 * max2 * max3, max1 * min1 * min2);
        }
    }
    class MaximumProductofThreeNumbers
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 1, 2, 3, 4 };
            Console.WriteLine(solution.MaximumProduct(nums));
            Console.ReadKey();
        }
    }
}
