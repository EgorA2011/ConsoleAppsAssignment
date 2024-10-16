using System;
using System.Data;

class Calculator
{
    static void Main(string[] args)
    {
        Console.Write("Введите выражение: ");
        string expression = Console.ReadLine();
        var result = new DataTable().Compute(expression, null);
        Console.WriteLine($"Результат: {result}");
    }
}
