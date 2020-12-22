using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class Class1
    {
        public static string FizzBuzz(int n)
        {
            var str = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    str += "FizzBuzz\n";
                }
                else if (i % 3 == 0)
                {
                    str += "Fizz\n";
                }
                else if (i % 5 == 0)
                {
                    str += "Buzz\n";
                }
                else
                {
                    str += i + "\n";
                }

            }
            return str;
        }

        public static string FizzBuzzCustom(Dictionary<int, string> wordPairList, int n)
        {
            string wordStr = "";
            for (int i = 1; i <= n; i++)
            {
                var wordList = wordPairList.Where(o => i % o.Key == 0).ToList();

                if (wordList.Any())
                {
                    wordStr += wordList.Select(p => p.Value).Aggregate((p, q) => p + q) + "\n";
                }
                else
                {
                    wordStr += i + "\n";
                }

            }
            return wordStr;
        }

    }
}
