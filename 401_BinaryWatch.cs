using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_programming
{
    public class Solution
    {
        public IList<string> ReadBinaryWatch(int num)
        {
            IList<string> result = new List<string>();
            int bit = 0, count = 0, temp, hour, minute;
            for (bit=0;bit<1024;bit++)
            {
                count = 0;
                temp = bit;
                hour = bit / 64;
                minute = bit % 64;
                for (int i=0;i<10;i++)
                {
                    count += temp & 1;
                    temp = temp >> 1;
                }
                if ((count==num) && (hour<=11) && (minute<=59))
                {
                    if (minute<10)
                    {
                        result.Add(hour.ToString() + ":0" + minute.ToString());
                    }
                    else
                    {
                        result.Add(hour.ToString() + ":" + minute.ToString());
                    }
                }
            }
            return result;
        }
    }
    class BinaryWatch
    {
        static void Main(string[] args)
        {
            int num = 3;
            Solution s = new Solution();
            IList<string> result;
            result = s.ReadBinaryWatch(num);
            for (int i=0;i<result.Count;i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();
        }
    }
}
