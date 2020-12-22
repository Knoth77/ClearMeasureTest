using FizzBuzz;
using System;
using System.Collections.Generic;

namespace ClearMeasureTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(100);

            Console.WriteLine(Class1.FizzBuzz(100));
            
            Console.WriteLine(Class1.FizzBuzzCustom(new Dictionary<int, string>
            {
                {2, "Fizz"},
                {4, "Buzz"},
                {6, "Fuzz" },
                {8, "Bizz" }
            }, 100));
        }

        public static string FizzBuzz(int n)
        {
            var str = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            return str;
        }
    }
}
