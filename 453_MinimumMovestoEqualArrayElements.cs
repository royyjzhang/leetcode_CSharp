using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_programming
{
    public class Solution
    {
        public int MinMoves(int[] nums)
        {
            int sum = nums[0], min = nums[0];
            for (int i=1;i<nums.Length;i++)
            {
                sum += nums[i];
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            return sum - min * nums.Length;
        }
    }
    class MinimumMovestoEqualArrayElements
    {
        static void Main(string[] args)
        {
            Solution s = new learning_programming.Solution();
            int[] nums = { 1, 2, 3 };
            int result;
            result = s.MinMoves(nums);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
