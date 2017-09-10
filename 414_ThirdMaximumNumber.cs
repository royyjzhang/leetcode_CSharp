using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    class Solution
    {
        public int ThirdMax(int[] nums)
        {
            bool max_flag1 = false, max_flag2 = false, max_flag3 = false;
            int max1 = 0, max2 = 0, max3 = 0;
            for (int i = 0;i < nums.Length; i++)
            {
                if (((max_flag1) && (nums[i] == max1)) || ((max_flag2) && (nums[i] == max2)) || ((max_flag3) && (nums[i] == max3)))
                    continue;
                if ((!max_flag1) || (nums[i] > max1))
                {
                    max_flag3 = max_flag2;
                    max3 = max2;
                    max_flag2 = max_flag1;
                    max2 = max1;
                    max_flag1 = true;
                    max1 = nums[i];
                }
                else if ((!max_flag2) || (nums[i] > max2))
                {
                    max_flag3 = max_flag2;
                    max3 = max2;
                    max_flag2 = true;
                    max2 = nums[i];
                }
                else if ((!max_flag3) || (nums[i] > max3))
                {
                    max_flag3 = true;
                    max3 = nums[i];
                }
            }
            if (max_flag3)
            {
                return max3;
            }
            else
            {
                return max1;
            }
        }
    }
    class ThirdMaximumNumber
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 1, 2, 1, 4, 5 };
            Console.WriteLine(solution.ThirdMax(nums));
            Console.ReadKey();
        }
    }
}
