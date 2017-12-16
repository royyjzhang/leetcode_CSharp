using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    class Element
    {
        public int freq = 0, start = 0, end = 0;
        public Element()
        {
            freq = 0;
            start = 0;
            end = 0;
        }
    }
    class Solution
    {
        public int FindShortestSubArray(int[] nums)
        {
            int result = nums.Length, maxfreq = 0;
            Dictionary<int, Element> map = new Dictionary<int, Element>();
            for (int i = 0;i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]].freq += 1;
                    map[nums[i]].end = i;
                }
                else
                {
                    Element e = new Element();
                    e.freq = 1;
                    e.start = i;
                    e.end = i;
                    map.Add(nums[i], e);
                }
            }
            foreach (KeyValuePair<int, Element> entry in map)
            {
                if (entry.Value.freq > maxfreq)
                {
                    maxfreq = entry.Value.freq;
                    result = entry.Value.end - entry.Value.start + 1;
                }
                else if ((entry.Value.freq == maxfreq) && (entry.Value.end - entry.Value.start + 1 < result))
                {
                    result = entry.Value.end - entry.Value.start + 1;
                }
            }
            return result;
        }
    }
    class DegreeofanArray
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 1, 2, 2, 3, 1 };
            Console.WriteLine(solution.FindShortestSubArray(nums));
            Console.ReadKey();
        }
    }
}
