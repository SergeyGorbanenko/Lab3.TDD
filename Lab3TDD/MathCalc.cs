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
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] != b[i, j])
                        return false;
            return true;
        }

        public double[,] Trans(double[,] a)
        {
            double[,] c = new double[a.GetLength(1), a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    c[i, j] = a[j, i];
            return c;
        }

        public double[,] Add(double[,] a, double[,] b)
        {
            double[,] c = new double[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    c[i, j] = a[i, j] + b[i, j];
            return c;
        }

        public double[,] Sub(double[,] a, double[,] b)
        {
            double[,] c = new double[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    c[i, j] = a[i, j] - b[i, j];
            return c;
        }

        public double[,] MulNum(double[,] a, int v)
        {
            double[,] c = new double[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    c[i, j] = a[i, j] * v;
            return c;
        }

        public double[,] Mul(double[,] a, double[,] b)
        {
            double[,] c = new double[a.GetLength(1), a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < b.GetLength(1); k++)
                        c[i, j] += a[i, k] * b[k, j];
                }
            return c;
        }
    }
}