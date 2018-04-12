﻿using System;

namespace Lab3TDD
{
    public class MathCalc
    {
        public MathCalc() { }

        public bool CompareMatrix(double[,] a, double[,] b)
        {
            if (a.GetLength(0) != b.GetLength(0) && a.GetLength(1) != b.GetLength(1))
                return false;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] != b[i, j])
                        return false;
            return true;
        }
    }
}