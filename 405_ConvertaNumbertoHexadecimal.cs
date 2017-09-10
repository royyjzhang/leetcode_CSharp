using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_programming
{
    public class Solution
    {
        public string ToHex(int num)
        {
            int[] hexBits = new int[8];
            Boolean positiveFlag = true;
            int i = 0, len = 0;
            long extnum = num;
            string result = "";
            if (num == 0)
                return "0";
            if (extnum < 0)
            {
                positiveFlag = false;
                extnum = -extnum;
            }
            while (extnum > 0)
            {
                hexBits[len] = (int)extnum % 16;
                extnum = extnum / 16;
                len++;
            }
            if (positiveFlag)
            {
                for (i = 0; i < len; i++)
                {
                    switch (hexBits[i])
                    {
                        case 10:
                            result = "a" + result;
                            break;
                        case 11:
                            result = "b" + result;
                            break;
                        case 12:
                            result = "c" + result;
                            break;
                        case 13:
                            result = "d" + result;
                            break;
                        case 14:
                            result = "e" + result;
                            break;
                        case 15:
                            result = "f" + result;
                            break;
                        default:
                            result = hexBits[i].ToString() + result;
                            break;
                    }
                }
            }
            else
            {
                for (i = 0; i < 8; i++)
                {
                    hexBits[i] = 15 - hexBits[i];
                    if (i == 0)
                    {
                        hexBits[i]++;
                    }
                }
                for (i = 0; i < 8; i++)
                {
                    if (hexBits[i] == 16)
                    {
                        hexBits[i] = 0;
                        hexBits[i + 1]++;
                    }
                    switch (hexBits[i])
                    {
                        case 10:
                            result = "a" + result;
                            break;
                        case 11:
                            result = "b" + result;
                            break;
                        case 12:
                            result = "c" + result;
                            break;
                        case 13:
                            result = "d" + result;
                            break;
                        case 14:
                            result = "e" + result;
                            break;
                        case 15:
                            result = "f" + result;
                            break;
                        default:
                            result = hexBits[i].ToString() + result;
                            break;
                    }
                }
            }
            return result;
        }
    }
    class ConvertaNumbertoHexadecimal
    {

        static void Main(string[] args)
        {
            int num = -2147483648;
            Solution solution = new Solution();
            Console.WriteLine(solution.ToHex(num));
            Console.ReadKey();
        }
    }
}
