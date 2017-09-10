using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    class Codec
    {
        Dictionary<string, string> url2code;
        Dictionary<string, string> code2url;
        Random random_char;
        Random random_case;
        public Codec()
        {
            url2code = new Dictionary<string, string>();
            code2url = new Dictionary<string, string>();
            random_char = new Random();
            random_case = new Random();
        }

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            string code = "";
            while (!url2code.ContainsKey(longUrl))
            {
                int char_case = 0, rand_char = 0;
                char now_char;
                for (int i = 0; i < 6; i++)
                {
                    char_case = random_case.Next(0, 2);
                    if (char_case == 0)
                    {
                        rand_char = random_char.Next(0, 26);
                        now_char = (char)('A' + rand_char);
                        code += now_char;
                    }
                    else if (char_case == 1)
                    {
                        rand_char = random_char.Next(0, 26);
                        now_char = (char)('a' + rand_char);
                        code += now_char;
                    }
                }
                if (!code2url.ContainsKey(code))
                {
                    url2code[longUrl] = code;
                    code2url[code] = longUrl;
                }
            }
            return "http://tinyurl.com/" + code;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            return code2url[shortUrl.Substring(shortUrl.Length - 6, 6)];
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec codec = new Codec();
    // codec.decode(codec.encode(url));
    class EncodeandDecodeTinyURL
    {
        static void Main(string[] args)
        {
            Codec codec = new Codec();
            string longUrl = "https://leetcode.com/problems/design-tinyurl", shortUrl;
            shortUrl = codec.encode(longUrl);
            Console.WriteLine(shortUrl);
            Console.WriteLine(codec.decode(shortUrl));
            Console.ReadKey();
        }
    }
}
