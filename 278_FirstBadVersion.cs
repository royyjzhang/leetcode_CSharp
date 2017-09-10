using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    /* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */
    
    class VersionControl
    {
        const int FIRST_BAD_VERSION = 3;
        public bool IsBadVersion(int version)
        {
            if (version >= FIRST_BAD_VERSION)
                return true;
            else
                return false;
        }
    }
    class Solution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int start = 1, end = n, mid = 0;
            while (start < end)
            {
                mid = start + (end - start) / 2;
                if (IsBadVersion(mid))
                {
                    end = mid;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;
        }
    }
    class FirstBadVersion
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int n = 5;
            Console.WriteLine(solution.FirstBadVersion(n));
            Console.ReadKey();
        }
    }
}
