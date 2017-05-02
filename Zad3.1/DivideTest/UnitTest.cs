using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace DivideTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DivideByZeroTest()
        {
            Program target = new Program();
            int numberA = 4;
            int numberB = 0;
            int actual;
            actual = target.Divide(numberA, numberB);
        }
    }
}
