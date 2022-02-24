using System;
using Xunit;
using WpfApp1;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestSum()
        {
            var result = OperationsHandler.getResult(5, 5, MainWindow.Operations.Summary);
            Assert.Equal(10, result);
        }

        [Fact]
        public void TestSub()
        {
            var result = OperationsHandler.getResult(5, 5, MainWindow.Operations.Substraction);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestMul()
        {
            var result = OperationsHandler.getResult(5, 5, MainWindow.Operations.Multiply);
            Assert.Equal(25, result);
        }

        [Fact]
        public void TestDiv()
        {
            var result = OperationsHandler.getResult(5, 5, MainWindow.Operations.Divide);
            Assert.Equal(1, result);
        }
    }
}
