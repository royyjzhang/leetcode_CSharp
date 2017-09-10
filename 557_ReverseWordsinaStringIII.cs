using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_programming
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            return string.Join(" ", s.Split().Select(w => new string(w.ToCharArray().Reverse().ToArray())));
        }
    }
    class ReverseWordsinaStringIII
    {
        static void Main(string[] args)
        {
            Solution s = new learning_programming.Solution();
            string str = "Let's take LeetCode contest", result;
            result = s.ReverseWords(str);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
