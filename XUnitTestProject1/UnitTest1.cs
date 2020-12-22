using FizzBuzz;
using System;
using System.Linq;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestFizzBuzz()
        {
            var str = Class1.FizzBuzz(15);

            Assert.EndsWith("FizzBuzz\n", str);
        }

        [Fact]
        public void TestFizz()
        {
            var str = Class1.FizzBuzz(15);
            var strList = str.Split("\n").Where(o => o == "Fizz").ToList();

            Assert.True(strList.Count == 4);
        }

        [Fact]
        public void TestBuzz()
        {
            var str = Class1.FizzBuzz(15);
            var strList = str.Split("\n").Where(o => o == "Buzz").ToList();

            Assert.True(strList.Count == 2);
        }
    }
}
