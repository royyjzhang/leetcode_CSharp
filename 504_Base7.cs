using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_programming
{
    public class Solution
    {
        public string ConvertToBase7(int num)
        {
            string result = "";
            Boolean positive = true;
            if (num < 0) {
                positive = false;
                num = -num;
            }
            else if (num == 0)
            {
                return "0";
            }
            while (num>0)
            {
                result = (num % 7).ToString() + result;
                num = num / 7;
            }
            if (!positive)
            {
                result = "-" + result;
            }
            return result;
        }
    }
    class Base7
    {
        static void Main(string[] args)
        {
            int num = -7;
            Solution s = new Solution();
            Console.WriteLine(s.ConvertToBase7(num));
            Console.ReadKey();
        }
    }
}
