using System;

namespace CalculatorLib;

public class ScientificCalculator : Calculator
{
    public double Power(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public double Sqrt(double a)
    {
        if (a < 0)
        {
            throw new ArgumentException("Нельзя извлечь корень из отрицательного числа!");
        }
        return Math.Sqrt(a);
    }

    public double Percent(double a, double b)
    {
        return a * b / 100;
    }

    public long Factorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Факториал только для неотрицательных чисел!");
        }
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result = result * i;
        }
        return result;
    }
}
