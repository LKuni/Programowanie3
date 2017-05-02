using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zad3._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3._1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DivideByZeroTest()
        {
            Program target = new Program();
            double A = 4;
            double B = 0;
            double actual;
            actual = target.DivideNumbers(A, B);
        }


        [TestMethod()]
        public void DivideTest()
        {
            Program target = new Program();
            double A = 4;
            double B = 2;
            double expected = 2;
            double actual;
            actual = target.DivideNumbers(A, B);
            Assert.AreEqual(expected, actual);
        }
    }


}