using System;
using Lab3TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD
{
    [TestClass]
    public class Test
    {
        private double[,] a = { { 1, 2, 3 }, { 2, 5, 6 }, { 4, 2, 7 } };
        private double[,] b = { { 5, 3, 1 }, { 2, 8, 0 }, { 3, 5, 4 } };
        private double[,] t = { { 1, 2, 4 }, { 2, 5, 2 }, { 3, 6, 7 } };
        private double[,] d = { { 6, 5, 4 }, { 4, 13, 6 }, { 7, 7, 11 } };
        private double[,] e = { { -4, -1, 2 }, { 0, -3, 6 }, { 1, -3, 3 } };
        private double[,] f = { { 2, 4, 6 }, { 4, 10, 12 }, { 8, 4, 14 } };
        private double[,] g = { { 18, 34, 13 }, { 38, 76, 26 }, { 45, 63, 32 } };

        [TestMethod]
        public void Test1_IsNotNullMathCalc()
        {
            MathCalc calc = new MathCalc();
            Assert.IsNotNull(calc);
        }

        [TestMethod]
        public void Test2_CompareMatrix()
        {
            MathCalc calc = new MathCalc();
            bool rezult = calc.CompareMatrix(a, a);
            Assert.AreEqual(true, rezult);
        }

        [TestMethod]
        public void Test3_CompareMatrix()
        {
            MathCalc calc = new MathCalc();
            bool rezult = calc.CompareMatrix(a, b);
            Assert.AreEqual(false, rezult);
        }

        [TestMethod]
        public void Test4_Trans()
        {
            MathCalc calc = new MathCalc();
            double [,] rezult = calc.Trans(a);
            Assert.AreEqual(true, calc.CompareMatrix(t, rezult));
        }

        [TestMethod]
        public void Test5_Add()
        {
            MathCalc calc = new MathCalc();
            double[,] rezult = calc.Add(a, b);
            Assert.AreEqual(true, calc.CompareMatrix(rezult, d));
        }

        [TestMethod]
        public void Test6_Sub()
        {
            MathCalc calc = new MathCalc();
            double[,] rezult = calc.Sub(a, b);
            Assert.AreEqual(true, calc.CompareMatrix(e, rezult));
        }

        [TestMethod]
        public void Test7_MulNum()
        {
            MathCalc calc = new MathCalc();
            double[,] rezult = calc.MulNum(a, 2);
            Assert.AreEqual(true, calc.CompareMatrix(f, rezult));
        }

        [TestMethod]
        public void Test8_Mul()
        {
            MathCalc calc = new MathCalc();
            double[,] rezult = calc.Mul(a, b);
            Assert.AreEqual(true, calc.CompareMatrix(g, rezult));
        }
    }
}
