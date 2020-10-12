using System;
using Xunit;

namespace Fibonacci.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void test1()
        {
            var result = Fibonacci.Compute.Execute(new[] {"44"});
            Assert.Equal(701408733, result[0]);
        }
    }
}

