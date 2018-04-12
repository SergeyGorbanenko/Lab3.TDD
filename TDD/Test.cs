﻿using System;
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
    }
}
