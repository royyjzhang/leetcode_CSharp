using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    class Solution
    {
        public int FindPairs(int[] nums, int k)
        {
            int result = 0;
            Dictionary<int, int> num_times = new Dictionary<int, int>();
            if (k < 0)
                return result;
            for (int i = 0; i < nums.Length; i++)
            {
                if (num_times.ContainsKey(nums[i]))
                {
                    num_times[nums[i]] += 1;
                }
                else
                {
                    num_times[nums[i]] = 1;
                }
            }
            List<int> keys = new List<int>(num_times.Keys);
            keys.Sort();
            if (k == 0)
            {
                for (int i = 0; i < keys.Count; i++)
                {
                    if (num_times[keys[i]] > 1)
                    {
                        result += 1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < keys.Count; i++)
                {
                    if (num_times.ContainsKey(keys[i] + k))
                    {
                        result += 1;
                    }
                }
            }
            return result;
        }
    }
    class K_diffPairsinanArray
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int k = 0;
            int[] nums = { 1, 2, 1, 4, 5 };
            Console.WriteLine(solution.FindPairs(nums, k));
            Console.ReadKey();
        }
    }
}
