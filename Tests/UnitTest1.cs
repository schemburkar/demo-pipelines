using System;
using Xunit;
using Business;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a = 1;
            var b = 2;

            var calc = new Calculator();

            //System.Threading.Thread.Sleep(TimeSpan.FromSeconds(60));
            Assert.Equal(3, calc.Sum(a, b));
        }
    }
}
