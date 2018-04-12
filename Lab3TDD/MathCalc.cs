using System;

namespace Lab3TDD
{
    public class MathCalc
    {
        public MathCalc() { }

        public bool CompareMatrix(double[,] a, double[,] b)
        {
            if (a.GetLength(0) != b.GetLength(0) && a.GetLength(1) != b.GetLength(1))
                return false;
            else
                return true;
        }
    }
}