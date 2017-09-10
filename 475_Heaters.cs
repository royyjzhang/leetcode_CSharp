using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    class Solution
    {
        public int FindRadius(int[] houses, int[] heaters)
        {
            int result = -1;
            Array.Sort<int>(heaters, new Comparison<int>((i1, i2) => i1.CompareTo(i2)));
            for (int i = 0;i < houses.Length;i++)
            {
                int start = 0, end = heaters.Length - 1, mid = 0, radius = 0;
                while (start < end)
                {
                    mid = (start + end) / 2;
                    if (heaters[mid] == houses[i])
                    {
                        break;
                    }
                    else if (heaters[mid] > houses[i])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                if (heaters[mid] != houses[i])
                {
                    if (heaters[start] > houses[i])
                    {
                        if (start == 0)
                        {
                            radius = heaters[start] - houses[i];
                        }
                        else
                        {
                            radius = Math.Min(heaters[start] - houses[i], Math.Abs(heaters[start - 1] - houses[i]));
                        }
                    }
                    else
                    {
                        if (start == heaters.Length - 1)
                        {
                            radius = houses[i] - heaters[start];
                        }
                        else
                        {
                            radius = Math.Min(houses[i] - heaters[start], Math.Abs(heaters[start + 1] - houses[i]));
                        }
                    }
                }
                if (result == -1)
                {
                    result = radius;
                }
                else if (radius > result)
                {
                    result = radius;
                }
            }
            return result;
        }
    }
    class Heaters
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] houses = { 1, 2, 3, 4 }, heaters = { 1, 4 };
            Console.WriteLine(solution.FindRadius(houses, heaters));
            Console.ReadKey();
        }
    }
}
