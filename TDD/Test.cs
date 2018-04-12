using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            MathCalc calc = new MathCalc();
            Assert.IsNotNull(calc);
        }
    }
}
