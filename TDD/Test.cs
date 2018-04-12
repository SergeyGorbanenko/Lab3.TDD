using System;
using Lab3TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD
{
    [TestClass]
    public class Test
    {
        private double[,] a = { { 1, 2, 3 }, { 2, 5, 6 }, { 4, 2, 7 } };

        [TestMethod]
        public void Test1_IsNotNullMathCalc()
        {
            MathCalc calc = new MathCalc();
            Assert.IsNotNull(calc);
        }

        public void Test2_CompareMatrix()
        {
            MathCalc calc = new MathCalc();
            bool rezult = calc.CompareMatrix(a, a);
            Assert.AreEqual(true, rezult);
        }
    }
}
