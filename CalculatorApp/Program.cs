using System;
using CalculatorLib;

class Program
{
    static void Main()
    {
        Calculator c = new Calculator();

        Console.WriteLine("10 + 5 = " + c.Add(10, 5));
        Console.WriteLine("10 - 5 = " + c.Subtract(10, 5));
        Console.WriteLine("10 * 5 = " + c.Multiply(10, 5));
        Console.WriteLine("10 / 5 = " + c.Divide(10, 5));

        ScientificCalculator sc = new ScientificCalculator();

        Console.WriteLine("2 ^ 10 = " + sc.Power(2, 10));
        Console.WriteLine("√144 = " + sc.Sqrt(144));
        Console.WriteLine("25% от 200 = " + sc.Percent(200, 25));
        Console.WriteLine("5! = " + sc.Factorial(5));

        try
        {
            Console.WriteLine("10 / 0 = " + c.Divide(10, 0));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }

        try
        {
            Console.WriteLine("√(-25) = " + sc.Sqrt(-25));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}
