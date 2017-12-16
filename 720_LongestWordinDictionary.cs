using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    class Solution
    {
        public string LongestWord(string[] words)
        {
            Array.Sort(words, StringComparer.InvariantCulture);
            string result = "";
            HashSet<string> built = new HashSet<string>();
            foreach (string word in words)
            {
                if ((word.Length == 1) || (built.Contains(word.Substring(0, word.Length - 1))))
                {
                    if (word.Length > result.Length)
                    {
                        result = word;
                    }
                    built.Add(word);
                }
            }
            return result;
        }
    }
    class LongestWordinDictionary
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] words = { "a", "banana", "app", "appl", "ap", "apply", "apple" };
            Console.WriteLine(solution.LongestWord(words));
            Console.ReadKey();
        }
    }
}
