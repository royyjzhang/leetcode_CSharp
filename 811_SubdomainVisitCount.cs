using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    class Solution
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            IList<string> result = new List<string>();
            Dictionary<string, int> table = new Dictionary<string, int>();
            foreach(string cpdomain in cpdomains)
            {
                string[] timesOfDomain = cpdomain.Split(' ');
                int times = Int32.Parse(timesOfDomain[0]);
                string[] domainNames = timesOfDomain[1].Split('.');
                for (int i = 0; i < domainNames.Length; i++)
                {
                    string domain = string.Join(".", domainNames.Skip(i));
                    if (table.ContainsKey(domain))
                    {
                        table[domain] += times;
                    }
                    else
                    {
                        table.Add(domain, times);
                    }
                }
            }
            foreach (KeyValuePair<string, int> item in table)
            {
                string r = item.Value.ToString() + " " + item.Key;
                result.Add(r);
            }
            return result;
        }
    }
    class Subdomain_Visit_Count
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] cpdomains = { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" };
            IList<string> result;
            result = solution.SubdomainVisits(cpdomains);
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
