using System;
using Lab3TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestIsNotNullMathCalc()
        {
            MathCalc calc = new MathCalc();
            Assert.IsNotNull(calc);
        }
    }
}
