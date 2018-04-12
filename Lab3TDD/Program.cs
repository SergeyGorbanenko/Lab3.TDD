using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            MathCalc calc = new MathCalc();
            Console.WriteLine("Выберите действие11:");
            Console.WriteLine("1. Сложение матриц");
            Console.WriteLine("2. Вычитание матриц");
            Console.WriteLine("3. Умножение матрицы на число");
            Console.WriteLine("4. Умножение матриц");
            Console.WriteLine("5. Транспонирование матрицы");
            int num = int.Parse(Console.ReadLine());
            double[,] c = null;
            if (num == 1 || num == 2 || num == 4)
            {
                Console.WriteLine("Матрица А. Размер:");
                Console.Write("n=");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("m=");
                int m1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите значения матрицы:");
                double[,] a = new double[n1, m1];
                for (int i = 0; i < n1; i++)
                    for (int j = 0; j < m1; j++)
                    {
                        Console.Write("a[{0},{1}]=", i, j);
                        a[i, j] = double.Parse(Console.ReadLine());
                    }
                Console.WriteLine("Матрица B. Размер:");
                Console.Write("n=");
                int n2 = int.Parse(Console.ReadLine());
                Console.Write("m=");
                int m2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите значения матрицы:");
                double[,] b = new double[n2, m2];
                for (int i = 0; i < n2; i++)
                    for (int j = 0; j < m2; j++)
                    {
                        Console.Write("b[{0},{1}]=", i, j);
                        b[i, j] = double.Parse(Console.ReadLine());
                    }
                switch (num)
                {
                    case 1:
                        c = calc.Add(a, b);
                        break;
                    case 2:
                        c = calc.Sub(a, b);
                        break;
                    case 3:
                        c = calc.Mul(a, b);
                        break;
                }
            }
            else if (num == 3)
            {
                Console.WriteLine("Матрица А. Размер:");
                Console.Write("n=");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("m=");
                int m1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите значения матрицы:");
                double[,] a = new double[n1, m1];
                for (int i = 0; i < n1; i++)
                    for (int j = 0; j < m1; j++)
                    {
                        Console.Write("a[{0},{1}]=", i, j);
                        a[i, j] = double.Parse(Console.ReadLine());
                    }
                Console.WriteLine("Число, на которое умножить:");
                Console.Write("x=");
                int x = int.Parse(Console.ReadLine());
                c = calc.MulNum(a, x);
            }
            else
            {
                Console.WriteLine("Матрица А. Размер:");
                Console.Write("n=");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("m=");
                int m1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите значения матрицы:");
                double[,] a = new double[n1, m1];
                for (int i = 0; i < n1; i++)
                    for (int j = 0; j < m1; j++)
                    {
                        Console.Write("a[{0},{1}]=", i, j);
                        a[i, j] = double.Parse(Console.ReadLine());
                    }
                c = calc.Trans(a);
            }
            Console.WriteLine("Результат:");
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                    Console.Write(c[i, j] + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
