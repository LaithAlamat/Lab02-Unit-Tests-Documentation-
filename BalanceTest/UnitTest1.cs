using System;
using Xunit;
using Unit_Testing;

namespace BalanceTest
{
    public class UnitTest1
    {
        [Fact]
        public void Blanace()
        {
            decimal getBalance = Program.ViewBalance();
            Assert.Equal(getBalance, Program.ViewBalance());
        }
    }
}
